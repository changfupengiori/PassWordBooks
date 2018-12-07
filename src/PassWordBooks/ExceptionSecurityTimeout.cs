/* * 
 * author:changfupeng
 * createDate:2018-11-30 13:24
 * remark:认证登陆超时。需要用户再次验证主账号登陆密码
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PassWordBooks
{
    public class ExceptionSecurityTimeout : Exception
    {
        public ExceptionSecurityTimeout() : base()
        {
        }
        public ExceptionSecurityTimeout(string message) :base(message)
        { }
    }
}
