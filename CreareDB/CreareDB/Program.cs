using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CreareDB
{
    class Program
    {
        static void Main(string[] args)
        {
            // Apelam cele doua metode
            // La apelul >>fiecareia<< dintre metode am deschis conexiunea cu serverul de baze de date,
            // am creat baza de date/cele doua tabele
            // apoi am inchis conexiunea cu serverul de baze de date
            Creare_DB();
            Creare_Tabele_Relatii();
            Console.ReadKey();
        }

        private static void Creare_DB()
        {
            // Se creaza baza de date fara tabele
            // String-ul de conexiune contine Data Source=...(calea spre serverul de baze de date)
            // dar nu contine denumirea nici unei baze de date
            MySqlConnection conn = new MySqlConnection("DataSource=localhost; UserID = root; ");
            MySqlCommand cmd = new MySqlCommand("CREATE DATABASE DBvideoteca;", conn);
            try
            {
                conn.Open();
                // Tratarea exceptiei pentru situatia in care deja exista baza de date creata
                cmd.ExecuteNonQuery();
                Console.WriteLine("Baza de date DBvideoteca a fost creata");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private static void Creare_Tabele_Relatii()
        {
            // Se creaza tabelele cu legatura dintre ele
            // String-ul de conexiune contine si database=videoteca...(calea spre baza de date creata prin metoda Creare_DB())
            MySqlConnection conn = new MySqlConnection("DataSource=localhost; UserID = root; database = DBvideoteca");
            MySqlCommand cmd = new MySqlCommand("CREATE TABLE domenii (idd int auto_increment, denumire varchar(30) NOT NULL, PRIMARY KEY(idd))", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Tabelul Domenii a fost creat");
                // Am creat intai tabela-parinte
                cmd.CommandText = "CREATE TABLE filme (idf int auto_increment, denumire varchar(50) NOT NULL, anul int, imagine varchar(30), nrtotal int, nrdisponibile int, iddomeniu int, PRIMARY KEY(idf), FOREIGN KEY(iddomeniu) REFERENCES domenii(idd))";
                cmd.ExecuteNonQuery();
                Console.WriteLine("Tabelul Filme a fost creat");
                //Pentru tabela-copil am stabilit si cheia straina (legatura spre tabela parinte)
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
