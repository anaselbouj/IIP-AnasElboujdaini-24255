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

namespace WpfSliderKleur
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Sld1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Kleur veranderd bij 20/40/60 en 90
            lblCijferKleur.Content = Math.Round(Sld1.Value, 0);
            if (Sld1.Value < 20)
            {
                lblCijferKleur.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (Sld1.Value < 40)
            {
                lblCijferKleur.Foreground = new SolidColorBrush(Colors.Green);
            }
            else if (Sld1.Value < 60)
            {
                lblCijferKleur.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            else if (Sld1.Value < 90)
            {
                lblCijferKleur.Foreground = new SolidColorBrush(Colors.DarkOrange);
            }
            else if (Sld1.Value >= 90)
            {
                lblCijferKleur.Foreground = new SolidColorBrush(Colors.DarkRed);
            }
        }
    }
}
