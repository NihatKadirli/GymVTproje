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
    public partial class Member : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=GYM;user ID =postgres; password=2383373n");

        public Member()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void NewMember_Load(object sender, EventArgs e)
        {

        }
        //YENİ ÜYE EKLEME İŞLEMİ
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
           

            
            NpgsqlCommand komut = new NpgsqlCommand("insert into member (memberid,membername,membersurname,memberphone,membermail,staff) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(textMemberID.Text));
            komut.Parameters.AddWithValue("@p2", textBoxMemberName.Text);
            komut.Parameters.AddWithValue("@p3", textBoxMemberSurname.Text);
           
            komut.Parameters.AddWithValue("@p4", textMemberPhone.Text);
            komut.Parameters.AddWithValue("@p5", textMemberEmail.Text);
            komut.Parameters.AddWithValue("@p6", int.Parse(textBoxSTAFFMEMBER.Text));
           
            komut.ExecuteNonQuery();//değişiklikleri veri tabanına yansıtması için
            baglanti.Close();
            MessageBox.Show(" Yeni Üye Kaydı Başarılı şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //listeleme işlemi
        private void button1_Click_1(object sender, EventArgs e)
        {
            string sorgu = "select * from member";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            string sorgu2 = "select * from staff";
            NpgsqlDataAdapter db =new NpgsqlDataAdapter(sorgu2, baglanti);
            DataSet dm=new DataSet();
            db.Fill(dm);
            dataGridView2.DataSource = dm.Tables[0];

        }
        //ÜYE SİLME İŞLEMİ
        private void button2RESETMEMBER_Click(object sender, EventArgs e) 
        {  
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete From member where memberid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(textMemberID.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye Kaydı silme işlemi başarıyla gerçekleşmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            

        }
        //Güncelleme işlemi
        private void button1_Click_2(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update member set membername=@p1,membersurname=@p2,memberphone=@p3 where memberid=@p4", baglanti);
            komut3.Parameters.AddWithValue("@p1", textBoxMemberName.Text);
            komut3.Parameters.AddWithValue("@p2", textBoxMemberSurname.Text);
            komut3.Parameters.AddWithValue("@p3", textMemberPhone.Text);
            komut3.Parameters.AddWithValue("@p4", int.Parse(textMemberID.Text));

            komut3.ExecuteNonQuery();
            MessageBox.Show("Üye kaydı güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            baglanti.Close();
        }
        //arama işlemi
        private void button2_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * from \"member\" where \"membername\" like '%" + textBoxSearch.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
