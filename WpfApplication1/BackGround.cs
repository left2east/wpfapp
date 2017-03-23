using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WpfApplication1
{
    class BackGround
    {
        
        /// <summary>   
        /// 返回指定目录下所有文件信息   
        /// </summary>   
        /// <param name="strDirectory">目录字符串</param>   
        /// <returns></returns>   
        public List<FileInfo> GetAllFilesInDirectory(string strDirectory)
        {
            List<FileInfo> listFiles = new List<FileInfo>(); //保存所有的文件信息   
            DirectoryInfo directory = new DirectoryInfo(strDirectory);
            DirectoryInfo[] directoryArray = directory.GetDirectories();
            FileInfo[] fileInfoArray = directory.GetFiles();
            if (fileInfoArray.Length > 0)
            {
                //string extension = System.IO.Path.GetExtension(fileInfoArray.ToString());
                //if (extension == ".jpg")
                //{
                listFiles.AddRange(fileInfoArray);
                //}
            }
            foreach (DirectoryInfo _directoryInfo in directoryArray)
            {
                DirectoryInfo directoryA = new DirectoryInfo(_directoryInfo.FullName);
                DirectoryInfo[] directoryArrayA = directoryA.GetDirectories();
                FileInfo[] fileInfoArrayA = directoryA.GetFiles();
                if (fileInfoArrayA.Length > 0)
                {
                    listFiles.AddRange(fileInfoArrayA);
                }
                GetAllFilesInDirectory(_directoryInfo.FullName);//递归遍历   
            }
            return listFiles;
        }

        /// <summary>
        /// 设置电脑背景图片
        /// </summary>
        /// <param name="strSavePath"></param>
        public static void setbackground(string strSavePath)
        {
            //设置墙纸显示方式
            //RegistryKey myRegKey = Registry.CurrentUser.OpenSubKey(@"Control Panel",true).OpenSubKey("Desktop", true);
    
            //myRegKey.SetValue("TileWallpaper", "0");//0 居中 1  平铺 默认
            //myRegKey.SetValue("WallpaperStyle", "0");//2 拉伸
            //this.label1.Text = "当前模式:居中";
            //this.label2.Text = "更改配置文件config.xml可在下次启动时改变模式";
            //关闭该项,并将改动保存到磁盘
            //myRegKey.Close();
            //设置墙纸
            //string strPathBmp = Directory.GetCurrentDirectory() + "im1.jpg";
            //strPathBmp = "D:\\Users\\a.jpg";
            //System.Drawing.Bitmap bm = new System.Drawing.Bitmap(strPathBmp);
            //bm.Save(strSavePath, System.Drawing.Imaging.ImageFormat.Bmp);//把jpg转成bmp 
            SystemParametersInfo(20, 1, strSavePath, 1);//SPI_SETDESKWALLPAPER
        }
        /// <summary>
        /// 调用电脑底层的接口
        /// </summary>
        /// <param name="uAction"></param>
        /// <param name="uParam"></param>
        /// <param name="lpvParam">图片的路径</param>
        /// <param name="fuWinIni"></param>
        /// <returns></returns>
        /// uAction Long，指定要设置的参数。参考uAction常数表 
        ///uParam Long，参考uAction常数表 
        ///
        ///lpvParam Any，按引用调用的Integer、Long和数据结构。 
        ///
        ///fuWinIni 这个参数规定了在设置系统参数的时候，是否应更新用户设置参数 
        ///
        ///下面是部分uAction参数，和使用它们的方法： 
        ///
        ///参数    意义和使用方法   
        ///
        ///6    设置视窗的大小，SystemParametersInfo(6, 放大缩小值, P, 0)，lpvParam为long型 
        ///
        ///17    开关屏保程序，SystemParametersInfo(17, False, P, 1)，uParam为布尔型 
        ///
        ///13，24    改变桌面图标水平和垂直间距，uParam为间距值(像素)，lpvParam为long型 
        ///
        ///15    设置屏保等待时间，SystemParametersInfo(15, 秒数, P, 1)，lpvParam为long型 
        ///
        ///20    设置桌面背景墙纸，SystemParametersInfo(20, True, 图片路径, 1) 
        ///
        ///93    开关鼠标轨迹，SystemParametersInfo(93, 数值, P, 1)，uParam为False则关闭 
        ///
        ///97    开关Ctrl+Alt+Del窗口，SystemParametersInfo(97, False, A, 0)，uParam为布尔型 
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfoA")]
        static extern Int32 SystemParametersInfo(Int32 uAction, Int32 uParam, string lpvParam, Int32 fuWinIni);//////lpvParam要设置成string

    }
}
