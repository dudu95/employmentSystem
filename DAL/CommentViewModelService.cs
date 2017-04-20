using Model;
using SqlHelper_Framework4_5_DG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CommentViewModelService
    {
        public List<CommentViewModel> GetCommentViewModelList(string condition = "and 1=1 ")
        {
            string sql = @"select cm.commentId,cm.employeeId,cm.employerId,cm.comment,
                em.name as employeeName,em.telphone,em.email,em.educationId,em.graduatedSchool,em.major,
                em.workingLifeId,em.targetPosition,em.note as employeeNote,
                e.name as employerName,e.site,e.companyCateId,e.investmentStateId,e.city,e.address,e.scale,e.intro,e.note as employerNote,e.logo,
                wo.workingLife,
                ed.educationName,
                com.cateName,
                inv.stateName
                from T_Comment cm
                left join T_Employee em on cm.employeeId=em.employeeId
                left join T_Employer e on e.employerId=cm.employerId
                left join T_WorkingLife wo on wo.workingLifeId=em.workingLifeId
                left join T_Education ed on ed.educationId=em.educationId
                left join T_CompanyCate com on com.companyCateId=e.companyCateId
                left join T_InvestmentState inv on e.investmentStateId=inv.investmentStateId
                where cm.employeeId=em.employeeId and e.employerId=cm.employerId " + condition;
            return SqlHelper_DG.ReturnListByModels<CommentViewModel>(SqlHelper_DG.ExecuteDataSet(SqlHelper_DG.ConnString, sql));
        }
    }
}
