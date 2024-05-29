using TVP_Projekat2.Cuvanje;
using System;
using System.Windows.Forms;

namespace Restoran.Forms
{
    public partial class DodajPrilogForm : Form
    {
        private readonly IData storage;
        public DodajPrilogForm(IData storage)
        {
            InitializeComponent();
            this.storage = storage;
        }

        private void HandleClick(object sender, EventArgs e)
        {
            string naziv = nazivTb.Text;
            if (naziv.Length < 3)
            {
                MessageBox.Show("Naziv mora imati najmanje 3 karaktera!");
                return;
            }
            if (!int.TryParse(cenaTb.Text, out int cena) || cena < 0)
            {
                MessageBox.Show("Cena mora biti pozitivan ceo broj!");
                return;
            }
            int result = storage.DodajPrilog(naziv, cena);
            if (result != -1)
            {
                MessageBox.Show("Uspesno ste dodali novi prilog!");
                this.Close();
            }
        }
    }
}
