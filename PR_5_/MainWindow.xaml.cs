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
            day.Text = "";
            months.SelectedIndex = -1;
        }
        private void OrientCheck(object sender, RoutedEventArgs e) //выбран восточный гороскоп
        {
            RBOrdinary.Visibility = Visibility.Collapsed;
            RBOriental.Visibility = Visibility.Visible;
            RBOriental.IsEnabled = true;
            year.Text = "";
        }

        private void months_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (months.SelectedIndex)
            {
                case 0:
                    if (int.Parse(day.Text) > 31 || int.Parse(day.Text) < 1)
                    {
                        MessageBox.Show("В январе 31 день. Повторите ввод");
                        day.Text = "";
                    }
                    break;
                case 1:
                    if (int.Parse(day.Text) > 28 || int.Parse(day.Text) < 1)
                    {
                        MessageBox.Show("В феврале 28 дней. Повторите ввод");
                        day.Text = "";
                    }
                    break;
                case 2:
                    if (int.Parse(day.Text) > 31 || int.Parse(day.Text) < 1)
                    {
                        MessageBox.Show("В марте 31 день. Повторите ввод");
                        day.Text = "";
                    }
                    break;
                case 3:
                    if (int.Parse(day.Text) > 30 || int.Parse(day.Text) < 1)
                    {
                        MessageBox.Show("В апреле 30 день. Повторите ввод");
                        day.Text = "";
                    }
                    break;
                case 4:
                    if (int.Parse(day.Text) > 31 || int.Parse(day.Text) < 1)
                    {
                        MessageBox.Show("В мае 31 день. Повторите ввод");
                        day.Text = "";
                    }
                    break;
                case 5:
                    if (int.Parse(day.Text) > 30 || int.Parse(day.Text) < 1)
                    {
                        MessageBox.Show("В июне 30 день. Повторите ввод");
                        day.Text = "";
                    }
                    break;
                case 6:
                    if (int.Parse(day.Text) > 31 || int.Parse(day.Text) < 1)
                    {
                        MessageBox.Show("В июле 31 день. Повторите ввод");
                        day.Text = "";
                    }
                    break;
                case 7:
                    if (int.Parse(day.Text) > 31 || int.Parse(day.Text) < 1)
                    {
                        MessageBox.Show("В августе 31 день. Повторите ввод");
                        day.Text = "";
                    }
                    break;
                case 8:
                    if (int.Parse(day.Text) > 30 || int.Parse(day.Text) < 1)
                    {
                        MessageBox.Show("В сентябре 30 день. Повторите ввод");
                        day.Text = "";
                    }
                    break;
                case 9:
                    if (int.Parse(day.Text) > 31 || int.Parse(day.Text) < 1)
                    {
                        MessageBox.Show("В октябре 31 день. Повторите ввод");
                        day.Text = "";
                    }
                    break;
                case 10:
                    if (int.Parse(day.Text) > 30 || int.Parse(day.Text) < 1)
                    {
                        MessageBox.Show("В ноябре 30 день. Повторите ввод");
                        day.Text = "";
                    }
                    break;
                case 11:
                    if (int.Parse(day.Text) > 31 || int.Parse(day.Text) < 1)
                    {
                        MessageBox.Show("В декабре 31 день. Повторите ввод");
                        day.Text = "";
                    }
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //if (day.Text != "" && months.Text != "")
            //{

            //}
        }

        private void day_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void year_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}
