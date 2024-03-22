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
using System.Windows.Shapes;

namespace Kartkowka3P2203KB
{
    /// <summary>
    /// Logika interakcji dla klasy PokazSrednia.xaml
    /// </summary>
    public partial class PokazSrednia : Window
    {
        private List<Srednia> Lista { get; set; }
        public int i;
        public PokazSrednia()
        {
            InitializeComponent();
            Przygotuj();
            i= 0;
            Odczyt();
            

        }
        
        private void Przygotuj()
        {
            Lista = new List<Srednia>();
            StreamReader streamReader = new StreamReader("../../../dane.txt");

            string nick = streamReader.ReadLine();

            int a, b, c;
            while (nick != null)
            {
                float suma;
                a = int.Parse(streamReader.ReadLine());
                b = int.Parse(streamReader.ReadLine());
                c = int.Parse(streamReader.ReadLine());
                suma = (a + b + c) / 3;
                string wartosc = suma.ToString();
                Lista.Add(new Srednia(nick, wartosc));
                nick = streamReader.ReadLine();
                
            }

            streamReader.Close();
        }
        
        private void Odczyt()
        {
            Nick.Text = Lista[i].Nick.ToString();
            Wartosc.Text = Lista[i].Wartosc.ToString();
        }
        
        private void Button_Click_Dalej(object sender, RoutedEventArgs e)
        {
           
            i++;
            if(i > Lista.Count-1) { i=0;}
            
            Odczyt();
        }

        private void Button_Click_Poprzedni(object sender, RoutedEventArgs e)
        {
            i--;
            if(i < 0) { i = Lista.Count - 1; }

            Odczyt();
        }
        
    }
}
