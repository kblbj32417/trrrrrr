using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(@"D:\CAD\Pictures");
            FileInfo[] files =  dirinfo.GetFiles();
            foreach(FileInfo fi in files)
            {
                if (fi.FullName.EndsWith(".jpg"))
                {
                Image img = new Image();
                
                BitmapSource src = new BitmapImage(new Uri(fi.FullName));
                img.Source = src;
                    img.Width =100;
                    img.Margin = new Thickness(10);
                this.wrapPanell.Children.Add(img);
            }
        }
    }
}
}