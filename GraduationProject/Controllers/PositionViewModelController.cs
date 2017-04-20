﻿using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GraduationProject.Controllers
{
    public class PositionViewModelController : ApiController
    {
        [Route("PositionViewModel/GetPositionViewModel")]
        public IHttpActionResult GetPositionViewModel()
        {
            try
            {
                List<PositionViewModel> PositionViewModelList = new PositionViewModelManager().GetPositionViewModelList();
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", PositionViewModelList, PositionViewModelList.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }

        [Route("PositionViewModel/GetPositionViewModelBySearch")]
        public IHttpActionResult GetPositionViewModelListBySearch(string name)
        {
            try
            {
                List<PositionViewModel> PositionViewModelList = new PositionViewModelManager().GetPositionViewModelListBySearch(name);
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", PositionViewModelList, PositionViewModelList.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }


        [Route("PositionViewModel/GetPositionViewModelByPaging")]
        public IHttpActionResult GetPositionViewModelByPaging(int PageIndex, int pageSize)
        {
            try
            {
                List<PositionViewModel> allList = new PositionViewModelManager().GetPositionViewModelList();
                List<PositionViewModel> PositionViewModelList = Helper.Paging.ListPaging<PositionViewModel>(allList, PageIndex, pageSize);
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", PositionViewModelList, PositionViewModelList.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }

    }
}
