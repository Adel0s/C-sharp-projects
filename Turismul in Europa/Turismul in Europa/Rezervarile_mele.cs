using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Turismul_in_Europa
{
    public partial class Rezervarile_mele : Form
    {
        SqlConnection con; 
        public Rezervarile_mele(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void Rezervarile_mele_Load(object sender, EventArgs e)
        {
            SqlCommand cmd;
            cmd = new SqlCommand("SELECT * FROM Rezervari", con);

            var red = cmd.ExecuteReader();

            while (red.Read())
            {
                string dataI = red[4].ToString();
                string dataF = red[5].ToString();
                dataI = dataI.Substring(0, dataI.IndexOf(' ') + 1);
                dataF = dataF.Substring(0, dataF.IndexOf(' ') + 1);

                dataGridView1.Rows.Add(red[0].ToString(), red[1].ToString(), red[2].ToString(), red[3].ToString(), dataI, dataF);

            }
        }
    }
}
