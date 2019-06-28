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
    public partial class Form2 : Form
    {
        public Form2(List<Ruch> historia)
        {
            InitializeComponent();
            listViewHistoria.View = View.Details;
            listViewHistoria.Columns.Add("Propozycja", 100);
            listViewHistoria.Columns.Add("Odpowiedź", 100);
            listViewHistoria.Columns.Add("Kiedy", 150);

            foreach (var h in historia)
            {
                listViewHistoria.Items.Add(new ListViewItem(h.ToString().Split(',')));
            }
        }
    }
}
