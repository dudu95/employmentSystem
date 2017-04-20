using System;

namespace Model
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
	/// Codes Builder Time (代码生成时间):2017/3/16 20:18:45
	/// </summary>

	/// <summary>
	/// 实体类tb_Account（可添加属性说明）
	/// </summary>
	[Serializable]
	public class tb_Account
	{
		/// <summary>
		/// 构造方法
		/// </summary>
		public tb_Account()
		{}

		private Int32 _id;		//
		private String _loginid;		//
		private String _pwd;		//
		private String _email;		//
		private Int32 _sex;		//
		private String _phone;		//

		/// <summary>
		///
		/// </summary>
		public Int32 ID
		{
			set{_id=value;}
			get{return _id;}
		}
		/// <summary>
		///
		/// </summary>
		public String loginId
		{
			set{_loginid=value;}
			get{return _loginid;}
		}
		/// <summary>
		///
		/// </summary>
		public String pwd
		{
			set{_pwd=value;}
			get{return _pwd;}
		}
		/// <summary>
		///
		/// </summary>
		public String email
		{
			set{_email=value;}
			get{return _email;}
		}
		/// <summary>
		///
		/// </summary>
		public Int32 sex
		{
			set{_sex=value;}
			get{return _sex;}
		}
		/// <summary>
		///
		/// </summary>
		public String phone
		{
			set{_phone=value;}
			get{return _phone;}
		}
	}
}
