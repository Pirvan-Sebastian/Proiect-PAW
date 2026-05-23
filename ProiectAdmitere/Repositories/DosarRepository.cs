using ProiectAdmitere.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectAdmitere.Repositories
{
    public class DosarRepository
    {
        private string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Cursuri\fACULTATE\PAW_Proiect\Proiect-PAW\ProiectAdmitere\AdmitereDB.mdf;Integrated Security=True";

        public List<DosarAdmitere> GetAll()
        {
            var lista = new List<DosarAdmitere>();
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();

                string query = @"
            SELECT d.Id, d.IdCandidat, d.IdFacultate, d.NotaBac, d.NotaExamen,
                   c.NumeComplet AS NumeCandidat, f.Nume AS NumeFacultate
            FROM Dosare d
            INNER JOIN Candidati c ON d.IdCandidat = c.Id
            INNER JOIN Facultati f ON d.IdFacultate = f.Id";

                SqlCommand cmd = new SqlCommand(query, con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new DosarAdmitere
                        {
                            Id = (int)reader["Id"],
                            IdCandidat = (int)reader["IdCandidat"],
                            IdFacultate = (int)reader["IdFacultate"],
                            NotaBac = Convert.ToDouble(reader["NotaBac"]),
                            NotaExamen = Convert.ToDouble(reader["NotaExamen"]),
                            NumeCandidat = reader["NumeCandidat"].ToString(),
                            NumeFacultate = reader["NumeFacultate"].ToString()
                        });
                    }
                }
            }
            return lista;
        }

        public void Add(DosarAdmitere d)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Dosare (IdCandidat, IdFacultate, NotaBac, NotaExamen) VALUES (@IdC, @IdF, @NB, @NE)", con);
                cmd.Parameters.AddWithValue("@IdC", d.IdCandidat);
                cmd.Parameters.AddWithValue("@IdF", d.IdFacultate);
                cmd.Parameters.AddWithValue("@NB", d.NotaBac);
                cmd.Parameters.AddWithValue("@NE", d.NotaExamen);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(DosarAdmitere d)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Dosare SET IdCandidat=@IdC, IdFacultate=@IdF, NotaBac=@NB, NotaExamen=@NE WHERE Id=@Id", con);
                cmd.Parameters.AddWithValue("@IdC", d.IdCandidat);
                cmd.Parameters.AddWithValue("@IdF", d.IdFacultate);
                cmd.Parameters.AddWithValue("@NB", d.NotaBac);
                cmd.Parameters.AddWithValue("@NE", d.NotaExamen);
                cmd.Parameters.AddWithValue("@Id", d.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Dosare WHERE Id=@Id", con);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
