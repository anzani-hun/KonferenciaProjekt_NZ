using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;       //mysql hozzáadása  + NuGet package-ben MySql.Data telepítése


namespace KonferenciaProjekt
{
    internal class Konferencia
    {

        MySqlCommand sql = null;
        MySqlConnection connection = null;

        public Konferencia()
        {
            MySqlConnectionStringBuilder adatbazisKapcsolat = new MySqlConnectionStringBuilder();
            adatbazisKapcsolat.Server = "localhost";
            adatbazisKapcsolat.UserID = "root";
            adatbazisKapcsolat.Password = "";
            adatbazisKapcsolat.Database = "konferencia";
            adatbazisKapcsolat.CharacterSet = "utf8";

            connection = new MySqlConnection(adatbazisKapcsolat.ConnectionString);
            sql = connection.CreateCommand();



            //try catch létrehozása, nyit, zár, és ha hiba van akkor üzenet megjelenítése
            try
            {
                kapcsolatNyit();        //metódus generálása lent
                Console.WriteLine("Sikeresen csatlakozva az adatbázishoz - OPEN!");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Hiba történt a kapcsolódás során: " + ex.Message);
                MessageBox.Show(ex.Message);
            }

            finally
            {
                KapcsolatZar();
            }
        }


        // az előadások adattag egy "ELOADAS" típusú objektumokat tartalmazó lista, ami lehetővé teszi a konferencia összes előadás kezelését
        internal List<Eloadas> adatokBetoltese()
        {
            List<Eloadas> eloadas = new List<Eloadas>();
            sql.CommandText = "SELECT * FROM `ertekelesek` NATURAL JOIN `eloadasok`";


            try
            {
                kapcsolatNyit();
                using (MySqlDataReader reader = sql.ExecuteReader())
                {
                    int aktualisId = -1;
                    int eloadasIndex = -1;
                    while (reader.Read())
                    {
                        if (aktualisId != reader.GetInt32("eloadasid"))
                        {
                            eloadas.Add(new Eloadas(reader.GetInt32("eloadasid"), reader.GetString("cim"), reader.GetInt32("sorok"), reader.GetInt32("szekek")));
                            aktualisId = reader.GetInt32("eloadasid");
                            eloadasIndex++;
                        }
                        eloadas[eloadasIndex].SorSzekInformacio(reader.GetInt32("sorok"), reader.GetInt32("szekek"), reader.GetInt32("ertekeles"));
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Hiba történt a kapcsolódás során: " + ex.Message);
                MessageBox.Show(ex.Message);
            }
            return eloadas;
        }







        /// <summary>
        ///  NYIT ÉS ZÁR metódus  az sql adatkapcsolatra
        /// </summary>
        private void kapcsolatNyit()
        {
            if (connection.State != System.Data.ConnectionState.Open) connection.Open();
        }


        private void KapcsolatZar()
        {
            if (connection.State != System.Data.ConnectionState.Closed) connection.Close();
        }

    }

}

