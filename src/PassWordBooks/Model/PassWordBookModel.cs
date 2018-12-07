using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PassWordBooks.Model
{
    public class PassWordBookModel
    {
        public PassWordBookModel()
        {
            Redo = 3;            
        }
        private string _id = string.Empty;
        /// <summary>
        /// 获取当前账本的唯一ID
        /// </summary>
        public string ID
        {
            get
            {
                if (string.IsNullOrEmpty(_id))
                    _id = Convert.ToString((DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000);
                return _id;
            }
            internal set
            {
                _id = value;
            }
        }
        /// <summary>
        /// 密码本账号
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 用户自定义名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 服务器地址
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// 文件存储地址
        /// </summary>
        internal string FilePath
        {
            get
            {
                return string.Format("Data/{0}/{1}.db", PassWordBooks.GetInstance().CurAccountName, ID);
            }
        }
        /// <summary>
        /// 密码本记录的类型
        /// </summary>
        public PassWordBookType Type { get; set; }
        /// <summary>
        /// 描述信息
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 帮助记忆密码文档
        /// </summary>
        public string PassWordHelp { get; set; }
        /// <summary>
        /// 标记
        /// </summary>
        public List<string> Tags { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get;internal set; }
        /// <summary>
        /// 重做频率单位月。默认3,0不提醒修改
        /// </summary>
        public int Redo { get; set; }
        /// <summary>
        /// 数据存储
        /// </summary>
        public List<Model.PassWordBookData> Data { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; }
        /// <summary>
        /// 转换成JSON存储
        /// </summary>
        /// <returns></returns>
        internal string ConverToJson()
        {
            Newtonsoft.Json.Linq.JToken jToken = new Newtonsoft.Json.Linq.JObject();
            jToken["ID"] = ID;
            jToken["Account"] = Account;
            jToken["Name"] = Name;
            jToken["Path"] = Path;
            jToken["FilePath"] = FilePath;
            jToken["Type"] = Type.ToString();
            jToken["Remark"] = Remark;
            jToken["PassWordHelp"] = PassWordHelp;
            jToken["Tags"] = new Newtonsoft.Json.Linq.JArray(Tags);
            jToken["CreateDate"] = CreateDate;
            jToken["Redo"] = Redo;
            return jToken.ToString();
        }
        /// <summary>
        /// json字符串转换成数字
        /// </summary>
        /// <param name="jsonStr"></param>
        internal void ConverToData(string jsonStr)
        {
            Newtonsoft.Json.Linq.JToken jToken =  Newtonsoft.Json.Linq.JToken.Parse(jsonStr);
            ID = jToken.Value<string>("ID");
            Account = jToken.Value<string>("Account");
            Name = jToken.Value<string>("Name");
            Path = jToken.Value<string>("Path");
            this.Type = (PassWordBookType)Enum.Parse(typeof(PassWordBookType), jToken["Type"].ToString());
            Remark = jToken.Value<string>("Remark");
            PassWordHelp = jToken.Value<string>("PassWordHelp");
            Tags = Newtonsoft.Json.Linq.JArray.Parse(jToken["Tags"].ToString()).Select(P => P.ToString()).ToList<string>();
            CreateDate = jToken.Value<DateTime>("CreateDate");
            Redo = jToken.Value<int>("Redo");
        }
    }
}
