using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using _04_WPF_Cashier_Project.Models;

namespace _04_WPF_Cashier_Project.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    public ObservableCollection<ProductModel> Products { get; set; }

    // Implement INotifyPropertyChanged interface here

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public MainViewModel()
    {
        // Initialize Products with 4 sample products (milk, sugar, toffee, rice)
        Products = new ObservableCollection<ProductModel>
            {
                new ProductModel { Name = "Milk", Price = 2.50m, StockCount = 10 },
                new ProductModel { Name = "Sugar", Price = 1.75m, StockCount = 15 },
                new ProductModel { Name = "Toffee", Price = 0.50m, StockCount = 20 },
                new ProductModel { Name = "Rice", Price = 3.00m, StockCount = 12 }
            };
    }

    // Add your ViewModel logic here
}
}
