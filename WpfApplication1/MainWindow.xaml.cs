using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using DataJson;
using Models.house;
using System.IO;
using System.Windows.Controls;
using Models;
using Models.house.ershoufang;
using System.Windows.Input;

namespace WpfApplication1
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static List<Ershoufang> getData(int cityId, int limitOffset, int limitCount)
        {
            string url = string.Format("http://m.api.lianjia.com/house/ershoufang/searchV3?city_id={0}&limit_offset={1}&limit_count={2}", cityId, limitOffset, limitCount);
            string res = HttpHelper.GetResponseString(HttpHelper.CreateGetHttpResponse(url, 1000, "", null));
            var r = JsonHelper.parse<Search>(res);
            return r.data.list;
        }
        private void loadList(object sender, MouseWheelEventArgs e)
        {
            MessageBox.Show("asdf");
        }
        public MainWindow()
        {
            InitializeComponent();

            //string locurl = "D:\\Users\\butterfly.jpg";
            //BackGround.setbackground(locurl);
            this.listBox1.ItemsSource = getData(110000, 10, 10);
            this.listBox1.MouseWheel += new MouseWheelEventHandler(loadList);
            //this.listBox1.Items.Add(getData(110000, 10, 10));
            //DataContext = getData(110000,10,10);
            //this.listView.ItemsSource = getData();
            //imageCovPic.Source = new BitmapImage(new Uri("https://image1.ljcdn.com/appro/group2/M00/F7/9C/rBAF7FbeRE6AP7M5AAGGbronOF8674.jpg.280x210.jpg"));
        }
    }
}
