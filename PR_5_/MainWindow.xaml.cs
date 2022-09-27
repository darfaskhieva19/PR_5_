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

namespace PR_5_
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
        private void OrdinCheck(object sender, RoutedEventArgs e) //выбран обычный гороскоп
        {
            RBOrdinary.Visibility = Visibility.Visible;
            RBOriental.Visibility = Visibility.Collapsed;
            RBOrdinary.IsEnabled = true;
        }
        private void OrientCheck(object sender, RoutedEventArgs e) //выбран восточный гороскоп
        {
            RBOrdinary.Visibility = Visibility.Collapsed;
            RBOriental.Visibility = Visibility.Visible;
            RBOriental.IsEnabled = true;
        }

        private void months_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (Convert.ToInt32(year.Text))
            {
                case 0:
                    result.Text = "го";
                    break;
            }


        }
    }
}
