using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace GymVTProje
{
    public partial class TotalMember : Form
    {

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=GYM;user ID =postgres; password=2383373n");
        public TotalMember()
        {
            InitializeComponent();
        }

        private void button1ListEquipment_Click(object sender, EventArgs e)
        {

        }

        private void button1ListSTAFF_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from totalmember";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
