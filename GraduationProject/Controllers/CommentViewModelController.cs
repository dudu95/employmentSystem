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
    public class CommentViewModelController : ApiController
    {
        [Route("CommentViewModel/GetCommentViewModel")]
        public IHttpActionResult GetCommentViewModel()
        {
            try
            {
                List<CommentViewModel> CommentViewModelList = new CommentViewModelManager().GetCommentViewModelList();
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", CommentViewModelList, CommentViewModelList.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }

        [Route("CommentViewModel/GetCommentViewModelListByEmployeeId")]
        public IHttpActionResult GetCommentViewModelListByEmployeeId(int employeeId)
        {
            try
            {
                List<CommentViewModel> CommentViewModelList = new CommentViewModelManager().GetCommentViewModelListByEmployeeId(employeeId);
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", CommentViewModelList, CommentViewModelList.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }

        [Route("CommentViewModel/GetCommentViewModelListByEmployerId")]
        public IHttpActionResult GetCommentViewModelListByEmployerId(int employerId)
        {
            try
            {
                List<CommentViewModel> CommentViewModelList = new CommentViewModelManager().GetCommentViewModelListByEmployerId(employerId);
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", CommentViewModelList, CommentViewModelList.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }
    }
}
