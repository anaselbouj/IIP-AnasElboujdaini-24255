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

namespace WpfCarConfigurator
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

        double basisPrijs = 0;

        private void CmbBmodel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateUI();
        }
        private void ChkBvelgen_Checked(object sender, RoutedEventArgs e)
        {
            UpdateUI();
        }
        private void ChkBmatjes_Checked(object sender, RoutedEventArgs e)
        {
            UpdateUI();
        }
        private void ChkBaudiospeeker_Checked(object sender, RoutedEventArgs e)
        {
            UpdateUI();
        }
        private void ChkBvelgen_Unchecked(object sender, RoutedEventArgs e)
        {
            UpdateUI();
        }
        private void ChkBaudiospeeker_Unchecked(object sender, RoutedEventArgs e)
        {
            UpdateUI();
        }
        private void ChkBmatjes_Unchecked(object sender, RoutedEventArgs e)
        {
            UpdateUI();
        }
        private void RdbtnBlauw_Checked(object sender, RoutedEventArgs e)
        {
            UpdateUI();
        }
        private void RdbtnGroen_Checked(object sender, RoutedEventArgs e)
        {
            UpdateUI();
        }
        private void RdbtnRood_Checked(object sender, RoutedEventArgs e)
        {
            UpdateUI();
        }
        private void UpdateUI()
        {
            imgCar.Source = new BitmapImage(new Uri(BepaalAfbeeldingPad(), UriKind.Relative));
            lblTotalePrijs.Content = BerekenPrijs().ToString() + " euro";
            imgAudio.Opacity = chkBaudiospeeker.IsChecked == true ? 1.0 : 0.3;
            imgVelgen.Opacity = chkBvelgen.IsChecked == true ? 1.0 : 0.3;
            imgMatjes.Opacity = chkBmatjes.IsChecked == true ? 1.0 : 0.3;
        }

        private int BerekenPrijs()
        {
            switch (cmbBmodel.SelectedIndex)
            {
                case 0:
                    basisPrijs = 85000;
                    break;
                case 1:
                    basisPrijs = 72000;
                    break;
                case 2:
                    basisPrijs = 65300;
                    break;
            }

            if (rdbtnBlauw.IsChecked == true)
                basisPrijs += 0;
            else if (rdbtnGroen.IsChecked == true)
                basisPrijs += 250;
            else if (rdbtnRood.IsChecked == true)
                basisPrijs += 700;

            if (chkBvelgen.IsChecked == true)
                basisPrijs += 300;

            if (chkBmatjes.IsChecked == true)
                basisPrijs += 450;

            if (chkBaudiospeeker.IsChecked == true)
                basisPrijs += 1250;

            return Convert.ToInt32(basisPrijs);
        }

        private string BepaalAfbeeldingPad()
        {
            if (cmbBmodel.SelectedItem != null)
            {
                string modelTag = ((ComboBoxItem)cmbBmodel.SelectedItem).Tag.ToString();
                string kleur = "blauw";

                if (rdbtnBlauw.IsChecked == true)
                    kleur = "blauw";
                else if (rdbtnGroen.IsChecked == true)
                    kleur = "groen";
                else if (rdbtnRood.IsChecked == true)
                    kleur = "rood";
                return $"/img/{modelTag}{kleur}.jpg";
            }

            return string.Empty;
        }
    }
}
