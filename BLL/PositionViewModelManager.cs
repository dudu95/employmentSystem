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
    public class PositionViewModelManager
    {
        public List<PositionViewModel> GetPositionViewModelList(string condition = " 1=1 ")
        {
            return new PositionViewModelService().GetPositionViewModelList(condition);
        }
        public List<PositionViewModel> GetPositionViewModelListBySearch(string str)
        {
            string condition = "pp.position LIKE '%" + str + "%' or e.name LIKE '%" + str + "%' or e.city LIKE '%" + str + "%'";
            return new PositionViewModelService().GetPositionViewModelList(condition);
        }

        public List<PositionViewModel> GetPositionViewModelByPositionId(int positionId)
        {
            string condition = "pp.positionId="+positionId;
            return new PositionViewModelService().GetPositionViewModelList(condition);
        }
      
    }
}
