using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace GymVTProje
{
    public partial class Equipment : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=GYM;user ID =postgres; password=2383373n");
        public Equipment()
        {
            InitializeComponent();
        }

        private void Equipment_Load(object sender, EventArgs e)
        {

        }
        //ekleme işlemi
        private void button1AddEquipment_Click(object sender, EventArgs e)
        {
            baglanti.Open();



            NpgsqlCommand komut = new NpgsqlCommand("insert into equipment (equipmentid,equipmentname,staff) values(@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse((textEquipmentID.Text)));
            komut.Parameters.AddWithValue("@p2", textBoxEquipmentName.Text);
            komut.Parameters.AddWithValue("@p3", int.Parse(textStaffEq.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(" Yeni Ekipman Kaydı Başarılı şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //listeleme işlemleri

        private void button1ListEquipment_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from equipment";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet eq = new DataSet();
            da.Fill(eq);
            dataGridViewEquipment.DataSource = eq.Tables[0];

            string sorgu2 = "select * from staff";
            NpgsqlDataAdapter db = new NpgsqlDataAdapter(sorgu2, baglanti);
            DataSet dm = new DataSet();
            db.Fill(dm);
            dataGridViewStaff.DataSource = dm.Tables[0];


        }
        
        private void button1_Click(object sender, EventArgs e)
        {


            textEquipmentID.Text = dataGridViewEquipment.CurrentRow.Cells["equipmentid"].Value.ToString();


        }

        private void textBoxComment_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void button2DeleteEquipment_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete From equipment where equipmentid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(textEquipmentID.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekipman Kaydı silme işlemi başarıyla gerçekleşmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

       private void button1updateEquipment_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update equipment set equipmentname=@p1,staff=@p2 where equipmentid=@p3", baglanti);
            komut3.Parameters.AddWithValue("@p1", textBoxEquipmentName.Text);
            komut3.Parameters.AddWithValue("@p2", int.Parse(textStaffEq.Text));
            komut3.Parameters.AddWithValue("@p3", int.Parse(textEquipmentID.Text));

            komut3.ExecuteNonQuery();
            MessageBox.Show("Ekipman kaydı güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            baglanti.Close();
        }
    }
}
