using Model;
using SqlHelper_Framework4_5_DG;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * author:qixiao
 * create:2017年4月15日 21:54:51
 * */
namespace DAL
{
    public class EmployeeViewModelService
    {
        public List<EmployeeViewModel> GetEmployeeViewModelList(string condition = " 1=1 ")
        {
            string sql = @"select em.employeeId,em.name,em.telphone,em.email,em.educationId,em.graduatedSchool,em.major,
                em.workingLifeId,em.targetPosition,em.note,em.username,em.password,
                ed.educationName,
                wo.workingLife
                from T_Employee em
                left join T_Education ed on ed.educationId=em.educationId 
                left join T_WorkingLife wo on em.workingLifeId=wo.workingLifeId where " + condition;
            return SqlHelper_DG.ReturnListByModels<EmployeeViewModel>(SqlHelper_DG.ExecuteDataSet(SqlHelper_DG.ConnString, sql));
        }
    }
}
