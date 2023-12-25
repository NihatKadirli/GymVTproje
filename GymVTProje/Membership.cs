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
    public partial class Membership : Form
    {

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=GYM;user ID =postgres; password=2383373n");
        public Membership()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //ekleme
        private void button1ADDSTAFF_Click(object sender, EventArgs e)
        {
            baglanti.Open();




            NpgsqlCommand komut = new NpgsqlCommand("insert into membership (memberid,membershipid,membershippay,membershipdate) values(@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse((textmmeberid.Text)));
            komut.Parameters.AddWithValue("@p2", int.Parse((textMembershipID.Text)));
            komut.Parameters.AddWithValue("@p3", textBoxMembershipPayment.Text);
            komut.Parameters.AddWithValue("@p4", textBoxMembershipDate.Text);


            komut.ExecuteNonQuery();//değişiklikleri veri tabanına yansıtması için
            baglanti.Close();
            MessageBox.Show(" Yeni Üyelik Kaydı Başarılı şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //listeleme
        private void button1ListSTAFF_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from member";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            string sorgu2 = "select * from membership";
            NpgsqlDataAdapter db = new NpgsqlDataAdapter(sorgu2, baglanti);
            DataSet dm = new DataSet();
            db.Fill(dm);
            dataGridView2.DataSource = dm.Tables[0];
        }
        //üyelik silme işlemi
        private void button2DELETESTAFF_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete From membership where membershipid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(textMembershipID.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üyelik Kaydı silme işlemi başarıyla gerçekleşmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        //üyelik güncelleme işlemi
        private void button1updateStaff_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            
            NpgsqlCommand komut3 = new NpgsqlCommand("update membership set membershipdate=@p1,membershippay=@p2 where membershipid=@p3", baglanti);
     

            komut3.Parameters.AddWithValue("@p1", textBoxMembershipDate.Text);
            komut3.Parameters.AddWithValue("@p2", textBoxMembershipPayment.Text);
            komut3.Parameters.AddWithValue("@p3", int.Parse(textMembershipID.Text));

            komut3.ExecuteNonQuery();
            MessageBox.Show("Üyelik kaydı güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            baglanti.Close();
        }
    }
}