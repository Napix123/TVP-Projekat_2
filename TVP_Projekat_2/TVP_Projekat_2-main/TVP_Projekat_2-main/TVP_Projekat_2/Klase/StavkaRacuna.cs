namespace TVP_Projekat2.Klase
{
    public class StavkaRacuna
    {
        private readonly Jelo jelo;
        private readonly Prilog prilog;

        public StavkaRacuna(Jelo jelo, Prilog prilog)
        {
            this.jelo = jelo;
            this.prilog = prilog;
        }

        public int UkupnaCena => CenaJelo + CenaPrilog;

        public int CenaJelo => jelo.Cena;

        public int CenaPrilog => !object.ReferenceEquals(prilog, null) ? prilog.Cena : 0;

        public Jelo Jelo => jelo;

        public Prilog Prilog => prilog;

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is StavkaRacuna druga)) return false;
            bool prilogJednak;
            if (object.ReferenceEquals(prilog, null))
            {
                prilogJednak = object.ReferenceEquals(druga.prilog, null);
            }
            else
            {
                prilogJednak = prilog == druga.prilog;
            }
            return jelo == druga.jelo && prilogJednak;
        }

        public override int GetHashCode()
        {
            int hashCode = -1228211071;
            hashCode = hashCode * -1521134295 + jelo.GetHashCode();
            if (!object.ReferenceEquals(prilog, null))
            {
                hashCode = hashCode * -1521134295 + prilog.GetHashCode();
            }
            return hashCode;
        }

        public static bool operator ==(StavkaRacuna left, StavkaRacuna right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(StavkaRacuna left, StavkaRacuna right)
        {
            return !(left == right);
        }
    }
}
