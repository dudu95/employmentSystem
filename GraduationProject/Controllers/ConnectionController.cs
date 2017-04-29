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
    public class ConnectionController : ApiController
    {
        [Route("Connection/GetConnection")]
        public IHttpActionResult GetConnection()
        {
            try
            {
                List<T_Connection> ConnectionList = new T_ConnectionManager().SelectALL();
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", ConnectionList, ConnectionList.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }

        [Route("Connection/GetConnectionById")]
        public IHttpActionResult GetConnectionById(int id)
        {
            T_ConnectionManager manager = new T_ConnectionManager();
            T_Connection Connection = manager.SelectSingleLine_RTModel(new T_Connection() { connectedId = id });
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetConnectionById", Connection, 1));
        }

        [Route("Connection/GetConnectionByEmployeeId")]
        public IHttpActionResult GetConnectionByEmployeeId(int employeeId)
        {
            T_ConnectionManager manager = new T_ConnectionManager();
            List<T_Connection> ConnectionList = manager.SelectByEmployeeId(new T_Connection() { employeeId = employeeId });
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetConnectionByEmployeeId", ConnectionList, ConnectionList.Count));
        }

        [Route("Connection/GetConnectionByEmployerId")]
        public IHttpActionResult GetConnectionByEmployerId(int employerId)
        {
            T_ConnectionManager manager = new T_ConnectionManager();
            List<T_Connection> ConnectionList = manager.SelectByEmployerId(new T_Connection() { employerId = employerId });
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetConnectionByEmployerId", ConnectionList, ConnectionList.Count));
        }

        [Route("Connection/IsExistWhereFeild")]
        [HttpGet]
        public IHttpActionResult IsExistWhereFeild(int employeeId,int employerId)
        {
            T_ConnectionManager manager = new T_ConnectionManager();
            Boolean isExist = manager.IsExistWhereFeild(new T_Connection() { employeeId = employeeId, employerId = employerId });
            return Json( new { isExist = isExist } );
        }
        [Route("Connection/SelectByeeIdAnderId")]
        public IHttpActionResult SelectByeeIdAnderId(int employeeId, int employerId)
        {
            T_ConnectionManager manager = new T_ConnectionManager();
            T_Connection Connection = manager.SelectByeeIdAnderId(new T_Connection() { employeeId = employeeId, employerId = employerId });
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("SelectByeeIdAnderId", Connection, 1));
        }
        
        [Route("Connection/AddConnection")]
        public IHttpActionResult AddConnection(dynamic query)
        {
            try
            {
                T_Connection Connection = new T_Connection();
                Connection.employeeId = query.employeeId;
                Connection.employerId = query.employerId;
                Connection.connectedStateId = query.connectedStateId;
                bool isAdd = new T_ConnectionManager().IsInsert(Connection);
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

        [Route("Connection/UpdateConnection")]
        public IHttpActionResult UpdateConnection(dynamic query)
        {
            try
            {
                T_Connection Connection = new T_ConnectionManager().SelectSingleLine_RTModel(new T_Connection { connectedId = query.connectedId });
                Connection.employeeId = query.employeeId;
                Connection.employerId = query.employerId;
                Connection.connectedStateId = query.connectedStateId;
                bool isUpdate = new T_ConnectionManager().IsUpdate(Connection);
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

        [Route("Connection/DeleteConnectionById")]
        [HttpPost, HttpDelete]//这里方法名称带Delete如果不配置这里允许post请求，那么必须使用delete请求方式
        public IHttpActionResult DeleteConnectionById(int id)
        {
            T_ConnectionManager manager = new T_ConnectionManager();
            bool isDelete = manager.IsDelete(new T_Connection() { connectedId = id });
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
