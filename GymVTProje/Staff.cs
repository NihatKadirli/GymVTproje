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
    public partial class Staff : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=GYM;user ID =postgres; password=2383373n");
        public Staff()
        {
            InitializeComponent();
        }

        //staff listeleme

        private void button1ListSTAFF_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from staff";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        //staff ekleme
        private void button1ADDSTAFF_Click(object sender, EventArgs e)
        {
            baglanti.Open();



            NpgsqlCommand komut = new NpgsqlCommand("insert into staff (staffid,staffname,staffsurname,staffphone,staffmail) values(@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(textStaffID.Text));
            komut.Parameters.AddWithValue("@p2", textBoxStaffName.Text);
            komut.Parameters.AddWithValue("@p3", textBoxStaffSurname.Text);

            komut.Parameters.AddWithValue("@p4", textStaffPhone.Text);
            komut.Parameters.AddWithValue("@p5", textStaffEmail.Text);

            komut.ExecuteNonQuery();//değişiklikleri veri tabanına yansıtması için
            baglanti.Close();
            MessageBox.Show(" Yeni Personel Kaydı Başarılı şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //silme işlemi
        private void button2DELETESTAFF_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete From staff where staffid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(textStaffID.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Kaydı silme işlemi başarıyla gerçekleşmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        //güncelleme işlemi
        private void button1updateStaff_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update staff set staffname=@p1,staffsurname=@p2,staffphone=@p3 where staffid=@p4", baglanti);
            komut3.Parameters.AddWithValue("@p1", textBoxStaffName.Text);
            komut3.Parameters.AddWithValue("@p2", textBoxStaffSurname.Text);
            komut3.Parameters.AddWithValue("@p3", textStaffPhone.Text);
            komut3.Parameters.AddWithValue("@p4", int.Parse(textStaffID.Text));

            komut3.ExecuteNonQuery();
            MessageBox.Show("Personel kaydı güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            baglanti.Close();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



    }
}