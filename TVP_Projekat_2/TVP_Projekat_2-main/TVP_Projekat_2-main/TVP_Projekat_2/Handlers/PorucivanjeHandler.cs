using TVP_Projekat2.Klase;
using TVP_Projekat2.Cuvanje;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Restoran.Forms;

namespace TVP_Projekat2.Handlers
{
    internal class PorucivanjeHandler : RestoranEventHandler
    {
        private const string TB_PLACEHOLDER = "Filtriraj po nazivu...";
        private readonly ListBox jelaListBox;
        private readonly GroupBox piloziGroupBox;
        private readonly ContextMenuStrip jeloContext;
        private readonly CheckBox cenaRastuceCb;
        private readonly CheckBox cenaOpadajuceCb;
        private readonly IData storage;
        private readonly TextBox filterNaziv;
        private bool otvorenMenu = false;
        private IList<Jelo> jela;

        public PorucivanjeHandler(ListBox jelaListBox, GroupBox piloziGroupBox, ContextMenuStrip jeloContext, TextBox filterNaziv, CheckBox cenaRastuceCb, CheckBox cenaOpadajuceCb, IData storage)
        {
            this.jelaListBox = jelaListBox;
            this.piloziGroupBox = piloziGroupBox;
            this.storage = storage;
            this.jeloContext = jeloContext;
            this.cenaRastuceCb = cenaRastuceCb;
            this.cenaOpadajuceCb = cenaOpadajuceCb;
            this.filterNaziv = filterNaziv;

            cenaOpadajuceCb.CheckedChanged += HandleSortiranjeCb;
            cenaRastuceCb.CheckedChanged += HandleSortiranjeCb;

            jelaListBox.MouseUp += HandleContextOpen;
            jeloContext.ItemClicked += HandleContextClick;
            jelaListBox.SelectedIndexChanged += HandleJeloLbChange;

            filterNaziv.LostFocus += HandleFocusLost;
            filterNaziv.GotFocus += HandleFocusGet;
            filterNaziv.TextChanged += HandleNazivFilterChange;

        }

        public void Initialize()
        {
            jela = storage.GetJela();
            cenaRastuceCb.Checked = false;
            cenaOpadajuceCb.Checked = false;
            jelaListBox.DataSource = jela;
            jelaListBox.SelectedIndex = -1;
            SetPlaceholder(filterNaziv);
        }

        private void HandleContextOpen(object sender, MouseEventArgs e)
        {
            jeloContext.Items[0].Enabled = true;
            if (e.Button != MouseButtons.Right) return;
            if (otvorenMenu) jeloContext.Items[0].Enabled = false;
            jeloContext.Show(jelaListBox, e.Location);
        }

        private void HandleContextClick(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString() == "Dodaj jelo")
            {
                otvorenMenu = true;
                DodajJeloForm forma = new DodajJeloForm(storage);
                forma.FormClosing += (obj, args) =>
                {
                    otvorenMenu = false;
                    Initialize();
                };

                forma.Show();
            }
        }
        private void HandleFocusLost(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filterNaziv.Text))
            {
                SetPlaceholder(filterNaziv);
            }
        }

        private void HandleFocusGet(object sender, EventArgs e)
        {
            if (filterNaziv.Text == TB_PLACEHOLDER)
            {
                filterNaziv.Clear();
                filterNaziv.ForeColor = Color.Black;
            }
        }

        private void HandleNazivFilterChange(object sender, EventArgs e)
        {
            if (filterNaziv.Text == TB_PLACEHOLDER) return;
            jelaListBox.DataSource = jela.Where(jelo => jelo.Naziv.ToLower().Contains(filterNaziv.Text.ToLower())).ToList();
        }

        private void HandleSortiranjeCb(object sender, EventArgs e)
        {
            if (cenaRastuceCb.Checked)
            {
                (jela as List<Jelo>).Sort((prvi, drugi) => prvi.Cena - drugi.Cena);
                cenaOpadajuceCb.Enabled = false;
            }
            else if (cenaOpadajuceCb.Checked)
            {
                (jela as List<Jelo>).Sort((prvi, drugi) => drugi.Cena - prvi.Cena);
                cenaRastuceCb.Enabled = false;
            }
            else
            {
                (jela as List<Jelo>).Sort((prvi, drugi) => prvi.Id - drugi.Id);
                cenaOpadajuceCb.Enabled = true;
                cenaRastuceCb.Enabled = true;
            }
            jelaListBox.DataSource = null;
            jelaListBox.DataSource = jela;
            HandleNazivFilterChange(sender, e);
        }

        private void HandleJeloLbChange(object sender, EventArgs e)
        {
            piloziGroupBox.Controls.Clear();
            if (jelaListBox.SelectedIndex == -1) return;
            Jelo jelo = jelaListBox.SelectedItem as Jelo;
            if (jelo == null) return;
            IList<Prilog> prilozi = jelo.MoguciPrilozi;
            int x = 10;
            int y = 20;
            foreach (Prilog prilog in prilozi)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Tag = prilog;
                checkBox.Text = prilog.Naziv;
                checkBox.AutoSize = true;
                checkBox.Location = new Point(x, y);
                checkBox.Click += (obj, args) =>
                {
                    CheckBox current = obj as CheckBox;
                    if (current.Checked)
                    {
                        foreach (var control in piloziGroupBox.Controls)
                        {
                            CheckBox box = control as CheckBox;
                            if (!box.Checked) box.Enabled = false;
                        }
                    }
                    else
                    {
                        foreach (var control in piloziGroupBox.Controls)
                        {
                            CheckBox box = control as CheckBox;
                            box.Enabled = true;
                        }
                    }
                };
                piloziGroupBox.Controls.Add(checkBox);
                y += checkBox.Height + 5;
                if (y > piloziGroupBox.Height - checkBox.Height)
                {
                    y = 20;
                    x += checkBox.Width;
                }
            }
        }

        private void SetPlaceholder(TextBox textBox)
        {
            textBox.Text = TB_PLACEHOLDER;
            textBox.ForeColor = Color.LightGray;
        }
    }
}
