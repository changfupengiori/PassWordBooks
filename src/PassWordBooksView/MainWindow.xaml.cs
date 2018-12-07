using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PassWordBooksView
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        //private log4net.ILog _log = log4net.LogManager.GetLogger("PassWordBooks");
        public MainWindow()
        {
            InitializeComponent();
            string str = "{'张志超':'你妈妈','data':[{},{}]}", key = "04551df76713561574a6183f050503bd", re = string.Empty, re1 = string.Empty;

            EncryptAndDecodeServer.IEncryptAndDecodeServer i = new EncryptAndDecodeServer.EncryptAndDecodeServer();
            re = i.AesEncryption(str, key);
            re1 = i.AesDecryption(re, key);
        }
    }
}
