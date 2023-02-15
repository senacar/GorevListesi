
namespace GorevListesi
{
    partial class GorevTablosu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GorevTablosu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_gorevekle = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 554);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint_1);
            // 
            // btn_geri
            // 
            this.btn_geri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_geri.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_geri.Location = new System.Drawing.Point(943, 12);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(75, 33);
            this.btn_geri.TabIndex = 1;
            this.btn_geri.Text = "<";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_gorevekle
            // 
            this.btn_gorevekle.Location = new System.Drawing.Point(12, 13);
            this.btn_gorevekle.Name = "btn_gorevekle";
            this.btn_gorevekle.Size = new System.Drawing.Size(130, 48);
            this.btn_gorevekle.TabIndex = 2;
            this.btn_gorevekle.Text = "Görev Ekle";
            this.btn_gorevekle.UseVisualStyleBackColor = true;
            this.btn_gorevekle.Click += new System.EventHandler(this.btn_gorevekle_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(428, 19);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(465, 26);
            this.txt_search.TabIndex = 3;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(385, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // GorevTablosu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 648);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_gorevekle);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GorevTablosu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GorevTablosu";
            this.Load += new System.EventHandler(this.GorevTablosu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_geri;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_gorevekle;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}