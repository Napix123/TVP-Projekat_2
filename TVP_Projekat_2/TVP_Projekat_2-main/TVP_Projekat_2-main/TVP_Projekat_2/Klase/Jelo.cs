using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TVP_Projekat2.Klase
{
    public class Jelo
    {
        private readonly int id;
        private readonly string naziv;
        private readonly int cena;
        private IList<Prilog> moguciPrilozi;

        public Jelo(int id, string naziv, int cena)
        {
            this.id = id;
            this.naziv = naziv;
            this.cena = cena;
            this.moguciPrilozi = new List<Prilog>();
        }

        public int Id => id;

        public string Naziv => naziv;

        public int Cena => cena;

        public IList<Prilog> MoguciPrilozi { get => new ReadOnlyCollection<Prilog>(moguciPrilozi); set => moguciPrilozi = value; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Jelo other)) return false;
            return id == other.id &&
                   naziv == other.naziv &&
                   cena == other.cena &&
                   this.moguciPrilozi.SequenceEqual(other.MoguciPrilozi);
        }

        public override int GetHashCode()
        {
            int hashCode = 1034421971;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + naziv.GetHashCode();
            hashCode = hashCode * -1521134295 + cena.GetHashCode();
            foreach (var prilog in moguciPrilozi)
            {
                hashCode = hashCode * -1521134295 + prilog.GetHashCode();
            }
            return hashCode;
        }

        public static bool operator ==(Jelo left, Jelo right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Jelo left, Jelo right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return $"Naziv: {naziv} Cena: {cena} din";
        }
    }
}
