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
	/// Codes Builder Time (代码生成时间):2017-04-13 22:37:26
	/// </summary>

	/// <summary>
	/// 实体类T_CompanyCate（可添加属性说明）
	/// </summary>
	[Serializable]
	public class T_CompanyCate
	{
		/// <summary>
		/// 构造方法
		/// </summary>
		public T_CompanyCate()
		{}

		private Int32 _companycateid;		// PK（主键） 
		private String _catename;		//

		/// <summary>
		///
		/// </summary>
		public Int32 companyCateId
		{
			set{_companycateid=value;}
			get{return _companycateid;}
		}
		/// <summary>
		///
		/// </summary>
		public String cateName
		{
			set{_catename=value;}
			get{return _catename;}
		}
	}
}
