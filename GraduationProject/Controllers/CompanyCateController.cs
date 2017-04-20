using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GraduationProject.Controllers
{
    public class CompanyCateController : ApiController
    {
        [Route("CompanyCate/GetCompanyCate")]
        public IHttpActionResult GetCompanyCate()
        {
            try
            {
                List<T_CompanyCate> CompanyCate = new T_CompanyCateManager().SelectALL();
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", CompanyCate, CompanyCate.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }

        [Route("CompanyCate/GetCompanyCateById")]
        public IHttpActionResult GetCompanyCateById(int id)
        {
            T_CompanyCateManager manager = new T_CompanyCateManager();
            T_CompanyCate CompanyCate = manager.SelectSingleLine_RTModel(new T_CompanyCate() { companyCateId = id });
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetCompanyCateById", CompanyCate, 1));
        }

        [Route("CompanyCate/GetCompanyCateByName")]
        public IHttpActionResult GetCompanyCateByName(string name)
        {
            T_CompanyCateManager manager = new T_CompanyCateManager();
            T_CompanyCate CompanyCate = manager.SelectByName_RTModel(new T_CompanyCate() { cateName = name });
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetCompanyCateByName", CompanyCate, 1));
        }

    }
}

