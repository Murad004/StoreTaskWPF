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

namespace StoreHomeTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Product> Products { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Products = new List<Product>
            {
                new Product
                {
                    Name="Chips", Description="ChipsFerma", Price=1.70,ImagePath="Image/chips.png"
                },
                new Product
                {
                    Name="Coca Cola", Description="CocaColaFerma", Price=0.7,ImagePath="Image/cola.png"
                },
                new Product
                {
                    Name="Potato", Description="PotatoFerma", Price=0.8,ImagePath="Image/potato.png"
                },
                new Product
                {
                    Name="Head&Shoulders", Description="HeadFerma", Price=2.30,ImagePath="Image/shampun.png"
                }
            };
        }

        
    }
}
