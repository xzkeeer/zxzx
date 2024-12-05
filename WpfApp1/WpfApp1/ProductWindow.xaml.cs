using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class ProductWindow : Window
    {
        private List<Product> products;

        // продукты принимаются 
        public ProductWindow(List<Product> products)
        {
            InitializeComponent();
            this.products = products;
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            string productName = ProductNameTextBox.Text;  
            bool isAvailable = StatusComboBox.SelectedItem != null && ((ComboBoxItem)StatusComboBox.SelectedItem).Content.ToString() == "здесь";  // 
            DateTime? deliveryDate = DeliveryDatePicker.SelectedDate;  

            // проверка для данных
            if (string.IsNullOrWhiteSpace(productName) || deliveryDate == null)
            {
                MessageBox.Show("поля заполните", "ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Product newProduct = new Product
            {
                ProductName = productName,
                IsAvailable = isAvailable,
                DeliveryTime = (DateTime)deliveryDate
            };

            products.Add(newProduct);  
            MessageBox.Show("добавленно", "ураааа", MessageBoxButton.OK, MessageBoxImage.Information);

            // чистка полей
            ProductNameTextBox.Clear();
            StatusComboBox.SelectedIndex = -1;
            DeliveryDatePicker.SelectedDate = null;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();  
        }
    }
}
