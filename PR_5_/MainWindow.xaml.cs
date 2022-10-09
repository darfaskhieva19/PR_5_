using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
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
            day.Text = "";
            CBMonths.SelectedIndex = -1;
        }
        private void OrientCheck(object sender, RoutedEventArgs e) //выбран восточный гороскоп
        {
            RBOriental.Visibility = Visibility.Visible;
            SPOriental.Visibility = Visibility.Visible;
            spBtn.Visibility = Visibility.Visible;
            SPOrdinary.Visibility = Visibility.Collapsed;
            RBOriental.IsEnabled = true;
            result.Text = "";
            year.Text = "";
        }

        private void CBMonths_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (CBMonths.SelectedIndex)
            {
                case 0:
                    if (Convert.ToInt32(day.Text) > 31 || Convert.ToInt32(day.Text) < 1)
                    {
                        MessageBox.Show("В январе 31 день. Повторите ввод");
                        day.Text = "";
                    }
                    break;
                case 1:
                    if (Convert.ToInt32(day.Text) > 28 || Convert.ToInt32(day.Text) < 1)
                    {
                        MessageBox.Show("В феврале 28 дней. Повторите ввод");
                        day.Text = "";
                    }
                    break;
                case 2:
                    if (Convert.ToInt32(day.Text) > 31 || Convert.ToInt32(day.Text) < 1)
                    {
                        MessageBox.Show("В марте 31 день. Повторите ввод");
                        day.Text = "";
                    }
                    break;
                case 3:
                    if (Convert.ToInt32(day.Text) > 30 || Convert.ToInt32(day.Text) < 1)
                    {
                        MessageBox.Show("В апреле 30 день. Повторите ввод");
                        day.Text = "";
                    }
                    break;
                case 4:
                    if (Convert.ToInt32(day.Text) > 31 || Convert.ToInt32(day.Text) < 1)
                    {
                        MessageBox.Show("В мае 31 день. Повторите ввод");
                        day.Text = "";
                    }
                    break;
                case 5:
                    if (Convert.ToInt32(day.Text) > 30 || Convert.ToInt32(day.Text) < 1)
                    {
                        MessageBox.Show("В июне 30 день. Повторите ввод");
                        day.Text = "";
                    }
                    break;
                case 6:
                    if (Convert.ToInt32(day.Text) > 31 || Convert.ToInt32(day.Text) < 1)
                    {
                        MessageBox.Show("В июле 31 день. Повторите ввод");
                        day.Text = "";
                    }
                    break;
                case 7:
                    if (Convert.ToInt32(day.Text) > 31 || Convert.ToInt32(day.Text) < 1)
                    {
                        MessageBox.Show("В августе 31 день. Повторите ввод");
                        day.Text = "";
                    }
                    break;
                case 8:
                    if (Convert.ToInt32(day.Text) > 30 || Convert.ToInt32(day.Text) < 1)
                    {
                        MessageBox.Show("В сентябре 30 день. Повторите ввод");
                        day.Text = "";
                    }
                    break;
                case 9:
                    if (Convert.ToInt32(day.Text) > 31 || Convert.ToInt32(day.Text) < 1)
                    {
                        MessageBox.Show("В октябре 31 день. Повторите ввод");
                        day.Text = "";
                    }
                    break;
                case 10:
                    if (Convert.ToInt32(day.Text) > 30 || Convert.ToInt32(day.Text) < 1)
                    {
                        MessageBox.Show("В ноябре 30 день. Повторите ввод");
                        day.Text = "";
                    }
                    break;
                case 11:
                    if (Convert.ToInt32(day.Text) > 31 || Convert.ToInt32(day.Text) < 1)
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
                    if (day.Text != "" && CBMonths.Text != "")
                    {
                        if (((Convert.ToInt32(day.Text) >= 22) && (Convert.ToInt32(day.Text) <= 31) && CBMonths.SelectedIndex == 11) || ((Convert.ToInt32(day.Text) >= 1) && (Convert.ToInt32(day.Text) <= 20) && CBMonths.SelectedIndex == 0))
                        {
                            result.Text = "Ваш знак зодиака - Козерог";
                        }
                        else if (((Convert.ToInt32(day.Text) >= 21) && (Convert.ToInt32(day.Text) <= 31) && CBMonths.SelectedIndex == 0) || ((Convert.ToInt32(day.Text) >= 1) && (Convert.ToInt32(day.Text) <= 18) && CBMonths.SelectedIndex == 1))
                        {
                            result.Text = "Ваш знак зодиака - Водолей";
                        }
                        else if (((Convert.ToInt32(day.Text) >= 19) && (Convert.ToInt32(day.Text) <= 28) && CBMonths.SelectedIndex == 1) || ((Convert.ToInt32(day.Text) >= 1) && (Convert.ToInt32(day.Text) <= 20) && CBMonths.SelectedIndex == 2))
                        {
                            result.Text = "Ваш знак зодиака - Рыбы";
                        }
                        else if (((Convert.ToInt32(day.Text) >= 21) && (Convert.ToInt32(day.Text) <= 31) && CBMonths.SelectedIndex == 2) || ((Convert.ToInt32(day.Text) >= 1) && (Convert.ToInt32(day.Text) <= 19) && CBMonths.SelectedIndex == 3))
                        {
                            result.Text = "Ваш знак зодиака - Овен";
                        }
                        else if (((Convert.ToInt32(day.Text) >= 20) && (Convert.ToInt32(day.Text) <= 31) && CBMonths.SelectedIndex == 3) || (Convert.ToInt32(day.Text) >= 1) && (Convert.ToInt32(day.Text) <= 20) && CBMonths.SelectedIndex == 4)
                        {
                            result.Text = "Ваш знак зодиака - Телец";
                        }
                        else if (((Convert.ToInt32(day.Text) >= 21) && (Convert.ToInt32(day.Text) <= 31) && CBMonths.SelectedIndex == 4) || (Convert.ToInt32(day.Text) >= 1) && (Convert.ToInt32(day.Text) <= 21) && CBMonths.SelectedIndex == 5)
                        {
                            result.Text = "Ваш знак зодиака - Близнецы";
                        }
                        else if (((Convert.ToInt32(day.Text) >= 21) && (Convert.ToInt32(day.Text) <= 30) && CBMonths.SelectedIndex == 5) || ((Convert.ToInt32(day.Text) >= 1) && (Convert.ToInt32(day.Text) <= 22) && CBMonths.SelectedIndex == 6))
                        {
                            result.Text = "Ваш знак зодиака - Рак";
                        }
                        else if (((Convert.ToInt32(day.Text) >= 23) && (Convert.ToInt32(day.Text) <= 31) && CBMonths.SelectedIndex == 6) || ((Convert.ToInt32(day.Text) >= 1) && (Convert.ToInt32(day.Text) <= 22) && CBMonths.SelectedIndex == 7))
                        {
                            result.Text = "Ваш знак зодиака - Лев";
                        }
                        else if (((Convert.ToInt32(day.Text) >= 23) && (Convert.ToInt32(day.Text) <= 31) && CBMonths.SelectedIndex == 7) || ((Convert.ToInt32(day.Text) >= 1) && (Convert.ToInt32(day.Text) <= 22) && CBMonths.SelectedIndex == 8))
                        {
                            result.Text = "Ваш знак зодиака - Дева";
                        }
                        else if (((Convert.ToInt32(day.Text) >= 23) && (Convert.ToInt32(day.Text) <= 30) && CBMonths.SelectedIndex == 8) || ((Convert.ToInt32(day.Text) >= 1) && (Convert.ToInt32(day.Text) <= 23) && CBMonths.SelectedIndex == 9))
                        {
                            result.Text = "Ваш знак зодиака - Весы";
                        }
                        else if (((Convert.ToInt32(day.Text) >= 24) && (Convert.ToInt32(day.Text) <= 30) && CBMonths.SelectedIndex == 9) || ((Convert.ToInt32(day.Text) >= 1) && (Convert.ToInt32(day.Text) <= 22) && CBMonths.SelectedIndex == 10))
                        {
                            result.Text = "Ваш знак зодиака - Скорпион";
                        }
                        else if (((Convert.ToInt32(day.Text) >= 23) && (Convert.ToInt32(day.Text) <= 31) && CBMonths.SelectedIndex == 10) || ((Convert.ToInt32(day.Text) >= 1) && (Convert.ToInt32(day.Text) <= 21) && CBMonths.SelectedIndex == 11))
                        {
                            result.Text = "Ваш знак зодиака - Стрелец";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else if (RBOriental.IsChecked == true)
                {
                    if (year.Text != "")
                    {
                        if (Convert.ToInt32(year.Text) % 12 == 0)
                        {
                            result.Text = "По восточному гороскопу Вы - Обезьяна";
                        }
                        else if (Convert.ToInt32(year.Text) % 12 == 1)
                        {
                            result.Text = "По восточному гороскопу Вы - Петух";
                        }
                        else if (Convert.ToInt32(year.Text) % 12 == 2)
                        {
                            result.Text = "По восточному гороскопу Вы - Собака";
                        }
                        else if (Convert.ToInt32(year.Text) % 12 == 3)
                        {
                            result.Text = "По восточному гороскопу Вы - Свинья";
                        }
                        else if (Convert.ToInt32(year.Text) % 12 == 4)
                        {
                            result.Text = "По восточному гороскопу Вы - Крыса";
                        }
                        else if (Convert.ToInt32(year.Text) % 12 == 5)
                        {
                            result.Text = "По восточному гороскопу Вы - Бык";
                        }
                        else if (Convert.ToInt32(year.Text) % 12 == 6)
                        {
                            result.Text = "По восточному гороскопу Вы - Тигр";
                        }
                        else if (Convert.ToInt32(year.Text) % 12 == 7)
                        {
                            result.Text = "По восточному гороскопу Вы - Кролик";
                        }
                        else if (Convert.ToInt32(year.Text) % 12 == 8)
                        {
                            result.Text = "По восточному гороскопу Вы - Дракон";
                        }
                        else if (Convert.ToInt32(year.Text) % 12 == 9)
                        {
                            result.Text = "По восточному гороскопу Вы - Змея";
                        }
                        else if (Convert.ToInt32(year.Text) % 12 == 10)
                        {
                            result.Text = "По восточному гороскопу Вы - Лошадь";
                        }
                        else if (Convert.ToInt32(year.Text) % 12 == 11)
                        {
                            result.Text = "По восточному гороскопу Вы - Коза";
                        }
                    }
                    else
                    {
                            MessageBox.Show("Заполните поле", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void day_PreviewTextInput(object sender, TextCompositionEventArgs e) //ввод чисел
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void year_PreviewTextInput(object sender, TextCompositionEventArgs e) //ввод чисел
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

    }
}
