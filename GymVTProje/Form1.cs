using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymVTProje
{
    public partial class GYM : Form
    {
        public GYM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void yeniÜyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member nm = new Member();
            nm.Show();
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Staff ns = new Staff();
            ns.Show();
            
        }

        private void MemberShip_Click(object sender, EventArgs e)
        {
            Membership ms= new Membership();
            ms.Show();

        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipment eq=new Equipment();
            eq.Show();
        }

        private void toplamÜyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TotalMember tm=new TotalMember();
            tm.Show();
        }

        private void totalPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TotalStaff  ts =new TotalStaff();
                ts.Show();
        }
    }
}
