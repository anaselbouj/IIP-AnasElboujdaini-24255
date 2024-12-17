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

namespace WpfFormChecking
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

        int aantalfouten = 0;
        private void BtnSend_Click(object sender, RoutedEventArgs e)
        {
            aantalfouten = 0;

            if (txtNaam.Text == "")
            {
                lblMessageName.Content = "naam moet ingevuld zijn ";

                aantalfouten++;
            }
            else if (txtNaam.Text != "")
            {
                lblMessageName.Content = "";
            }

            if (txtEmail.Text == "")
            {
                lblMessageEmail.Content = "email moet ingevuld zijn";

                aantalfouten++;
            }
            else if (txtEmail.Text != "")
            {
                lblMessageEmail.Content = "";
            }

            if (datGeboorte.Text == "")
            {
                lblMessageGeboorte.Content = "datum moet ingevuld zijn";
                aantalfouten++;
            }
            else if (datGeboorte.Text != "")
            {
                lblMessageGeboorte.Content = "";
            }

            if (lstProfiel.Text == "selecteer...")
            {
                lblMessageProfiel.Content = "maak een keuze";
                aantalfouten++;
            }
            else if (lstProfiel.Text != "selecteer...")
            {
                lblMessageProfiel.Content = "";
            }

            if (pwdPaswoord.Password == "")
            {
                lblMessagePaswoord.Content = "kies een passwoord";
                aantalfouten++;
            }
            else if (pwdPaswoord.Password != "")
            {
                lblMessagePaswoord.Content = "";
            }

            if (rbnMan.IsChecked == false && rbnVrouw.IsChecked == false)
            {
                lblMessageGeslacht.Content = "kies een geslacht";
                aantalfouten++;
            }
            else
            {
                lblMessageGeslacht.Content = "";
            }

            if (chbBusiness.IsChecked == false && chbNetwerken.IsChecked == false && chbProgrammeren.IsChecked == false)
            {
                lblMessageInteresses.Content = "kies minstent één interesse";
                aantalfouten++;
            }
            else
            {
                lblMessageInteresses.Content = "";
            }

            lblNumFouten.Content = $"dit formulier bevat {aantalfouten} fouten";
            if (aantalfouten == 0)
            {
                txtNaam.Text = "";
                txtEmail.Text = "";
                lblMessageName.Content = "";
                lblMessageEmail.Content = "";
                datGeboorte.Text = "";
                lblMessageGeboorte.Content = "";
                lstProfiel.Text = "";
                lblMessageProfiel.Content = "";
                pwdPaswoord.Password = "";
                lblMessagePaswoord.Content = "";
                rbnMan.IsChecked = false;
                rbnVrouw.IsChecked = false;
                lblMessageGeslacht.Content = "";
                chbBusiness.IsChecked = false;
                chbNetwerken.IsChecked = false;
                chbProgrammeren.IsChecked = false;
                lblMessageInteresses.Content = "";
                lblNumFouten.Content = "";
                MessageBox.Show("bedankt voor de registratie");
            }
        }
        
        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            lstProfiel.Text = "selecteer...";
            aantalfouten = 0;
            txtNaam.Text = "";
            txtEmail.Text = "";
            lblMessageName.Content = "";
            lblMessageEmail.Content = "";
            datGeboorte.Text = "";
            lblMessageGeboorte.Content = "";
            lblMessageProfiel.Content = "";
            pwdPaswoord.Password = "";
            lblMessagePaswoord.Content = "";
            rbnMan.IsChecked = false;
            rbnVrouw.IsChecked = false;
            lblMessageGeslacht.Content = "";
            chbBusiness.IsChecked = false;
            chbNetwerken.IsChecked = false;
            chbProgrammeren.IsChecked = false;
            lblMessageInteresses.Content = "";
            lblNumFouten.Content = "";
        }
    }
}
