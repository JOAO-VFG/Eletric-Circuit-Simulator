using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eletric_Circuit
{
    public partial class telaInicial : Form
    {
        public telaInicial()
        {
            InitializeComponent();

            // Inicia a imagem dos quatro botões na tela
            btnCircuito.BackgroundImage = Properties.Resources.electronic_circuit_on;
            btnResistores.BackgroundImage = Properties.Resources.resistor_off;
            btnBateria.BackgroundImage = Properties.Resources.battery_off;
            btnSettings.BackgroundImage = Properties.Resources.settings_off;

            // Configura as propriedades da tela dos resistores
            telaResistor.SendToBack();
            telaResistor.Location = new Point(100, 0);
            telaResistor.Size = new Size(730, 500);
        }

        // Botão para exibir tela de configurações do resistor clicado
        private void btnCircuito_Click(object sender, EventArgs e)
        {
            trocarImagemBotao(btnCircuito);
            telaResistor.SendToBack();
        }
        // Exibe a tela dos resistores
        private void btnResistores_Click(object sender, EventArgs e)
        {
            trocarImagemBotao(btnResistores);
            telaResistor.BringToFront();
        }
        // Exibe a tela da bateria
        private void btnBateria_Click(object sender, EventArgs e)
        {
            trocarImagemBotao(btnBateria);
        }
        // Exibe a tela das configurações
        private void btnSettings_Click(object sender, EventArgs e)
        {
            trocarImagemBotao(btnSettings);
        }

        // Método auxiliar para mudar a imagem de um botão
        private void trocarImagemBotao(Button botaoClicado)
        {
            // Coloca todos os botoes no estado "OFF"
            ImagemParaPadrao();

            // Botões no estado "ON" quando clicados, imagem
            Image circuitoOn = Properties.Resources.electronic_circuit_on;
            Image resistorOn = Properties.Resources.resistor_on;
            Image bateriaOn = Properties.Resources.battery_on;
            Image settingsOn = Properties.Resources.settings_on;

            // Clicou no botão do circuito
            if (botaoClicado == btnResistores)
            {
                botaoClicado.BackgroundImage = circuitoOn;
            }
            // Clicou no botão do resistor
            if (botaoClicado == btnResistores)
            {
                botaoClicado.BackgroundImage = resistorOn;
            }
            // Clicou botão da bateria
            if (botaoClicado == btnBateria)
            {
                btnBateria.BackgroundImage = bateriaOn;
            }
            // Clicou no botão das configuracoes
            if (botaoClicado == btnSettings)
            {
                btnSettings.BackgroundImage = settingsOn;
            }
        }
        // Configura a imagem de todos os botoes como desligado
        private void ImagemParaPadrao()
        {
            // Imagens de todos os botoes no modo "OFF"
            Image circuitoOff = Properties.Resources.electronic_circuit_off;
            Image resistorOff = Properties.Resources.resistor_off;
            Image bateriaOff = Properties.Resources.battery_off;
            Image settingsOff = Properties.Resources.settings_off;

            // Array dos botões na tela
            Button[] botoes = { btnCircuito, btnResistores, btnBateria, btnSettings };
            // Array com as imagens no estado "OFF"
            Image[] images = { circuitoOff, resistorOff, bateriaOff, settingsOff };

            for (int i = 0; i < botoes.Length; i++)
            {
                botoes[i].BackgroundImage = images[i];
            }
        }
    }
}
