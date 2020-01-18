using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // Pentru legatura cu baza de date
using System.Data; // Pentru DataTable

namespace Aplicatie
{
    class Interogari_DB
    {
        static string connstr = "Data Source=localhost;UserId=root;database=DBvideoteca";
        static MySqlConnection conn = new MySqlConnection(connstr);

        public static string caut_User(string u, string p)
        {
            // -- Operatia de gasire --
            // Cautam in baza de date DBvideoteca combinatia user+parola
            // transmisa prin parametrii: (string u, string p)
            MySqlCommand comUser = new MySqlCommand();
            comUser.Connection = conn;
            comUser.CommandText = "SELECT denumire_rol FROM utilizatori join roluri on idrol = idr where user = @paramUser and parola = @paramParola";
            comUser.Parameters.AddWithValue("@paramUser", u);
            comUser.Parameters.AddWithValue("@paramParola", p);
            string rol = "";
            try
            {
                conn.Open();
                MySqlDataReader readerUser = comUser.ExecuteReader();
                // Daca a fost gasita o inregistrare in baza de date - preluam denumirea rolului
            if (readerUser.Read())
                {
                    rol = readerUser["denumire_rol"].ToString();
                }
                // Golim parametrii folositi de comUser pentru a-i putea
                // reutiliza la un apel urmator al metodei: caut_user()
                comUser.Parameters.Clear();
            }
            catch (Exception)
            {
                // Aruncam exceptia in Form1.cs (modulul apelant)
                throw;
            }
            finally
            {
                // Inchidem conexiunea cu baza de date
                conn.Close();
            }
            
            return rol;
        }

        public static DataTable selectez_Filme(int idCurentPrim, int idCurentUltim, int dir)
        {
            // -- Operatia de interogare --
            MySqlCommand comFilme = new MySqlCommand();
            comFilme.Connection = conn;
            MySqlDataAdapter filmeAdp = new MySqlDataAdapter(comFilme);
            DataTable filmeDT = new DataTable();
            if (dir == 1)
            {
                // Cautam urmatoarele 3 filme de dupa ultimul idf al filmului afisat deja
                // in ordinea crescatoare a idf (id film in tabela filme)
                comFilme.CommandText = "SELECT idf, f.denumire AS denFilm, d.denumire AS denDomeniu, imagine, nrdisponibile FROM filme f JOIN domenii d ON iddomeniu = idd WHERE idf > @paramID ORDER BY idf ASC LIMIT 3";
                comFilme.Parameters.AddWithValue("@paramID", idCurentUltim);
            }
            else
            {
                // Cautam cele 3 filme de inaintea primului idf afisat deja
                // le obtinem in ordine descrescatoare a idf si le includem intr-o alta comanda SELECT
                // care sa le sorteze in ordinea crescatoare a idf (id film in tabela filme)
                comFilme.CommandText = "SELECT * FROM ( SELECT idf, f.denumire AS denFilm, d.denumire AS denDomeniu, imagine, nrdisponibile FROM filme f JOIN domenii d ON iddomeniu = idd WHERE idf<@paramID ORDER BY idf DESC LIMIT 3) a ORDER BY idf ASC ";
                comFilme.Parameters.AddWithValue("@paramID", idCurentPrim);
            }
            try
            {
                conn.Open();
                filmeAdp.Fill(filmeDT);
            }
            catch (Exception)
            {
                // Aruncam exceptia in Afisare.cs (modulul apelant)
                throw;
            }
            finally
            {
                // Curatam parametri comenzii comFilme pentru a-i putea reutiliza la un apel urmator al metodei: caut_filme()
                comFilme.Parameters.Clear();
                // Inchidem conexiunea cu baza de date
                conn.Close();
            }
            return filmeDT;
        }

    }
}
