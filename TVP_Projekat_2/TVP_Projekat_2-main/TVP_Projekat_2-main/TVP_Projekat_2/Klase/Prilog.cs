namespace TVP_Projekat2.Klase
{
    public class Prilog
    {
        private readonly int id;
        private readonly string naziv;
        private readonly int cena;

        public Prilog(int id, string naziv, int cena)
        {
            this.id = id;
            this.naziv = naziv;
            this.cena = cena;
        }

        public int Id => id;

        public string Naziv => naziv;

        public int Cena => cena;

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            return obj is Prilog prilog &&
                   id == prilog.id &&
                   naziv == prilog.naziv &&
                   cena == prilog.cena;
        }

        public override int GetHashCode()
        {
            int hashCode = -2085033791;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + naziv.GetHashCode();
            hashCode = hashCode * -1521134295 + cena.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Prilog left, Prilog right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Prilog left, Prilog right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return $"Naziv: {naziv} Cena: {cena} din";
        }
    }
}
