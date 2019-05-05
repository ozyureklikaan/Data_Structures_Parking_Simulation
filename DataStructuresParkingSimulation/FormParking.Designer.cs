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
            this.btnExitAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxDelete = new System.Windows.Forms.CheckBox();
            this.checkBoxList = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListToExitQueue = new System.Windows.Forms.Button();
            this.btnAddToExitQueue = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExitAll
            // 
            this.btnExitAll.Location = new System.Drawing.Point(69, 294);
            this.btnExitAll.Name = "btnExitAll";
            this.btnExitAll.Size = new System.Drawing.Size(216, 23);
            this.btnExitAll.TabIndex = 18;
            this.btnExitAll.Text = "Remove All Cars In The Car Park";
            this.btnExitAll.UseVisualStyleBackColor = true;
            this.btnExitAll.Click += new System.EventHandler(this.BtnExitAll_Click);
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
            // checkBoxDelete
            // 
            this.checkBoxDelete.AutoSize = true;
            this.checkBoxDelete.Location = new System.Drawing.Point(101, 234);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(147, 17);
            this.checkBoxDelete.TabIndex = 16;
            this.checkBoxDelete.Text = "Remove From Exit Queue";
            this.checkBoxDelete.UseVisualStyleBackColor = true;
            this.checkBoxDelete.CheckedChanged += new System.EventHandler(this.CheckBoxDelete_CheckedChanged_1);
            // 
            // checkBoxList
            // 
            this.checkBoxList.AutoSize = true;
            this.checkBoxList.Location = new System.Drawing.Point(101, 211);
            this.checkBoxList.Name = "checkBoxList";
            this.checkBoxList.Size = new System.Drawing.Size(113, 17);
            this.checkBoxList.TabIndex = 15;
            this.checkBoxList.Text = "List To Exit Queue";
            this.checkBoxList.UseVisualStyleBackColor = true;
            this.checkBoxList.CheckedChanged += new System.EventHandler(this.CheckBoxList_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(118, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "WELCOME";
            // 
            // btnListToExitQueue
            // 
            this.btnListToExitQueue.Location = new System.Drawing.Point(69, 264);
            this.btnListToExitQueue.Name = "btnListToExitQueue";
            this.btnListToExitQueue.Size = new System.Drawing.Size(216, 23);
            this.btnListToExitQueue.TabIndex = 13;
            this.btnListToExitQueue.Text = "List To Cars In The Exit Queue";
            this.btnListToExitQueue.UseVisualStyleBackColor = true;
            this.btnListToExitQueue.Click += new System.EventHandler(this.BtnListToExitQueue_Click);
            // 
            // btnAddToExitQueue
            // 
            this.btnAddToExitQueue.Location = new System.Drawing.Point(69, 147);
            this.btnAddToExitQueue.Name = "btnAddToExitQueue";
            this.btnAddToExitQueue.Size = new System.Drawing.Size(216, 23);
            this.btnAddToExitQueue.TabIndex = 12;
            this.btnAddToExitQueue.Text = "Add Cars To Exit Queue From Car Park";
            this.btnAddToExitQueue.UseVisualStyleBackColor = true;
            this.btnAddToExitQueue.Click += new System.EventHandler(this.BtnAddToExitQueue_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(69, 118);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(216, 23);
            this.btnList.TabIndex = 11;
            this.btnList.Text = "List To Cars";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(69, 89);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(216, 23);
            this.btnAddCar.TabIndex = 10;
            this.btnAddCar.Text = "Add Cars To The Car Park";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.BtnAddCar_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 364);
            this.Controls.Add(this.btnExitAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxDelete);
            this.Controls.Add(this.checkBoxList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListToExitQueue);
            this.Controls.Add(this.btnAddToExitQueue);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnAddCar);
            this.Name = "FormParking";
            this.Text = "Data Structures Parking Simulation";
            this.Load += new System.EventHandler(this.FormParking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxDelete;
        private System.Windows.Forms.CheckBox checkBoxList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListToExitQueue;
        private System.Windows.Forms.Button btnAddToExitQueue;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnAddCar;
    }
}

