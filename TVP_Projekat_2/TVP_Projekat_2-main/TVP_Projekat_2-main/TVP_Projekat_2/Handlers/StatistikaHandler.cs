using TVP_Projekat2.Cuvanje;
using TVP_Projekat2.Klase;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TVP_Projekat2.Handlers
{
    internal class StatistikaHandler : RestoranEventHandler
    {
        private readonly IData storage;
        private readonly ListBox jelaListBox;
        private readonly Panel piePanel;
        private readonly Label jeloLabel;
        private readonly Label ostaloLabel;
        private DateTime odVreme;
        private DateTime doVreme;

        private (int, int) statistike; // odabrano jelo, sve ostalo
        public StatistikaHandler(IData storage, ListBox jelaListBox, Panel piePanel, Label jeloLabel, Label ostaloLabel,  DateTimePicker odPicker, DateTimePicker doPicker, Button clearFilter, Button filter)
        {
            this.storage = storage;
            this.jelaListBox = jelaListBox;
            this.piePanel = piePanel;
            this.jeloLabel = jeloLabel;
            this.ostaloLabel = ostaloLabel;

            jelaListBox.SelectedIndexChanged += HandleIndexChange;
            piePanel.Paint += HandleDraw;

            filter.Click += (obj, args) =>
            {
                if (odPicker.Value.Date > doPicker.Value.Date)
                {
                    MessageBox.Show("Ne moze OD datum da bude posle DO datuma!");
                    return;
                }
                odVreme = odPicker.Value;
                doVreme = doPicker.Value;
                HandleIndexChange(obj, args);
            };

            clearFilter.Click += (obj, args) =>
            {
                odVreme = default;
                doVreme = default;
                HandleIndexChange(obj, args);
            };
        }

        private void HandleDraw(object sender, PaintEventArgs e)
        {
            if (jelaListBox.SelectedIndex == -1) return;
            Rectangle rectangle = new Rectangle(0, 0, piePanel.Width, piePanel.Height);
            e.Graphics.FillEllipse(Brushes.Black, rectangle);
            float zahvat = (float)statistike.Item1 / statistike.Item2 * 360;
            e.Graphics.FillPie(Brushes.LightSkyBlue, rectangle, 270, zahvat);
        }

        public void Initialize()
        {
            jelaListBox.DataSource = storage.GetJela();
            jelaListBox.SelectedIndex = -1;
            jeloLabel.Text = string.Empty;
            ostaloLabel.Text = string.Empty;
        }

        private void HandleIndexChange(object sender, EventArgs e)
        {
            var selected = jelaListBox.SelectedItem;
            if (selected == null) return;
            Jelo jelo = selected as Jelo;
            statistike = storage.GetStatistike(jelo.Id, odVreme, doVreme);
            Console.WriteLine($"Prva: {statistike.Item1} Druga: {statistike.Item2}");
            double proc = Math.Round((double)statistike.Item1 / (statistike.Item2 == 0 ? 1 : statistike.Item2) * 100, 2);
            jeloLabel.Text = $"{jelo.Naziv}: Ukupno prodato: {statistike.Item1}, Procenat: {proc}%";
            ostaloLabel.Text = $"Ostalo: Ukupno prodato: {statistike.Item2 - statistike.Item1}, Procenat: {100 - proc}%";
            piePanel.Invalidate();
        }
    }
}
