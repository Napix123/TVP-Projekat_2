using TVP_Projekat2.Cuvanje;
using System;
using System.Windows.Forms;
using Restoran.Forms;

namespace TVP_Projekat2.Handlers
{
    internal class PriloziHandler : RestoranEventHandler
    {
        private readonly ListBox priloziListBox;
        private readonly Button dodajPrilogBtn;
        private readonly IData storage;

        public PriloziHandler(ListBox priloziListBox, Button dodajPrilogBtn, IData storage)
        {
            this.priloziListBox = priloziListBox;
            this.dodajPrilogBtn = dodajPrilogBtn;
            this.storage = storage;

            dodajPrilogBtn.Click += HandleDodajPrilog;
        }

        public void Initialize()
        {
            priloziListBox.DataSource = storage.GetPrilozi();
        }

        private void HandleDodajPrilog(object sender, EventArgs e)
        {
            dodajPrilogBtn.Enabled = false;
            DodajPrilogForm forma = new DodajPrilogForm(storage);
            forma.Show();
            forma.FormClosing += (obj, args) =>
            {
                dodajPrilogBtn.Enabled = true;
                this.Initialize();
            };
        }
    }
}
