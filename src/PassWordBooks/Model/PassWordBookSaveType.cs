using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PassWordBooks
{
    /// <summary>
    /// 密码本存储的类型
    /// </summary>
    public enum PassWordBookSaveType
    {
        /// <summary>
        /// 无需二次加密
        /// </summary>
        Null = 0,
        /// <summary>
        /// 验证邮箱验证码
        /// </summary>
        AuthEmailCode = 1,
        /// <summary>
        /// 验证手机验证码
        /// </summary>
        AuthPhoneCode = 2,
        /// <summary>
        /// 二次验证密码
        /// </summary>
        AuthPassWord = 3,
        /// <summary>
        /// 验证物理密码密文
        /// </summary>
        PhysicsCode = 4
    }
}
