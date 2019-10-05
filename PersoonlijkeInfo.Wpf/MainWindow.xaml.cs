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

namespace PersoonlijkeInfo.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool rijksregisterOK, familieNaamOK, voornaamOK;

        const string ONDERGEWICHT = "Ondergewicht";
        const string GEZOND_GEWICHT = "Gezond gewicht";
        const string OVERGEWICHT = "Overgewicht";
        const string OBESITAS = "Obesitas";

        const string ONDERGEWICHT_ADVIES = @"Probeer wat aan te komen. Volg hierbij de adviezen bij de voedings- en de bewegings driehoek en/of doe een beroep op professionele hulp. ";
        const string GEZOND_GEWICHT_ADVIES = @"Probeer op gewicht te blijven. Volg hierbij de adviezen bij de voedings- en de bewegings driehoek en/of doe een beroep op professionele hulp.";
        const string OVERGEWICHT_ADVIES = @"Probeer af te vallen (of zorg in elk geval dat je niet verder aankomt). Volg hierbij de adviezen bij de voedings- en de bewegings driehoek en/of doe een beroep op professionele hulp.";
        const string OBESITAS_ADVIES = @"Probeer af te vallen. Doe hiervoor een beroep op professionele hulp.";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            VulBoxen();
            GeefMockData();
        }

        private void btnVatSamen_Click(object sender, RoutedEventArgs e)
        {
            //declaratie variabelen
            string volledigeNaam;
            int lengteInCm;
            int gewichtInKg;
            string rijksRegister;
            string samenVatting;
            float bmi;

            //ophalen info uit de GUI
            volledigeNaam = txtVoornaam.Text + " " + txtFamilienaam.Text;
            gewichtInKg = (int)cmbGewicht.SelectedItem;
            lengteInCm = (int)cmbLengte.SelectedValue;
            rijksRegister = txtRijksregister.Text;

            //Call naar eigen methode(n)
            bmi = BerekenBMI(gewichtInKg, lengteInCm);
            samenVatting = VatInfoSamen(volledigeNaam, lengteInCm, gewichtInKg, rijksRegister, bmi);

            //feedback aan gebruiker
            lblSamenvatting.Content = samenVatting;
        }

        private void TxtFamilienaam_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void TxtRijksregister_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtVoornaam_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        float BerekenBMI(int gewichtInKg, int lengteInCm)
        {
            float bmi;
            float lengteInMeter;
            lengteInMeter = (float)lengteInCm / 100F;
            bmi = gewichtInKg / (lengteInMeter * lengteInMeter);
            return bmi;
        }

        int BerekenControleGetal(string rijksregister)
        {
            int controleGetal;
            string eerste9Cijfers;
            long rijksNummer;
            int restBijDelingDoor97;
            eerste9Cijfers = rijksregister.Substring(0, 9);
            rijksNummer = long.Parse(eerste9Cijfers);
            restBijDelingDoor97 = (int)(rijksNummer % 97);
            controleGetal = 97 - restBijDelingDoor97;

            return controleGetal;
        }

        void GeefGewichtsAdvies()
        {

        }

        void GeefGewichtsAdviesKleur()
        {

        }

        void GeefGewichtsToestand()
        {

        }

        void GeefMockData()
        {
            txtFamilienaam.Text = "Done";
            txtVoornaam.Text = "John";
            txtRijksregister.Text = "65012937728";
            cmbGewicht.SelectedIndex = 2;
            cmbLengte.SelectedItem = 185;
        }

        bool HeeftTekstMinimumLengte(string input, int minLengte)
        {
            bool isLangGenoeg = false;
            int stringLengte;
            stringLengte = input.Length;
            if (stringLengte >= minLengte)
            {
                isLangGenoeg = true;
            }
            return isLangGenoeg;
        }


        void IsFormulierGoedIngevuld()
        {

        }

        void IsRijksRegisterCorrect()
        {

        }

        void MarkeerTextbox(TextBox teMarkeren, bool isInputCorrect)
        {
            if (!isInputCorrect)
            {
                teMarkeren.Background = Brushes.LightPink;
                teMarkeren.BorderThickness = new Thickness(3);
                teMarkeren.BorderBrush = Brushes.Red;
            }
            else
            {
                teMarkeren.Background = Brushes.White;
                teMarkeren.BorderThickness = new Thickness(1);
                teMarkeren.BorderBrush = Brushes.Gray;
            }
        }


        string VatInfoSamen(string volledigeNaam, int lengte, int gewicht, string rijksRegister, float bmi)
        {
            string samenVatting;

            samenVatting = $"Samenvatting\n\n{volledigeNaam}\n" +
                           $"Met een gewicht van {gewicht} en een lengte van {lengte} is je BMI {bmi}\n" +
                           $"Je rijksregisternummer is {rijksRegister.Substring(0, 6)}-{rijksRegister.Substring(6, 3)}" +
                           $"-{rijksRegister.Substring(9, 2)}\n" +
                           $"Het controlegetal van je rijksregisternummer is " +
                           $"{BerekenControleGetal(rijksRegister)}";

            return samenVatting;
        }

        void VulBoxen()
        {
            cmbGewicht.Items.Add(65);
            cmbGewicht.Items.Add(70);
            cmbGewicht.Items.Add(75);
            cmbGewicht.Items.Add(80);
            cmbGewicht.Items.Add(85);

            cmbLengte.Items.Add(150);
            cmbLengte.Items.Add(160);
            cmbLengte.Items.Add(170);
            cmbLengte.Items.Add(180);
            cmbLengte.Items.Add(185);
        }

    }
}
