using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace TVP_Projekat2.Klase
{
    public class Racun
    {
        private int id;
        private DateTime date;
        private IDictionary<StavkaRacuna, int> jela; // Stavka, Kolicina

        public Racun(int id, DateTime date) : this()
        {
            this.id = id;
            this.date = date;
        }

        public Racun()
        {
            jela = new Dictionary<StavkaRacuna, int>();
        }

        public void DodajStavku(Jelo jelo, Prilog prilog)
        {
            StavkaRacuna stavka = new StavkaRacuna(jelo, prilog);
            jela.TryGetValue(stavka, out int trenutnoJela);
            jela[stavka] = trenutnoJela + 1;
        }

        public void ObrisiStavku(StavkaRacuna stavka)
        {
            jela.TryGetValue(stavka, out int trenutnoJela);
            if (trenutnoJela == 1) jela.Remove(stavka);
            else jela[stavka] = trenutnoJela - 1;

        }

        public IList<Pripadnost> GetDisplay()
        {
            return jela.Select(kv => new Pripadnost
            {
                Stavka = kv.Key,
                Kolicina = kv.Value,
            }).ToList();
        }

        public bool IsEmpty()
        {
            return jela.Count == 0;
        }


        public int Id { get => id; set => id = value; }

        public DateTime Date { get => date; set => date = value; }

        public IDictionary<StavkaRacuna, int> Jela { get => jela; set => jela = value; }

        public int UkupnaCena => jela.Keys.Select(k => k.UkupnaCena * jela[k]).DefaultIfEmpty(0).Sum();

        public override string ToString()
        {
            return $"Datum: {date.ToString("dd/M/yyyy", CultureInfo.InvariantCulture)} Cena: {UkupnaCena}";
        }
    }
}
