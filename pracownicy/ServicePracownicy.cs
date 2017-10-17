using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace pracownicy
{
    
    public class ServicePracownicy : IServicePracownicy
    {
        SqlConnection connection;
        SqlConnectionStringBuilder constringbuilder;
        SqlCommand command;


        public ServicePracownicy()
        {
            connectDB();
        }

        void connectDB()
        {

            connection = new SqlConnection();
            command = connection.CreateCommand();
            constringbuilder = new SqlConnectionStringBuilder();

            constringbuilder.DataSource = @"FELEK-PC\SQLEXPRESS";
            constringbuilder.InitialCatalog = "PracownicyDB";
            constringbuilder.IntegratedSecurity = true;

            connection.ConnectionString = constringbuilder.ToString();
            
        }

        public int DodajPracownika(Pracownik p)
        {

            try
            {
                command.CommandText = "INSERT INTO PracownicyT VALUES (@PESEL,@Imie,@Nazwisko)";
                command.Parameters.AddWithValue("PESEL", p.PESEL);
                command.Parameters.AddWithValue("Imie", p.Imie);
                command.Parameters.AddWithValue("Nazwisko", p.Nazwisko);
                command.CommandType = System.Data.CommandType.Text;

                connection.Open();
                int rowsaffected = command.ExecuteNonQuery();
                connection.Close();

                return rowsaffected;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }


        }
        
        public string WczytajPracownika(Pracownik p)
        {
            
            try
            {
                command.CommandText = "SELECT Imie, Nazwisko FROM PracownicyT WHERE PESEL=@PESEL";
                command.Parameters.AddWithValue("PESEL", p.PESEL);
                command.CommandType = System.Data.CommandType.Text;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.HasRows == true)
                    {
                        
                        return reader["Imie"].ToString() + " " + reader["Nazwisko"].ToString();
                    }
                    
                }

                return "Brak takiego pracownika w bazie danych";

            }
            catch (Exception)
            {
                return " Wystąpił Błąd ";
               
            }
            finally
            {
                connection.Close();
            }

        }
        
        public int SprawdzPracownika(Pracownik p)
        {
            try
            {
                command.CommandText = "SELECT PESEL FROM PracownicyT WHERE PESEL=@PESEL";
                command.Parameters.AddWithValue("PESEL", p.PESEL);
                command.CommandType = System.Data.CommandType.Text;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows == true)
                    {
                        connection.Close();
                        return 1;
                        
                    }
                }
                connection.Close();
                return 0;
                
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
            
        }

        public int UsunPracownika(Pracownik p)
        {
            try
            {
                command.CommandText = "DELETE FROM PracownicyT WHERE PESEL=@PESEL";
                command.Parameters.AddWithValue("PESEL", p.PESEL);
                command.CommandType = System.Data.CommandType.Text;

                connection.Open();
                int rowsaffect = command.ExecuteNonQuery();
                connection.Close();

                return rowsaffect;

            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }
    }
}
 