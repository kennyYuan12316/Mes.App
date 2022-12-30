using Mes.BLL.SystemManagement.DataDic;
using Mes.Common;
using Mes.Model.ViewModel;
using Mes.WebApi.Core;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using Unity;

namespace Mes.WebApi.Controllers.SystemManagement
{
    [RoutePrefix("api/DataDic")]
    public class DataDicController : BaseApiController
    {
        [Dependency]
        public IDataDicBLL dataDicBLL { get; set; }


        [HttpGet, Route("GetDataDicTree")]
        public JsonResult<JObject> GetDataDicTree()
        {
            JObject jr = new JObject();
            JArray tree = dataDicBLL.GetDataDicTree();
            jr.Add("data", tree);
            jr.Add("code", 20000);
            return Json<JObject>(jr);
        }

        [HttpGet, Route("GetDataDicTable")]
        public JsonResult<JObject> GetDataDicTable(string dicType)
        {
            JObject jr = new JObject();
            List < DataDicVM > dataDicList= dataDicBLL.GetDataDicTable(dicType);
            jr.Add("data", dataDicList.SerializeObject());
            jr.Add("code", 20000);
            return Json<JObject>(jr);
        }

        [HttpGet, Route("GetDataDicDetailTable")]
        public JsonResult<JObject> GetDataDicDetailTable(string dicCode)
        {
            JObject jr = new JObject();
            List<DataDicDetailVM> dataDicList = dataDicBLL.GetDataDicDetailTable(dicCode);
            jr.Add("data", dataDicList.SerializeObject());
            jr.Add("code", 20000);
            return Json<JObject>(jr);
        }

        [Route("AddOrUpdateDataDic")]
        [HttpPost]
        public JsonResult<JObject> AddOrUpdateDataDic([FromBody] JObject dataDic)
        {
            JObject jr = new JObject();
            DataDicAndDetailVM dataDicVM = dataDic.ToString().DeserializeObject<DataDicAndDetailVM>();
            dataDicVM.createUserId = (string)HttpContext.Current.Items["userId"];
            bool operationFlag = dataDicBLL.AddOrUpdateDataDic(dataDicVM);
            if (operationFlag)
            {
                jr.Add("message", "保存成功");
                jr.Add("code", 20000);
            }
            else
            {
                jr.Add("message", "保存失败");
                jr.Add("code", 20001);
            }
            return Json<JObject>(jr);
        }


        [Route("DeleteDataDicByDicCode")]
        [HttpPost]
        public JsonResult<JObject> DeleteDataDicByDicCode([FromBody] JObject delParas)
        {
            JObject jr = new JObject();
            string dicCode = delParas["dicCode"].ToString();
            bool OperaFlag = dataDicBLL.DeleteDataDicByDicCode(dicCode);
            if (OperaFlag == false)
            {
                jr.Add("message", "获取失败");
                jr.Add("code", 20001);
            }
            else
            {
                jr.Add("message", "获取成功");
                jr.Add("code", 20000);
            }
            return Json<JObject>(jr);
        }


        [HttpGet, Route("GetDataDicBydicCode")]
        public JsonResult<JObject> GetDataDicBydicCode(string dicCode)
        {
            JObject jr = new JObject();
            DataDicAndDetailVM dataDicList = dataDicBLL.GetDataDicBydicCode(dicCode);
            jr.Add("data", dataDicList.SerializeObject());
            jr.Add("code", 20000);
            return Json<JObject>(jr);
        }


    }
}