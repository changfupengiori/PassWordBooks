/* * 
 * author:changfupeng
 * createDate:2018-11-22 13:41
 * remark:单例缓存对象
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace PassWordBooks
{
    /// <summary>
    /// 缓存密码凭证
    /// </summary>
    internal sealed class CachePassWordSecurity
    {
        private static CachePassWordSecurity _cachePassWordSecurity;
        private static readonly object SyncRoot = new object();
        /// <summary>
        /// 计时器间隔
        /// </summary>
        private readonly int Timespan= 5 * 60 * 1000;
        private Timer _timer;

        private DateTime? _securityTime;
        private string _security=string.Empty;
        private Dictionary<string, string> _verifyCode = new Dictionary<string, string>();

        /// <summary>
        /// 缓存密码凭证
        /// </summary>
        private CachePassWordSecurity()
        {            
        }
        /// <summary>
        /// 缓存验证码
        /// </summary>
        /// <param name="verifyCode">验证码</param>
        /// <returns></returns>
        public string SetVerifyCode(string verifyCode)
        {
            string key = Convert.ToString((DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000);
            _verifyCode.Add(key, verifyCode);
            return key;
        }
        /// <summary>
        /// 验证验证码是否正确
        /// </summary>
        /// <param name="key">生成的验证码编号</param>
        /// <param name="verifyCode">验证码</param>
        /// <returns>检查结果</returns>
        public bool CheckVerifyCode(string key, string verifyCode)
        {
            if (_verifyCode.ContainsKey(key))
            {
                return _verifyCode[key].Equals(verifyCode);
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 移除验证码的缓存
        /// </summary>
        /// <param name="key">生成的验证码编号</param>
        public void RemoveVerifyCode(string key)
        {
            if (_verifyCode.ContainsKey(key))
            {
                _verifyCode.Remove(key);
            }
        }
        /// <summary>
        /// 获取缓存实例对象
        /// </summary>
        /// <returns></returns>
        public static CachePassWordSecurity GetInstance()
        {
            if (_cachePassWordSecurity == null)
            {
                lock (SyncRoot)
                {
                    if (_cachePassWordSecurity == null)
                    {
                        _cachePassWordSecurity = new CachePassWordSecurity();

                        //初始化计时器
                        _cachePassWordSecurity._timer = new Timer(_cachePassWordSecurity.Timespan);
                        _cachePassWordSecurity._timer.AutoReset = false;
                        _cachePassWordSecurity._timer.Elapsed += _cachePassWordSecurity.Timer_Elapsed;
                    }
                }
            }
            return _cachePassWordSecurity;
        }
        /// <summary>
        /// 获取缓存是否有效
        /// </summary>
        public bool IsCache
        {
            get
            {
                ///防止用户通过改本地系统时间使密保长期有效
                if (_securityTime != null && Math.Abs((DateTime.Now - _securityTime).Value.TotalMinutes) <= 5)
                    return true;
                else
                    return false;
            }
        }
        /// <summary>
        /// 此属性有时效性，5分钟过期自行判断时间有效期
        /// </summary>
        /// <exception cref="ExceptionSecurityTimeout">密码验证超时需要再次做密码验证</exception>
        public string Security
        {
            get
            {
                ///防止用户通过改本地系统时间使密保长期有效
                if (_securityTime != null && Math.Abs((DateTime.Now - _securityTime).Value.TotalMinutes) <= 5)
                {
                    return _security;
                }
                else
                {
                    throw new ExceptionSecurityTimeout("密码验证超时需要再次做密码验证");
                }
            }
           internal set
            {
                _security = value;
                _securityTime = DateTime.Now;
                _timer.Stop();
                _timer.Start();
            }
        }
        /// <summary>
        /// 计时器自动清理缓存数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _security = string.Empty;
            _securityTime = null;
            _verifyCode.Clear();
        }
    }
}
