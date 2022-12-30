
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.Common.ExcelHelper
{
    public class ExcelHelper
    {

    

        /// <summary>
        /// 将DataTable数据导入到excel中
        /// </summary>
        /// <param name="data">要导入的数据</param>
        /// <param name="isColumnWritten">DataTable的列名是否要导入</param>
        /// <param name="sheetName">要导入的excel的sheet的名称</param>
        /// <returns>导入数据行数(包含列名那一行)</returns>
        public static int DataTableToExcel(DataTable data,string fileName ,string sheetName, bool isColumnWritten)
        {
            int i = 0;
            int j = 0;
            int count = 0;
            ISheet sheet = null;
            IWorkbook workbook = null;
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            if (fileName.IndexOf(".xlsx") > 0) // 2007版本
                workbook = new XSSFWorkbook();
            else if (fileName.IndexOf(".xls") > 0) // 2003版本
                workbook = new HSSFWorkbook();

            try
            {
                if (workbook != null)
                {
                    sheet = workbook.CreateSheet(sheetName);
                }
                else
                {
                    return -1;
                }

                if (isColumnWritten == true) //写入DataTable的列名
                {
                    IRow row = sheet.CreateRow(0);
                    for (j = 0; j < data.Columns.Count; ++j)
                    {
                        row.CreateCell(j).SetCellValue(data.Columns[j].ColumnName);
                    }
                    count = 1;
                }
                else
                {
                    count = 0;
                }

                for (i = 0; i < data.Rows.Count; ++i)
                {
                    IRow row = sheet.CreateRow(count);
                    for (j = 0; j < data.Columns.Count; ++j)
                    {
                        row.CreateCell(j).SetCellValue(data.Rows[i][j].ToString());
                    }
                    ++count;
                }
                workbook.Write(fs,false); //写入到excel
                return count;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return -1;
            }
        }

        /// <summary>
        /// 将excel中的数据导入到DataTable中
        /// </summary>
        /// <param name="sheetName">excel工作薄sheet的名称</param>
        /// <param name="isFirstRowColumn">第一行是否是DataTable的列名</param>
        /// <returns>返回的DataTable</returns>
        public static List<T> ExcelToList<T>(string fileName,Stream fs,bool isFirstRowColumn, string sheetName )
        {
            IWorkbook workbook = null;
            ISheet sheet = null;
            DataTable data = new DataTable();
            int startRow = 0;
            try
            {
                if (fileName.IndexOf(".xlsx") > 0) // 2007版本
                    workbook = new XSSFWorkbook(fs);
                else if (fileName.IndexOf(".xls") > 0) // 2003版本
                    workbook = new HSSFWorkbook(fs);

                if (sheetName != null)
                {
                    sheet = workbook.GetSheet(sheetName);
                    if (sheet == null) //如果没有找到指定的sheetName对应的sheet，则尝试获取第一个sheet
                    {
                        sheet = workbook.GetSheetAt(0);
                    }
                }
                else
                {
                    sheet = workbook.GetSheetAt(0);
                }
                if (sheet != null)
                {
                    IRow firstRow = sheet.GetRow(0);
                    int cellCount = firstRow.LastCellNum; //一行最后一个cell的编号 即总的列数

                    if (isFirstRowColumn)
                    {
                        for (int i = firstRow.FirstCellNum; i < cellCount; ++i)
                        {
                            ICell cell = firstRow.GetCell(i);
                            if (cell != null)
                            {
                                string cellValue = cell.StringCellValue;
                                if (cellValue != null)
                                {
                                    DataColumn column = new DataColumn(cellValue);
                                    data.Columns.Add(column);
                                }
                            }
                        }
                        startRow = sheet.FirstRowNum + 1;
                    }
                    else
                    {
                        //startRow = sheet.FirstRowNum;
                        startRow = sheet.FirstRowNum + 1;
                    }

                    //最后一列的标号
                    int rowCount = sheet.LastRowNum;
                    for (int i = startRow; i <= rowCount; ++i)
                    {
                        IRow row = sheet.GetRow(i);
                        if (row == null) continue; //没有数据的行默认是null　　　　　　　

                        DataRow dataRow = data.NewRow();
                        for (int j = row.FirstCellNum; j < cellCount; ++j)
                        {
                            if (row.GetCell(j) != null)
                            {
                                //同理，没有数据的单元格都默认是null
                                string value = row.GetCell(j).StringCellValue;
                                dataRow[j] = value;
                            }
                            else
                            {
                                dataRow[j] = null;
                            }
                        }
                        data.Rows.Add(dataRow);
                    }
                }
                var list =  DataTable2List<T>(data);
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return null;
            }
        }
    
    
        /// <summary>
        /// 使用反射将DataTable转换成List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static List<T> DataTable2List<T>(DataTable data)
        {
            List<T> results = new List<T>();
            Type type =  typeof(T); 
            foreach(DataRow row in data.Rows)
            {
                T o =(T)  Activator.CreateInstance(type);
                var props = type.GetProperties();
                foreach (var prop in props)
                {
                    // 获取到属性上的 ColumnOrderAttribute 特性
                    object[] attributes = prop.GetCustomAttributes(typeof(ColumnOrderAttribute), false);
                    // ColumnOrderAttribute 特性存在
                    if (attributes.Length > 0)
                    {
                        ColumnOrderAttribute orderAttribute = attributes[0] as ColumnOrderAttribute;
                        
                        if(prop.PropertyType.FullName.Contains("DateTime")){
                            if(!row[orderAttribute.Order].ToString().Equals(""))
                                prop.SetValue(o, DateTime.Parse(row[orderAttribute.Order].ToString()));
                        }
                        if(prop.PropertyType.FullName.Contains("String"))
                        {
                            if (!row[orderAttribute.Order].ToString().Equals(""))
                                prop.SetValue(o, row[orderAttribute.Order].ToString());
                        }
                        if (prop.PropertyType.FullName.Contains("Boolean"))
                        {
                            if (!row[orderAttribute.Order].ToString().Equals(""))
                                prop.SetValue(o, Boolean.Parse(row[orderAttribute.Order].ToString()));
                        }
                        
                    }
                }
                results.Add(o);
            }
            
            return results;
        }

    }
}
