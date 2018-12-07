/* * 
 * author:changfupeng
 * createDate:2018-12-4 9:17
 * remark:二次认证事件基类
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PassWordBooks
{
    /// <summary>
    /// 二次认证事件基类
    /// </summary>
    /// <remarks>通过正确的VerifyCode和VerifyCode能够获取数据。异常数据流将终止</remarks>
    public class EventSencondVerify : EventArgs
    {
        /// <summary>
        /// 二次认证事件基类
        /// </summary>
        public EventSencondVerify()
        {
            IsCancel = false;
        }
        /// <summary>
        /// 二次认证事件基类
        /// </summary>
        /// <param name="type">二次验证的类型</param>
        /// <param name="model">密码本对象</param>
        public EventSencondVerify(PassWordBookSaveType type, Model.PassWordBookModel model)
        {
            Type = type;
            PassWordBookModel = model;
        }
        /// <summary>
        /// 当前数据需要二次验证的类型
        /// </summary>
        public PassWordBookSaveType Type {  get; protected internal set; }
        /// <summary>
        /// 当前解析的密码本对象
        /// </summary>
        public Model.PassWordBookModel PassWordBookModel { get; protected internal set; }
        /// <summary>
        /// 邮箱手机验证码或者二次验证码或者物理验证key
        /// </summary>
        public string VerifyCode { get; set; }
        /// <summary>
        /// 发送验证码对应的编号
        /// </summary>
        public string VerifyCodeKey { get; set; }
        /// <summary>
        /// 是否取消
        /// </summary>
        public bool IsCancel { get; set; }
    }
}
