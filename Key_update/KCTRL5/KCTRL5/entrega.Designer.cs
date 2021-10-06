namespace KCTRL5
{
    partial class entrega
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbKey = new System.Windows.Forms.ComboBox();
            this.cmbProfessor = new System.Windows.Forms.ComboBox();
            this.txtRet = new System.Windows.Forms.TextBox();
            this.txtDev = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dgDados = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(546, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrega de Chaves";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(747, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Professor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1122, 768);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuário:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(49, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Retirada";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(752, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Devolução";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(456, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 35);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cadastrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmbKey
            // 
            this.cmbKey.FormattingEnabled = true;
            this.cmbKey.Location = new System.Drawing.Point(244, 98);
            this.cmbKey.Name = "cmbKey";
            this.cmbKey.Size = new System.Drawing.Size(407, 24);
            this.cmbKey.TabIndex = 7;
            this.cmbKey.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbProfessor
            // 
            this.cmbProfessor.FormattingEnabled = true;
            this.cmbProfessor.Location = new System.Drawing.Point(927, 100);
            this.cmbProfessor.Name = "cmbProfessor";
            this.cmbProfessor.Size = new System.Drawing.Size(407, 24);
            this.cmbProfessor.TabIndex = 8;
            // 
            // txtRet
            // 
            this.txtRet.Location = new System.Drawing.Point(256, 221);
            this.txtRet.Name = "txtRet";
            this.txtRet.Size = new System.Drawing.Size(302, 22);
            this.txtRet.TabIndex = 9;
            this.txtRet.TextChanged += new System.EventHandler(this.txtRet_TextChanged);
            // 
            // txtDev
            // 
            this.txtDev.Location = new System.Drawing.Point(951, 221);
            this.txtDev.Name = "txtDev";
            this.txtDev.Size = new System.Drawing.Size(302, 22);
            this.txtDev.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(752, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 35);
            this.button4.TabIndex = 11;
            this.button4.Text = "Voltar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgDados
            // 
            this.dgDados.AllowUserToOrderColumns = true;
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgDados.Location = new System.Drawing.Point(192, 470);
            this.dgDados.Name = "dgDados";
            this.dgDados.RowHeadersWidth = 51;
            this.dgDados.RowTemplate.Height = 24;
            this.dgDados.Size = new System.Drawing.Size(1015, 242);
            this.dgDados.TabIndex = 12;
            this.dgDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(602, 751);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 35);
            this.button5.TabIndex = 13;
            this.button5.Text = "Atualizar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // entrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 795);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dgDados);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtDev);
            this.Controls.Add(this.txtRet);
            this.Controls.Add(this.cmbProfessor);
            this.Controls.Add(this.cmbKey);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "entrega";
            this.Text = "entrega";
            this.Load += new System.EventHandler(this.entrega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbKey;
        private System.Windows.Forms.ComboBox cmbProfessor;
        private System.Windows.Forms.TextBox txtRet;
        private System.Windows.Forms.TextBox txtDev;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgDados;
        private System.Windows.Forms.Button button5;
    }
}