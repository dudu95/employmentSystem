using System;
using System.Collections.Generic;
using DAL;
using Model;

namespace BLL
{
	/// <summary>
	/// QIXIAO CodesBuilders 七小代码生成器
	/// CopyRight（版权信息）------
	/// Version （版本号）:3.2.0
	/// Author （作者）:QIXIAO 七小(東哥)
	/// History Version 2.1.0 Made：2016-05-07 Asian China Tianjin
	/// History Version 2.2.0 Made：2016-06-05 Asian China Tianjin
	/// History Version 3.1.0 Made：2016-06-08 Asian China Tianjin
	/// Codes Standard （代码标准）：東哥的SqlHelper_DG
	/// Codes Builder Time (代码生成时间):2017-04-13 21:49:06
	/// </summary>

	/// <summary>
	/// 实体类T_InvestmentStateManager（可添加属性说明）
	/// </summary>
	public class T_InvestmentStateManager
	{
		//返回表中的数据数量 Int 一般配合分页使用
		public int DataCount()
		{
			string where = " 1=1 ";//判断条件语句可以自由发挥,默认返回全部 必须写安全的sql语句，防止数据注入!!!
			return new T_InvestmentStateService().DataCount(where);
		}
		//返回是否存在
		public Boolean IsExistWhereFeild(T_InvestmentState T_InvestmentStateObject)
		{
			return new T_InvestmentStateService().IsExistWhereFeild(T_InvestmentStateObject);//这个需要按项目需求修改DAL层的条件代码以符合项目！！！
		}
		//插入业务
		public Boolean IsInsert(T_InvestmentState T_InvestmentStateObject)
		{
			return new T_InvestmentStateService().IsInsert(T_InvestmentStateObject);//自动过滤掉自增字段
		}
		//修改业务
		public Boolean IsUpdate(T_InvestmentState T_InvestmentStateObject)
		{
			return new T_InvestmentStateService().IsUpdate(T_InvestmentStateObject);//条件写在DAL层代码中
		}
		//删除业务
		public Boolean IsDelete(T_InvestmentState T_InvestmentStateObject)
		{
			return new T_InvestmentStateService().IsDelete(T_InvestmentStateObject);//条件写在DAL层代码中
		}
		//获取到某一行的业务--返回是Model类型的数据
		public T_InvestmentState SelectSingleLine_RTModel(T_InvestmentState T_InvestmentStateObject)
		{
			return new T_InvestmentStateService().SelectSingleLine_RTModel<T_InvestmentState>(T_InvestmentStateObject);
		}
        public T_InvestmentState SelectByName_RTModel(T_InvestmentState T_InvestmentStateObject)
		{
            return new T_InvestmentStateService().SelectByName_RTModel<T_InvestmentState>(T_InvestmentStateObject);
		}
		//获取到符合条件的所有值的业务--返回List T
		public List<T_InvestmentState> SelectALL()
		{
			return new T_InvestmentStateService().SelectALL<T_InvestmentState>();//这里补充返回Model的条件，为空默认所有数据
		}
		//分页获取到符合条件的所有值的业务，一般配合返回总数的方法使用显示总页数！--返回List T
		public List<T_InvestmentState> SelectALLPaginByRowNumber(int PageSize, int PageNumber, string DataOrderBy)
		{
			string where = " 1=1 ";//判断条件语句可以自由发挥,默认返回全部 必须写安全的sql语句，防止数据注入!!!
			return new T_InvestmentStateService().SelectALLPaginByRowNumber<T_InvestmentState>(PageSize,PageNumber,DataOrderBy,where);
		}
	}
}
