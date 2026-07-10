namespace teste
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbOrigemDestino = new ComboBox();
            txtTempo = new TextBox();
            cbPlano = new ComboBox();
            txtSemPlano = new TextBox();
            txtComPlano = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // cbOrigemDestino
            // 
            cbOrigemDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOrigemDestino.FormattingEnabled = true;
            cbOrigemDestino.Location = new Point(50, 167);
            cbOrigemDestino.Name = "cbOrigemDestino";
            cbOrigemDestino.Size = new Size(121, 23);
            cbOrigemDestino.TabIndex = 0;
            cbOrigemDestino.SelectedIndexChanged += cbOrigemDestino_SelectedIndexChanged;
            // 
            // txtTempo
            // 
            txtTempo.Location = new Point(200, 167);
            txtTempo.Name = "txtTempo";
            txtTempo.Size = new Size(100, 23);
            txtTempo.TabIndex = 1;
            txtTempo.TextChanged += txtTempo_TextChanged;
            txtTempo.KeyPress += txtTempo_KeyPress;
            // 
            // cbPlano
            // 
            cbPlano.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPlano.FormattingEnabled = true;
            cbPlano.Location = new Point(325, 167);
            cbPlano.Name = "cbPlano";
            cbPlano.Size = new Size(121, 23);
            cbPlano.TabIndex = 2;
            cbPlano.SelectedIndexChanged += cbPlano_SelectedIndexChanged;
            // 
            // txtSemPlano
            // 
            txtSemPlano.Location = new Point(595, 167);
            txtSemPlano.Name = "txtSemPlano";
            txtSemPlano.ReadOnly = true;
            txtSemPlano.Size = new Size(100, 23);
            txtSemPlano.TabIndex = 4;
            txtSemPlano.TextAlign = HorizontalAlignment.Center;
            // 
            // txtComPlano
            // 
            txtComPlano.Location = new Point(470, 167);
            txtComPlano.Name = "txtComPlano";
            txtComPlano.ReadOnly = true;
            txtComPlano.Size = new Size(100, 23);
            txtComPlano.TabIndex = 3;
            txtComPlano.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(307, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 45);
            label1.TabIndex = 6;
            label1.Text = "Skynetz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(271, 48);
            label2.Name = "label2";
            label2.Size = new Size(203, 32);
            label2.TabIndex = 7;
            label2.Text = "Escolha seu Plano";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 140);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 8;
            label3.Text = "Origem e Destino";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(229, 140);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 10;
            label5.Text = "Tempo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(342, 140);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 11;
            label6.Text = "Plano FaleMais";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(479, 140);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 12;
            label7.Text = "Com FaleMais";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(605, 140);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 13;
            label8.Text = "Sem FaleMais";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(220, 85);
            label4.Name = "label4";
            label4.Size = new Size(300, 21);
            label4.TabIndex = 14;
            label4.Text = "Tudo estará sendo calculado por minutos!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 257);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtComPlano);
            Controls.Add(txtSemPlano);
            Controls.Add(cbPlano);
            Controls.Add(txtTempo);
            Controls.Add(cbOrigemDestino);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Planos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbOrigemDestino;
        private TextBox txtTempo;
        private ComboBox cbPlano;
        private TextBox txtSemPlano;
        private TextBox txtComPlano;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label4;
    }
}
