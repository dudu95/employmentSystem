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
    public class EmployerViewModelService
    {
        public List<EmployerViewModel> GetEmployerViewModelList(string condition = " 1=1 ")
        {
            string sql = @"SELECT e.employerId,e.name,e.site,e.companyCateId,e.investmentStateId,e.city,e.address,e.scale,e.intro,e.note,e.logo ,inv.stateName,com.cateName,po.advantage,po.describe,po.educationId,po.position,po.positionId,po.salary,po.workingLifeId,ed.educationName,wo.workingLife FROM T_Employer e left join T_InvestmentState inv on e.investmentStateId=inv.investmentStateId left join T_CompanyCate com on com.companyCateId=e.companyCateId left join T_PostPosition po on po.employerId=e.employerId left join T_Education ed on ed.educationId=po.educationId left join T_WorkingLife wo on po.workingLifeId=wo.workingLifeId  WHERE " + condition;
            return SqlHelper_DG.ReturnListByModels<EmployerViewModel>(SqlHelper_DG.ExecuteDataSet(SqlHelper_DG.ConnString, sql));
        }
    }
}
