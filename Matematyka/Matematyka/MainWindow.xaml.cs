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
            int aD1 = int.Parse(D1.Text);
            int aD2 = int.Parse(D2.Text);
            int aO1 = int.Parse(O1.Text);
            int aO2 = int.Parse(O2.Text);
            int aM1 = int.Parse(M1.Text);
            int aM2 = int.Parse(M2.Text);
            int aDz1 = int.Parse(Dz1.Text);
            int aDz2 = int.Parse(Dz2.Text);

            D1Wynik.Content = aD1 + aD2;
            O1Wynik.Content = aO1 - aO2;
            M1Wynik.Content = aM1 * aM2;
            Dz1Wynik.Content = aDz1 / aDz2;
        }
    }
    
}
