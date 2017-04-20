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
	/// Codes Builder Time (代码生成时间):2017-04-13 22:41:11
	/// </summary>

	/// <summary>
	/// 实体类T_Employee（可添加属性说明）
	/// </summary>
	[Serializable]
	public class T_Employee
	{
		/// <summary>
		/// 构造方法
		/// </summary>
		public T_Employee()
		{}

		private Int32 _employeeid;		// PK（主键） 
		private String _name;		//
		private String _telphone;		//
		private String _email;		//
		private Int32 _educationid;		//
		private String _graduatedschool;		//
		private String _major;		//
		private Int32 _workinglifeid;		//
		private String _targetposition;		//
		private String _note;		//
		private String _username;		//
		private String _password;		//

		/// <summary>
		///
		/// </summary>
		public Int32 employeeId
		{
			set{_employeeid=value;}
			get{return _employeeid;}
		}
		/// <summary>
		///
		/// </summary>
		public String name
		{
			set{_name=value;}
			get{return _name;}
		}
		/// <summary>
		///
		/// </summary>
		public String telphone
		{
			set{_telphone=value;}
			get{return _telphone;}
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
		public Int32 educationId
		{
			set{_educationid=value;}
			get{return _educationid;}
		}
		/// <summary>
		///
		/// </summary>
		public String graduatedSchool
		{
			set{_graduatedschool=value;}
			get{return _graduatedschool;}
		}
		/// <summary>
		///
		/// </summary>
		public String major
		{
			set{_major=value;}
			get{return _major;}
		}
		/// <summary>
		///
		/// </summary>
		public Int32 workingLifeId
		{
			set{_workinglifeid=value;}
			get{return _workinglifeid;}
		}
		/// <summary>
		///
		/// </summary>
		public String targetPosition
		{
			set{_targetposition=value;}
			get{return _targetposition;}
		}
		/// <summary>
		///
		/// </summary>
		public String note
		{
			set{_note=value;}
			get{return _note;}
		}
		/// <summary>
		///
		/// </summary>
		public String username
		{
			set{_username=value;}
			get{return _username;}
		}
		/// <summary>
		///
		/// </summary>
		public String password
		{
			set{_password=value;}
			get{return _password;}
		}
	}
}
