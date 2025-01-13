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

namespace WpfComplexiteit
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

        static int AantalKarakters(string woord)
        {
            return woord.Length;
        }

        static int AantalLettergrepen(string woord)
        {
            int aantalLettergrepen = 0;
            bool vorigeIsKlinker = false;

            foreach (char karakter in woord)
            {
                if (IsKlinker(karakter))
                {
                    if (!vorigeIsKlinker)
                    {
                        aantalLettergrepen++;
                    }
                    vorigeIsKlinker = true;
                }
                else
                {
                    vorigeIsKlinker = false;
                }
            }

            return aantalLettergrepen;
        }

        static double Complexiteit(string woord)
        {
            int aantalKarakters = AantalKarakters(woord);
            int aantalLettergrepen = AantalLettergrepen(woord);
            double complexiteit = aantalKarakters / 3.0 + aantalLettergrepen;

            foreach (char karakter in woord)
            {
                if (karakter == 'x' || karakter == 'y' || karakter == 'q')
                {
                    complexiteit++;
                }
            }

            return complexiteit;
        }

        static bool IsKlinker(char karakter)
        {
            char[] klinkers = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };
            foreach (char klinker in klinkers)
            {
                if (karakter == klinker)
                {
                    return true;
                }
            }
            return false;
        }
        private void Btn_analyseer_Click(object sender, RoutedEventArgs e)
        {
            string woord = txtTekst.Text;

            if (string.IsNullOrWhiteSpace(woord))
            {
                txtB_Bewerking.Text = "Voer een woord in.";
                return;
            }

            int aantalKarakters = AantalKarakters(woord);
            int aantalLettergrepen = AantalLettergrepen(woord);
            double complexiteit = Complexiteit(woord);

            string resultaatTekst = $@"Aantal karakters: {aantalKarakters}
Aantal lettergrepen: {aantalLettergrepen}
Complexiteit: {complexiteit:F1}";

            txtB_Bewerking.Text = resultaatTekst;
        }
    }
}

