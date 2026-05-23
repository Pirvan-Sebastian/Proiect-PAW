using ProiectAdmitere.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectAdmitere.Repositories
{
    //folderul repository va avea logica CRUD pentru cele 3 clase ca sa fie frumos organizat
    public class CandidatRepository
    {
        //in cazul in care lucrez pe laptop asta trebuie updatata
        private string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Cursuri\fACULTATE\PAW_Proiect\Proiect-PAW\ProiectAdmitere\AdmitereDB.mdf;Integrated Security=True";
        //READ-iau din baza de date toti candidatii ii bag in obiecte de tip candidat si apoi in lista
        public List<Candidat> GetAll()
        {
            var lista=new List<Candidat>();

            using (SqlConnection conn = new SqlConnection(connString)) 
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Candidati", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        lista.Add(new Candidat{ Id = (int)reader["Id"],
                                                NumeComplet = reader["NumeComplet"].ToString(),
                                                CNP = reader["CNP"].ToString() 
                                                });
                    }
                }

            }

            return lista;
        }
        //Create
        public void Add(Candidat candidat)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Candidati (NumeComplet, CNP) VALUES (@Nume, @CNP)", conn);
                cmd.Parameters.AddWithValue("@Nume", candidat.NumeComplet);
                cmd.Parameters.AddWithValue("@CNP", candidat.CNP);
                cmd.ExecuteNonQuery();
            }
        }
        //Update
        public void Update(Candidat candidat)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Candidati SET NumeComplet=@Nume, CNP=@CNP WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Nume", candidat.NumeComplet);
                cmd.Parameters.AddWithValue("@CNP", candidat.CNP);
                cmd.Parameters.AddWithValue("@Id", candidat.Id);
                cmd.ExecuteNonQuery();
            }

        }

        //DELETE
        public void Delete(int id)
        {
            using (SqlConnection conn=new SqlConnection(connString)) 
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Candidati WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
