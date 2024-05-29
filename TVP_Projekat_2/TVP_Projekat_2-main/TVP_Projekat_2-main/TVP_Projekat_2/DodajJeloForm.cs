using TVP_Projekat2.Klase;
using TVP_Projekat2.Cuvanje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Restoran.Forms
{
    public partial class DodajJeloForm : Form
    {
        private readonly IData storage;
        private readonly IList<Prilog> prilozi;
        public DodajJeloForm(IData storage)
        {
            InitializeComponent();
            this.storage = storage;
            prilozi = storage.GetPrilozi();
            priloziCombo.DataSource = prilozi;
            priloziListBox.MouseUp += HandleOpenContext;
            obrisiPrilogContext.ItemClicked += HandleContextClick;
        }

        private void HandleDodajPrilog(object sender, EventArgs e)
        {
            var selectedPrilog = priloziCombo.SelectedItem;
            priloziListBox.Items.Add(selectedPrilog);
            prilozi.Remove(selectedPrilog as Prilog);
            priloziCombo.DataSource = null;
            priloziCombo.DataSource = prilozi;
        }

        private void HandleOpenContext(object sender, MouseEventArgs e)
        {
            obrisiPrilogContext.Items[0].Enabled = true;
            if (e.Button != MouseButtons.Right) return;
            var listBoxIndex = priloziListBox.IndexFromPoint(e.Location);
            if (listBoxIndex == -1)
            {
                obrisiPrilogContext.Items[0].Enabled = false;
            }
            else priloziListBox.SelectedIndex = listBoxIndex;
            obrisiPrilogContext.Show(priloziListBox, e.Location);
        }

        private void HandleContextClick(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString() == "Obrisi prilog")
            {
                var selected = priloziListBox.SelectedItem;
                priloziListBox.Items.Remove(selected);
                prilozi.Add(selected as Prilog);
                priloziCombo.DataSource = null;
                priloziCombo.DataSource = prilozi;
            }
        }

        private void HandleDodajJelo(object sender, EventArgs e)
        {
            string naziv = nazivTb.Text;
            if (naziv.Length < 3)
            {
                MessageBox.Show("Naziv mora imati najmanje 3 karaktera!");
                return;
            }
            if (!int.TryParse(cenaTb.Text, out int cena) || cena < 0)
            {
                MessageBox.Show("Cena mora biti pozitivan ceo broj !");
                return;

            }
            var izabraniPrilozi = priloziListBox.Items.Cast<Prilog>().ToList();
            int result = storage.DodajJelo(naziv, cena, izabraniPrilozi);
            if (result != -1)
            {
                MessageBox.Show("Uspesno ste dodali novo jelo!");
                this.Close();
            }
        }
    }
}
