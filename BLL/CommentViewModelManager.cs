using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CommentViewModelManager
    {
        public List<CommentViewModel> GetCommentViewModelList(string condition = "and 1=1 ")
        {
            return new CommentViewModelService().GetCommentViewModelList(condition);
        }
        public List<CommentViewModel> GetCommentViewModelListByEmployeeId(int employeeId)
        {
            string condition = "and cm.employeeId = " + employeeId;
            return new CommentViewModelService().GetCommentViewModelList(condition);
        }
        public List<CommentViewModel> GetCommentViewModelListByEmployerId(int employerId)
        {
            string condition = "and cm.employerId = " + employerId;
            return new CommentViewModelService().GetCommentViewModelList(condition);
        }
    }
}
