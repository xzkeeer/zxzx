using System;
using System.Collections.Generic;
using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public List<Product> Products { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Products = new List<Product>();
        }

        private void ViewProducts_Click(object sender, RoutedEventArgs e)
        {
            ProductWindow productWindow = new ProductWindow(Products);  
            productWindow.Show();
            this.Close();  
        }

        private void CalculateDeliveryTime_Click(object sender, RoutedEventArgs e)
        {
            DeliveryTimeWindow deliveryTimeWindow = new DeliveryTimeWindow(Products);
            deliveryTimeWindow.Show();
            this.Close();
        }
    }
}
