using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BinaryConverter
{
	
	public partial class MainForm : Form // Declara a classe MainForm que herda de Form
    {
        public MainForm() // Declara o construtor da classe MainForm
        {
            InitializeComponent(); // Inicializa os componentes do formulário
        }
        
        // Método chamado quando o botão de conversão é clicado
        void ConvertButtonMouseClick(object sender, MouseEventArgs e)
        {
            string binary = BinaryTextBox.Text.Trim(); // Obtém o texto do campo de entrada binária
            string translation = TranslationTextBox.Text.Trim(); // Obtém o texto do campo de tradução

            if (string.IsNullOrWhiteSpace(binary)) // Verifica se o campo de entrada binária está vazio ou contém apenas espaços em branco
            {
                if (!string.IsNullOrWhiteSpace(translation)) // Verifica se o campo de tradução não está vazio
                {
                    BinaryTextBox.Text = StringToBinary(translation); // Converte o texto para binário e exibe no campo de entrada binária
                }
                else
                {
                    // Exibe uma mensagem de erro se ambos os campos estiverem vazios
                    MessageBox.Show("Opa, parece que o seu código binário contém um erro! Atenção, sem espaçamentos, letras ou números diferentes de 0 ou 1 nesse campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (IsBinary(binary)) // Verifica se o texto do campo de entrada binária é binário válido
            {
                TranslationTextBox.Text = BinaryToString(binary); // Converte o binário para texto e exibe no campo de tradução
            }
            else if (!string.IsNullOrWhiteSpace(translation)) // Verifica se o campo de tradução não está vazio
            {
                BinaryTextBox.Text = StringToBinary(translation); // Converte o texto para binário e exibe no campo de entrada binária
            }
            else
            {
                // Exibe uma mensagem de erro se o binário contiver caracteres inválidos
                MessageBox.Show("Opa, parece que o seu código binário contém um erro! Atenção, sem espaçamentos, letras ou números diferentes de 0 ou 1 nesse campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // Método que verifica se uma string representa um número binário válido
        private bool IsBinary(string input)
        {
            foreach (char c in input) // Percorre cada caractere da string
            {
                if (c != '0' && c != '1') // Verifica se o caractere não é '0' ou '1'
                {
                    return false; // Retorna false se encontrar um caractere inválido
                }
            }
            return true; // Retorna true se todos os caracteres forem '0' ou '1'
        }

        // Método que converte uma string binária em texto
        private string BinaryToString(string binary)
        {
            string text = "";
            for (int i = 0; i < binary.Length; i += 8) // Loop para percorrer a string binária em grupos de 8 bits
            {
                string byteBinary = binary.Substring(i, Math.Min(8, binary.Length - i)); // Obtém um grupo de 8 bits
                text += (char)Convert.ToInt32(byteBinary, 2); // Converte os bits para um caractere e adiciona ao texto
            }
            return text; // Retorna o texto convertido
        }

        // Método que converte um texto em binário
        private string StringToBinary(string text)
        {
            string binary = "";
            foreach (char c in text) // Loop para percorrer cada caractere do texto
            {
                binary += Convert.ToString(c, 2).PadLeft(8, '0'); // Converte o caractere para binário e adiciona à string binária
            }
            return binary; // Retorna a string binária resultante
        }
        
        // Método chamado quando o botão de limpeza é clicado
        void Button1Click(object sender, EventArgs e)
        {
            BinaryTextBox.Clear(); // Limpa o campo de entrada binária
            TranslationTextBox.Clear(); // Limpa o campo de tradução
        }
	}
}
