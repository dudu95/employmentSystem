using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmployeeViewModelManager
    {
        public List<EmployeeViewModel> GetEmployeeViewModelList(string condition = " 1=1 ")
        {
            return new EmployeeViewModelService().GetEmployeeViewModelList(condition);
        }
        public List<EmployeeViewModel> GetEmployeeViewModelListBySearch(string str)
        {
            string condition = "em.targetPosition LIKE '%" + str + "%' or ed.educationName LIKE '%" + str + "%' or wo.workingLife LIKE '%" + str + "%'";
            return new EmployeeViewModelService().GetEmployeeViewModelList(condition);
        }
    }
}
