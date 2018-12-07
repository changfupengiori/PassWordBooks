/* * 
 * author:changfupeng
 * createDate:2018-11-19 13:41
<<<<<<< HEAD
 * remark:邮件服务
=======
 * remark:邮件服务接口
>>>>>>> 3eadf37... 初始版本
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD
using System.Net.Mail;

namespace EmailServer
{
    /// <summary>
    /// 邮件服务
    /// </summary>
    public class EmailServer : IEmailServer
    {
        /// <summary>
        /// 邮件服务
        /// </summary>
        private EmailServer()
        {
            initEmailServer();
        }
        /// <summary>
        /// 邮件服务
        /// </summary>
        private SmtpClient _clientSmtp = new SmtpClient();
        private static EmailServer _emailServer=null;
        private static readonly object SyncRoot = new object();
        /// <summary>
        /// 获取邮件服务的地址
        /// </summary>
        /// <returns></returns>
        public static EmailServer GetInstance()
        {
            if (_emailServer == null)
            {
                lock (SyncRoot)
                {
                    if (_emailServer == null)
                    {
                        _emailServer = new EmailServer();
                    }
                }
            }
            return _emailServer;
        }
        /// <summary>
        /// 邮件服务
        /// </summary>
        /// <returns></returns>
        public bool initEmailServer()
        {
            _clientSmtp.Host = "smtp.126.com";
            _clientSmtp.Port = 25;
            _clientSmtp.UseDefaultCredentials = false;
            _clientSmtp.Credentials = new System.Net.NetworkCredential("changfupengiori", "cfpCFP123456");
            return true;
        }
        /// <summary>
        /// 初始化用于检查配置的账号等相关信息
        /// </summary>
        /// <param name="accountKey">初始化具体使用某一套账号发送</param>
        /// <returns></returns>
=======

namespace EmailServer
{
    public class EmailServer : IEmailServer
    {
        public bool initEmailServer()
        {
            throw new NotImplementedException();
        }

>>>>>>> 3eadf37... 初始版本
        public bool initEmailServer(int accountKey)
        {
            throw new NotImplementedException();
        }
<<<<<<< HEAD
        /// <summary>
        /// 保存邮箱账号
        /// </summary>
        /// <param name="account">账号</param>
        /// <param name="password">密码</param>
        /// <param name="port">端口</param>
        /// <param name="serverpath">服务地址</param>
=======

>>>>>>> 3eadf37... 初始版本
        public void SaveEmailAccount(string account, string password, int port, string serverpath)
        {
            throw new NotImplementedException();
        }
<<<<<<< HEAD
        /// <summary>
        /// 发送测试邮件测试邮箱用户配置账号的时候使用
        /// </summary>
        /// <returns></returns>
=======

>>>>>>> 3eadf37... 初始版本
        public bool SendEmailTest()
        {
            throw new NotImplementedException();
        }
<<<<<<< HEAD
        /// <summary>
        /// 通过邮件发送验证码
        /// </summary>
        /// <param name="verCode">验证码</param>
        /// <param name="emailAddress">目的地邮箱地址</param>
        /// <returns></returns>
        public bool SendVerCodeByEmail(string verCode, string emailAddress)
        {
            MailMessage msg = CreateMessageModel();
            msg.To.Add(new MailAddress(emailAddress));
            msg.Subject = "密码本系统程序校验验证码邮件";//邮件标题 
            msg.Body = string.Format("你的密码本验码是【{0}】,有效期5分钟。", verCode);//邮件内容  

            try
            {
                _clientSmtp.Send(msg);
                msg.Dispose();
                return true;
            }
            catch (SmtpException ex)
            {
                ///log4记录邮件发送的异常
                return false;
            }
        }
        /// <summary>
        /// 创建一个邮件对象
        /// </summary>
        /// <returns></returns>
        private MailMessage CreateMessageModel()
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("changfupengiori@126.com", "密码本系统邮件服务");            
            msg.SubjectEncoding = Encoding.UTF8;//邮件标题编码  
            msg.IsBodyHtml = true;//是否是HTML邮件  
            return msg;
=======

        public bool SendVerCodeByEmail(int verCode, string emailAddress)
        {
            throw new NotImplementedException();
>>>>>>> 3eadf37... 初始版本
        }
    }
}
