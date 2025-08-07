using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Koe3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Luodaan globaalit muuttujat
        double pitsojenKokonaisHinta;
        double lisataytteetKokonaisHinta;
        double juomienKokonaisHinta;

        // Pitsat
        double pepperoni = 10.00;
        double havaiji = 10.00;
        double capricciosa = 10.00;
        double margherita = 10.00;
        double kebab = 10.00;
        double mexicana = 10.00;
        double salaatti = 10.00;
        double americano = 10.00;
        double fantasia = 10.00;
        double chicken = 10.00;

        // Heti kun form avataan
        private void Form1_Load(object sender, EventArgs e)
        {
            // Piilotetaan labelit
            lblPizza1Uusi.Hide();
            lblPizza2Uusi.Hide();
            lblPizza3Uusi.Hide();
            lblPizza4Uusi.Hide();
            lblPizza5Uusi.Hide();
            lblPizza6Uusi.Hide();
            lblPizza7Uusi.Hide();
            lblPizza8Uusi.Hide();
            lblPizza9Uusi.Hide();
            lblPizza10Uusi.Hide();

            // Piilotetaan numericUpDownit
            numUpDownPizza1Uusi.Hide();
            numUpDownPizza2Uusi.Hide();
            numUpDownPizza3Uusi.Hide();
            numUpDownPizza4Uusi.Hide();
            numUpDownPizza5Uusi.Hide();
            numUpDownPizza6Uusi.Hide();
            numUpDownPizza7Uusi.Hide();
            numUpDownPizza8Uusi.Hide();
            numUpDownPizza9Uusi.Hide();
            numUpDownPizza10Uusi.Hide();
        }

        private void btnLaske_Click(object sender, EventArgs e)
        {
            // Alustetaan muitten tuotteiden muuttujat

            // Lisätäytteet
            double lisatayte1 = 1.50;
            double lisatayte2 = 1.50;
            double lisatayte3 = 1.50;
            double lisatayte4 = 1.50;
            double lisatayte5 = 1.50;
            double lisatayte6 = 1.50;
            double lisatayte7 = 1.50;
            double lisatayte8 = 1.50;
            double lisatayte9 = 1.50;
            double lisatayte10 = 1.50;

            // Juomat
            double juoma1 = 3.00;
            double juoma2 = 5.00;


            // Pitsat


            // Lasketaan pepperonin hinta (10.00 euroa * pitsojen määrä)
            double pepperoniHinta = pepperoni * (double)numUpDownPizza1.Value;

            // Lasketaan havaijin hinta (10.00 euroa * pitsojen määrä)
            double havaijiHinta = havaiji * (double)numUpDownPizza2.Value;

            // Lasketaan capricciosan hinta (10.00 euroa * pitsojen määrä)
            double capricciosaHinta = capricciosa * (double)numUpDownPizza3.Value;

            // Lasketaan margheritan hinta (10.00 euroa * pitsojen määrä)
            double margheritaHinta = margherita * (double)numUpDownPizza4.Value;

            // Lasketaan kebabin hinta (10.00 euroa * pitsojen määrä)
            double kebabHinta = kebab * (double)numUpDownPizza5.Value;

            // Lasketaan mexicanan hinta (10.00 euroa * pitsojen määrä)
            double mexicanaHinta = mexicana * (double)numUpDownPizza6.Value;

            // Lasketaan salaatin hinta (10.00 euroa * pitsojen määrä)
            double salaattiHinta = salaatti * (double)numUpDownPizza7.Value;

            // Lasketaan americanon hinta (10.00 euroa * pitsojen määrä)
            double americanoHinta = americano * (double)numUpDownPizza8.Value;

            // Lasketaan fantasian hinta (10.00 euroa * pitsojen määrä)
            double fantasiaHinta = fantasia * (double)numUpDownPizza9.Value;

            // Lasketaan chickenin hinta (10.00 euroa * pitsojen määrä)
            double chickenHinta = chicken * (double)numUpDownPizza10.Value;

            // Lasketaan pitsojen kokonaishinta
            pitsojenKokonaisHinta = pepperoniHinta + havaijiHinta + capricciosaHinta + margheritaHinta + kebabHinta
                                         + mexicanaHinta + salaattiHinta + americanoHinta + fantasiaHinta + chickenHinta;

            // Lisätäytteet


            // Lasketaan ensimmäisen pitsan lisätäytteiden hinta (1.50 euroa * lisätäytteiden määrä)
            double lisatayte1Hinta = lisatayte1 * (double)numUpDownLisataytteet1.Value;

            // Lasketaan toisen pitsan lisätäytteiden hinta (1.50 euroa * lisätäytteiden määrä)
            double lisatayte2Hinta = lisatayte2 * (double)numUpDownLisataytteet2.Value;

            // Lasketaan kolmannen pitsan lisätäytteiden hinta (1.50 euroa * lisätäytteiden määrä)
            double lisatayte3Hinta = lisatayte3 * (double)numUpDownLisataytteet3.Value;

            // Lasketaan neljännen pitsan lisätäytteiden hinta (1.50 euroa * lisätäytteiden määrä)
            double lisatayte4Hinta = lisatayte4 * (double)numUpDownLisataytteet4.Value;

            // Lasketaan viidennen pitsan lisätäytteiden hinta (1.50 euroa * lisätäytteiden määrä)
            double lisatayte5Hinta = lisatayte5 * (double)numUpDownLisataytteet5.Value;

            // Lasketaan kuuden pitsan lisätäytteiden hinta (1.50 euroa * lisätäytteiden määrä)
            double lisatayte6Hinta = lisatayte6 * (double)numUpDownLisataytteet6.Value;

            // Lasketaan seitsemännen pitsan lisätäytteiden hinta (1.50 euroa * lisätäytteiden määrä)
            double lisatayte7Hinta = lisatayte7 * (double)numUpDownLisataytteet7.Value;

            // Lasketaan kahdeksannen pitsan lisätäytteiden hinta (1.50 euroa * lisätäytteiden määrä)
            double lisatayte8Hinta = lisatayte8 * (double)numUpDownLisataytteet8.Value;

            // Lasketaan yhdeksännen pitsan lisätäytteiden hinta (1.50 euroa * lisätäytteiden määrä)
            double lisatayte9Hinta = lisatayte9 * (double)numUpDownLisataytteet9.Value;

            // Lasketaan kymmenen pitsan lisätäytteiden hinta (1.50 euroa * lisätäytteiden määrä)
            double lisatayte10Hinta = lisatayte10 * (double)numUpDownLisataytteet10.Value;

            // Lasketaan lisätäytteiden kokonaishinta
            lisataytteetKokonaisHinta = lisatayte1Hinta + lisatayte2Hinta + lisatayte3Hinta + lisatayte4Hinta 
                                          + lisatayte5Hinta + lisatayte6Hinta + lisatayte7Hinta + lisatayte8Hinta
                                          + lisatayte9Hinta + lisatayte10Hinta;


            // Juomat


            // Lasketaan ensimmäisen juoman hinta (3.00 euroa * juomien määrä)
            double juoma1Hinta = juoma1 * (double)numUpDown05L.Value;

            // Lasketaan toisen juoman hinta (5.00 euroa * juomien määrä)
            double juoma2Hinta = juoma2 * (double)numUpDown15L.Value;

            // Lasketaan juomien kokonaishinta
            juomienKokonaisHinta = juoma1Hinta + juoma2Hinta;




            // Pizzapassi

            // Luodaan pizzapassi bool, jolla voidaan tarkistaa voiko pizzapassia käyttää
            bool pizzapassi = false;

            // Jos pitsojen kokonaishinta on 60.00 euroa tai yli ||
            // 120.00 euroa tai yli || 180.00 euroa tai yli || 240.00 euroa tai yli || 300.00 euroa tai yli
            if (pitsojenKokonaisHinta >= 60.00 
                || pitsojenKokonaisHinta >= 120.00 
                || pitsojenKokonaisHinta >= 180.00
                || pitsojenKokonaisHinta >= 240.00
                || pitsojenKokonaisHinta >= 300.00)
            {
                // Miinustetaan pitsojen kokonaishinnasta 5.00 euroa
                pitsojenKokonaisHinta = pitsojenKokonaisHinta - 5.00;

                // Pizzapassi on käytössä
                pizzapassi = true;

            }

            // Jos lisätäytteet on enemmän kuin 0 ja pitsamäärä on 0, tulee virheilmoitus

            // Pepperoni
            if (numUpDownLisataytteet1.Value > 0 && numUpDownPizza1.Value == 0)
            {
                MessageBox.Show("Valitse pitsa, jolle laitetaan lisätäytteet");
                return;
            }

            // Havaiji
            if (numUpDownLisataytteet2.Value > 0 && numUpDownPizza2.Value == 0)
            {
                MessageBox.Show("Valitse pitsa, jolle laitetaan lisätäytteet");
                return;
            }

            // Capricciosa
            if (numUpDownLisataytteet3.Value > 0 && numUpDownPizza3.Value == 0)
            {
                MessageBox.Show("Valitse pitsa, jolle laitetaan lisätäytteet");
                return;
            }

            // Margherita
            if (numUpDownLisataytteet4.Value > 0 && numUpDownPizza4.Value == 0)
            {
                MessageBox.Show("Valitse pitsa, jolle laitetaan lisätäytteet");
                return;
            }

            // Kebab
            if (numUpDownLisataytteet5.Value > 0 && numUpDownPizza5.Value == 0)
            {
                MessageBox.Show("Valitse pitsa, jolle laitetaan lisätäytteet");
                return;
            }

            // Mexicana
            if (numUpDownLisataytteet6.Value > 0 && numUpDownPizza6.Value == 0)
            {
                MessageBox.Show("Valitse pitsa, jolle laitetaan lisätäytteet");
                return;
            }

            // Salaatti
            if (numUpDownLisataytteet7.Value > 0 && numUpDownPizza7.Value == 0)
            {
                MessageBox.Show("Valitse pitsa, jolle laitetaan lisätäytteet");
                return;
            }

            // Americano
            if (numUpDownLisataytteet8.Value > 0 && numUpDownPizza8.Value == 0)
            {
                MessageBox.Show("Valitse pitsa, jolle laitetaan lisätäytteet");
                return;
            }

            // Fantasia
            if (numUpDownLisataytteet9.Value > 0 && numUpDownPizza9.Value == 0)
            {
                MessageBox.Show("Valitse pitsa, jolle laitetaan lisätäytteet");
                return;
            }

            // Chicken
            if (numUpDownLisataytteet10.Value > 0 && numUpDownPizza1.Value == 0)
            {
                MessageBox.Show("Valitse pitsa, jolle laitetaan lisätäytteet");
                return;
            }

            // Jos valittujen pitsojen määrä ylittää 10, tulee virheilmoitus
            if (numUpDownPizza1.Value + numUpDownPizza2.Value + numUpDownPizza3.Value + numUpDownPizza4.Value + numUpDownPizza5.Value
                + numUpDownPizza6.Value + numUpDownPizza7.Value + numUpDownPizza8.Value + numUpDownPizza9.Value + numUpDownPizza10.Value > 10)
            {
                MessageBox.Show("Valitse maksimissaan 10 pitsaa");
            }

            else
            {
                // Alustetaan tulostus
                string tulostus = "";

                // Pizzat
                // Tarkistetaan, että määrä on suurempi kuin 0 ennen kuin lisätään tekstikenttään
                if (numUpDownPizza1.Value > 0)
                    tulostus += numUpDownPizza1.Value + " Pepperoni - " + pepperoniHinta.ToString("0.00") + " €" + Environment.NewLine;
                if (numUpDownPizza2.Value > 0)
                    tulostus += numUpDownPizza2.Value + " Havaiji - " + havaijiHinta.ToString("0.00") + " €" + Environment.NewLine;
                if (numUpDownPizza3.Value > 0)
                    tulostus += numUpDownPizza3.Value + " Capricciosa - " + capricciosaHinta.ToString("0.00") + " €" + Environment.NewLine;
                if (numUpDownPizza4.Value > 0)
                    tulostus += numUpDownPizza4.Value + " Margherita - " + margheritaHinta.ToString("0.00") + " €" + Environment.NewLine;
                if (numUpDownPizza5.Value > 0)
                    tulostus += numUpDownPizza5.Value + " Kebab - " + kebabHinta.ToString("0.00") + " €" + Environment.NewLine;
                if (numUpDownPizza6.Value > 0)
                    tulostus += numUpDownPizza6.Value + " Mexicana - " + mexicanaHinta.ToString("0.00") + " €" + Environment.NewLine;
                if (numUpDownPizza7.Value > 0)
                    tulostus += numUpDownPizza7.Value + " Salaatti - " + salaattiHinta.ToString("0.00") + " €" + Environment.NewLine;
                if (numUpDownPizza8.Value > 0)
                    tulostus += numUpDownPizza8.Value + " Americano - " + americanoHinta.ToString("0.00") + " €" + Environment.NewLine;
                if (numUpDownPizza9.Value > 0)
                    tulostus += numUpDownPizza9.Value + " Fantasia - " + fantasiaHinta.ToString("0.00") + " €" + Environment.NewLine;
                if (numUpDownPizza10.Value > 0)
                    tulostus += numUpDownPizza10.Value + " Chicken - " + chickenHinta.ToString("0.00") + " €" + Environment.NewLine;

                // Lisätäytteet
                // Tarkistetaan, että määrä on suurempi kuin 0 ennen kuin lisätään tekstikenttään
                if (numUpDownLisataytteet1.Value > 0)
                    tulostus += numUpDownLisataytteet1.Value + " Pepperoni Lisätäytteet - " + lisatayte1Hinta.ToString("0.00") + " €" + Environment.NewLine;
                if (numUpDownLisataytteet2.Value > 0)
                    tulostus += numUpDownLisataytteet2.Value + " Havaiji Lisätäytteet - " + lisatayte2Hinta.ToString("0.00") + " €" + Environment.NewLine;
                if (numUpDownLisataytteet3.Value > 0)
                    tulostus += numUpDownLisataytteet3.Value + " Capricciosa Lisätäytteet - " + lisatayte3Hinta.ToString("0.00") + " €" + Environment.NewLine;
                if (numUpDownLisataytteet4.Value > 0)
                    tulostus += numUpDownLisataytteet4.Value + " Margherita Lisätäytteet - " + lisatayte4Hinta.ToString("0.00") + " €" + Environment.NewLine;
                if (numUpDownLisataytteet5.Value > 0)
                    tulostus += numUpDownLisataytteet5.Value + " Kebab Lisätäytteet - " + lisatayte5Hinta.ToString("0.00") + " €" + Environment.NewLine;
                if (numUpDownLisataytteet6.Value > 0)
                    tulostus += numUpDownLisataytteet6.Value + " Mexicana Lisätäytteet - " + lisatayte6Hinta.ToString("0.00") + " €" + Environment.NewLine;
                if (numUpDownLisataytteet7.Value > 0)
                    tulostus += numUpDownLisataytteet7.Value + " Salaatti Lisätäytteet - " + lisatayte7Hinta.ToString("0.00") + " €" + Environment.NewLine;
                if (numUpDownLisataytteet8.Value > 0)
                    tulostus += numUpDownLisataytteet8.Value + " Americano Lisätäytteet - " + lisatayte8Hinta.ToString("0.00") + " €" + Environment.NewLine;
                if (numUpDownLisataytteet9.Value > 0)
                    tulostus += numUpDownLisataytteet9.Value + " Fantasia Lisätäytteet - " + lisatayte9Hinta.ToString("0.00") + " €" + Environment.NewLine;
                if (numUpDownLisataytteet10.Value > 0)
                    tulostus += numUpDownLisataytteet10.Value + " Chicken Lisätäytteet - " + lisatayte10Hinta.ToString("0.00") + " €" + Environment.NewLine;

                // Juomat
                // Tarkistetaan, että määrä on suurempi kuin 0 ennen kuin lisätään tekstikenttään
                if (numUpDown05L.Value > 0)
                    tulostus += numUpDown05L.Value + " 0.5L juoma - " + juoma1Hinta.ToString("0.00") + " €" + Environment.NewLine;
                if (numUpDown15L.Value > 0)
                    tulostus += numUpDown15L.Value + " 1.5L juoma - " + juoma2Hinta.ToString("0.00") + " €" + Environment.NewLine;

                // Jos pizzapassi on käytettävissä, tulostetaan erillinen rivi
                if (pizzapassi == true)
                    tulostus += Environment.NewLine + "Pizzapassi vähensi kokonaiskulutuksesta 5 €" + Environment.NewLine;

                // Tulostetaan kaikki valitut tuotteet, lisätäytteiden kokonaishinta, juomien kokonaishinta ja myös kaikkien tuotteiden kokonaiskustannukset
                txtTulostus.Text = tulostus + Environment.NewLine + "Lisätäytteiden kokonaishinta: " 
                                 + lisataytteetKokonaisHinta.ToString("0.00") + " €" + Environment.NewLine + "Juomien kokonaishinta: " 
                                 + juomienKokonaisHinta.ToString("0.00") + " €" + Environment.NewLine + "Kokonaiskustannukset: " 
                                 + (pitsojenKokonaisHinta + lisataytteetKokonaisHinta + juomienKokonaisHinta).ToString("0.00") + " €";
            }
        }

        // Luodaan globaali muuttuja
        double kokonaisSumma;

        private void btnKassa_Click(object sender, EventArgs e)
        {
            // Lasketaan kokonaissumma (joka kerta kun painiketta painetaan,
            // lisätään uudelle riville kassaan kertynyt raha)
            kokonaisSumma += pitsojenKokonaisHinta + lisataytteetKokonaisHinta + juomienKokonaisHinta;
            
            // Tulostetaan kassaan kertynyt raha tekstikenttään
            txtKassaTulostus.Text += "Kassaan kertynyt raha: " + kokonaisSumma.ToString("0.00") + " €" + Environment.NewLine;
        }
    
        private void btnTyhjenna_Click(object sender, EventArgs e)
        {
            // Tyhjennetään tulostus tekstikentät
            txtTulostus.Text = "";

            // Asetetaan kaikki valinnat 0
            numUpDownPizza1.Value = 0;
            numUpDownPizza2.Value = 0;
            numUpDownPizza3.Value = 0;
            numUpDownPizza4.Value = 0;
            numUpDownPizza5.Value = 0;
            numUpDownPizza6.Value = 0;
            numUpDownPizza7.Value = 0;
            numUpDownPizza8.Value = 0;
            numUpDownPizza9.Value = 0;
            numUpDownPizza10.Value = 0;

            numUpDownLisataytteet1.Value = 0;
            numUpDownLisataytteet2.Value = 0;
            numUpDownLisataytteet3.Value = 0;
            numUpDownLisataytteet4.Value = 0;
            numUpDownLisataytteet5.Value = 0;
            numUpDownLisataytteet6.Value = 0;
            numUpDownLisataytteet7.Value = 0;
            numUpDownLisataytteet8.Value = 0;
            numUpDownLisataytteet9.Value = 0;
            numUpDownLisataytteet10.Value = 0;

            numUpDown05L.Value = 0;
            numUpDown15L.Value = 0;

            numUpDownPizza1Uusi.Value = 0;
            numUpDownPizza2Uusi.Value = 0;
            numUpDownPizza3Uusi.Value = 0;
            numUpDownPizza4Uusi.Value = 0;
            numUpDownPizza5Uusi.Value = 0;
            numUpDownPizza6Uusi.Value = 0;
            numUpDownPizza7Uusi.Value = 0;
            numUpDownPizza8Uusi.Value = 0;
            numUpDownPizza9Uusi.Value = 0;
            numUpDownPizza10Uusi.Value = 0;
        }

        private void btnMuutaHintoja_Click(object sender, EventArgs e)
        {
            // Näytetään labelit
            lblPizza1Uusi.Show();
            lblPizza2Uusi.Show();
            lblPizza3Uusi.Show();
            lblPizza4Uusi.Show();
            lblPizza5Uusi.Show();
            lblPizza6Uusi.Show();
            lblPizza7Uusi.Show();
            lblPizza8Uusi.Show();
            lblPizza9Uusi.Show();
            lblPizza10Uusi.Show();

            // Näytetään numericUpDownit
            numUpDownPizza1Uusi.Show();
            numUpDownPizza2Uusi.Show();
            numUpDownPizza3Uusi.Show();
            numUpDownPizza4Uusi.Show();
            numUpDownPizza5Uusi.Show();
            numUpDownPizza6Uusi.Show();
            numUpDownPizza7Uusi.Show();
            numUpDownPizza8Uusi.Show();
            numUpDownPizza9Uusi.Show();
            numUpDownPizza10Uusi.Show();
        }

        private void btnTallennaUudetHinnat_Click(object sender, EventArgs e)
        {
            // Muutetaan alkuperäiset hinnat haluttuihin hintoihin
            pepperoni = (double)numUpDownPizza1Uusi.Value;
            havaiji = (double)numUpDownPizza2Uusi.Value;
            capricciosa = (double)numUpDownPizza3Uusi.Value;
            margherita = (double)numUpDownPizza4Uusi.Value;
            kebab = (double)numUpDownPizza5Uusi.Value;
            mexicana = (double)numUpDownPizza6Uusi.Value;
            salaatti = (double)numUpDownPizza7Uusi.Value;
            americano = (double)numUpDownPizza8Uusi.Value;
            fantasia = (double)numUpDownPizza9Uusi.Value;
            chicken = (double)numUpDownPizza10Uusi.Value;

            // Muutetaan alkuperäisten hintojen labelit haluttuihin
            lblPizza1.Text = "Pepperoni (" + numUpDownPizza1Uusi.Value + ".00 €)";
            lblPizza2.Text = "Havaiji (" + numUpDownPizza2Uusi.Value + ".00 €)";
            lblPizza3.Text = "Capricciosa (" + numUpDownPizza3Uusi.Value + ".00 €)";
            lblPizza4.Text = "Margherita (" + numUpDownPizza4Uusi.Value + ".00 €)";
            lblPizza5.Text = "Kebab (" + numUpDownPizza5Uusi.Value + ".00 €)";
            lblPizza6.Text = "Mexicana (" + numUpDownPizza6Uusi.Value + ".00 €)";
            lblPizza7.Text = "Salaatti (" + numUpDownPizza7Uusi.Value + ".00 €)";
            lblPizza8.Text = "Americano (" + numUpDownPizza8Uusi.Value + ".00 €)";
            lblPizza9.Text = "Fantasia (" + numUpDownPizza9Uusi.Value + ".00 €)";
            lblPizza10.Text = "Chicken (" + numUpDownPizza10Uusi.Value + ".00 €)";
        }
    }
}
