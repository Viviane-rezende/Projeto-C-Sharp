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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.BackColor = SystemColors.ActiveCaptionText;
            lbl_Nome.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Nome.ForeColor = SystemColors.ButtonFace;
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
            btn_Enviar.Location = new Point(357, 289);
            btn_Enviar.Name = "btn_Enviar";
            btn_Enviar.Size = new Size(75, 23);
            btn_Enviar.TabIndex = 2;
            btn_Enviar.Text = "ENVIAR";
            btn_Enviar.UseVisualStyleBackColor = false;
            btn_Enviar.Click += btn_Enviar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.R;
            pictureBox1.Location = new Point(327, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Enviar);
            Controls.Add(txt_Nome);
            Controls.Add(lbl_Nome);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Nome;
        private TextBox txt_Nome;
        private Button btn_Enviar;
        private PictureBox pictureBox1;
    }
}
