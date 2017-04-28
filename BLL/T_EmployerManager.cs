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
    /// Codes Builder Time (代码生成时间):2017-04-10 22:36:56
    /// </summary>

    /// <summary>
    /// 实体类T_EmployerManager（可添加属性说明）
    /// </summary>
    public class T_EmployerManager
    {
        //返回表中的数据数量 Int 一般配合分页使用
        public int DataCount()
        {
            string where = " 1=1 ";//判断条件语句可以自由发挥,默认返回全部 必须写安全的sql语句，防止数据注入!!!
            return new T_EmployerService().DataCount(where);
        }
        //返回是否存在
        public Boolean IsExistWhereFeild(T_Employer T_EmployerObject)
        {
            return new T_EmployerService().IsExistWhereFeild(T_EmployerObject);//这个需要按项目需求修改DAL层的条件代码以符合项目！！！
        }
        //插入业务
        public Boolean IsInsert(T_Employer T_EmployerObject)
        {
            return new T_EmployerService().IsInsert(T_EmployerObject);//自动过滤掉自增字段
        }
        //修改业务
        public Boolean IsUpdate(T_Employer T_EmployerObject)
        {
            return new T_EmployerService().IsUpdate(T_EmployerObject);//条件写在DAL层代码中
        }
        //删除业务
        public Boolean IsDelete(T_Employer T_EmployerObject)
        {
            return new T_EmployerService().IsDelete(T_EmployerObject);//条件写在DAL层代码中
        }
        //获取到某一行的业务--返回是Model类型的数据
        public T_Employer SelectSingleLine_RTModel(T_Employer T_EmployerObject)
        {
            return new T_EmployerService().SelectSingleLine_RTModel<T_Employer>(T_EmployerObject);
        }
        public T_Employer SelectByUserNameAndPassword(string username, string password)
        {
            return new T_EmployerService().SelectByUserNameAndPassword<T_Employer>(username, password);
        }
        //获取到符合条件的所有值的业务--返回List T
        public List<T_Employer> SelectALL()
        {
            return new T_EmployerService().SelectALL<T_Employer>();//这里补充返回Model的条件，为空默认所有数据
        }
        public List<T_Employer> SelectByCompanyCateId(T_Employer T_EmployerObject)
        {
            return new T_EmployerService().SelectByCompanyCateId<T_Employer>(T_EmployerObject);//这里补充返回Model的条件，为空默认所有数据
        }
        //分页获取到符合条件的所有值的业务，一般配合返回总数的方法使用显示总页数！--返回List T
        public List<T_Employer> SelectALLPaginByRowNumber(int PageSize, int PageNumber)
        {
            string where = " 1=1 ";//判断条件语句可以自由发挥,默认返回全部 必须写安全的sql语句，防止数据注入!!!
            return new T_EmployerService().SelectALLPaginByRowNumber<T_Employer>(PageSize, PageNumber, where);
        }
    }
}
