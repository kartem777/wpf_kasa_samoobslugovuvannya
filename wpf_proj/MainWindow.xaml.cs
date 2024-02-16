using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_proj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<products> product = new List<products>();
        int totalPrice = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             Button a = (Button)sender;
             Random rnd = new Random();
             products c = new products(a.Content.ToString(), rnd.Next(1,15));
             product.Add(c);
             totalPrice += c.price;
             tprice.Text = "Total price: " + totalPrice.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int a = product.Last().price; 
            totalPrice -= a;
            tprice.Text = "Total price: " + totalPrice.ToString();
            product.RemoveAt(product.Count - 1);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string a = "";
            foreach(products p in product)
            {
                a += p.name + " " + p.price.ToString() + "\n";
            }
            MessageBox.Show(a);
        }
    }
}