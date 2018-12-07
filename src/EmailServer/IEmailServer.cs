/* * 
 * author:changfupeng
 * createDate:2018-11-19 13:41
 * remark:邮件服务接口
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmailServer
{
    /// <summary>
    /// 邮箱相关服务
    /// </summary>
    public interface IEmailServer
    {
        /// <summary>
        /// 通过邮件发送验证码
        /// </summary>
        /// <param name="verCode">验证码</param>
        /// <param name="emailAddress">目的地邮箱地址</param>
        /// <returns></returns>
        bool SendVerCodeByEmail(string verCode,string emailAddress);

        /// <summary>
        /// 保存邮箱账号
        /// </summary>
        /// <param name="account">账号</param>
        /// <param name="password">密码</param>
        /// <param name="port">端口</param>
        /// <param name="serverpath">服务地址</param>
        void SaveEmailAccount(string account, string password, int port, string serverpath);
        /// <summary>
        /// 初始化 用于检查配置的账号等相关信息
        /// </summary>
        /// <returns></returns>
        bool initEmailServer();
        /// <summary>
        /// 初始化 用于检查配置的账号等相关信息
        /// </summary>
        /// <param name="accountKey">初始化具体使用某一套账号发送</param>
        /// <returns></returns>
        bool initEmailServer(int accountKey);
        /// <summary>
        /// 发送测试邮件测试邮箱用户配置账号的时候使用
        /// </summary>
        /// <returns></returns>
        bool SendEmailTest();
    }
}
