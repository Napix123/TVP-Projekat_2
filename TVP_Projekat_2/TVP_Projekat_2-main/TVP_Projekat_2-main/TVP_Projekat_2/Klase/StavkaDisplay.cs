using System.Text;

namespace TVP_Projekat2.Klase
{
    public class Pripadnost
    {
        public StavkaRacuna Stavka { get; set; }
        public int Kolicina { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"Jelo: {Stavka.Jelo.Naziv} ");
            if (!object.ReferenceEquals(Stavka.Prilog, null)) builder.AppendLine($"Prilog: {Stavka.Prilog.Naziv}");
            builder.Append($"Kolicina: x{Kolicina} Cena: {Stavka.UkupnaCena * Kolicina}");
            return builder.ToString();
        }
    }
}
