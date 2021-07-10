using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace PasswordGenerator
{
    public class Utilizatori
    {
        public int ID { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public string email { get; set; }
        public string parola { get; set; }

        public Utilizatori(SqlConnection con, int id)
        {
            this.ID = id;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Utilizatori WHERE idUtilizator=@id", con);
            cmd.Parameters.AddWithValue("id", id);
            var red = cmd.ExecuteReader();
            while (red.Read())
            {
                this.nume = red[1].ToString();
                this.prenume = red[2].ToString();
                this.email = red[3].ToString();
                this.parola = red[4].ToString();
            }
        }
    }
}
