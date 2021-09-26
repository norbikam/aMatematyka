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
using System.Text.RegularExpressions;

namespace Matematyka
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {



            if (D1.Text.Length > 0 && D2.Text.Length > 0)
            {
                int aD1 = int.Parse(D1.Text);
                int aD2 = int.Parse(D2.Text);
                D1Wynik.Content = aD1 + aD2;
            }
            else if (D1.Text.Length > 0 && D2.Text.Length < 1)
            {
                D1Wynik.Content = "---";
            }
            else if (D2.Text.Length > 0 && D1.Text.Length < 1)
            {
                D1Wynik.Content = "---";
            }
            else if (D1.Text.Length < 1 && D2.Text.Length < 1)
            {
                D1Wynik.Content = "---";
            }





            if (O1.Text.Length > 0 && O2.Text.Length > 0)
            {
                int aO1 = int.Parse(O1.Text);
                int aO2 = int.Parse(O2.Text);
                O1Wynik.Content = aO1 - aO2;
            }
            else if (O1.Text.Length > 0 && O2.Text.Length < 1)
            {
                O1Wynik.Content = "---";
            }
            else if (O2.Text.Length > 0 && O1.Text.Length < 1)
            {
                O1Wynik.Content = "---";
            }
            else if (O1.Text.Length < 1 && O2.Text.Length < 1)
            {
                O1Wynik.Content = "---";
            }







            if (M1.Text.Length > 0 && M2.Text.Length > 0)
            {
                int aM1 = int.Parse(M1.Text);
                int aM2 = int.Parse(M2.Text);
                M1Wynik.Content = aM1 * aM2;
            }
            else if (M1.Text.Length > 0 && M2.Text.Length < 1)
            {
                M1Wynik.Content = "---";
            }
            else if (M2.Text.Length > 0 && M1.Text.Length < 1)
            {
                M1Wynik.Content = "---";
            }
            else if (M1.Text.Length < 1 && M2.Text.Length < 1)
            {
                M1Wynik.Content = "---";
            }






            if (Dz1.Text.Length > 0 && Dz2.Text.Length > 0)
            {
                int aDz1 = int.Parse(Dz1.Text);
                int aDz2 = int.Parse(Dz2.Text);
                Dz1Wynik.Content = aDz1 / aDz2;
            }
            else if (Dz1.Text.Length > 0 && Dz2.Text.Length < 1)
            {
                Dz1Wynik.Content = "---";
            }
            else if (Dz2.Text.Length > 0 && Dz1.Text.Length < 1)
            {
                Dz1Wynik.Content = "---";
            }
            else if (Dz1.Text.Length < 1 && Dz2.Text.Length < 1)
            {
                Dz1Wynik.Content = "---";
            }



        }
    }
    
}
