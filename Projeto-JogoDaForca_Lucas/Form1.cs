using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_JogoDaForca_Lucas
{
    public partial class Form1 : Form
    {
        string[] Palavras = { "Telefone", "Jogador", "Volante"};
        char[] PalavraSelecionada;
        int Tentativas = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            char letra = 'g';
            VerificarLetra(letra);

            button8.Enabled = false;
            button8.BackColor = Color.Gray;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            char letra = 'k';
            VerificarLetra(letra);

            button21.Enabled = false;
            button21.BackColor = Color.Gray;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            char letra = 'q';
            VerificarLetra(letra);

            button15.Enabled = false;
            button15.BackColor = Color.Gray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblVidas.Text = Tentativas.ToString() + "/5";
        }

        string EscolhaPalavra()
        {
            Random random = new Random();
            int escolha = random.Next(Palavras.Length);

            return Palavras[escolha];
        }

        void ConverterPalavra(string Selecionada)
        {
           PalavraSelecionada = Selecionada.ToCharArray();
            
            string convertida = "";

            for (int i = 0; i < PalavraSelecionada.Length; i++)
                convertida = convertida + '_';
           
            txtPalavra.Text=convertida;
        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt16(txtNum.Text);
                if (num == 1)
                    ConverterPalavra(Palavras[0]);
                else if (num == 2)
                    ConverterPalavra(Palavras[1]);
                else if (num == 3)
                    ConverterPalavra(Palavras[2]);
                else
                    ConverterPalavra("Programacao");
            }
            catch 
            {
                string aleatoria = EscolhaPalavra();
                ConverterPalavra(aleatoria);
            }
        }

        bool VerificarLetra(char letra)
        {
            bool letraEncontrada = false;

            for (int i = 0; i < PalavraSelecionada.Length; i++)
            {
                if (char.ToLower(PalavraSelecionada[i]) == letra)
                {
                    txtPalavra.Text = txtPalavra.Text.Substring(0, i) + char.ToUpper(letra) + txtPalavra.Text.Substring(i+1);
                    letraEncontrada = true;
                }
            }
            if (letraEncontrada==false)
            {
                Tentativas--;
                lblVidas.Text = Tentativas.ToString() + "/5";
            }

            if(Tentativas <= 0)
            {
                MessageBox.Show("Insucesso, Esgotou o número de tentativas", "Informação");
            }

            return letraEncontrada;
        }
            private void button2_Click(object sender, EventArgs e)
            {
            char letra = 'a';
            VerificarLetra(letra);

            button2.Enabled = false;
            button2.BackColor = Color.Gray;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            char letra = 'b';
            VerificarLetra(letra);

            button3.Enabled = false;
            button3.BackColor = Color.Gray;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            char letra = 'c';
            VerificarLetra(letra);
            button4.Enabled = false;
            button4.BackColor = Color.Gray;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            char letra = 'd';
            VerificarLetra(letra);

            button5.Enabled = false;
            button5.BackColor = Color.Gray;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            char letra = 'e';
            VerificarLetra(letra);

            button6.Enabled = false;
            button6.BackColor = Color.Gray;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            char letra = 'f';
            VerificarLetra(letra);

            button7.Enabled = false;
            button7.BackColor = Color.Gray;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            char letra = 'h';
            VerificarLetra(letra);

            button9.Enabled = false;
            button9.BackColor = Color.Gray;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            char letra = 'i';
            VerificarLetra(letra);

            button10.Enabled = false;
            button10.BackColor = Color.Gray;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            char letra = 'j';
            VerificarLetra(letra);

            button11.Enabled = false;
            button11.BackColor = Color.Gray;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            char letra = 'l';
            VerificarLetra(letra);

            button20.Enabled = false;
            button20.BackColor = Color.Gray;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            char letra = 'm';
            VerificarLetra(letra);

            button19.Enabled = false;
            button19.BackColor = Color.Gray;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            char letra = 'n';
            VerificarLetra(letra);

            button18.Enabled = false;
            button18.BackColor = Color.Gray;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            char letra = 'o';
            VerificarLetra(letra);

            button17.Enabled = false;
            button17.BackColor = Color.Gray;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            char letra = 'p';
            VerificarLetra(letra);

            button16.Enabled = false;
            button16.BackColor = Color.Gray;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            char letra = 'r';
            VerificarLetra(letra);

            button14.Enabled = false;
            button14.BackColor = Color.Gray;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            char letra = 's';
            VerificarLetra(letra);

            button13.Enabled = false;
            button13.BackColor = Color.Gray;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            char letra = 't';
            VerificarLetra(letra);

            button12.Enabled = false;
            button12.BackColor = Color.Gray;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            char letra = 'u';
            VerificarLetra(letra);

            button28.Enabled = false;
            button28.BackColor = Color.Gray;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            char letra = 'v';
            VerificarLetra(letra);

            button27.Enabled = false;
            button27.BackColor = Color.Gray;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            char letra = 'w';
            VerificarLetra(letra);

            button26.Enabled = false;
            button26.BackColor = Color.Gray;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            char letra = 'x';
            VerificarLetra(letra);

            button25.Enabled = false;
            button25.BackColor = Color.Gray;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            char letra = 'y';
            VerificarLetra(letra);

            button24.Enabled = false;
            button24.BackColor = Color.Gray;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            char letra = 'z';
            VerificarLetra(letra);

            button23.Enabled = false;
            button23.BackColor = Color.Gray;
        }

        private void txtPalavra_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


