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
    /// Codes Builder Time (代码生成时间):2017-03-23 17:56:15
    /// </summary>

    /// <summary>
    /// 实体类T_Employer（可添加属性说明）
    /// </summary>
    [Serializable]
    public class T_Employer
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public T_Employer()
        { }

        private Int32 _employerid;		// PK（主键） 
        private String _name;		//
        private String _logo;		//
        private String _site;		//
        private Int32 _companycateid;		//
        private Int32 _investmentstateid;		//
        private String _city;		//
        private String _address;		//
        private String _scale;		//
        private String _intro;		//
        private String _note;		//

        /// <summary>
        ///
        /// </summary>
        public Int32 employerId
        {
            set { _employerid = value; }
            get { return _employerid; }
        }
        /// <summary>
        ///
        /// </summary>
        public String name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        ///
        /// </summary>
        public string logo
        {
            set { _logo = value; }
            get { return _logo; }
        }
        /// <summary>
        ///
        /// </summary>
        public String site
        {
            set { _site = value; }
            get { return _site; }
        }
        /// <summary>
        ///
        /// </summary>
        public Int32 companyCateId
        {
            set { _companycateid = value; }
            get { return _companycateid; }
        }
        /// <summary>
        ///
        /// </summary>
        public Int32 investmentStateId
        {
            set { _investmentstateid = value; }
            get { return _investmentstateid; }
        }
        /// <summary>
        ///
        /// </summary>
        public String city
        {
            set { _city = value; }
            get { return _city; }
        }
        /// <summary>
        ///
        /// </summary>
        public String address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        ///
        /// </summary>
        public String scale
        {
            set { _scale = value; }
            get { return _scale; }
        }
        /// <summary>
        ///
        /// </summary>
        public String intro
        {
            set { _intro = value; }
            get { return _intro; }
        }
        /// <summary>
        ///
        /// </summary>
        public String note
        {
            set { _note = value; }
            get { return _note; }
        }
    }
}
