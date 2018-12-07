using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileServer
{
    public class FileServer : IFileServer
    {
        public string GetFileString(string filePath, string passWordCertificate)
        {
            if (System.IO.File.Exists(filePath))
            {
                using (System.IO.StreamReader sw = new System.IO.StreamReader(filePath))
                {
                    string dbString = sw.ReadToEnd();

                    //判断行头是否此账号下的内容
                    if (!dbString.StartsWith(passWordCertificate))
                    {
                        throw new NullReferenceException("数据文件被修改或者配置错误");
                    }
                    string db = dbString.Substring(0, dbString.Length - 32);
                    string md5 = dbString.Replace(db, "");
                    EncryptAndDecodeServer.IEncryptAndDecodeServer encrypt = new EncryptAndDecodeServer.EncryptAndDecodeServer();
                    if (md5 == encrypt.GetMd532(db))
                    {
                        return db.Replace(passWordCertificate, "");
                    }
                    else
                    {
                        throw new NullReferenceException("数据文件被修改或者配置错误");
                    }
                }
            }
            else
            {
                throw new NullReferenceException("数据文件未查找到");
            }
        }

        public string GetPropertyFile(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                using (System.IO.StreamReader sw = new System.IO.StreamReader(filePath))
                {
                    string dbString = sw.ReadToEnd();
                    return dbString;
                }
            }
            else
            {
                throw new NullReferenceException("数据文件未查找到");
            }
        }

        public void SaveFile(string fileString, string passWordCertificate, string filePath)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filePath, false))
            {
                EncryptAndDecodeServer.IEncryptAndDecodeServer encrypt = new EncryptAndDecodeServer.EncryptAndDecodeServer();
                string md5 = encrypt.GetMd532(passWordCertificate + fileString);
                sw.Write((passWordCertificate + fileString + md5).ToCharArray());
            }
        }

        public void SavePropertyFile(string propertyStr, string filePath)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filePath, false))
            {
                sw.Write(propertyStr);
            }
        }
    }
}
