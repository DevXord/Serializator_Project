
namespace serializacja_studia
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.at_bt = new System.Windows.Forms.Button();
            this.save_bt = new System.Windows.Forms.Button();
            this.mat_bt = new System.Windows.Forms.Button();
            this.load_bt = new System.Windows.Forms.Button();
            this.playerinfo_lb = new System.Windows.Forms.Label();
            this.player_pic = new System.Windows.Forms.PictureBox();
            this.wolf_pic = new System.Windows.Forms.PictureBox();
            this.wolfinfo_lb = new System.Windows.Forms.Label();
            this.atackp_pc = new System.Windows.Forms.PictureBox();
            this.atackw_pc = new System.Windows.Forms.PictureBox();
            this.hit_lb = new System.Windows.Forms.Label();
            this.new_bt = new System.Windows.Forms.Button();
            this.tura_lb = new System.Windows.Forms.Label();
            this.turaliczba_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wolf_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atackp_pc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atackw_pc)).BeginInit();
            this.SuspendLayout();
            // 
            // at_bt
            // 
            this.at_bt.Location = new System.Drawing.Point(374, 297);
            this.at_bt.Name = "at_bt";
            this.at_bt.Size = new System.Drawing.Size(75, 23);
            this.at_bt.TabIndex = 2;
            this.at_bt.Text = "Attack";
            this.at_bt.UseVisualStyleBackColor = true;
            this.at_bt.Click += new System.EventHandler(this.at_bt_Click);
            // 
            // save_bt
            // 
            this.save_bt.Location = new System.Drawing.Point(312, 415);
            this.save_bt.Name = "save_bt";
            this.save_bt.Size = new System.Drawing.Size(75, 23);
            this.save_bt.TabIndex = 4;
            this.save_bt.Text = "Save";
            this.save_bt.UseVisualStyleBackColor = true;
            this.save_bt.Click += new System.EventHandler(this.save_bt_Click);
            // 
            // mat_bt
            // 
            this.mat_bt.Location = new System.Drawing.Point(293, 297);
            this.mat_bt.Name = "mat_bt";
            this.mat_bt.Size = new System.Drawing.Size(75, 23);
            this.mat_bt.TabIndex = 8;
            this.mat_bt.Text = "Magic";
            this.mat_bt.UseVisualStyleBackColor = true;
            this.mat_bt.Click += new System.EventHandler(this.mat_bt_Click);
            // 
            // load_bt
            // 
            this.load_bt.Location = new System.Drawing.Point(393, 415);
            this.load_bt.Name = "load_bt";
            this.load_bt.Size = new System.Drawing.Size(75, 23);
            this.load_bt.TabIndex = 9;
            this.load_bt.Text = "Load";
            this.load_bt.UseVisualStyleBackColor = true;
            this.load_bt.Click += new System.EventHandler(this.load_bt_Click);
            // 
            // playerinfo_lb
            // 
            this.playerinfo_lb.AutoSize = true;
            this.playerinfo_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerinfo_lb.Location = new System.Drawing.Point(455, 191);
            this.playerinfo_lb.Name = "playerinfo_lb";
            this.playerinfo_lb.Size = new System.Drawing.Size(46, 17);
            this.playerinfo_lb.TabIndex = 11;
            this.playerinfo_lb.Text = "label1";
            // 
            // player_pic
            // 
            this.player_pic.Image = ((System.Drawing.Image)(resources.GetObject("player_pic.Image")));
            this.player_pic.Location = new System.Drawing.Point(299, 191);
            this.player_pic.Name = "player_pic";
            this.player_pic.Size = new System.Drawing.Size(150, 100);
            this.player_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player_pic.TabIndex = 12;
            this.player_pic.TabStop = false;
            // 
            // wolf_pic
            // 
            this.wolf_pic.Image = ((System.Drawing.Image)(resources.GetObject("wolf_pic.Image")));
            this.wolf_pic.Location = new System.Drawing.Point(299, 12);
            this.wolf_pic.Name = "wolf_pic";
            this.wolf_pic.Size = new System.Drawing.Size(150, 100);
            this.wolf_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.wolf_pic.TabIndex = 13;
            this.wolf_pic.TabStop = false;
            // 
            // wolfinfo_lb
            // 
            this.wolfinfo_lb.AutoSize = true;
            this.wolfinfo_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wolfinfo_lb.Location = new System.Drawing.Point(455, 12);
            this.wolfinfo_lb.Name = "wolfinfo_lb";
            this.wolfinfo_lb.Size = new System.Drawing.Size(46, 17);
            this.wolfinfo_lb.TabIndex = 14;
            this.wolfinfo_lb.Text = "label1";
            // 
            // atackp_pc
            // 
            this.atackp_pc.Image = ((System.Drawing.Image)(resources.GetObject("atackp_pc.Image")));
            this.atackp_pc.Location = new System.Drawing.Point(412, 118);
            this.atackp_pc.Name = "atackp_pc";
            this.atackp_pc.Size = new System.Drawing.Size(27, 67);
            this.atackp_pc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atackp_pc.TabIndex = 15;
            this.atackp_pc.TabStop = false;
            // 
            // atackw_pc
            // 
            this.atackw_pc.Image = ((System.Drawing.Image)(resources.GetObject("atackw_pc.Image")));
            this.atackw_pc.Location = new System.Drawing.Point(312, 118);
            this.atackw_pc.Name = "atackw_pc";
            this.atackw_pc.Size = new System.Drawing.Size(27, 67);
            this.atackw_pc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atackw_pc.TabIndex = 16;
            this.atackw_pc.TabStop = false;
            // 
            // hit_lb
            // 
            this.hit_lb.AutoSize = true;
            this.hit_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hit_lb.Location = new System.Drawing.Point(345, 140);
            this.hit_lb.Name = "hit_lb";
            this.hit_lb.Size = new System.Drawing.Size(60, 24);
            this.hit_lb.TabIndex = 17;
            this.hit_lb.Text = "label2";
            // 
            // new_bt
            // 
            this.new_bt.Location = new System.Drawing.Point(31, 415);
            this.new_bt.Name = "new_bt";
            this.new_bt.Size = new System.Drawing.Size(75, 23);
            this.new_bt.TabIndex = 18;
            this.new_bt.Text = "New";
            this.new_bt.UseVisualStyleBackColor = true;
            this.new_bt.Click += new System.EventHandler(this.new_bt_Click);
            // 
            // tura_lb
            // 
            this.tura_lb.AutoSize = true;
            this.tura_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tura_lb.Location = new System.Drawing.Point(596, 129);
            this.tura_lb.Name = "tura_lb";
            this.tura_lb.Size = new System.Drawing.Size(113, 35);
            this.tura_lb.TabIndex = 20;
            this.tura_lb.Text = "TURA:";
            // 
            // turaliczba_lb
            // 
            this.turaliczba_lb.AutoSize = true;
            this.turaliczba_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turaliczba_lb.Location = new System.Drawing.Point(631, 173);
            this.turaliczba_lb.Name = "turaliczba_lb";
            this.turaliczba_lb.Size = new System.Drawing.Size(33, 35);
            this.turaliczba_lb.TabIndex = 21;
            this.turaliczba_lb.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.turaliczba_lb);
            this.Controls.Add(this.tura_lb);
            this.Controls.Add(this.new_bt);
            this.Controls.Add(this.hit_lb);
            this.Controls.Add(this.atackw_pc);
            this.Controls.Add(this.atackp_pc);
            this.Controls.Add(this.wolfinfo_lb);
            this.Controls.Add(this.wolf_pic);
            this.Controls.Add(this.player_pic);
            this.Controls.Add(this.playerinfo_lb);
            this.Controls.Add(this.load_bt);
            this.Controls.Add(this.mat_bt);
            this.Controls.Add(this.save_bt);
            this.Controls.Add(this.at_bt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(18, 150);
            this.Name = "Form1";
            this.Text = "Serializator2000";
            ((System.ComponentModel.ISupportInitialize)(this.player_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wolf_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atackp_pc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atackw_pc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button at_bt;
        private System.Windows.Forms.Button save_bt;
        private System.Windows.Forms.Button mat_bt;
        private System.Windows.Forms.Button load_bt;
        private System.Windows.Forms.Label playerinfo_lb;
        private System.Windows.Forms.PictureBox player_pic;
        private System.Windows.Forms.PictureBox wolf_pic;
        private System.Windows.Forms.Label wolfinfo_lb;
        private System.Windows.Forms.PictureBox atackp_pc;
        private System.Windows.Forms.PictureBox atackw_pc;
        private System.Windows.Forms.Label hit_lb;
        private System.Windows.Forms.Button new_bt;
        private System.Windows.Forms.Label tura_lb;
        private System.Windows.Forms.Label turaliczba_lb;
    }
}

