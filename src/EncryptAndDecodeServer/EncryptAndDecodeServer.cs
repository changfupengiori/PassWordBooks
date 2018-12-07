using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace EncryptAndDecodeServer
{
    public class EncryptAndDecodeServer : IEncryptAndDecodeServer
    {
        private const string IV = "691a51b412d6a442";
        public string AesDecryption(string text, string secretKey)
        {
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                aes.Key = Encoding.UTF8.GetBytes(secretKey);
                aes.IV = Encoding.UTF8.GetBytes(IV);
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                var enc = aes.CreateDecryptor(aes.Key, aes.IV);
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, enc, CryptoStreamMode.Write))
                    {
                        var bts = Convert.FromBase64String(text);
                        cs.Write(bts, 0, bts.Length);
                    }
                    return Encoding.UTF8.GetString(ms.ToArray());
                }
            }
        }

        public string AesEncryption(string text, string secretKey)
        {
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                //aes的key和iv有长度要求
                aes.Key = Encoding.UTF8.GetBytes(secretKey);
                aes.IV = Encoding.UTF8.GetBytes(IV);
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                var enc = aes.CreateEncryptor(aes.Key, aes.IV);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, enc, CryptoStreamMode.Write))
                    {
                        var bts = Encoding.UTF8.GetBytes(text);
                        cs.Write(bts, 0, bts.Length);
                    }
                    //用Base64编码存储加密后的字符串；其他编码格式可能因不可显示字符而造成数据丢失
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        public string GetHMacSha512(string text, string secretKey)
        {
            string pwd = string.Empty;

            //实例化一个md5对像
            HMACSHA512 hmacsha512 = new HMACSHA512(Encoding.Default.GetBytes(secretKey));

            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] s = hmacsha512.ComputeHash(Encoding.Default.GetBytes(text));

            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            for (int i = 0; i < s.Length; i++)
            {
                // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
                pwd = pwd + s[i].ToString("x2");
            }

            return pwd;
        }

        public string GetMd516(string text)
        {
            string pwd = string.Empty;

            //使用加密服务提供程序
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            //将指定的字节子数组的每个元素的数值转换为它的等效十六进制字符串表示形式。
            pwd = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(text)), 4, 8);

            pwd = pwd.Replace("-", "");

            return pwd;
        }

        public string GetMd532(string text)
        {
            string pwd = string.Empty;

            //实例化一个md5对像
            MD5 md5 = MD5.Create();

            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] s = md5.ComputeHash(Encoding.Default.GetBytes(text));

            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            for (int i = 0; i < s.Length; i++)
            {
                // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
                pwd = pwd + s[i].ToString("x2");
            }

            return pwd;
        }

        public string GetSha1(string text)
        {
            string pwd = string.Empty;

            //实例化一个SHA1对像
            SHA1 sha1 = SHA1.Create();

            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] s = sha1.ComputeHash(Encoding.Default.GetBytes(text));

            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            for (int i = 0; i < s.Length; i++)
            {
                // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
                pwd = pwd + s[i].ToString("x2");
            }

            return pwd;
        }

        public string GetSha512(string text)
        {
            string pwd = string.Empty;

            //实例化一个SHA512对像
            SHA512 sha1 = SHA512.Create();

            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] s = sha1.ComputeHash(Encoding.Default.GetBytes(text));

            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            for (int i = 0; i < s.Length; i++)
            {
                // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
                pwd = pwd + s[i].ToString("x2");
            }

            return pwd;
        }
    }
}
