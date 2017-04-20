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
    public class CommentController : ApiController
    {
        [Route("Comment/GetComment")]
        public IHttpActionResult GetComment()
        {
            try
            {
                List<T_Comment> CommentList = new T_CommentManager().SelectALL();
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", CommentList, CommentList.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }

        [Route("Comment/GetCommentPaging")]
        public IHttpActionResult GetCommentPaging(int PageSize, int PageNumber, string DataOrderBy)
        {
            List<T_Comment> CommentList = new T_CommentManager().SelectALLPaginByRowNumber(PageSize, PageNumber, DataOrderBy);
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account list paging", CommentList, CommentList.Count));
        }

        [Route("Comment/GetCommentByEmployeeId")]
        public IHttpActionResult GetCommentByEmployeeId(int employeeId)
        {
            T_CommentManager manager = new T_CommentManager();
            List<T_Comment> CommentList = manager.SelectByEmployeeId(new T_Comment() { employeeId = employeeId });
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetCommentByEmployeeId", CommentList, CommentList.Count));
        }

        [Route("Comment/GetCommentByEmployerId")]
        public IHttpActionResult GetCommentByEmployerId(int employerId)
        {
            T_CommentManager manager = new T_CommentManager();
            List<T_Comment> CommentList = manager.SelectByEmployerId(new T_Comment() { employerId = employerId });
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetCommentByEmployerId", CommentList, CommentList.Count));
        }

        [Route("Comment/AddComment")]
        public IHttpActionResult AddComment(dynamic query)
        {
            try
            {
                T_Comment Comment = new T_Comment();
                Comment.employeeId = query.employeeId;
                Comment.employerId = query.employerId;
                Comment.comment = query.comment;
                bool isAdd = new T_CommentManager().IsInsert(Comment);
                if (isAdd)
                {
                    return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("add success", true));
                }
                else
                {
                    return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("add faild", false));
                }
            }
            catch (Exception ex)
            {
                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 1));
            }

        }


        [Route("Comment/DeleteCommentById")]
        [HttpPost, HttpDelete]//这里方法名称带Delete如果不配置这里允许post请求，那么必须使用delete请求方式
        public IHttpActionResult DeleteCommentById(int id)
        {
            T_CommentManager manager = new T_CommentManager();
            bool isDelete = manager.IsDelete(new T_Comment() { commentId = id });
            if (isDelete)
            {
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("delete success", true));
            }
            else
            {
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("delete faild", false));
            }
        }
    }
}
