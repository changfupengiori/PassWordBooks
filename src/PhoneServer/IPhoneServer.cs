/* * 
 * author:changfupeng
 * createDate:2018-11-20 14:55
 * remark:手机短信服务接口
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneServer
{
    public interface IPhoneServer
    {
        /// <summary>
        /// 通过手机发送验证码
        /// </summary>
        /// <param name="verCode">验证码</param>
        /// <param name="emailAddress">手机号</param>
        /// <returns></returns>
        bool SendVerCodeByPhone(int verCode, string phoneNumber);
        /// <summary>
        /// 初始化 用于检查配置的账号等相关信息
        /// </summary>
        /// <returns></returns>
        bool initPhoneServer();
    }
}
