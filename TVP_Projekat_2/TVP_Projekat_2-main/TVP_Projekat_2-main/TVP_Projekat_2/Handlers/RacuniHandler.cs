using TVP_Projekat2.Klase;
using TVP_Projekat2.Cuvanje;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TVP_Projekat2.Handlers
{
    internal class RacuniHandler : RestoranEventHandler
    {
        private readonly ListBox racunListBox;
        private readonly ListBox stavkeListBox;
        private readonly DateTimePicker odPicker;
        private readonly DateTimePicker doPicker;
        private readonly IData storage;

        public RacuniHandler(ListBox racunListBox, ListBox stavkeListBox, DateTimePicker odPicker, DateTimePicker doPicker, Button resetBtn, Button filterBtn, IData storage)
        {
            this.racunListBox = racunListBox;
            this.stavkeListBox = stavkeListBox;
            this.storage = storage;
            this.odPicker = odPicker;
            this.doPicker = doPicker;
            resetBtn.Click += (obj, args) =>
            {
                racunListBox.DataSource = storage.GetRacuni();
                odPicker.Value = DateTime.Now;
                doPicker.Value = DateTime.Now;
            };
            filterBtn.Click += HandleDatumFilter;
            racunListBox.SelectedIndexChanged += HandleIndexChange;
            stavkeListBox.DrawItem += HandleRacunListDraw;
            stavkeListBox.MeasureItem += HandleRacunMeasureItem;
        }

        public void Initialize()
        {
            racunListBox.DataSource = storage.GetRacuni();
        }

        private void HandleIndexChange(object sender, EventArgs e)
        {
            var selected = racunListBox.SelectedItem;
            if (selected != null)
            {
                Racun racun = selected as Racun;
                stavkeListBox.DataSource = racun.GetDisplay();
            }
            else stavkeListBox.DataSource = null;
        }

        private void HandleDatumFilter(object sender, EventArgs e)
        {
            DateTime odDatum = odPicker.Value;
            DateTime doDatum = doPicker.Value;
            if (odDatum.Date > doDatum.Date)
            {
                MessageBox.Show("OD datum ne moze biti posle DO datuma!");
                return;
            }
            racunListBox.DataSource = storage.GetRacuni(odDatum, doDatum);
            stavkeListBox.DataSource = null;
        }

        private void HandleRacunListDraw(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) return;
            e.DrawBackground();
            e.Graphics.DrawString(stavkeListBox.Items[e.Index].ToString(),
                e.Font, new SolidBrush(e.ForeColor), e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void HandleRacunMeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index == -1) return;
            e.ItemHeight = 13;
            ListBox listBox = sender as ListBox;
            string text = listBox.Items[e.Index].ToString();
            int count = text.Split('\n').Length;
            e.ItemHeight = count * 15;
        }
    }
}
