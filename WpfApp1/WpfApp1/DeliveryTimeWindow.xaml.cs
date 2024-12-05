using System;
using System.Windows;

namespace WpfApp1
{
    public partial class DeliveryTimeWindow : Window
    {
        public DeliveryTimeWindow(System.Collections.Generic.List<Product> products)
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(DistanceTextBox.Text, out double distance) && double.TryParse(SpeedTextBox.Text, out double speed))
            {
                if (speed > 0)
                {
                    // Рассчитываем время доставки
                    double time = distance / speed;
                    ResultTextBlock.Text = $"Время: {time} часов";
                }
                else
                {
                    MessageBox.Show("какой ноль", "ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите нормальную скорость", "ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
