using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicsServer
{
    public class Physics : IPhysics
    {
        public string GetPhysicsKey(string filePath, string passWordSecurity)
        {
            if (System.IO.File.Exists(filePath))
            {
                throw new NullReferenceException("物理文件密钥未查询到");
            }
            EncryptAndDecodeServer.IEncryptAndDecodeServer server = new EncryptAndDecodeServer.EncryptAndDecodeServer();
            using (System.IO.StreamReader sw = new System.IO.StreamReader(filePath))
            {
                string str = sw.ReadToEnd();
                str = server.AesDecryption(str, passWordSecurity);
                return str;
            }
        }

        public void SavePhysicsKey(string fileDir, string passWordSecurity, string secondPassWord, string target)
        {
            EncryptAndDecodeServer.IEncryptAndDecodeServer server = new EncryptAndDecodeServer.EncryptAndDecodeServer();
            string physiceStr = server.AesEncryption(secondPassWord, passWordSecurity);
            string filePath = string.Format(@"{0}/{1}_{2}.db", fileDir.TrimEnd('/'), target, DateTime.Now.ToString("yyyyMMddhhmmss"));
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filePath))
            {
                sw.WriteLine(physiceStr);
            }
        }
    }
}
