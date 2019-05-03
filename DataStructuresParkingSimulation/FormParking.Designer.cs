namespace DataStructuresParkingSimulation
{
    partial class FormParking
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
            this.btnCikisKuyrukCikar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxSil = new System.Windows.Forms.CheckBox();
            this.checkBoxListele = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCikisKuyrukListele = new System.Windows.Forms.Button();
            this.btnCikisKuyrukEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnArabalarıEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCikisKuyrukCikar
            // 
            this.btnCikisKuyrukCikar.Location = new System.Drawing.Point(69, 294);
            this.btnCikisKuyrukCikar.Name = "btnCikisKuyrukCikar";
            this.btnCikisKuyrukCikar.Size = new System.Drawing.Size(216, 23);
            this.btnCikisKuyrukCikar.TabIndex = 18;
            this.btnCikisKuyrukCikar.Text = "Tüm Arabaları Otoparktan Çıkar";
            this.btnCikisKuyrukCikar.UseVisualStyleBackColor = true;
            this.btnCikisKuyrukCikar.Click += new System.EventHandler(this.BtnCikisKuyrukCikar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(66, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Arabaları ;";
            // 
            // checkBoxSil
            // 
            this.checkBoxSil.AutoSize = true;
            this.checkBoxSil.Location = new System.Drawing.Point(101, 234);
            this.checkBoxSil.Name = "checkBoxSil";
            this.checkBoxSil.Size = new System.Drawing.Size(141, 17);
            this.checkBoxSil.TabIndex = 16;
            this.checkBoxSil.Text = "Çıkış Kuyruğundan Çıkar";
            this.checkBoxSil.UseVisualStyleBackColor = true;
            this.checkBoxSil.CheckedChanged += new System.EventHandler(this.CheckBoxSil_CheckedChanged);
            // 
            // checkBoxListele
            // 
            this.checkBoxListele.AutoSize = true;
            this.checkBoxListele.Location = new System.Drawing.Point(101, 211);
            this.checkBoxListele.Name = "checkBoxListele";
            this.checkBoxListele.Size = new System.Drawing.Size(141, 17);
            this.checkBoxListele.TabIndex = 15;
            this.checkBoxListele.Text = "Çıkış Kuyruğunda Listele";
            this.checkBoxListele.UseVisualStyleBackColor = true;
            this.checkBoxListele.CheckedChanged += new System.EventHandler(this.CheckBoxListele_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(96, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "HOŞGELDİNİZ";
            // 
            // btnCikisKuyrukListele
            // 
            this.btnCikisKuyrukListele.Location = new System.Drawing.Point(69, 264);
            this.btnCikisKuyrukListele.Name = "btnCikisKuyrukListele";
            this.btnCikisKuyrukListele.Size = new System.Drawing.Size(216, 23);
            this.btnCikisKuyrukListele.TabIndex = 13;
            this.btnCikisKuyrukListele.Text = "Çıkış Kuyrupundaki Arabaları Listele";
            this.btnCikisKuyrukListele.UseVisualStyleBackColor = true;
            this.btnCikisKuyrukListele.Click += new System.EventHandler(this.BtnCikisKuyrukListele_Click);
            // 
            // btnCikisKuyrukEkle
            // 
            this.btnCikisKuyrukEkle.Location = new System.Drawing.Point(69, 147);
            this.btnCikisKuyrukEkle.Name = "btnCikisKuyrukEkle";
            this.btnCikisKuyrukEkle.Size = new System.Drawing.Size(216, 23);
            this.btnCikisKuyrukEkle.TabIndex = 12;
            this.btnCikisKuyrukEkle.Text = "Arabaları Otoparktan Çıkış Kuyruğuna Ekle";
            this.btnCikisKuyrukEkle.UseVisualStyleBackColor = true;
            this.btnCikisKuyrukEkle.Click += new System.EventHandler(this.BtnCikisKuyrukEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(69, 118);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(216, 23);
            this.btnListele.TabIndex = 11;
            this.btnListele.Text = "Arabaları Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // btnArabalarıEkle
            // 
            this.btnArabalarıEkle.Location = new System.Drawing.Point(69, 89);
            this.btnArabalarıEkle.Name = "btnArabalarıEkle";
            this.btnArabalarıEkle.Size = new System.Drawing.Size(216, 23);
            this.btnArabalarıEkle.TabIndex = 10;
            this.btnArabalarıEkle.Text = "Arabaları Otoparka Ekle";
            this.btnArabalarıEkle.UseVisualStyleBackColor = true;
            this.btnArabalarıEkle.Click += new System.EventHandler(this.BtnArabalarıEkle_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 364);
            this.Controls.Add(this.btnCikisKuyrukCikar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxSil);
            this.Controls.Add(this.checkBoxListele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikisKuyrukListele);
            this.Controls.Add(this.btnCikisKuyrukEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnArabalarıEkle);
            this.Name = "FormParking";
            this.Text = "Data Structures Parking Simulation";
            this.Load += new System.EventHandler(this.FormParking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikisKuyrukCikar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxSil;
        private System.Windows.Forms.CheckBox checkBoxListele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCikisKuyrukListele;
        private System.Windows.Forms.Button btnCikisKuyrukEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnArabalarıEkle;
    }
}

