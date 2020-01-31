using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // Pentru legatura cu baza de date
using System.Data; // Pentru DataTable
using System.Collections; // Pentru ArrayList

namespace Aplicatie
{
    class Restituire_DB
    {
        static string connstr = "Data Source=localhost;UserId=root;database=DBvideoteca";
        static MySqlConnection conn = new MySqlConnection(connstr);

        public static void Inregistrez_restituire_in_BD(ArrayList filmeDeRestituit, int id_client)
        {
            MySqlCommand stergImprumut = new MySqlCommand("Delete from imprumuturi where idfilm=@idfilm and idclient = @idclient", conn);
           
            MySqlCommand adaugFilme = new MySqlCommand("Update filme set nrdisponibile=nrdisponibile+1 where idf = @idf", conn);
            // Deschidem conexiunea cu serverul de BD
            conn.Open();
            // Instantiem si incepem executia unei tranzactii pe conexiunea cu baza de date deschisa
            MySqlTransaction tx = conn.BeginTransaction();
            try
            {
                // Atasam cele doua comenzi stergImprumut si adaugFilme tranzactiei tx
                stergImprumut.Transaction = tx;
                adaugFilme.Transaction = tx;
                // Parcurgem in ArrayList filmeDeRestituit toate id-urile filmelor
                // care au fost preluate pentru restituire din checkedListBoxFilme
                foreach (int id_film in filmeDeRestituit)
                {
                    stergImprumut.Parameters.AddWithValue("@idfilm", id_film);
                    stergImprumut.Parameters.AddWithValue("@idclient", id_client);
                    stergImprumut.ExecuteNonQuery();
                    stergImprumut.Parameters.Clear();
                    adaugFilme.Parameters.AddWithValue("@idf", id_film);
                    adaugFilme.ExecuteNonQuery();
                    adaugFilme.Parameters.Clear();
                }
                // Modificarile devin permanente
                tx.Commit();
                // Modificari in baza de date finalizate cu succes
            }
            catch (Exception)
            {
                // Daca a aparut o eroare in timpul executiei vreuneia dintre operatiile asupra bazei de date
                // se vor anula toate operatiile, si cele care au fost parcurse inaintea erorii 
                tx.Rollback();
                throw;
                // Modificari in baza de date neefectuate din cauza unei erori
            }
            finally
            {
                conn.Close();
            }
        }

    }




}
