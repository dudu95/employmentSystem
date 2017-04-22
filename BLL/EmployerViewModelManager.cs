using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * author:qixiao
 * create:2017年4月15日 21:54:51
 * */
namespace BLL
{
    public class EmployerViewModelManager
    {
        public List<EmployerViewModel> GetEmployerViewModelList(string condition = " 1=1 ")
        {
            return new EmployerViewModelService().GetEmployerViewModelList(condition);
        }
        public List<EmployerViewModel> GetEmployerViewModelListBySearch(string str)
        {
            string condition = "e.name LIKE '%" + str + "%' or e.city LIKE '%" + str + "%' or inv.stateName LIKE '%" + str + "%'";
            return new EmployerViewModelService().GetEmployerViewModelList(condition);
        }
        public List<EmployerViewModel> GetEmployerViewModelListByEmployerId(int employerId)
        {
            string condition = "e.employerId = "+employerId;
            return new EmployerViewModelService().GetEmployerViewModelList(condition);
        }
    }
}
