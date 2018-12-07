using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PassWordBooks
{
    /// <summary>
    /// 密码本允许记录的类型
    /// </summary>
    public enum PassWordBookType
    {
        http = 0,
        file = 1,
        zip = 2,
        other = 3
    }
}
