using Model;
using SqlHelper_Framework4_5_DG;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
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
    /// 实体类T_EmployerService（可添加属性说明）
    /// </summary>
    public class T_EmployerService
    {
        /// <summary>
        /// 计算当前表内的符合条件的所有数据的数量
        /// </summary>
        /// <param name="safeSqlConditionInBLL">安全的sql条件语句,从BLL层获取</param>
        /// <returns></returns>
        public int DataCount(string safeSqlConditionInBLL = "")
        {
            try
            {
                string commandText = "select count(0) from T_Employer WHERE " + safeSqlConditionInBLL;
                return Convert.ToInt32(SqlHelper_DG.ExecuteScalar(SqlHelper_DG.ConnString, commandText));
            }
            catch (Exception)
            {
                return default(int);
            }
        }
        /// <summary>
        /// 检测是否存在条件所指示的数据------------这个方法需要按需求来修改条件，不能盲目使用！！！
        /// </summary>
        /// <param name="T_EmployerObject">从对象中提取中要查找的字段是否存在(对象方式是防止数据注入！)</param>
        /// <returns></returns>
        public Boolean IsExistWhereFeild(T_Employer T_EmployerObject)
        {
            try
            {
                string commandText = "select count(0) from T_Employer WHERE name=@name";
                SqlParameter[] parms = new SqlParameter[]{
				new SqlParameter("@name",T_EmployerObject.name),
				};
                return Convert.ToInt32(SqlHelper_DG.ExecuteScalar(SqlHelper_DG.ConnString, commandText, CommandType.Text, parms)) > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Insert插入语句，返回插入的结果：成功true，失败false
        /// </summary>
        /// <param name="T_EmployerObject">要插入的对象，屏蔽掉自增的字段</param>
        /// <returns></returns>
        public Boolean IsInsert(T_Employer T_EmployerObject)
        {
            try
            {
                string commandText = "INSERT INTO T_Employer ( name,logo,site,companyCateId,investmentStateId,city,address,scale,intro,note,username,password) VALUES (@name,@logo,@site,@companyCateId,@investmentStateId,@city,@address,@scale,@intro,@note,@username,@password)";
                SqlParameter[] parms = new SqlParameter[]{
				new SqlParameter("@name",T_EmployerObject.name),
				new SqlParameter("@logo",T_EmployerObject.logo),
				new SqlParameter("@site",T_EmployerObject.site),
				new SqlParameter("@companyCateId",T_EmployerObject.companyCateId),
				new SqlParameter("@investmentStateId",T_EmployerObject.investmentStateId),
				new SqlParameter("@city",T_EmployerObject.city),
				new SqlParameter("@address",T_EmployerObject.address),
				new SqlParameter("@scale",T_EmployerObject.scale),
				new SqlParameter("@intro",T_EmployerObject.intro),
				new SqlParameter("@note",T_EmployerObject.note),
                new SqlParameter("@username",T_EmployerObject.username),
				new SqlParameter("@password",T_EmployerObject.password),
				};
                return SqlHelper_DG.ExecuteNonQuery(SqlHelper_DG.ConnString, commandText, CommandType.Text, parms) > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Update修改语句，返回修改的结果：成功true，失败false
        /// </summary>
        /// <param name="T_EmployerObject">要修改的结果对象，屏蔽掉自增的列，条件可修改</param>
        /// <returns></returns>
        public Boolean IsUpdate(T_Employer T_EmployerObject)
        {
            try
            {
                string commandText = "UPDATE T_Employer SET name=@name,logo=@logo,site=@site,companyCateId=@companyCateId,investmentStateId=@investmentStateId,city=@city,address=@address,scale=@scale,intro=@intro,note=@note,@username,@password WHERE employerId=@employerId";
                SqlParameter[] parms = new SqlParameter[]{
					new SqlParameter("@employerId",T_EmployerObject.employerId),
					new SqlParameter("@name",T_EmployerObject.name),
					new SqlParameter("@logo",T_EmployerObject.logo),
					new SqlParameter("@site",T_EmployerObject.site),
					new SqlParameter("@companyCateId",T_EmployerObject.companyCateId),
					new SqlParameter("@investmentStateId",T_EmployerObject.investmentStateId),
					new SqlParameter("@city",T_EmployerObject.city),
					new SqlParameter("@address",T_EmployerObject.address),
					new SqlParameter("@scale",T_EmployerObject.scale),
					new SqlParameter("@intro",T_EmployerObject.intro),
					new SqlParameter("@note",T_EmployerObject.note),
                    new SqlParameter("@username",T_EmployerObject.username),
				    new SqlParameter("@password",T_EmployerObject.password),
				};
                return SqlHelper_DG.ExecuteNonQuery(SqlHelper_DG.ConnString, commandText, CommandType.Text, parms) > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Delete删除语句，返回删除的结果：成功true，失败false
        /// </summary>
        /// <param name="T_EmployerObject">条件对象，唯一字段或者自定义删除条件</param>
        /// <returns></returns>
        public Boolean IsDelete(T_Employer T_EmployerObject)
        {
            try
            {
                string commandText = "DELETE FROM T_Employer WHERE employerId=@employerId";
                SqlParameter[] parms = new SqlParameter[]{
				new SqlParameter("@employerId",T_EmployerObject.employerId),
				};
                return SqlHelper_DG.ExecuteNonQuery(SqlHelper_DG.ConnString, commandText, CommandType.Text, parms) > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Select Model语句，返回查询的Model结果
        /// </summary>
        /// <param name="T_EmployerObject">条件对象，按需求来确定查找的条件</param>
        /// <returns></returns>
        public T SelectSingleLine_RTModel<T>(T_Employer T_EmployerObject)
        {
            try
            {
                string commandText = "SELECT TOP (1) * FROM T_Employer WHERE employerId=@employerId";//这里需要按需求来确定需要查找的是哪个参数 因为要返回一行数据，所以搜索的条件值必须是唯一的，主键是最佳选择！
                SqlParameter[] parms = new SqlParameter[]{
				new SqlParameter("@employerId",T_EmployerObject.employerId),
				};
                return SqlHelper_DG.ReturnModelByModels<T>(SqlHelper_DG.ExecuteReader(SqlHelper_DG.ConnString, commandText, CommandType.Text, parms));
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        public T SelectByUserNameAndPassword<T>(string username, string password)
        {
            try
            {
                string commandText = "SELECT TOP (1) * FROM T_Employer WHERE username=@username and password=@password";//这里需要按需求来确定需要查找的是哪个参数 因为要返回一行数据，所以搜索的条件值必须是唯一的，主键是最佳选择！
                SqlParameter[] parms = new SqlParameter[]{
				    new SqlParameter("@username",username),
                    new SqlParameter("@password",password)
				};
                return SqlHelper_DG.ReturnModelByModels<T>(SqlHelper_DG.ExecuteReader(SqlHelper_DG.ConnString, commandText, CommandType.Text, parms));
            }
            catch (Exception)
            {
                return default(T);
            }
        }
        /// <summary>
        /// Select List语句，返回查询的List结果集
        /// </summary>
        /// <param name="safeSqlCondition">查询的条件,从BLL层传来的安全的sql语句</param>
        /// <returns></returns>
        public List<T> SelectALL<T>(string safeSqlCondition = " 1=1 ")
        {
            try
            {
                string commandText = "SELECT * FROM T_Employer WHERE " + safeSqlCondition;//这里修改条件语句 默认全部
                return SqlHelper_DG.ReturnListByModels<T>(SqlHelper_DG.ExecuteDataSet(SqlHelper_DG.ConnString, commandText));
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<T> SelectByCompanyCateId<T>(T_Employer T_EmployerObject)
        {
            try
            {
                string commandText = "SELECT * FROM T_Employer WHERE companyCateId=@companyCateId";
                SqlParameter[] parms = new SqlParameter[]{
				    new SqlParameter("@companyCateId",T_EmployerObject.companyCateId),
				};
                return SqlHelper_DG.ReturnListByModels<T>(SqlHelper_DG.ExecuteDataSet(SqlHelper_DG.ConnString, commandText, CommandType.Text, parms));
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// 用RowNumber方法进行分页处理返回List结果集，效率最佳但不支持低版本SqlServer
        /// </summary>
        /// <param name="PageSize">int页大小，每页容纳的行数</param>
        /// <param name="PageNumber">int页码，第几页</param>
        /// <param name="DataOrderBy">object表中按这个字段顺序排序,可以是任意字段,可以加修饰符如DESC</param>
        /// <param name="safeSqlCondition">所有集合中先找出符合这个条件的结果再进行分页处理 查询的条件,从BLL层传来的安全的sql语句</param>
        /// <returns></returns>
        public List<T> SelectALLPaginByRowNumber<T>(int PageSize, int PageNumber, string safeSqlCondition = "1=1")
        {
            try
            {
                StringBuilder commandText = new StringBuilder();
                commandText.Append("SELECT TOP " + PageSize + " * FROM (SELECT ROW_NUMBER() OVER (ORDER BY employerId) AS RowNumber,* FROM T_Employer ");
                commandText.Append(" WHERE " + safeSqlCondition + " ");//这里修改条件语句
                commandText.Append(" ) AS T  WHERE RowNumber > (" + PageSize + "*(" + PageNumber + "-1))");
                return SqlHelper_DG.ReturnListByModels<T>(SqlHelper_DG.ExecuteDataSet(SqlHelper_DG.ConnString, commandText.ToString()));
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
