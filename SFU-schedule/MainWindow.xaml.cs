using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace SFU_schedule
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
        //Кнопки деканата и курсов
        private void Dec_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://dec.sfu-kras.ru/cabinet/login.zul");
            //MessageBox.Show("Первая кнопка");
        }

        private void Ecourse_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://e.sfu-kras.ru/");
        }
        //Кнопки Екурсов
        //private void Course1(object sender, RoutedEventArgs e)
        //{
        //    Process.Start("https://e.sfu-kras.ru/course/view.php?id=11924");
        //}

        private void Ecourse1(object sender, RoutedEventArgs e)
        {
            Process.Start("https://e.sfu-kras.ru/course/view.php?id=11924");
        }

        private void Ecourse2(object sender, RoutedEventArgs e)
        {
            //Process.Start("");
            MessageBox.Show("?");
        }
        private void Ecourse3(object sender, RoutedEventArgs e)
        {
            Process.Start("https://e.sfu-kras.ru/course/view.php?id=22264");
        }

        private void Ecourse4(object sender, RoutedEventArgs e)
        {
            Process.Start("https://e.sfu-kras.ru/course/view.php?id=9535");
        }

        private void Ecourse5(object sender, RoutedEventArgs e)
        {
            Process.Start("https://e.sfu-kras.ru/course/view.php?id=12000");
        }

        private void Ecourse6(object sender, RoutedEventArgs e)
        {
            Process.Start("https://e.sfu-kras.ru/course/view.php?id=1120");
        }

        private void Ecourse7(object sender, RoutedEventArgs e)
        {
            //Process.Start("");
            MessageBox.Show("?");
        }

        private void Ecourse8(object sender, RoutedEventArgs e)
        {
            Process.Start("https://e.sfu-kras.ru/course/view.php?id=7821");
        }

        private void Ecourse9(object sender, RoutedEventArgs e)
        {
            Process.Start("https://e.sfu-kras.ru/course/view.php?id=12968");
        }

        //Кнопки занятий
        private void Lesson1(object sender, RoutedEventArgs e)
        {
            Process.Start("https://meet.sfu-kras.ru/b/xdy-z3h-swu");
        }

        private void Lesson2(object sender, RoutedEventArgs e)
        {
            //Process.Start("");
            MessageBox.Show("?");
        }

        private void Lesson3(object sender, RoutedEventArgs e)
        {
            Process.Start("https://us04web.zoom.us/j/2204399467?pwd=bFErdmJlUTA3bzRtTXN5U0hPa29YUT09");
        }

        private void Lesson4(object sender, RoutedEventArgs e)
        {
            Process.Start("https://us04web.zoom.us/j/3020074898?pwd=ZnoyTnR6WFFZTGFUM21DeWtRdGxpQT09");
        }

        private void Lesson5(object sender, RoutedEventArgs e)
        {
            Process.Start("https://us04web.zoom.us/j/74318097822?pwd=dG02c0w3OU9uK3BySDhOYU5NNURYQT09");
        }

        private void Lesson6(object sender, RoutedEventArgs e)
        {
            Process.Start("https://us02web.zoom.us/j/6695999385?pwd=Rk1BL2d2dUt0bC82WWxOUHpMYjQwZz09");
        }

        private void Lesson7(object sender, RoutedEventArgs e)
        {
            //Process.Start("");
            MessageBox.Show("?");
        }

        private void Lesson8(object sender, RoutedEventArgs e)
        {
            Process.Start("https://meet.google.com/baa-imba-eky");
        }

        private void Lesson9(object sender, RoutedEventArgs e)
        {
            Process.Start("https://meet.sfu-kras.ru/b/xdy-z3h-swu");
        }
    }
}
