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
    public class PositionViewModelService
    {
        public List<PositionViewModel> GetPositionViewModelList(string condition = " 1=1 ")
        {
            string sql = @"select pp.positionId,pp.employerId,pp.position,pp.workingLifeId,pp.educationId,pp.salary,pp.advantage,pp.describe,
                e.address,e.city,e.companyCateId,e.intro,e.investmentStateId,e.logo,e.name,e.note,e.scale,e.site,
                wo.workingLife,
                ed.educationName,
                com.cateName,
                inv.stateName
                from T_PostPosition pp
                left join T_Employer e on e.employerId=pp.employerId
                left join T_WorkingLife wo on wo.workingLifeId=pp.workingLifeId
                left join T_Education ed on ed.educationId=pp.educationId
                left join T_CompanyCate com on com.companyCateId=e.companyCateId
                left join T_InvestmentState inv on e.investmentStateId=inv.investmentStateId
                WHERE " + condition;
            return SqlHelper_DG.ReturnListByModels<PositionViewModel>(SqlHelper_DG.ExecuteDataSet(SqlHelper_DG.ConnString, sql));
        }
        
    }
}
