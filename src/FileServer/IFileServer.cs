/* * 
 * author:changfupeng
 * createDate:2018-11-20 13:55
 * remark:文件服务接口
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileServer
{
    public interface IFileServer
    {
        /// <summary>
        /// 字符保存到文本
        /// </summary>
        /// <param name="fileString">保存的文本正文</param>
        /// <param name="filePath">保存的文件名（含完整路径）</param>
        /// <param name="passWordCertificate">主账号密钥证书</param>
        void SaveFile(string fileString, string passWordCertificate, string filePath);
        /// <summary>
        /// 检查文件是否被修改
        /// </summary>
        /// <returns>返回数据</returns>
        /// <remarks>如果数据文件被修订或者格式不正确将返回空</remarks>
        string GetFileString(string filePath, string passWordCertificate);
        /// <summary>
        /// 获取配置文件
        /// </summary>
        /// <param name="filePath">配置文件地址</param>
        /// <returns></returns>
        string GetPropertyFile(string filePath);
        /// <summary>
        /// 保存配置文件
        /// </summary>
        /// <param name="propertyStr">配置文件字符串形式</param>
        /// <param name="filePath">文件路径</param>
        void SavePropertyFile(string propertyStr,string filePath);
    }
}