namespace Projeto_C_Sharp
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
            lbl_Nome = new Label();
            txt_Nome = new TextBox();
            btn_Enviar = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            txt_Nulos = new TextBox();
            label2 = new Label();
            txt_Brancos = new TextBox();
            pic_Gatinho = new PictureBox();
            label3 = new Label();
            label5 = new Label();
            txt_Validos = new TextBox();
            lbl_Resultado = new Label();
            lbl_Result = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_Gatinho).BeginInit();
            SuspendLayout();
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.BackColor = SystemColors.ActiveCaptionText;
            lbl_Nome.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Nome.ForeColor = Color.FromArgb(255, 192, 255);
            lbl_Nome.Location = new Point(285, 206);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(220, 28);
            lbl_Nome.TabIndex = 0;
            lbl_Nome.Text = "Insira seu nome:";
            // 
            // txt_Nome
            // 
            txt_Nome.Location = new Point(304, 247);
            txt_Nome.Name = "txt_Nome";
            txt_Nome.Size = new Size(176, 23);
            txt_Nome.TabIndex = 1;
            // 
            // btn_Enviar
            // 
            btn_Enviar.BackColor = Color.FromArgb(255, 192, 255);
            btn_Enviar.Cursor = Cursors.Hand;
            btn_Enviar.FlatStyle = FlatStyle.Flat;
            btn_Enviar.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Enviar.Location = new Point(353, 527);
            btn_Enviar.Name = "btn_Enviar";
            btn_Enviar.Size = new Size(75, 23);
            btn_Enviar.TabIndex = 2;
            btn_Enviar.Text = "ENVIAR";
            btn_Enviar.UseVisualStyleBackColor = false;
            btn_Enviar.Click += btn_Enviar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(329, 287);
            label1.Name = "label1";
            label1.Size = new Size(130, 22);
            label1.TabIndex = 5;
            label1.Text = "Votos nulos:";
            // 
            // txt_Nulos
            // 
            txt_Nulos.Location = new Point(340, 324);
            txt_Nulos.Name = "txt_Nulos";
            txt_Nulos.Size = new Size(100, 23);
            txt_Nulos.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(312, 369);
            label2.Name = "label2";
            label2.Size = new Size(150, 22);
            label2.TabIndex = 8;
            label2.Text = "Votos Brancos:";
            // 
            // txt_Brancos
            // 
            txt_Brancos.Location = new Point(340, 406);
            txt_Brancos.Name = "txt_Brancos";
            txt_Brancos.Size = new Size(100, 23);
            txt_Brancos.TabIndex = 9;
            // 
            // pic_Gatinho
            // 
            pic_Gatinho.Image = Properties.Resources.R;
            pic_Gatinho.Location = new Point(304, 78);
            pic_Gatinho.Name = "pic_Gatinho";
            pic_Gatinho.Size = new Size(156, 125);
            pic_Gatinho.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Gatinho.TabIndex = 14;
            pic_Gatinho.TabStop = false;
            pic_Gatinho.Click += pic_Gatinho_Click;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(312, 448);
            label5.Name = "label5";
            label5.Size = new Size(150, 22);
            label5.TabIndex = 16;
            label5.Text = "Votos válidos:";
            // 
            // txt_Validos
            // 
            txt_Validos.Location = new Point(340, 483);
            txt_Validos.Name = "txt_Validos";
            txt_Validos.Size = new Size(100, 23);
            txt_Validos.TabIndex = 17;
            // 
            // lbl_Resultado
            // 
            lbl_Resultado.Location = new Point(0, 0);
            lbl_Resultado.Name = "lbl_Resultado";
            lbl_Resultado.Size = new Size(100, 23);
            lbl_Resultado.TabIndex = 0;
            // 
            // lbl_Result
            // 
            lbl_Result.AutoSize = true;
            lbl_Result.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Result.ForeColor = Color.FromArgb(255, 192, 255);
            lbl_Result.Location = new Point(285, 595);
            lbl_Result.Name = "lbl_Result";
            lbl_Result.Size = new Size(0, 22);
            lbl_Result.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(779, 761);
            Controls.Add(lbl_Result);
            Controls.Add(lbl_Resultado);
            Controls.Add(txt_Validos);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(pic_Gatinho);
            Controls.Add(txt_Brancos);
            Controls.Add(label2);
            Controls.Add(txt_Nulos);
            Controls.Add(label1);
            Controls.Add(btn_Enviar);
            Controls.Add(txt_Nome);
            Controls.Add(lbl_Nome);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pic_Gatinho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Nome;
        private TextBox txt_Nome;
        private Button btn_Enviar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private TextBox txt_Nulos;
        private Label label2;
        private TextBox txt_Brancos;
        private PictureBox pic_Gatinho;
        private Label label3;
        private Label label5;
        private TextBox txt_Validos;
        private Label lbl_Resultado;
        private Label lbl_Result;
    }
}
