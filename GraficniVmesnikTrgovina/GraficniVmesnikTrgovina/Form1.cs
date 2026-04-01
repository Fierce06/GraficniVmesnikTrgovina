using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrgovinaLib;

namespace GraficniVmesnikTrgovina
{
    public partial class Form1 : Form
    {
        List<Izdelek> izdelki = new List<Izdelek>();
        Trgovina trgovina = new Trgovina(0.1);

        /// <summary>
        /// Inicializira glavno okno aplikacije in pripravi uporabniški vmesnik.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            cmbTip.Items.Add("Telefon");
            cmbTip.Items.Add("Laptop");

            groupBoxTelefon.Visible = false;
            groupBoxLaptop.Visible = false;

            trgovina.IzdelekDodan += ObDodajanjuIzdelka;
        }

        /// <summary>
        /// Prikaže obvestilo, ko je v trgovino dodan nov izdelek.
        /// </summary>
        /// <param name="izdelek">Izdelek, ki je bil dodan.</param>
        private void ObDodajanjuIzdelka(Izdelek izdelek)
        {
            MessageBox.Show("Dodan je bil izdelek: " + izdelek.Naziv);
        }

        /// <summary>
        /// Glede na izbran tip izdelka prikaže ustrezen del obrazca.
        /// </summary>
        /// <param name="sender">Objekt, ki je sprožil dogodek.</param>
        /// <param name="e">Podatki o dogodku.</param>
        private void cmbTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTip.SelectedItem.ToString() == "Telefon")
            {
                groupBoxTelefon.Visible = true;
                groupBoxLaptop.Visible = false;
            }
            else
            {
                groupBoxTelefon.Visible = false;
                groupBoxLaptop.Visible = true;
            }
        }

        /// <summary>
        /// Ustvari nov izdelek in ga doda v trgovino ter seznam izdelkov.
        /// </summary>
        /// <param name="sender">Objekt, ki je sprožil dogodek.</param>
        /// <param name="e">Podatki o dogodku.</param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            double cena = double.Parse(txtCena.Text);

            Izdelek izdelek;

            if (cmbTip.SelectedItem.ToString() == "Telefon")
            {
                izdelek = new Telefon(txtNaziv.Text, cena, int.Parse(txtKamera.Text), chk5G.Checked, int.Parse(txtBaterija.Text));
            }
            else
            {
                izdelek = new Laptop(txtNaziv.Text, cena, int.Parse(cmbRam.SelectedItem.ToString()), txtProcesor.Text, double.Parse(txtTeza.Text));
            }

            izdelki.Add(izdelek);
            lstIzdelki.Items.Add(izdelek.Izpis());

            trgovina.DodajIzdelek(izdelek);
        }

        /// <summary>
        /// Izračuna skupno ceno vseh dodanih izdelkov.
        /// </summary>
        /// <param name="sender">Objekt, ki je sprožil dogodek.</param>
        /// <param name="e">Podatki o dogodku.</param>
        private void btnCena_Click(object sender, EventArgs e)
        {
            double vsota = 0;

            for (int i = 0; i < izdelki.Count; i++)
            {
                vsota += trgovina[i].Cena;
            }

            lblCena.Text = "Skupna cena: " + vsota.ToString("0.00") + " €";
        }
    }   
}