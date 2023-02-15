
namespace GorevListesi
{
    partial class GuncellemePaneli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_panelac = new System.Windows.Forms.Button();
            this.panel_liste = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listbox_secilenler = new System.Windows.Forms.ListBox();
            this.listbox_kisiliste = new System.Windows.Forms.ListBox();
            this.btn_panelkapat = new System.Windows.Forms.Button();
            this.btn_grvkapat = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.richtxt_gorev = new System.Windows.Forms.RichTextBox();
            this.dt_planlanan = new System.Windows.Forms.DateTimePicker();
            this.dt_gercekbitis = new System.Windows.Forms.DateTimePicker();
            this.txt_musteri = new System.Windows.Forms.TextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbox_display = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel_liste.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbox_display);
            this.groupBox1.Controls.Add(this.btn_grvkapat);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.richtxt_gorev);
            this.groupBox1.Controls.Add(this.dt_planlanan);
            this.groupBox1.Controls.Add(this.dt_gercekbitis);
            this.groupBox1.Controls.Add(this.txt_musteri);
            this.groupBox1.Controls.Add(this.txt_isim);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_panelac);
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 486);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Görev Bilgileri";
            // 
            // btn_panelac
            // 
            this.btn_panelac.Location = new System.Drawing.Point(455, 57);
            this.btn_panelac.Name = "btn_panelac";
            this.btn_panelac.Size = new System.Drawing.Size(130, 64);
            this.btn_panelac.TabIndex = 7;
            this.btn_panelac.Text = "Projeye Dahil Edilecekler";
            this.btn_panelac.UseVisualStyleBackColor = true;
            this.btn_panelac.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_liste
            // 
            this.panel_liste.Controls.Add(this.label7);
            this.panel_liste.Controls.Add(this.label5);
            this.panel_liste.Controls.Add(this.listbox_secilenler);
            this.panel_liste.Controls.Add(this.listbox_kisiliste);
            this.panel_liste.Controls.Add(this.btn_panelkapat);
            this.panel_liste.Location = new System.Drawing.Point(36, 12);
            this.panel_liste.Name = "panel_liste";
            this.panel_liste.Size = new System.Drawing.Size(616, 486);
            this.panel_liste.TabIndex = 8;
            this.panel_liste.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_liste_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "secilenler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "kişi listesi";
            // 
            // listbox_secilenler
            // 
            this.listbox_secilenler.FormattingEnabled = true;
            this.listbox_secilenler.ItemHeight = 20;
            this.listbox_secilenler.Location = new System.Drawing.Point(55, 262);
            this.listbox_secilenler.Name = "listbox_secilenler";
            this.listbox_secilenler.Size = new System.Drawing.Size(453, 144);
            this.listbox_secilenler.TabIndex = 3;
            this.listbox_secilenler.SelectedIndexChanged += new System.EventHandler(this.listbox_secilenler_SelectedIndexChanged);
            // 
            // listbox_kisiliste
            // 
            this.listbox_kisiliste.FormattingEnabled = true;
            this.listbox_kisiliste.ItemHeight = 20;
            this.listbox_kisiliste.Location = new System.Drawing.Point(55, 65);
            this.listbox_kisiliste.Name = "listbox_kisiliste";
            this.listbox_kisiliste.Size = new System.Drawing.Size(453, 144);
            this.listbox_kisiliste.TabIndex = 2;
            this.listbox_kisiliste.SelectedIndexChanged += new System.EventHandler(this.listbox_kisiliste_SelectedIndexChanged);
            // 
            // btn_panelkapat
            // 
            this.btn_panelkapat.Location = new System.Drawing.Point(523, 7);
            this.btn_panelkapat.Name = "btn_panelkapat";
            this.btn_panelkapat.Size = new System.Drawing.Size(75, 40);
            this.btn_panelkapat.TabIndex = 0;
            this.btn_panelkapat.Text = "X";
            this.btn_panelkapat.UseVisualStyleBackColor = true;
            this.btn_panelkapat.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_grvkapat
            // 
            this.btn_grvkapat.Location = new System.Drawing.Point(464, 354);
            this.btn_grvkapat.Name = "btn_grvkapat";
            this.btn_grvkapat.Size = new System.Drawing.Size(109, 52);
            this.btn_grvkapat.TabIndex = 6;
            this.btn_grvkapat.Text = "Görevi Kapat";
            this.btn_grvkapat.UseVisualStyleBackColor = true;
            this.btn_grvkapat.Click += new System.EventHandler(this.btn_grvkapat_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(217, 427);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(94, 44);
            this.btn_kaydet.TabIndex = 5;
            this.btn_kaydet.Text = "button1";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // richtxt_gorev
            // 
            this.richtxt_gorev.Location = new System.Drawing.Point(158, 90);
            this.richtxt_gorev.Name = "richtxt_gorev";
            this.richtxt_gorev.Size = new System.Drawing.Size(232, 128);
            this.richtxt_gorev.TabIndex = 1;
            this.richtxt_gorev.Text = "";
            // 
            // dt_planlanan
            // 
            this.dt_planlanan.Location = new System.Drawing.Point(158, 318);
            this.dt_planlanan.Name = "dt_planlanan";
            this.dt_planlanan.Size = new System.Drawing.Size(232, 26);
            this.dt_planlanan.TabIndex = 3;
            // 
            // dt_gercekbitis
            // 
            this.dt_gercekbitis.Location = new System.Drawing.Point(158, 376);
            this.dt_gercekbitis.Name = "dt_gercekbitis";
            this.dt_gercekbitis.Size = new System.Drawing.Size(232, 26);
            this.dt_gercekbitis.TabIndex = 4;
            this.dt_gercekbitis.ValueChanged += new System.EventHandler(this.dt_gercekbitis_ValueChanged);
            // 
            // txt_musteri
            // 
            this.txt_musteri.Location = new System.Drawing.Point(158, 261);
            this.txt_musteri.Name = "txt_musteri";
            this.txt_musteri.Size = new System.Drawing.Size(232, 26);
            this.txt_musteri.TabIndex = 2;
            this.txt_musteri.TextChanged += new System.EventHandler(this.txt_gorevid_TextChanged);
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(158, 36);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(232, 26);
            this.txt_isim.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gerçek Bitiş:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Müşteri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Planlanan Bitiş:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Görev:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim:";
            // 
            // lbox_display
            // 
            this.lbox_display.FormattingEnabled = true;
            this.lbox_display.ItemHeight = 20;
            this.lbox_display.Location = new System.Drawing.Point(440, 214);
            this.lbox_display.Name = "lbox_display";
            this.lbox_display.Size = new System.Drawing.Size(164, 124);
            this.lbox_display.TabIndex = 8;
            this.lbox_display.SelectedIndexChanged += new System.EventHandler(this.lbox_display_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(436, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Proje İlgilileri:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // GuncellemePaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 510);
            this.Controls.Add(this.panel_liste);
            this.Controls.Add(this.groupBox1);
            this.Name = "GuncellemePaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuncellemePaneli";
            this.Load += new System.EventHandler(this.GuncellemePaneli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_liste.ResumeLayout(false);
            this.panel_liste.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_isim;
        public System.Windows.Forms.DateTimePicker dt_gercekbitis;
        public System.Windows.Forms.TextBox txt_musteri;
        public System.Windows.Forms.DateTimePicker dt_planlanan;
        public System.Windows.Forms.RichTextBox richtxt_gorev;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_grvkapat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_panelac;
        public System.Windows.Forms.Panel panel_liste;
        public System.Windows.Forms.ListBox listbox_secilenler;
        public System.Windows.Forms.ListBox listbox_kisiliste;
        public System.Windows.Forms.Button btn_panelkapat;
        private System.Windows.Forms.ListBox lbox_display;
        private System.Windows.Forms.Label label8;
    }
}