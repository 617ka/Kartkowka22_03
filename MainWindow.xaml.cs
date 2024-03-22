using System;
using System.Collections.Generic;
using System.IO;
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

namespace Kartkowka3P2203KB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Srednia> srednias { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ComboBox comboBox1 = Czas;
            ComboBox comboBox2 = Dostawca;
            ComboBox comboBox3 = Produkt;


            StreamWriter streamWriter = new StreamWriter("../../../dane.txt", true);
            streamWriter.WriteLine(Nick.Text);
            streamWriter.WriteLine(comboBox1.Text);
            streamWriter.WriteLine(comboBox2.Text);
            streamWriter.WriteLine(comboBox3.Text);

            streamWriter.Close();
        }
    }
}
