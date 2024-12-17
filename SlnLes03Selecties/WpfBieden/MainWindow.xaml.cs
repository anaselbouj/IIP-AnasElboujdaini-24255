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

namespace WpfBieden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double hoogstebod = 0;
        string hoogsteBieder;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnPlaatsBod_Click(object sender, RoutedEventArgs e)
        {
            double bod = Convert.ToDouble(txtbod.Text);

            if (bod > hoogstebod)
            {
                hoogstebod = bod;
                hoogsteBieder = txtnaam.Text;
                txtBantwoord.Text = $"{txtnaam.Text} heeft met {hoogstebod} euro het hoogste bod!";
            }
            else
            {
                txtBantwoord.Text = $"sorry, {hoogsteBieder} heeft momenteel het hoogste bod";
            }

            txtnaam.Text = "";
            txtbod.Text = "";
        }
    }
}
