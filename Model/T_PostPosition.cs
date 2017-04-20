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
	/// Codes Builder Time (代码生成时间):2017-04-13 22:40:22
	/// </summary>

	/// <summary>
	/// 实体类T_PostPosition（可添加属性说明）
	/// </summary>
	[Serializable]
	public class T_PostPosition
	{
		/// <summary>
		/// 构造方法
		/// </summary>
		public T_PostPosition()
		{}

		private Int32 _positionid;		// PK（主键） 
		private Int32 _employerid;		//
		private String _position;		//
		private Int32 _workinglifeid;		//
		private Int32 _educationid;		//
		private String _salary;		//
		private String _advantage;		//
		private String _describe;		//

		/// <summary>
		///
		/// </summary>
		public Int32 positionId
		{
			set{_positionid=value;}
			get{return _positionid;}
		}
		/// <summary>
		///
		/// </summary>
		public Int32 employerId
		{
			set{_employerid=value;}
			get{return _employerid;}
		}
		/// <summary>
		///
		/// </summary>
		public String position
		{
			set{_position=value;}
			get{return _position;}
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
		public Int32 educationId
		{
			set{_educationid=value;}
			get{return _educationid;}
		}
		/// <summary>
		///
		/// </summary>
		public String salary
		{
			set{_salary=value;}
			get{return _salary;}
		}
		/// <summary>
		///
		/// </summary>
		public String advantage
		{
			set{_advantage=value;}
			get{return _advantage;}
		}
		/// <summary>
		///
		/// </summary>
		public String describe
		{
			set{_describe=value;}
			get{return _describe;}
		}
	}
}
