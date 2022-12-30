using Mes.Model.Entites;
using Mes.Model.ViewModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.BLL.SystemManagement.DataDic
{
    public class DataDicBLL : IDataDicBLL
    {
        public List<DataDicVM> GetDataDicTable(string dicType)
        {
            List<DataDicVM> dataDicList = new List<DataDicVM>();
            using (MesDB db = new MesDB())
            {
                var dataDicTree = db.TB_Sys_DataDictionaryMaster.Where(f => f.FC_Type == dicType).ToList();
                if (dataDicTree.Count() > 0)
                {
                    foreach (var item in dataDicTree)
                    {
                        DataDicVM dataDicVM = new DataDicVM();
                        dataDicVM.createDate = item.FD_CDate;
                        dataDicVM.createUserId = item.FC_CUser;
                        dataDicVM.dicCode = item.FC_DicCode;
                        dataDicVM.dicName = item.FC_DicName;
                        dataDicVM.dicType = item.FC_Type;
                        dataDicVM.status = item.FB_Enable;
                        dataDicVM.updateDate = item.FD_UDate;
                        dataDicVM.updateUserId = item.FC_UUser;
                        dataDicVM.status = item.FB_Enable;
                        dataDicList.Add(dataDicVM);
                    }
                }
                return dataDicList;
            }
        }

        public List<DataDicDetailVM> GetDataDicDetailTable(string dicCode)
        {
            List<DataDicDetailVM> dataDicDetailList = new List<DataDicDetailVM>();
            using (MesDB db = new MesDB())
            {
                var dataDicDetailTree = db.TB_Sys_DataDictionaryDetail.Where(f => f.FC_DicCode == dicCode).ToList();
                if (dataDicDetailTree.Count() > 0)
                {
                    foreach (var item in dataDicDetailTree)
                    {
                        DataDicDetailVM dataDicDetailVM = new DataDicDetailVM();
                        dataDicDetailVM.createDate = item.FD_CDate;
                        dataDicDetailVM.createUserId = item.FC_CUser;
                        dataDicDetailVM.pk = item.FC_PK;
                        dataDicDetailVM.pn = item.FC_PN;
                        dataDicDetailVM.v1 = item.FC_V1;
                        dataDicDetailVM.v2 = item.FC_V2;
                        dataDicDetailVM.v3 = item.FC_V3;
                        dataDicDetailVM.v4 = item.FC_V4;
                        dataDicDetailVM.v5 = item.FC_V5;
                        dataDicDetailVM.v6 = item.FC_V6;
                        dataDicDetailList.Add(dataDicDetailVM);
                    }
                }
                return dataDicDetailList;
            }
        }

        public JArray GetDataDicTree()
        {
            JArray navTree = new JArray();
            using (MesDB db = new MesDB())
            {
                var dataDicTree = db.TB_Sys_DataDictionaryMaster.Select(f => f.FC_Type).Distinct().ToList();
                if (dataDicTree.Count() > 0)
                {
                    foreach (var item in dataDicTree)
                    {
                      navTree.Add(new JObject(new JProperty("label", item),
                          new JProperty("id", item))
                          );
                    }
                }

            }
            return navTree;
        }

        public bool AddOrUpdateDataDic(DataDicAndDetailVM datDicAndDetail)
        {
            bool insertFlag = false;
            List<TB_Sys_DataDictionaryDetail> dataDicDetailList = new List<TB_Sys_DataDictionaryDetail>();
            using (MesDB db = new MesDB())
            {
                var dataDicMaster = db.TB_Sys_DataDictionaryMaster.Where(f => f.FC_DicCode == datDicAndDetail.dicCode).FirstOrDefault();
                if (dataDicMaster == null)
                {
                    TB_Sys_DataDictionaryMaster dataDicMaser = new TB_Sys_DataDictionaryMaster();
                    dataDicMaser.FB_Enable = datDicAndDetail.status;
                    dataDicMaser.FC_CUser = datDicAndDetail.createUserId;
                    dataDicMaser.FC_DicCode = datDicAndDetail.dicCode;
                    dataDicMaser.FC_DicName = datDicAndDetail.dicName;
                    dataDicMaser.FC_Type = datDicAndDetail.dicType;
                    dataDicMaser.FC_UUser = datDicAndDetail.createUserId; ;
                    dataDicMaser.FD_UDate = DateTime.Now;
                    dataDicMaser.FD_CDate = DateTime.Now;
                    var getdataDicDetail = db.TB_Sys_DataDictionaryDetail.Where(f => f.FC_DicCode == datDicAndDetail.dicCode).ToList();
                    if (getdataDicDetail.Count > 0)
                    {
                        db.TB_Sys_DataDictionaryDetail.RemoveRange(getdataDicDetail);
                    }
                    if (datDicAndDetail.detailTable.Count > 0)
                    {
                        foreach (var item in datDicAndDetail.detailTable)
                        {
                            TB_Sys_DataDictionaryDetail dataDicDetail = new TB_Sys_DataDictionaryDetail();
                            dataDicDetail.FC_CUser = datDicAndDetail.createUserId;
                            dataDicDetail.FC_DicCode = datDicAndDetail.dicCode;
                            dataDicDetail.FC_PK = item.pk;
                            dataDicDetail.FC_PN = item.pn;
                            dataDicDetail.FC_V1 = item.v1;
                            dataDicDetail.FC_V2 = item.v2;
                            dataDicDetail.FC_V3 = item.v3;
                            dataDicDetail.FC_V4 = item.v4;
                            dataDicDetail.FC_V5 = item.v5;
                            dataDicDetail.FC_V6 = item.v6;
                            dataDicDetail.FD_CDate = DateTime.Now;
                            dataDicDetailList.Add(dataDicDetail);
                        }
                        db.TB_Sys_DataDictionaryDetail.AddRange(dataDicDetailList);
                        db.TB_Sys_DataDictionaryMaster.Add(dataDicMaser);
                    }
                }
                else
                {
                    dataDicMaster.FB_Enable = datDicAndDetail.status;
                    dataDicMaster.FC_Type = datDicAndDetail.dicType;
                    dataDicMaster.FC_UUser = datDicAndDetail.createUserId; ;
                    dataDicMaster.FD_UDate = DateTime.Now;
                    var getdataDicDetail = db.TB_Sys_DataDictionaryDetail.Where(f => f.FC_DicCode == datDicAndDetail.dicCode).ToList();
                    if (getdataDicDetail.Count > 0)
                    {
                        db.TB_Sys_DataDictionaryDetail.RemoveRange(getdataDicDetail);
                    }
                    if (datDicAndDetail.detailTable.Count > 0)
                    {
                        foreach (var item in datDicAndDetail.detailTable)
                        {
                            TB_Sys_DataDictionaryDetail dataDicDetail = new TB_Sys_DataDictionaryDetail();
                            dataDicDetail.FC_CUser = datDicAndDetail.createUserId;
                            dataDicDetail.FC_DicCode = datDicAndDetail.dicCode;
                            dataDicDetail.FC_PK = item.pk;
                            dataDicDetail.FC_PN = item.pn;
                            dataDicDetail.FC_V1 = item.v1;
                            dataDicDetail.FC_V2 = item.v2;
                            dataDicDetail.FC_V3 = item.v3;
                            dataDicDetail.FC_V4 = item.v4;
                            dataDicDetail.FC_V5 = item.v5;
                            dataDicDetail.FC_V6 = item.v6;
                            dataDicDetail.FD_CDate = DateTime.Now;
                            dataDicDetailList.Add(dataDicDetail);
                        }
                        db.TB_Sys_DataDictionaryDetail.AddRange(dataDicDetailList);
                    }

                }
                if (db.SaveChanges() > 0)
                {
                    return insertFlag = true;
                }
                else
                {
                    return insertFlag;
                }
            }
        }

        public DataDicAndDetailVM GetDataDicBydicCode(string dicCode)
        {
            DataDicAndDetailVM dataDicAndDetail = new DataDicAndDetailVM ();
            using (MesDB db = new MesDB())
            {
                var dataDicMaster = db.TB_Sys_DataDictionaryMaster.Where(f => f.FC_DicCode == dicCode).FirstOrDefault();
                if (dataDicMaster!=null)
                {
                    //dataDicAndDetail.createDate = dataDicMaster.FD_CDate;
                    dataDicAndDetail.createUserId = dataDicMaster.FC_CUser;
                    dataDicAndDetail.dicCode = dataDicMaster.FC_DicCode;
                    dataDicAndDetail.dicName = dataDicMaster.FC_DicName;
                    dataDicAndDetail.dicType = dataDicMaster.FC_Type;
                    dataDicAndDetail.status = dataDicMaster.FB_Enable;
                    //dataDicAndDetail.updateDate = dataDicMaster.FD_UDate;
                    dataDicAndDetail.updateUserId = dataDicMaster.FC_UUser;
                    dataDicAndDetail.status = dataDicMaster.FB_Enable;
                    var dataDicDetail = db.TB_Sys_DataDictionaryDetail.Where(f => f.FC_DicCode == dicCode).ToList();
                    if (dataDicDetail.Count > 0)
                    {
                        foreach (var item in dataDicDetail)
                        {
                            DataDicDetailVM dataDicVM = new DataDicDetailVM();
                            dataDicVM.pk = item.FC_PK;
                            dataDicVM.pn = item.FC_PN;
                            dataDicVM.v1 = item.FC_V1;
                            dataDicVM.v2 = item.FC_V2;
                            dataDicVM.v3 = item.FC_V3;
                            dataDicVM.v4 = item.FC_V4;
                            dataDicVM.v5 = item.FC_V5;
                            dataDicVM.v6 = item.FC_V6;
                            dataDicAndDetail.detailTable.Add(dataDicVM);
                        }
                    }
                }
                return dataDicAndDetail;
            }
        }

        public bool DeleteDataDicByDicCode(string dicCode)
        {
            bool OperaFlag = false;
            using (MesDB db = new MesDB())
            {
                var dataDicMaster = db.TB_Sys_DataDictionaryMaster.Where(f => f.FC_DicCode == dicCode).FirstOrDefault();
                if (dataDicMaster != null)
                {
                    var dataDicDetailList = db.TB_Sys_DataDictionaryDetail.Where(f => f.FC_DicCode == dicCode).ToList();
                    if (dataDicDetailList.Count>0)
                    {
                        db.TB_Sys_DataDictionaryDetail.RemoveRange(dataDicDetailList);
                    }
                    db.TB_Sys_DataDictionaryMaster.Remove(dataDicMaster);
                }
                if (db.SaveChanges() > 0)
                {
                    OperaFlag = true;
                }
                return OperaFlag;
            }
        }
    }
}
