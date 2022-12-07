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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {

            //Tehdään if scripti jossa lisätään sen elokuvan genre joka valitse käyttäjä  //

            if (cbKauhu.IsChecked == true)
            {
                tbOstokset.Text = tbOstokset.Text + tbTuote.Text + " (Kauhu)  ";
            }
            if (cbKomedia.IsChecked == true)
            {
                tbOstokset.Text = tbOstokset.Text + tbTuote.Text + " (Komedia)  ";
            }
            if (cbSciFi.IsChecked == true)
            {
                tbOstokset.Text = tbOstokset.Text + tbTuote.Text + " (Sci-Fi)  ";
            }
            if (cbDoc.IsChecked == true)
            {
                tbOstokset.Text = tbOstokset.Text + tbTuote.Text + " (Rikoselokuva)  ";
            }



        }
        //Scriptissä siirretän käyttäjän antama tiedot toisen tiedostoon käyttäen Stream
        private void BtnTotext_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                using (StreamWriter file = new StreamWriter(System.IO.Path.Combine(docPath, "Valitutelokuvat.txt")))
                {
                    file.WriteLine(tbOstokset.Text);
                }
                tbSuccess.Text = "Ostokset on maksettu, kiitos käynnistä ja tervetuloa uudelleen.";
            }

            catch
            {
                tbTuote.Text = "Virhe, kirjoita tiedot oikein";
                tbOstokset.Text = string.Empty;



            }




        }
        //Tässä kohtaan luetellaan eri elokuva genret. //
        private void cbKauhu_Checked(object sender, RoutedEventArgs e)
        {

        }



        private void cbKomedia_Checked(object sender, RoutedEventArgs e)
        {

        }



        private void cbSciFi_Checked(object sender, RoutedEventArgs e)
        {

        }



        private void cbDoc_Checked(object sender, RoutedEventArgs e)
        {

        }



        private void Off_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void tbOstokset_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


    }
}
