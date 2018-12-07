/* * 
 * author:changfupeng
 * createDate:2018-11-20 15:00
 * remark:物理密钥服务接口
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicsServer
{
    public interface IPhysics
    {
        /// <summary>
        /// 保存物理密钥
        /// </summary>
        /// <param name="fileDir">存储文件夹</param>
        /// <param name="passWordSecurity">主账号密码密钥</param>
        /// <param name="secondPassWord">副密码</param>
        /// <param name="target">快速识别标识</param>
        void SavePhysicsKey(string fileDir, string passWordSecurity, string secondPassWord, string target);
        /// <summary>
        /// 获取物理密钥
        /// </summary>
        /// <param name="filePath">存储位置</param>
        /// <param name="passWordCertificate">主账号密码密钥</param>
        /// <returns>副密码</returns>
        string GetPhysicsKey(string filePath, string passWordSecurity);
    }
}
