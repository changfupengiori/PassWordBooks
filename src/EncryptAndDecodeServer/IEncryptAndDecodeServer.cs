/* * 
 * author:changfupeng
 * createDate:2018-11-19 13:57
 * remark:加密解密服务接口
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncryptAndDecodeServer
{
    public interface IEncryptAndDecodeServer
    {
        /// <summary>
        /// 获取字符串的Md5码32位
        /// </summary>
        /// <param name="text">摘要文本</param>
        /// <returns></returns>
        string GetMd532(string text);
        /// <summary>
        /// 获取字符串的Md5码16位
        /// </summary>
        /// <param name="text">摘要文本</param>
        /// <returns></returns>
        string GetMd516(string text);
        /// <summary>
        /// 获取字符串的Hmac512码
        /// </summary>
        /// <param name="text"></param>
        /// <param name="secretKey"></param>
        /// <returns></returns>
        string GetHMacSha512(string text, string secretKey);
        /// <summary>
        /// 获取字符串的sha1码
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        string GetSha1(string text);
        /// <summary>
        /// 获取字符串的sha512码
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        string GetSha512(string text);
        /// <summary>
        /// 字符串的Aes加密
        /// </summary>
        /// <param name="text"></param>
        /// <param name="secretKey"></param>
        /// <returns></returns>
        string AesEncryption(string text, string secretKey);
        /// <summary>
        /// 字符串的Aes解密
        /// </summary>
        /// <param name="text"></param>
        /// <param name="secretKey"></param>
        /// <returns></returns>
        string AesDecryption(string text, string secretKey);
    }
}
