using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EncryptAndDecodeServer;
using Newtonsoft.Json.Linq;

namespace PassWordBooks
{
    public class PassWordBooks
    {

        private readonly string BasePath = AppDomain.CurrentDomain.BaseDirectory;
        private static readonly object SyncRoot = new object();
        private static PassWordBooks _passWordBooks;

        private FileServer.IFileServer _iFileServer;
        internal FileServer.IFileServer IFileServer
        {
            get
            {
                if (_iFileServer == null)
                    _iFileServer = new FileServer.FileServer();
                return _iFileServer;
            }
        }        

        private IEncryptAndDecodeServer _iEncryptAndDecodeServer;
        internal IEncryptAndDecodeServer IEncryptAndDecodeServer
        {
            get
            {
                if (_iEncryptAndDecodeServer == null)
                    _iEncryptAndDecodeServer = new EncryptAndDecodeServer.EncryptAndDecodeServer();
                return _iEncryptAndDecodeServer;
            }
        }

        private Model.AccountModel _curAccountModel;
        /// <summary>
        /// 获取主账号数据信息
        /// </summary>
        public Model.AccountModel CurPassWordBookModel
        {
            get
            {
                if (_curAccountModel == null)
                {
                    RefreshAccount();
                }
                return _curAccountModel;
            }
        }

        private PassWordBooks()
        {

        }
        /// <summary>
        /// 获取密码本服务实例对象
        /// </summary>
        /// <returns></returns>
        public static PassWordBooks GetInstance()
        {
            if (_passWordBooks == null)
            {
                lock (SyncRoot)
                {
                    if (_passWordBooks == null)
                    {
                        _passWordBooks = new  PassWordBooks();
                    }
                }
            }
            return _passWordBooks;
        }
        /// <summary>
        /// 当前账号的名称
        /// </summary>
        public string CurAccountName
        {
            get
            {
                return CurPassWordBookModel.Account;
            }
        }
        /// <summary>
        /// 检查主账号是否存在
        /// </summary>
        /// <returns></returns>
        public bool CheckAccount()
        {
            if (System.IO.Directory.Exists(BasePath + "data"))
            {
                var list = System.IO.Directory.GetDirectories(BasePath + "data");
                if (list != null && list.Length >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        /// <summary>
        /// 重新加载数据
        /// </summary>
        /// <returns></returns>
        public void RefreshAccount()
        {
            string filePath = string.Empty;
            if (System.IO.Directory.Exists(BasePath + "data"))
            {
                var list = System.IO.Directory.GetDirectories(BasePath + "data");
                if (list != null && list.Length > 1)//存在多账号取默认
                {
                    //回头再修改
                    throw new Exception("还未实现");
                }
                else
                {
                    string fileName = list[0].Split('\\').Last();
                    filePath = list[0] + "\\" + fileName + ".json";
                }
            }
            string propertyFileStr = IFileServer.GetPropertyFile(filePath);
            JToken jtoken = Newtonsoft.Json.JsonConvert.DeserializeObject<JToken>(propertyFileStr);
            _curAccountModel = new Model.AccountModel()
            {
                Account = jtoken["Account"].ToString(),
                CreateDate = jtoken["CreateDate"].Value<DateTime>(),
                Email = jtoken["Email"].ToString(),
                IsComputer = jtoken["IsComputer"].Value<bool>(),
                Phone = jtoken["Phone"].ToString(),
                Remark = jtoken["Remark"].ToString(),
                PassWordCertificate = jtoken["PassWordCertificate"].ToString(),
                PassWordHelp = jtoken["PassWordHelp"].ToString(),
                //PassWordBooks = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Model.PassWordBookModel>>(jtoken["PassWordBooks"].ToString())
            };
            foreach (JToken item in jtoken["PassWordBooks"])
            {
                var model = new Model.PassWordBookModel();
                model.ConverToData(item.ToString());
                _curAccountModel.PassWordBooks.Add(model);
            }
        }

        /// <summary>
        /// 保存对当前账号的修改
        /// </summary>
        private void SaveAccount()
        {
            JToken jtoken = JToken.Parse(Newtonsoft.Json.JsonConvert.SerializeObject(CurPassWordBookModel));
            JArray jArray = new JArray();
            foreach (var item in CurPassWordBookModel.PassWordBooks)
            {
                jArray.Add(JToken.Parse(item.ConverToJson()));
            }
            jtoken["PassWordBooks"] = jArray;

            IFileServer.SavePropertyFile(jtoken.ToString(), string.Format("{0}data\\{1}\\{1}.json", BasePath, CurPassWordBookModel.Account));
        }
        /// <summary>
        /// 切换当前操作账号
        /// </summary>
        /// <param name="acount">账号</param>
        public void ChangeAccount(string acount)
        {

        }
        /// <summary>
        /// 初始化主账号
        /// </summary>
        /// <param name="account">账户名</param>
        /// <param name="password">密码明文</param>
        public void InitAccount(string account, string password, string passWordHelp, string remark, bool isComputer)
        {
            //1、创建目录
            System.IO.Directory.CreateDirectory(BasePath + "data\\" + account);
            //2、创建主账号配置文件
            Newtonsoft.Json.Linq.JToken jtoken = new Newtonsoft.Json.Linq.JObject();
            jtoken["Account"] = account;
            jtoken["Remark"] = remark;
            jtoken["PassWordHelp"] = passWordHelp;
            jtoken["PassWordCertificate"] = GetPassWordCertificate(account, password, isComputer);
            jtoken["Phone"] = "";
            jtoken["Email"] = "";
            jtoken["CreateDate"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            jtoken["IsComputer"] = isComputer;
            jtoken["PassWordBooks"] = new Newtonsoft.Json.Linq.JArray();
            IFileServer.SavePropertyFile(jtoken.ToString(), string.Format("{0}data\\{1}\\{1}.json", BasePath, account));
            //3、设置配置文件。设置默认账号
            //4、加载默认账号
            RefreshAccount();
        }
        /// <summary>
        /// 生成验证码
        /// </summary>
        /// <returns></returns>
        public string SendVerifyCode()
        {
            return string.Empty;
        }
        /// <summary>
        /// 创建手机号
        /// </summary>
        /// <param name="phone">新手机号</param>
        /// <param name="oldPhone">旧手机号,初次绑定为空</param>
        /// <param name="verifyCode">验证码</param>
        public void SetAccountPhone(string oldPhone,string phone, string verifyCode)
        {

        }
        /// <summary>
        /// 创建邮箱
        /// </summary>
        /// <param name="email">新邮箱</param>
        /// <param name="oldEmail">旧邮箱,初次绑定为空</param>
        /// <param name="verifyCode">邮箱验证码</param>
        public void SetAccountEmail(string oldEmail, string email,string verifyCode)
        {

        }
        /// <summary>
        /// 验证主账号密码
        /// </summary>
        /// <param name="password">主账号密码</param>
        /// <returns></returns>
        public bool VerifyAccountPwd(string password)
        {
            string passWordCertificate = CurPassWordBookModel.Account + password;
            if (CurPassWordBookModel.IsComputer)
            {
                string computer = getComputer();
                computer = IEncryptAndDecodeServer.GetSha1(computer);
                passWordCertificate = IEncryptAndDecodeServer.GetHMacSha512(passWordCertificate, computer);
            }
            else
            {
                passWordCertificate = IEncryptAndDecodeServer.GetSha512(passWordCertificate);
            }
            passWordCertificate = IEncryptAndDecodeServer.GetMd532(passWordCertificate);
            if (passWordCertificate.Equals(CurPassWordBookModel.PassWordCertificate))
            {
                //生成加密认证的密保
                GetPassWordSecurity(password);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 二次验证密码本
        /// </summary>
        /// <param name="secondPwd"></param>
        /// <returns></returns>
        public bool VerifySecondPwd(string secondPwd)
        {
            return false;
        }
        /// <summary>
        /// 保存单个密码本
        /// </summary>
        /// <param name="passwordbook">数据</param>
        public void SavePassWordBook(Model.PassWordBookModel passwordbook)
        {
            SavePassWordBook(passwordbook, PassWordBookSaveType.Null,string.Empty);
        }
        /// <summary>
        /// 保存单个密码本
        /// </summary>
        /// <param name="passwordbook">数据</param>
        /// <param name="type">密保类型</param>
        /// <returns>物理认证加密后的密保文件</returns>
        public string SavePassWordBook(Model.PassWordBookModel passwordbook, PassWordBookSaveType type)
        {
            return SavePassWordBook(passwordbook, type, string.Empty);
        }
        /// <summary>
        /// 保存单个密码本
        /// </summary>
        /// <param name="passwordbook">数据</param>
        /// <param name="type">密保类型</param>
        /// <param name="secondpwd">二次密码</param>
        /// <returns>物理认证加密后的密保文件</returns>
        public string SavePassWordBook(Model.PassWordBookModel passwordbook, PassWordBookSaveType type, string secondpwd)
        {
            if (!CachePassWordSecurity.GetInstance().IsCache)
            {
                throw new ExceptionSecurityTimeout("密码验证超时需要再次做密码验证");
            }
            if (type == PassWordBookSaveType.AuthPassWord && string.IsNullOrEmpty(secondpwd))
            {
                throw new Exception("使用二次密码认证，二次密码不能为空");
            }
            string savePhysicsStr = string.Empty;
            //设置时间标记
            passwordbook.CreateDate = DateTime.Now;

            Newtonsoft.Json.Linq.JToken jtoken = new JObject();
            jtoken["SecondAuthentication"] = type.ToString();
            jtoken["PassWord"] = passwordbook.PassWord;
            //移除密码显示存储。
            passwordbook.PassWord = string.Empty;
            jtoken["Data"] = Newtonsoft.Json.JsonConvert.SerializeObject(passwordbook.Data);

            string saveStr = jtoken.ToString();
            //针对不同类型进行不同的加密处置方式
            switch (type)
            {
                case PassWordBookSaveType.Null:
                    break;
                case PassWordBookSaveType.AuthEmailCode:
                    break;
                case PassWordBookSaveType.AuthPhoneCode:
                    break;
                case PassWordBookSaveType.AuthPassWord:
                    saveStr = SecondPwdEncryptionData(secondpwd, saveStr, type);
                    break;
                case PassWordBookSaveType.PhysicsCode:
                    secondpwd = GetRandomPassWord(12);
                    saveStr = SecondPwdEncryptionData(secondpwd, saveStr, type);
                    //创建物理的密钥文件
                    savePhysicsStr = IEncryptAndDecodeServer.AesEncryption(secondpwd, CachePassWordSecurity.GetInstance().Security);
                    break;
                default:
                    break;
            }

            //使用密码证书做AES加密
            saveStr = IEncryptAndDecodeServer.AesEncryption(saveStr, CachePassWordSecurity.GetInstance().Security);
            //保存密码本文件
            IFileServer.SaveFile(saveStr, CurPassWordBookModel.PassWordCertificate, passwordbook.FilePath);

            CurPassWordBookModel.PassWordBooks.Add(passwordbook);
            SaveAccount();

            return savePhysicsStr;
        }

        /// <summary>
        /// 二次加密数据方式
        /// </summary>
        /// <param name="secondpwd">二次加密密码</param>
        /// <param name="str">加密字符串</param>
        /// <returns></returns>
        private string SecondPwdEncryptionData(string secondpwd, string str, PassWordBookSaveType type)
        {
            string sencondMd5 = IEncryptAndDecodeServer.GetMd532(secondpwd);
            //使用密码做AES加密
            str = IEncryptAndDecodeServer.AesEncryption(str, secondpwd);
            //拼接字符串
            str = sencondMd5 + str + IEncryptAndDecodeServer.GetMd532(sencondMd5 + str);
            //拼接外部Json结构
            JObject jtoken = new JObject();
            jtoken["SecondAuthentication"] = type.ToString();
            jtoken["Data"] = str;
            return jtoken.ToString();
        }

        /// <summary>
        /// 获取密码本存储的了下
        /// </summary>
        /// <param name="passwordbookfilepath"></param>
        /// <returns></returns>
        public PassWordBookSaveType CheckPassWorkBookType(string passwordbookfilepath)
        {
            return PassWordBookSaveType.Null;
        }
        /// <summary>
        /// 获取密码本
        /// </summary>
        /// <param name="passwordbookfilepath">密码本路径</param>
        /// <param name="type">密码本类型</param>
        /// <param name="verifyCode">邮箱手机验证码或者二次验证码或者物理验证key</param>
        /// <returns></returns>
        public Model.PassWordBookModel GetPassWordBook(string passwordbookfilepath, PassWordBookSaveType type, string verifyCode)
        {
            return null;
        }
        /// <summary>
        /// 带过滤功能的过滤密码本
        /// </summary>
        /// <param name="searchWord"></param>
        /// <returns></returns>
        public List<Model.PassWordBookModel> GetPassWordBooks(string searchWord)
        {
            return null;
        }
        /// <summary>
        /// 获取用户已有的标签
        /// </summary>
        /// <returns></returns>
        public HashSet<string> GetTags()
        {
            return new HashSet<string>();
        }
        /// <summary>
        /// 备份全库数据
        /// </summary>
        /// <returns></returns>
        public string Backups()
        {
            return string.Empty;
        }
        /// <summary>
        /// 还原全库数据
        /// </summary>
        /// <param name="path">还原的数据</param>
        /// <returns></returns>
        public void Restore(string path)
        {
            
        }
        /// <summary>
        /// 变更密码
        /// </summary>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        public bool ChangePwd(string newPassword)
        {
            return false;
        }
        /// <summary>
        /// 获取主账号列表名称
        /// </summary>
        /// <returns></returns>
        public string[] GetAccountNames()
        {
            return null;
        }
        /// <summary>
        /// 随机生产一个密码
        /// </summary>
        /// <param name="length">密码长度,最少4位</param>
        /// <returns></returns>
        public string GetRandomPassWord(int length)
        {
            string result = string.Empty;
            Random randmo = new Random();
            //使用ASCII码随机生成33-126。
            if (length >= 4)
            {
                bool isNumber = false, isUpper = false, isLower = false;
                int c;
                Char[] chars = new Char[length];
                for (int i = 0; i < length; i++)
                {
                    c = randmo.Next(33, 127);
                    chars[i] = Convert.ToChar(c);

                    if (!isNumber && c >= 48 && c <= 57)
                        isNumber = true;
                    if (!isUpper && c >= 65 && c <= 90)
                        isUpper = true;
                    if (!isLower && c >= 97 && c <= 122)
                        isLower = true;
                }
                if (!isNumber)
                    chars[randmo.Next(0, length)] = Convert.ToChar(randmo.Next(48, 58));
                if (!isUpper)
                    chars[randmo.Next(0, length)] = Convert.ToChar(randmo.Next(65, 91));
                if (!isLower)
                    chars[randmo.Next(0, length)] = Convert.ToChar(randmo.Next(97, 123));
                //如果还是出现不同时包含大小写和数字，也没办法了。
                result = new string(chars);
            }
            return result;
        }
        /// <summary>
        /// 保存账号密保
        /// </summary>
        /// <param name="filePath"></param>
        public void SaveShield(string filePath, string password)
        {
            string account = CurPassWordBookModel.Account;
            string accountMd5 = IEncryptAndDecodeServer.GetMd532(account);
            //1、SHA512
            account = IEncryptAndDecodeServer.GetSha512(account);
            //2、数组逆转
            var oldArray = account.ToArray();
            Char[] newArray = new Char[oldArray.Length];
            for (int i = 0; i < oldArray.Length; i++)
            {
                newArray[oldArray.Length - 1] = oldArray[i];
            }
            //3、获取MD5
            account = IEncryptAndDecodeServer.GetMd532(new string(newArray));

            if (CurPassWordBookModel.IsComputer)
            {
                string computerStr = getComputer();
                string computerMd5 = IEncryptAndDecodeServer.GetMd532(computerStr);
                //1、机器码SHA
                computerStr = IEncryptAndDecodeServer.GetSha1(computerStr);
                //2、数组逆转
                oldArray = computerStr.ToArray();
                newArray = new Char[oldArray.Length];
                for (int i = 0; i < oldArray.Length; i++)
                {
                    newArray[oldArray.Length - 1] = oldArray[i];
                }
                //3、获取MD5
                computerStr = IEncryptAndDecodeServer.GetMd532(new string(newArray));
                //4、加密AES密码
                password = IEncryptAndDecodeServer.AesEncryption(password, computerStr);
                //5、验证数据拼接
                password = computerMd5 + password + IEncryptAndDecodeServer.GetMd532((computerMd5 + password));
            }
            else
            {
                string zero = "00000000000000000000000000000000";
                password = zero + password + IEncryptAndDecodeServer.GetMd532((zero + password));
            }
            account = IEncryptAndDecodeServer.AesEncryption(password, account);
            IFileServer.SaveFile(account, accountMd5, filePath);
        }
        /// <summary>
        /// 忘记密码
        /// </summary>
        /// <param name="filePath">密保文件</param>
        /// <returns></returns>
        public string FotgotPassWord(string filePath)
        {
            string result = string.Empty;

            string account = CurPassWordBookModel.Account;
            string accountMd5 = IEncryptAndDecodeServer.GetMd532(account);
            //1、SHA512
            account = IEncryptAndDecodeServer.GetSha512(account);
            //2、数组逆转
            var oldArray = account.ToArray();
            Char[] newArray = new Char[oldArray.Length];
            for (int i = 0; i < oldArray.Length; i++)
            {
                newArray[oldArray.Length - 1] = oldArray[i];
            }
            //3、获取MD5
            account = IEncryptAndDecodeServer.GetMd532(new string(newArray));
            try
            {
                //1、获取密保文件。引发NullReferenceException异常则文件被修改或者选择错误
                result = IFileServer.GetFileString(filePath, accountMd5);
                //2、账号解密
                result = IEncryptAndDecodeServer.AesDecryption(result, account);
                //3、数据完整性检查
                string computerCheck = result.Substring(0, 32);
                string db = result.Substring(0, result.Length - 32);
                string md5 = result.Replace(db, "");

                if (md5 == IEncryptAndDecodeServer.GetMd532(db))
                {
                    result = db.Replace(computerCheck, "");
                }
                else
                {
                    return "数据文件被修改或者配置错误";
                }
                //4、是否机器加密
                string zero = "00000000000000000000000000000000";
                if (computerCheck == zero)//非机器加密
                {
                    return result;
                }
                else
                {
                    string computerStr = getComputer();
                    string computerMd5 = IEncryptAndDecodeServer.GetMd532(computerStr);
                    if (computerCheck != computerMd5)
                    {
                        return "密保文件记录的机器码和当前计算机不匹配";
                    }
                    //1、机器码SHA
                    computerStr = IEncryptAndDecodeServer.GetSha1(computerStr);
                    //2、数组逆转
                    oldArray = computerStr.ToArray();
                    newArray = new Char[oldArray.Length];
                    for (int i = 0; i < oldArray.Length; i++)
                    {
                        newArray[oldArray.Length - 1] = oldArray[i];
                    }
                    //3、获取MD5
                    computerStr = IEncryptAndDecodeServer.GetMd532(new string(newArray));
                    //4、加密AES密码
                    result = IEncryptAndDecodeServer.AesDecryption(result, computerStr);
                }
            }
            catch (NullReferenceException e)
            {
                return e.Message;
            }
            return result;
        }
        /// <summary>
        /// 生成密码凭证
        /// </summary>
        /// <param name="isComputer">是否计算机加密</param>
        /// <param name="account">账号</param>
        /// <param name="passWord">密码</param>
        private string GetPassWordCertificate(string account, string passWord, bool isComputer)
        {
            string passWordCertificate = string.Empty;
            if (isComputer)//需要机器码
            {
                string computerInfo = getComputer();
                string sha1 = IEncryptAndDecodeServer.GetSha1(computerInfo);
                passWordCertificate = IEncryptAndDecodeServer.GetHMacSha512(account + passWord, sha1);
            }
            else
            {
                passWordCertificate = IEncryptAndDecodeServer.GetSha512(account + passWord);
            }

            return IEncryptAndDecodeServer.GetMd532(passWordCertificate);
        }
        /// <summary>
        /// 生成加密密码凭证并缓存
        /// </summary>
        /// <param name="passWord">密码</param>
        private void GetPassWordSecurity(string passWord)
        {
            string securityStr = CurPassWordBookModel.Account + passWord;
            //1、SHA512
            securityStr = IEncryptAndDecodeServer.GetSha512(securityStr);
            //2、数组逆转
            var oldArray = securityStr.ToArray();
            Char[] newArray = new Char[oldArray.Length];
            for (int i = 0; i < oldArray.Length; i++)
            {
                newArray[oldArray.Length - 1] = oldArray[i];
            }
            //3、获取MD5
            securityStr = IEncryptAndDecodeServer.GetMd532(new string(newArray));

            CachePassWordSecurity.GetInstance().Security = securityStr;
        }
        /// <summary>
        /// 获取机器码
        /// </summary>
        /// <returns></returns>
        private string getComputer()
        {
            string cpuInfo = string.Empty;//cpu序列号
            System.Management.ManagementClass cimobject = new System.Management.ManagementClass("Win32_Processor");
            System.Management.ManagementObjectCollection moc = cimobject.GetInstances();
            foreach (System.Management.ManagementObject mo in moc)
            {
                cpuInfo += mo.Properties["ProcessorId"].Value.ToString();
            }
            return cpuInfo;
        }
    }
}
