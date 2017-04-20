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
    /// Codes Builder Time (代码生成时间):2017-03-23 17:55:03
    /// </summary>

    /// <summary>
    /// 实体类T_Comment（可添加属性说明）
    /// </summary>
    [Serializable]
    public class T_Comment
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public T_Comment()
        { }

        private Int32 _commentid;		// PK（主键） 
        private Int32 _employeeid;		//
        private Int32 _employerid;		//
        private String _comment;		//

        /// <summary>
        ///
        /// </summary>
        public Int32 commentId
        {
            set { _commentid = value; }
            get { return _commentid; }
        }
        /// <summary>
        ///
        /// </summary>
        public Int32 employeeId
        {
            set { _employeeid = value; }
            get { return _employeeid; }
        }
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
        public String comment
        {
            set { _comment = value; }
            get { return _comment; }
        }
    }
}
