namespace SonProje
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtbt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Processing = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update1 = new System.Windows.Forms.Button();
            this.txtıdsetup = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtbtsetup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btsetup = new System.Windows.Forms.Label();
            this.Save2 = new System.Windows.Forms.Button();
            this.Delete2 = new System.Windows.Forms.Button();
            this.Update2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.move = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.moveıd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(587, 404);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(600, 412);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(602, 244);
            this.dataGridView2.TabIndex = 1;
            // 
            // txtbt
            // 
            this.txtbt.Location = new System.Drawing.Point(154, 42);
            this.txtbt.Name = "txtbt";
            this.txtbt.Size = new System.Drawing.Size(100, 20);
            this.txtbt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "BT : ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1033, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 68);
            this.button2.TabIndex = 5;
            this.button2.Text = "Get List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.List);
            // 
            // Processing
            // 
            this.Processing.Location = new System.Drawing.Point(461, 14);
            this.Processing.Name = "Processing";
            this.Processing.Size = new System.Drawing.Size(120, 41);
            this.Processing.TabIndex = 7;
            this.Processing.Text = "1-Move";
            this.Processing.UseVisualStyleBackColor = true;
            this.Processing.Click += new System.EventHandler(this.Processing_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(6, 74);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(109, 41);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save-D";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(245, 74);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(118, 41);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Delete-D";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update1
            // 
            this.Update1.Location = new System.Drawing.Point(121, 74);
            this.Update1.Name = "Update1";
            this.Update1.Size = new System.Drawing.Size(118, 41);
            this.Update1.TabIndex = 10;
            this.Update1.Text = "Update-D";
            this.Update1.UseVisualStyleBackColor = true;
            this.Update1.Click += new System.EventHandler(this.Update1_Click);
            // 
            // txtıdsetup
            // 
            this.txtıdsetup.Location = new System.Drawing.Point(220, 19);
            this.txtıdsetup.Name = "txtıdsetup";
            this.txtıdsetup.Size = new System.Drawing.Size(100, 20);
            this.txtıdsetup.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // txtbtsetup
            // 
            this.txtbtsetup.Location = new System.Drawing.Point(220, 43);
            this.txtbtsetup.Name = "txtbtsetup";
            this.txtbtsetup.Size = new System.Drawing.Size(100, 20);
            this.txtbtsetup.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "INDIVIDUAL_IMPORT_ID : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "BIDS_DOCUMENT_NAME : ";
            // 
            // btsetup
            // 
            this.btsetup.AutoSize = true;
            this.btsetup.Location = new System.Drawing.Point(129, 46);
            this.btsetup.Name = "btsetup";
            this.btsetup.Size = new System.Drawing.Size(30, 13);
            this.btsetup.TabIndex = 16;
            this.btsetup.Text = "BT : ";
            // 
            // Save2
            // 
            this.Save2.Location = new System.Drawing.Point(0, 74);
            this.Save2.Name = "Save2";
            this.Save2.Size = new System.Drawing.Size(120, 41);
            this.Save2.TabIndex = 17;
            this.Save2.Text = "Save-IMPORT";
            this.Save2.UseVisualStyleBackColor = true;
            this.Save2.Click += new System.EventHandler(this.Save2_Click);
            // 
            // Delete2
            // 
            this.Delete2.Location = new System.Drawing.Point(126, 74);
            this.Delete2.Name = "Delete2";
            this.Delete2.Size = new System.Drawing.Size(124, 41);
            this.Delete2.TabIndex = 18;
            this.Delete2.Text = "Delete-IMPORT";
            this.Delete2.UseVisualStyleBackColor = true;
            this.Delete2.Click += new System.EventHandler(this.Delete2_Click);
            // 
            // Update2
            // 
            this.Update2.Location = new System.Drawing.Point(259, 74);
            this.Update2.Name = "Update2";
            this.Update2.Size = new System.Drawing.Size(124, 41);
            this.Update2.TabIndex = 19;
            this.Update2.Text = "Update-IMPORT";
            this.Update2.UseVisualStyleBackColor = true;
            this.Update2.Click += new System.EventHandler(this.Update2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Controls.Add(this.Update1);
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 121);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INDIVIDUAL_IMPORT_DOCUMENTS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Save2);
            this.groupBox2.Controls.Add(this.Delete2);
            this.groupBox2.Controls.Add(this.Update2);
            this.groupBox2.Controls.Add(this.txtbtsetup);
            this.groupBox2.Controls.Add(this.btsetup);
            this.groupBox2.Controls.Add(this.txtıdsetup);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(376, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 121);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INDIVIDUAL_IMPORTS";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(600, 143);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(602, 263);
            this.dataGridView3.TabIndex = 23;
            // 
            // move
            // 
            this.move.Location = new System.Drawing.Point(461, 65);
            this.move.Name = "move";
            this.move.Size = new System.Drawing.Size(120, 41);
            this.move.TabIndex = 25;
            this.move.Text = "Multi-Move";
            this.move.UseVisualStyleBackColor = true;
            this.move.Click += new System.EventHandler(this.move_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "INDIVIDUAL_IMPORT_DOCUMENTS",
            "INDIVIDUAL_IMPORTS"});
            this.comboBox2.Location = new System.Drawing.Point(27, 14);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(227, 21);
            this.comboBox2.TabIndex = 27;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.moveıd);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.move);
            this.groupBox3.Controls.Add(this.txtbt);
            this.groupBox3.Controls.Add(this.Processing);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(7, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(587, 117);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Move Functions";
            // 
            // moveıd
            // 
            this.moveıd.Location = new System.Drawing.Point(154, 76);
            this.moveıd.Name = "moveıd";
            this.moveıd.Size = new System.Drawing.Size(100, 20);
            this.moveıd.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "INDIVIDUAL_IMPORT_ID : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 660);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Sql-Dapper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtbt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Processing;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update1;
        private System.Windows.Forms.TextBox txtıdsetup;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtbtsetup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btsetup;
        private System.Windows.Forms.Button Save2;
        private System.Windows.Forms.Button Delete2;
        private System.Windows.Forms.Button Update2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button move;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox moveıd;
        private System.Windows.Forms.Label label5;
    }
}

