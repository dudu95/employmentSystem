using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ConnectionViewModelManager
    {
        public List<ConnectionViewModel> GetConnectionViewModelList(string condition = "and 1=1 ")
        {
            return new ConnectionViewModelService().GetConnectionViewModelList(condition);
        }
        public List<ConnectionViewModel> GetConnectionViewModelListByEmployeeId(int employeeId)
        {
            string condition = "and con.employeeId = " + employeeId;
            return new ConnectionViewModelService().GetConnectionViewModelList(condition);
        }
        public List<ConnectionViewModel> GetConnectionViewModelListByEmployerId(int employerId)
        {
            string condition = "and con.employerId = " + employerId;
            return new ConnectionViewModelService().GetConnectionViewModelList(condition);
        }
        public List<ConnectionViewModel> GetConnectionViewModelListByConnectedStateId(int connectedStateId)
        {
            string condition = "and con.connectedStateId = " + connectedStateId;
            return new ConnectionViewModelService().GetConnectionViewModelList(condition);
        }
    }
}
