using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Product_WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProdName = "Сыр",
                ProdPrice = 820,
                ProdImage = "Data/cheese2.png",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Мороженое",
                ProdPrice = 80,
                ProdImage = "Data/ice-pop2.png",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Плита",
                ProdPrice = 18200,
                ProdImage = "Data/cooker2.png",
                ProductCategory = ProductCategorys.Appliances
            });
            listBox.ItemsSource = products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product()
            {
                ProdName = "Утюг",
                ProdPrice = 6200,
                ProdImage = "Data/iron.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
        }
    }
}
