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
    public class AccountController : ApiController
    {
        [Route("Account/GetAccount")]
        public IHttpActionResult GetAccount()
        {
            try
            {
                List<tb_Account> AccountList = new tb_AccountManager().SelectALL();
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", AccountList, AccountList.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(),0));
            }
        }
        [Route("Account/GetAccountPaging")]
        public IHttpActionResult GetAccountPaging(int PageSize, int PageNumber, string DataOrderBy)
        {
            List<tb_Account> AccountList = new tb_AccountManager().SelectALLPaginByRowNumber(PageSize,PageNumber,DataOrderBy);
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account list paging", AccountList, AccountList.Count));
        }
        [Route("Account/GetAccountById")]
        public IHttpActionResult GetAccountById(int id)
        {
            tb_AccountManager manager = new tb_AccountManager();
            tb_Account Account = manager.SelectSingleLine_RTModel(new tb_Account() { ID=id});
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetAccountById", Account, 1));
        }
        [Route("Account/GetAccountByLoginId")]
        public IHttpActionResult GetAccountByLoginId(string loginId)
        {
            tb_AccountManager manager = new tb_AccountManager();
            List<tb_Account> AccountList= manager.SelectALL(" loginId =" + loginId);
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", AccountList, AccountList.Count));
        }
        [Route("Account/DeleteAccountById")]
        [HttpPost,HttpDelete]//这里方法名称带Delete如果不配置这里允许post请求，那么必须使用delete请求方式
        public IHttpActionResult DeleteAccountById(int id)
        {
            tb_AccountManager manager = new tb_AccountManager();
            bool isDelete = manager.IsDelete(new tb_Account() { ID = id });
            if (isDelete)
            {
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("delete success", true));
            }
            else
            {
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("delete faild", false));
            }
         }
        [Route("Account/AddAccount")]
        public IHttpActionResult AddAccount(dynamic query)
        {
            try
            {
                tb_Account account = new tb_Account();
                account.loginId = query.loginId;
                account.pwd = query.pwd;
                account.email = query.email;
                account.sex = query.sex;
                account.phone = query.phone;
                bool isAdd = new tb_AccountManager().IsInsert(account);
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
    }
}
