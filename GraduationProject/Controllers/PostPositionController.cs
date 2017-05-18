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
    public class PostPositionController : ApiController
    {
        [Route("PostPosition/GetPostPosition")]
        public IHttpActionResult GetPostPosition()
        {
            try
            {
                List<T_PostPosition> PostPositionList = new T_PostPositionManager().SelectALL();
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", PostPositionList, PostPositionList.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }

        [Route("PostPosition/GetPostPositionPaging")]
        public IHttpActionResult GetPostPositionPaging(int PageSize, int PageNumber, string DataOrderBy)
        {
            List<T_PostPosition> PostPositionList = new T_PostPositionManager().SelectALLPaginByRowNumber(PageSize, PageNumber, DataOrderBy);
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account list paging", PostPositionList, PostPositionList.Count));
        }

        [Route("PostPosition/GetPostPositionById")]
        public IHttpActionResult GetPostPositionById(int id)
        {
            T_PostPositionManager manager = new T_PostPositionManager();
            T_PostPosition PostPosition = manager.SelectSingleLine_RTModel(new T_PostPosition() { positionId = id });
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetPostPositionById", PostPosition, 1));
        }

        [Route("PostPosition/GetPostPositionByEmployerId")]
        public IHttpActionResult GetPostPositionByEmployerId(int employerId)
        {
            T_PostPositionManager manager = new T_PostPositionManager();
            List<T_PostPosition> PostPositionList = manager.SelectByEmployerId(new T_PostPosition() { employerId = employerId });
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetPostPositionByEmployerId", PostPositionList, PostPositionList.Count));
        }

        [Route("PostPosition/AddPostPosition")]
        public IHttpActionResult AddPostPosition(dynamic query)
        {
            try
            {
                T_PostPosition PostPosition = new T_PostPosition();
                PostPosition.employerId = query.employerId;
                PostPosition.position = query.position;
                PostPosition.workingLifeId = query.workingLifeId;
                PostPosition.educationId = query.educationId;
                PostPosition.salary = query.salary;
                PostPosition.advantage = query.advantage;
                PostPosition.describe = query.describe;
                bool isAdd = new T_PostPositionManager().IsInsert(PostPosition);
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

        [Route("PostPosition/UpdatePostPosition")]
        public IHttpActionResult UpdatePostPosition(dynamic query)
        {
            try
            {
                T_PostPosition PostPosition = new T_PostPosition();
                PostPosition.employerId = query.employerId;
                PostPosition.position = query.position;
                PostPosition.workingLifeId = query.workingLifeId;
                PostPosition.educationId = query.educationId;
                PostPosition.salary = query.salary;
                PostPosition.advantage = query.advantage;
                PostPosition.describe = query.describe;
                bool isUpdate = new T_PostPositionManager().IsUpdate(PostPosition);
                if (isUpdate)
                {
                    return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("update success", true));
                }
                else
                {
                    return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("update faild", false));
                }
            }
            catch (Exception ex)
            {
                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 1));
            }

        }

        [Route("PostPosition/DeletePostPositionById")]
        [HttpPost, HttpDelete]//这里方法名称带Delete如果不配置这里允许post请求，那么必须使用delete请求方式
        public IHttpActionResult DeletePostPositionById(int id)
        {
            T_PostPositionManager manager = new T_PostPositionManager();
            bool isDelete = manager.IsDelete(new T_PostPosition() { positionId = id });
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
