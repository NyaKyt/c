using System;
using System.Collections.Generic;
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
using System.IO;
namespace folders
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string path = @"C:\folderss";
            string subpath = "";

            for (int i = 0; i < 21; i++)
            {
                string iter = i.ToString();
                string subiter = (i + 1).ToString();
                if (i < 10)
                {
                    iter = "0" + i;

                }
                if (i < 9)
                {
                    subiter = "0" + (i + 1);
                }

                subpath = @" Folder_" + subiter;



                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }
                dirInfo.CreateSubdirectory(subpath); //max 248 characters in path
                //dirInfo.Delete();
                path += @"\" + subpath;
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string path = @"C:\folders";
            string subpath = "";
            for (int i = 0; i < 100; i++)
            {
                
                
                    subpath = "Folder_" + i.ToString(); //The fully qualified file name must be less than 260 characters

                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }
                dirInfo.CreateSubdirectory(subpath);
                subpath = i.ToString();
            }
        }
    }
}