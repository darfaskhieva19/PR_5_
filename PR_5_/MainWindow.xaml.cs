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
            SPOrdinary.Visibility = Visibility.Visible;
            spBtn.Visibility = Visibility.Visible;
            SPOriental.Visibility = Visibility.Collapsed;
            RBOrdinary.IsEnabled = true;
            result.Text = "";
        }
        private void OrientCheck(object sender, RoutedEventArgs e) //выбран восточный гороскоп
        {
            RBOriental.Visibility = Visibility.Visible;
            SPOriental.Visibility = Visibility.Visible;
            spBtn.Visibility = Visibility.Visible;
            SPOrdinary.Visibility = Visibility.Collapsed;
            RBOriental.IsEnabled = true;
            result.Text = "";
        }

        private void CBMonths_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (CBMonths.SelectedIndex)
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
            try
            {
                if (RBOrdinary.IsChecked == true)
                {
                    switch (CBMonths.SelectedIndex)
                    {
                        case 0:
                            if (((Convert.ToInt32(day.Text) >= 21) && (Convert.ToInt32(day.Text) <= 31) && CBMonths.SelectedIndex == 2) || ((Convert.ToInt32(day.Text)>=1)&&(Convert.ToInt32(day.Text)<=20)&&CBMonths.SelectedIndex==3))
                            {
                                result.Text = "Ваш знак зодиака Овен";

                            }
                            break;
                    }
                }
                else if(RBOriental.IsChecked == true)
                {
                    if (Convert.ToInt32(year.Text) % 12 == 0)
                    {
                        result.Text = "По восточному гороскопу Вы - обезьяна";
                    }
                    else if(Convert.ToInt32(year.Text) % 12 == 1)
                    {
                        result.Text = "По восточному гороскопу Вы - петух";
                    }
                    else if (Convert.ToInt32(year.Text) % 12 == 2)
                    {
                        result.Text = "По восточному гороскопу Вы - собака";
                    }
                    else if (Convert.ToInt32(year.Text) % 12 == 3)
                    {
                        result.Text = "По восточному гороскопу Вы - свинья";
                    }
                    else if (Convert.ToInt32(year.Text) % 12 == 4)
                    {
                        result.Text = "По восточному гороскопу Вы - крыса";
                    }
                    else if (Convert.ToInt32(year.Text) % 12 == 5)
                    {
                        result.Text = "По восточному гороскопу Вы - бык";
                    }
                    else if (Convert.ToInt32(year.Text) % 12 == 6)
                    {
                        result.Text = "По восточному гороскопу Вы - тигр";
                    }
                    else if (Convert.ToInt32(year.Text) % 12 == 7)
                    {
                        result.Text = "По восточному гороскопу Вы - кролик";
                    }
                    else if (Convert.ToInt32(year.Text) % 12 == 8)
                    {
                        result.Text = "По восточному гороскопу Вы - дракон";
                    }
                    else if (Convert.ToInt32(year.Text) % 12 == 9)
                    {
                        result.Text = "По восточному гороскопу Вы - змея";
                    }
                    else if (Convert.ToInt32(year.Text) % 12 == 10)
                    {
                        result.Text = "По восточному гороскопу Вы - лошадь";
                    }
                    else if (Convert.ToInt32(year.Text) % 12 == 11)
                    {
                        result.Text = "По восточному гороскопу Вы - коза";
                    }
                    else
                    {
                        MessageBox.Show("Что-то не так");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так.Ошибка");
            }
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
