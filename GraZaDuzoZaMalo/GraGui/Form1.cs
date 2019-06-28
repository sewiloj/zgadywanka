﻿using System;
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
            int zakresOd = int.Parse(textBoxZakresOd.Text);
            int zakresDo = int.Parse(textBoxZakresDo.Text);
            gra = new Gra(zakresOd, zakresDo);
            groupBoxOdgadnij.Visible = true;
        }

        private void ButtonSprawdz_Click(object sender, EventArgs e)
        {
            int propozycja = int.Parse(textBoxPodajLiczbe.Text);
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
                labelOcena.Text = "Trafiono!";
                labelOcena.ForeColor = Color.Green;
            }

            labelOcena.Visible = true;

        }
    }
}
