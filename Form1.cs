using System.Media;

namespace Projeto_C_Sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            int totalVotos;
            int votosNulos = Convert.ToInt32(txt_Nulos.Text);
            int votosBrancos = Convert.ToInt32(txt_Brancos.Text);
            int votosValidos = Convert.ToInt32(txt_Validos.Text);
            totalVotos = (votosNulos + votosBrancos + votosValidos);

            lbl_Result.Text = $"Olá, {txt_Nome.Text}\n";

            lbl_Result.Text += ($"O total de votos é: {totalVotos}\n");
            lbl_Result.Text += $"{(votosNulos * 100) / totalVotos} % de votos nulos\n";
            lbl_Result.Text += $"{(votosBrancos * 100) / totalVotos} % de votos brancos\n";
            lbl_Result.Text += $"{(votosValidos * 100) / totalVotos} % de votos válidos";
        }

        private void pic_Gatinho_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MIAUUU");
        }

       
    }
}
