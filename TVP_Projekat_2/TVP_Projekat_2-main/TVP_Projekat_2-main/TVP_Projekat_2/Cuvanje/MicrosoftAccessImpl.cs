using TVP_Projekat2.Klase;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace TVP_Projekat2.Cuvanje
{
    internal class MicrosoftAccessImpl : IData
    {
        private ConnectionWrapper connection;

        public MicrosoftAccessImpl()
        {
            /*DATABASE STRING*/
            connection = new ConnectionWrapper(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\TVP_Projekat_2-main-20240529T100333Z-001\TVP_Projekat_2-main\TVP_Projekat_2-main\Restoran(1).accdb");
        }
        public IList<Jelo> GetJela()
        {
            return connection.UseQuery("select * from Jelo", (reader) =>
            {
                IList<Jelo> jela = new List<Jelo>();
                while (reader.Read())
                {
                    int id = int.Parse(reader["id_jelo"].ToString());
                    string naziv = reader["naziv"].ToString();
                    int cena = int.Parse(reader["cena"].ToString());
                    Jelo jelo = new Jelo(id, naziv, cena);
                    jelo.MoguciPrilozi = GetPrilogZaJelo(id); 
                    jela.Add(jelo);
                }
                return jela;
            });
        }
        public IList<Prilog> GetPrilogZaJelo(int id)
        {
            return connection.UseQuery(
                "select * from Prilog inner join Pripadnost on Prilog.id_prilog = Pripadnost.id_prilog " +
                "where Pripadnost.id_jelo = @0",
                (reader) =>
            {
                IList<Prilog> prilozi = new List<Prilog>();
                while (reader.Read())
                {
                    int prilogId = int.Parse(reader["Prilog.id_prilog"].ToString());
                    string prilogNaziv = reader["naziv"].ToString();
                    int cena = int.Parse(reader["cena"].ToString());
                    prilozi.Add(new Prilog(prilogId, prilogNaziv, cena));
                }
                return prilozi;
            }, id);
        }

        public IList<Prilog> GetPrilozi()
        {
            return connection.UseQuery("select * from Prilog", (reader) =>
            {
                IList<Prilog> prilozi = new List<Prilog>();
                while (reader.Read())
                {
                    int prilogId = int.Parse(reader["id_prilog"].ToString());
                    string prilogNaziv = reader["naziv"].ToString();
                    int cena = int.Parse(reader["cena"].ToString());
                    prilozi.Add(new Prilog(prilogId, prilogNaziv, cena));
                }
                return prilozi;
            });
        }

        public int DodajPrilog(string naziv, int cena)
        {
            return connection.UseVoidQuery("insert into Prilog(naziv, cena) values (@0, @1)", naziv, cena);
        }

        public int DodajJelo(string naziv, int cena, List<Prilog> prilozi)
        {
            int jeloId = connection.UseVoidQuery("insert into Jelo(naziv, cena) values (@0, @1)", naziv, cena);
            foreach (Prilog prilog in prilozi)
            {
                connection.UseVoidQuery("insert into Pripadnost(id_jelo, id_prilog) values (@0, @1)", jeloId, prilog.Id);
            }
            return jeloId;
        }

        public int DodajRacun(Racun racun)
        {
            int racunId = connection.UseVoidQuery("insert into racun(ukupna_cena, datum) values (@0, @1)",
                racun.UkupnaCena, DateTime.Now);
            var jela = racun.Jela;
            foreach (var keyValue in jela)
            {
                StavkaRacuna stavka = keyValue.Key;
                int kolicina = keyValue.Value;
                bool prilogPrisutan = !object.ReferenceEquals(stavka.Prilog, null);
                connection.UseVoidQuery("insert into Stavka_racuna(id_racun, id_jelo, id_prilog, cenaJelo, cenaPrilog, kolicina) values (@0, @1, @2, @3, @4, @5)",
                    racunId,
                    stavka.Jelo.Id,
                    prilogPrisutan ? (object)stavka.Prilog.Id : DBNull.Value,
                    stavka.Jelo.Cena,
                    prilogPrisutan ? (object)stavka.Prilog.Cena : DBNull.Value,
                    kolicina);
            }
            return racunId;
        }

        public IDictionary<StavkaRacuna, int> GetStavkeZaRacun(int id)
        {
            return connection.UseQuery("SELECT Stavka_racuna.id_jelo, Jelo.naziv, Jelo.cena, Stavka_racuna.id_prilog, Prilog.naziv AS NazivPrilog, Prilog.cena AS CenaPriloga, Stavka_racuna.kolicina " +
                "FROM ((Stavka_racuna INNER JOIN Jelo ON Stavka_racuna.id_jelo = Jelo.id_jelo) " +
                "LEFT OUTER JOIN Prilog ON Stavka_racuna.id_prilog = Prilog.id_prilog) " +
                "WHERE (Stavka_racuna.id_racun = @0)", (reader) =>
            {
                IDictionary<StavkaRacuna, int> jela = new Dictionary<StavkaRacuna, int>();
                while (reader.Read())
                {
                    int kolicina = (int)reader["kolicina"];
                    Jelo jelo = new Jelo((int)reader["id_jelo"], reader["naziv"].ToString(), (int)reader["cena"]);
                    object idPrilogTemp = reader["id_prilog"];
                    Prilog prilog;
                    if (idPrilogTemp == DBNull.Value)
                    {
                        prilog = null;
                    }
                    else
                    {
                        prilog = new Prilog((int)idPrilogTemp, reader["NazivPrilog"].ToString(), (int)reader["CenaPriloga"]);
                    }

                    jela.Add(new StavkaRacuna(jelo, prilog), kolicina);
                }
                return jela;
            }, id);
        }

        public Jelo GetTopJelo()
        {
            return connection.UseQuery("select top 1 Jelo.naziv, Jelo.cena, Stavka_racuna.id_jelo, sum(Stavka_racuna.kolicina) as kolicina " +
                "from (Stavka_racuna inner join Jelo on Jelo.id_jelo = Stavka_racuna.id_jelo) " +
                "group by Stavka_racuna.id_jelo, Jelo.naziv, Jelo.cena " +
                "order by sum(Stavka_racuna.kolicina) desc", (reader) =>
            {
                if (!reader.Read()) return null;
                else return new Jelo(int.Parse(reader["id_jelo"].ToString()), reader["naziv"].ToString(), int.Parse(reader["cena"].ToString()));
            });
        }

        public (int, int) GetStatistike(int id, DateTime odDatum, DateTime doDatum)
        {
            string izabraniQuery = "select sum(kolicina) as ukupno " +
                "from Stavka_racuna " +
                "inner join Racun on Stavka_racuna.id_racun = Racun.id_racun " +
                "where (id_jelo = @0)";
            string ukupnoQuery = "select sum(kolicina) as ukupno " +
                "from Stavka_racuna " +
                "inner join Racun on Stavka_racuna.id_racun = Racun.id_racun";
            if (odDatum != default && doDatum != default)
            {
                izabraniQuery += " and datum between @1 and @2";
                ukupnoQuery += " where datum between @0 and @1";
            }
            int izabrani = connection.UseQuery(izabraniQuery, ParseUkupno, id, odDatum, doDatum);
            int sve = connection.UseQuery(ukupnoQuery, ParseUkupno, odDatum, doDatum);

            return (izabrani, sve);
        }

        private int ParseUkupno(OleDbDataReader reader)
        {
            if (!reader.Read()) return -1;
            else return int.TryParse(reader["ukupno"].ToString(), out int temp) ? temp : 0;
        }

        public IList<Racun> GetRacuni(DateTime? odDatum, DateTime? doDatum)
        {
            DateTime odDatumFinish = odDatum.HasValue ? odDatum.Value : new DateTime(1970, 1, 1);
            DateTime doDatumFinished = doDatum.HasValue ? doDatum.Value : DateTime.Now;
            return connection.UseQuery("select id_racun, datum from racun where datum between @0 and @1", (reader) =>
            {
                IList<Racun> racuni = new List<Racun>();
                while (reader.Read())
                {
                    Racun racun = new Racun((int)reader["id_racun"], (DateTime)reader["datum"]);
                    racun.Jela = GetStavkeZaRacun(racun.Id);
                    racuni.Add(racun);
                }
                return racuni;
            }, odDatumFinish, doDatumFinished);
        }

        public void Close()
        {
            connection.Close();
        }

    }
}
