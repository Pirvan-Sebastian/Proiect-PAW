using ProiectAdmitere.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectAdmitere.Repositories
{
    public class FacultateRepository
    {
        private string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Cursuri\fACULTATE\PAW_Proiect\Proiect-PAW\ProiectAdmitere\AdmitereDB.mdf;Integrated Security=True";
        public List<Facultate> GetAll()
        {
            var lista = new List<Facultate>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Facultati", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        lista.Add(new Facultate { Id = (int)reader["Id"], Nume = reader["Nume"].ToString(), NumarLocuri = (int)reader["NumarLocuri"] });
                }
            }
            return lista;
        }

        public void Add(Facultate f)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Facultati (Nume, NumarLocuri) VALUES (@Nume, @Loc)", conn);
                cmd.Parameters.AddWithValue("@Nume", f.Nume);
                cmd.Parameters.AddWithValue("@Loc", f.NumarLocuri);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Facultate f)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Facultati SET Nume=@Nume, NumarLocuri=@Loc WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Nume", f.Nume);
                cmd.Parameters.AddWithValue("@Loc", f.NumarLocuri);
                cmd.Parameters.AddWithValue("@Id", f.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Facultati WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
