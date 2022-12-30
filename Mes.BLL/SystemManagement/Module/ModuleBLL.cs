using Mes.BLL.Comm;
using Mes.Common;
using Mes.Model.CommModel;
using Mes.Model.Entites;
using Mes.Model.StoredProcedure;
using Mes.Model.ViewModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes.BLL.SystemManagement.Module
{
    public class ModuleBLL : IModuleBLL
    {
        public bool AddOrUpdateModuleData(ModuleVM moduleData)
        {
            bool insertFlag = false;
            using (MesDB db = new MesDB())
            {
                var isHasModuleId = db.TB_Sys_ModuleMaster.Where(f => f.FC_ModCode == moduleData.modCode).FirstOrDefault();
                if (isHasModuleId == null)
                {
                    TB_Sys_ModuleMaster moduleMasterVM = new TB_Sys_ModuleMaster();
                    moduleMasterVM.FC_ModCode = moduleData.modCode;
                    moduleMasterVM.FC_ModName = moduleData.modName;
                    moduleMasterVM.FC_Icon = moduleData.icon;
                    moduleMasterVM.FB_Enable = moduleData.status;
                    moduleMasterVM.FC_RTUrl = moduleData.rtUrl;
                    moduleMasterVM.FC_Desc = moduleData.desc;
                    moduleMasterVM.FN_Sort = moduleData.sort;
                    moduleMasterVM.FD_CDate = DateTime.Now;
                    moduleMasterVM.FD_UDate = DateTime.Now;
                    moduleMasterVM.FC_CUser = moduleData.userId;
                    moduleMasterVM.FC_UUser = moduleData.userId;
                    moduleMasterVM.FC_ParentId = moduleData.parentId;
                    if (moduleData.btnArr.Length > 0)
                    {
                        List<TB_Sys_ModuleDetail> moduleDetailList = new List<TB_Sys_ModuleDetail>();
                        foreach (var item in moduleData.btnArr)
                        {
                            TB_Sys_ModuleDetail moduleDetail = new TB_Sys_ModuleDetail();
                            moduleDetail.FD_CDate = DateTime.Now;
                            moduleDetail.FC_CUser = moduleData.userId;
                            moduleDetail.FC_ModCode = moduleData.modCode;
                            moduleDetail.FC_BtnCode = item;
                            moduleDetail.FC_BtnName = DictDetailComm.GetDictDetailForDicCode("BtnPermDic").Where(f => f.pk == item).FirstOrDefault().pn; 
                            moduleDetailList.Add(moduleDetail);
                        }
                        db.TB_Sys_ModuleDetail.AddRange(moduleDetailList);

                    }
                    db.TB_Sys_ModuleMaster.Add(moduleMasterVM);
                }
                else
                {
                    isHasModuleId.FC_ModCode = moduleData.modCode;
                    isHasModuleId.FC_ModName = moduleData.modName;
                    isHasModuleId.FC_Icon = moduleData.icon;
                    isHasModuleId.FB_Enable = moduleData.status;
                    isHasModuleId.FC_RTUrl = moduleData.rtUrl;
                    isHasModuleId.FC_Desc = moduleData.desc;
                    isHasModuleId.FN_Sort = moduleData.sort;
                    isHasModuleId.FD_UDate = DateTime.Now;
                    isHasModuleId.FC_UUser = moduleData.userId;
                    isHasModuleId.FC_ParentId = moduleData.parentId;

                    var IsHasDetailButtonPermissionsList = db.TB_Sys_ModuleDetail.Where(f => f.FC_ModCode == moduleData.modCode).ToList();
                    db.TB_Sys_ModuleDetail.RemoveRange(IsHasDetailButtonPermissionsList);
                    if (moduleData.btnArr.Count() > 0)
                    {
                        List<TB_Sys_ModuleDetail> moduleDetailList = new List<TB_Sys_ModuleDetail>();
                        foreach (var item in moduleData.btnArr)
                        {
                            TB_Sys_ModuleDetail moduleDetail = new TB_Sys_ModuleDetail();
                            moduleDetail.FD_CDate = DateTime.Now;
                            moduleDetail.FC_CUser = moduleData.userId;
                            moduleDetail.FC_ModCode = moduleData.modCode;
                            moduleDetail.FC_BtnCode = item;
                            moduleDetail.FC_BtnName = DictDetailComm.GetDictDetailForDicCode("BtnPermDic").Where(f => f.pk == item).FirstOrDefault().pn;
                            moduleDetailList.Add(moduleDetail);
                        }
                        db.TB_Sys_ModuleDetail.AddRange(moduleDetailList);

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
        public ModuleVM GetModuleById(string moduleId)
        {
            ModuleVM moduleVM = null;
            using (MesDB db = new MesDB())
            {
                var isHasModuleId = db.TB_Sys_ModuleMaster.Where(f => f.FC_ModCode == moduleId).FirstOrDefault();
                if (isHasModuleId != null)
                {
                    moduleVM = new ModuleVM();
                    moduleVM.modCode = isHasModuleId.FC_ModCode;
                    moduleVM.modName = isHasModuleId.FC_ModName;
                    moduleVM.icon = isHasModuleId.FC_Icon;
                    moduleVM.rtUrl = isHasModuleId.FC_RTUrl;
                    moduleVM.desc = isHasModuleId.FC_Desc;
                    moduleVM.status = isHasModuleId.FB_Enable;
                    moduleVM.parentId = isHasModuleId.FC_ParentId;
                    moduleVM.sort = isHasModuleId.FN_Sort;
                    var IshasKeyList = db.TB_Sys_ModuleDetail.Where(f => f.FC_ModCode == moduleId).ToList();
                    if (IshasKeyList.Count > 0)
                    {
                        ArrayList arrList = new ArrayList(moduleVM.btnArr.ToArray());
                        foreach (var item in IshasKeyList)
                        {
                            arrList.Add(item.FC_BtnCode);
                        }
                        moduleVM.btnArr = (string[])arrList.ToArray(typeof(string));
                    }
                }
                return moduleVM;
            }
        }
        public JArray GetModuleTree()
        {
            JArray navTree = new JArray();
            using (MesDB db = new MesDB())
            {

                var query = db.TB_Sys_ModuleMaster.ToList();
                var top = from q in query
                          where q.FC_ParentId == "0"
                          orderby q.FN_Sort
                          select q;
                foreach (var item in top)
                {
                    JArray submenlist = new JArray();
                    GetChilds(item.FC_ModCode, query, submenlist);
                    if (submenlist.Count > 0)
                        navTree.Add(
                                  new JObject(
                                        new JProperty("label", item.FC_ModName),
                                        new JProperty("children", submenlist),
                                        new JProperty("id", item.FC_ModCode)
                                    )
                                  );
                }
            }
            return navTree;
        }
        private void GetChilds(string parent, List<TB_Sys_ModuleMaster> datas, JArray array)
        {
            var dd = (from d in datas
                      where d.FC_ParentId == parent
                      orderby d.FN_Sort
                      select d).ToList();
            if (dd.Count == 0)
                return;
            else
            {
                for (int i = 0; i < dd.Count; i++)
                {
                    JArray submenlist = new JArray();
                    GetChilds(dd[i].FC_ModCode, datas, submenlist);
                    array.Add(new JObject(
                                     new JProperty("label", dd[i].FC_ModName),
                                        new JProperty("children", submenlist),
                                        new JProperty("id", dd[i].FC_ModCode)
                                    ));
                }
            }
        }
        public List<ModuleVM> GetModuleTable(string parentId, int page, int size, ref int total)
        {
            total = 0;
            List<TB_Sys_ModuleMaster> modMasterList = new List<TB_Sys_ModuleMaster>();
            List<ModuleVM> moduleList = new List<ModuleVM>();
            using (MesDB db = new MesDB())
            {
                var list = db.TB_Sys_ModuleMaster.Where(f => f.FC_ParentId == parentId).OrderBy(f => f.FN_Sort);
                modMasterList = LinqHelper.DataPaging(list, page, size).ToList();
                foreach (var item in modMasterList)
                {
                    ModuleVM modvm = new ModuleVM();
                    modvm.modCode = item.FC_ModCode;
                    modvm.icon = item.FC_Icon;
                    modvm.status = item.FB_Enable;
                    modvm.modName = item.FC_ModName;
                    modvm.parentId = item.FC_ParentId;
                    modvm.sort = item.FN_Sort;
                    modvm.rtUrl = item.FC_RTUrl;
                    modvm.createDate = item.FD_CDate;
                    modvm.desc = item.FC_Desc;
                    modvm.updateDate = item.FD_UDate;
                    modvm.createUserId = item.FC_CUser;
                    modvm.updateUserId = item.FC_UUser;
                    moduleList.Add(modvm);
                }
                int count = list.ToList().Count;
                total = count % size == 0 ? count / size : count / size + 1;
            }
            return moduleList;
        }

        public List<KeyValuePair> GetDictDetailForDicCode(string dicCode)
        {
            List<KeyValuePair> keyCodeList = new List<KeyValuePair>();
            List<DataDicDetailVM> DetailDataInfo = DictDetailComm.GetDictDetailForDicCode(dicCode);
            if (DetailDataInfo.Count > 0)
            {
                foreach (var item in DetailDataInfo)
                {
                    KeyValuePair keyCodeVM = new KeyValuePair();
                    keyCodeVM.keyCode = item.pk;
                    keyCodeVM.keyName = item.pn;
                    keyCodeList.Add(keyCodeVM);
                }
            }
            return keyCodeList;
        }

        public bool DeleteModuleDataByModuleId(string modCode)
        {
            bool OperaFlag = false;
            using (MesDB db = new MesDB())
            {
                var isHasModuleId = db.TB_Sys_ModuleMaster.Where(f => f.FC_ModCode == modCode).FirstOrDefault();
                if (isHasModuleId != null)
                {
                    var isHasModuleDetail = db.TB_Sys_ModuleDetail.Where(f => f.FC_ModCode == modCode).ToList();
                    if (isHasModuleDetail.Count>0)
                    {
                        db.TB_Sys_ModuleDetail.RemoveRange(isHasModuleDetail);
                    }
                    db.TB_Sys_ModuleMaster.Remove(isHasModuleId);
                }
                if (db.SaveChanges() > 0)
                {
                    OperaFlag = true;
                }
                return OperaFlag;
            }
        }


        public JArray GetModuleDetailTree( bool disableStatus)
        {
            JArray navTree = new JArray();
            using (MesDB db = new MesDB())
            {

                var query = db.TB_Sys_ModuleMaster.ToList();
                var top = from q in query
                          where q.FC_ParentId == "0"
                          orderby q.FN_Sort
                          select q;
                foreach (var item in top)
                {
                    JArray submenlist = new JArray();
                    GetDetailChilds(item.FC_ModCode, query, submenlist, disableStatus);
                    if (submenlist.Count > 0)
                        navTree.Add(
                                  new JObject(
                                        new JProperty("label", item.FC_ModName),
                                        new JProperty("children", submenlist),
                                        new JProperty("id", item.FC_ModCode),
                                         new JProperty("disabled", disableStatus)
                                    )
                                  );
                }
            }
            return navTree;
        }

        private void GetDetailChilds(string parent, List<TB_Sys_ModuleMaster> datas, JArray array, bool disableStatus)
        {
            var dd = (from d in datas
                      where d.FC_ParentId == parent
                      orderby d.FN_Sort
                      select d).ToList();
            if (dd.Count == 0)
            {
                using (MesDB db = new MesDB())
                {
                    var moduleBtnDetail = db.TB_Sys_ModuleDetail.Where(f => f.FC_ModCode == parent).ToList();
                    if (moduleBtnDetail.Count > 0)
                    {
                        foreach (var item in moduleBtnDetail)
                        {
                            JArray submenlist = new JArray();
                            array.Add(new JObject(
                                             new JProperty("label", item.FC_BtnName),
                                                new JProperty("children", submenlist),
                                                new JProperty("id", parent + "_" + item.FC_BtnCode),
                                                new JProperty("disabled", disableStatus)
                                            ));
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < dd.Count; i++)
                {
                    JArray submenlist = new JArray();
                    GetDetailChilds(dd[i].FC_ModCode, datas, submenlist, disableStatus);
                    array.Add(new JObject(
                                     new JProperty("label", dd[i].FC_ModName),
                                        new JProperty("children", submenlist),
                                        new JProperty("id", dd[i].FC_ModCode),
                                        new JProperty("disabled", disableStatus)
                                    ));
                }
            }
        }
    }
}
