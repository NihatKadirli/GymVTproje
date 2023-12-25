namespace GymVTProje
{
    partial class GYM
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GYM));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NewMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MemberShip = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toplamÜyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMemberToolStripMenuItem,
            this.newStaffToolStripMenuItem,
            this.MemberShip,
            this.equipmentToolStripMenuItem,
            this.toplamÜyeToolStripMenuItem,
            this.totalPaymentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1125, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NewMemberToolStripMenuItem
            // 
            this.NewMemberToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.NewMemberToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("NewMemberToolStripMenuItem.Image")));
            this.NewMemberToolStripMenuItem.Name = "NewMemberToolStripMenuItem";
            this.NewMemberToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.NewMemberToolStripMenuItem.Text = " Member";
            this.NewMemberToolStripMenuItem.Click += new System.EventHandler(this.yeniÜyeToolStripMenuItem_Click);
            // 
            // newStaffToolStripMenuItem
            // 
            this.newStaffToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newStaffToolStripMenuItem.Image")));
            this.newStaffToolStripMenuItem.Name = "newStaffToolStripMenuItem";
            this.newStaffToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.newStaffToolStripMenuItem.Text = "Staff";
            this.newStaffToolStripMenuItem.Click += new System.EventHandler(this.newStaffToolStripMenuItem_Click);
            // 
            // MemberShip
            // 
            this.MemberShip.BackColor = System.Drawing.Color.Transparent;
            this.MemberShip.Image = ((System.Drawing.Image)(resources.GetObject("MemberShip.Image")));
            this.MemberShip.Name = "MemberShip";
            this.MemberShip.Size = new System.Drawing.Size(126, 24);
            this.MemberShip.Text = "Membership";
            this.MemberShip.Click += new System.EventHandler(this.MemberShip_Click);
            // 
            // equipmentToolStripMenuItem
            // 
            this.equipmentToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.equipmentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("equipmentToolStripMenuItem.Image")));
            this.equipmentToolStripMenuItem.Name = "equipmentToolStripMenuItem";
            this.equipmentToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.equipmentToolStripMenuItem.Text = "Equipment";
            this.equipmentToolStripMenuItem.Click += new System.EventHandler(this.equipmentToolStripMenuItem_Click);
            // 
            // toplamÜyeToolStripMenuItem
            // 
            this.toplamÜyeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toplamÜyeToolStripMenuItem.Image")));
            this.toplamÜyeToolStripMenuItem.Name = "toplamÜyeToolStripMenuItem";
            this.toplamÜyeToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.toplamÜyeToolStripMenuItem.Text = "Total Member";
            this.toplamÜyeToolStripMenuItem.Click += new System.EventHandler(this.toplamÜyeToolStripMenuItem_Click);
            // 
            // totalPaymentToolStripMenuItem
            // 
            this.totalPaymentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("totalPaymentToolStripMenuItem.Image")));
            this.totalPaymentToolStripMenuItem.Name = "totalPaymentToolStripMenuItem";
            this.totalPaymentToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.totalPaymentToolStripMenuItem.Text = "Total Staff";
            this.totalPaymentToolStripMenuItem.Click += new System.EventHandler(this.totalPaymentToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // GYM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1125, 668);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GYM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NewMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MemberShip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toplamÜyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalPaymentToolStripMenuItem;
    }
}

