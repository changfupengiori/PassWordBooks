using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PassWordBooks.Model
{
    public class AccountModel
    {
        public AccountModel()
        {
            PassWordBooks = new List<Model.PassWordBookModel>();
        }
        /// <summary>
        /// 账号
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 帮助记忆密码文档
        /// </summary>
        public string PassWordHelp { get; set; }
        /// <summary>
        /// 密码凭证
        /// </summary>
        public string PassWordCertificate { get; internal set; }
        /// <summary>
        /// 账号手机
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get; internal set; }
        /// <summary>
        /// 是否指定计算机
        /// </summary>
        public bool IsComputer { get;internal set; }
        /// <summary>
        /// 密码本
        /// </summary>
        public List<PassWordBookModel> PassWordBooks { get; set; }
    }
}
