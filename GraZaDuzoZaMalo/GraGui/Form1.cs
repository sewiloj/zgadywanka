using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraModel;
using static GraModel.Gra;

namespace GraGui
{
    public partial class Form1 : Form
    {
        private Gra gra;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonNowaGra_Click(object sender, EventArgs e)
        {
            groupBoxLosowanie.Visible = true;
        }

        private void ButtonWylosuj_Click(object sender, EventArgs e)
        {
            try
            {
                int zakresOd = int.Parse(textBoxZakresOd.Text);
                int zakresDo = int.Parse(textBoxZakresDo.Text);
                if (zakresOd >= zakresDo)
                    throw new ArgumentOutOfRangeException();
                gra = new Gra(zakresOd, zakresDo);
            }
            catch(FormatException)
            {
                labelError.Text = "Błąd! Wprowadziłeś błędne znaki!";
                labelError.ForeColor = Color.Red;
                labelError.Visible = true;
                return;
            }
            catch(ArgumentOutOfRangeException)
            {
                labelError.Text = "Błąd! Podałeś zły zakres!";
                labelError.ForeColor = Color.Red;
                labelError.Visible = true;
                return;
            }

            labelError.Visible = false;

            groupBoxOdgadnij.Visible = true;
            groupBoxLosowanie.Visible = false;
            buttonNowaGra.Text = "Od nowa";
        }

        private void ButtonSprawdz_Click(object sender, EventArgs e)
        {
            int propozycja;
            try
            {
                propozycja = int.Parse(textBoxPodajLiczbe.Text);
            }
            catch(FormatException)
            {
                labelError.Text = "Błąd! Wprowadziłeś błędne znaki!";
                labelError.ForeColor = Color.Red;
                labelError.Visible = true;
                return;
            }

            labelError.Visible = false;

            Odp odpowiedz = gra.Ocena(propozycja);

            if (odpowiedz == Odp.ZaMalo)
            {
                labelOcena.Text = "Za mało! Spróbuj jeszcze raz!";
                labelOcena.ForeColor = Color.Red;
            }
            else if (odpowiedz == Odp.ZaDuzo)
            {
                labelOcena.Text = "Za dużo! Spróbuj Jeszcze raz!";
                labelOcena.ForeColor = Color.Red;
            }
            else
            {
                labelOcena.Text = "Trafiono! Koniec gry.";
                labelOcena.ForeColor = Color.Green;
                textBoxPodajLiczbe.Enabled = false;
                buttonSprawdz.Enabled = false;
            }

            labelOcena.Visible = true;

        }
    }
}
