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
    public class EducationController : ApiController
    {
        [Route("Education/GetEducation")]
        public IHttpActionResult GetEducation()
        {
            try
            {
                List<T_Education> EducationList = new T_EducationManager().SelectALL();
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", EducationList, EducationList.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }

        [Route("Education/GetEducationById")]
        public IHttpActionResult GetEducationById(int id)
        {
            T_EducationManager manager = new T_EducationManager();
            T_Education Education = manager.SelectSingleLine_RTModel(new T_Education() { educationId = id });
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetEducationById", Education, 1));
        }

        [Route("Education/GetEducationByName")]
        public IHttpActionResult GetEducationByName(string name)
        {
            T_EducationManager manager = new T_EducationManager();
            T_Education Education = manager.SelectByName_RTModel(new T_Education() { educationName = name });
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetEducationByName", Education, 1));
        }

    }
}
