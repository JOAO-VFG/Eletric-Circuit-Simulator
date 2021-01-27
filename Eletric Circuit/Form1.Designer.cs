
namespace Eletric_Circuit
{
    partial class telaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panInformacao = new System.Windows.Forms.Panel();
            this.panCircuito = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCircuito = new System.Windows.Forms.Button();
            this.btnBateria = new System.Windows.Forms.Button();
            this.btnResistores = new System.Windows.Forms.Button();
            this.telaResistor = new Eletric_Circuit.TelaResistor();
            this.panInformacao.SuspendLayout();
            this.panCircuito.SuspendLayout();
            this.SuspendLayout();
            // 
            // panInformacao
            // 
            this.panInformacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(91)))), ((int)(((byte)(92)))));
            this.panInformacao.Controls.Add(this.btnSettings);
            this.panInformacao.Controls.Add(this.btnCircuito);
            this.panInformacao.Controls.Add(this.btnBateria);
            this.panInformacao.Controls.Add(this.btnResistores);
            this.panInformacao.Location = new System.Drawing.Point(0, 0);
            this.panInformacao.Name = "panInformacao";
            this.panInformacao.Size = new System.Drawing.Size(100, 500);
            this.panInformacao.TabIndex = 0;
            // 
            // panCircuito
            // 
            this.panCircuito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panCircuito.BackgroundImage = global::Eletric_Circuit.Properties.Resources.backCircuito;
            this.panCircuito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panCircuito.Controls.Add(this.label5);
            this.panCircuito.Controls.Add(this.label4);
            this.panCircuito.Controls.Add(this.label3);
            this.panCircuito.Controls.Add(this.label2);
            this.panCircuito.Controls.Add(this.label1);
            this.panCircuito.Location = new System.Drawing.Point(100, 0);
            this.panCircuito.Name = "panCircuito";
            this.panCircuito.Size = new System.Drawing.Size(730, 500);
            this.panCircuito.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "0 Ω";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(677, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "0 V";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(528, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "0 Ω";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "0 Ω";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "0 V";
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = global::Eletric_Circuit.Properties.Resources.settings_off;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(0, 400);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(100, 100);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnCircuito
            // 
            this.btnCircuito.BackgroundImage = global::Eletric_Circuit.Properties.Resources.electronic_circuit_off;
            this.btnCircuito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCircuito.FlatAppearance.BorderSize = 0;
            this.btnCircuito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCircuito.Location = new System.Drawing.Point(0, 0);
            this.btnCircuito.Name = "btnCircuito";
            this.btnCircuito.Size = new System.Drawing.Size(100, 100);
            this.btnCircuito.TabIndex = 2;
            this.btnCircuito.UseVisualStyleBackColor = true;
            this.btnCircuito.Click += new System.EventHandler(this.btnCircuito_Click);
            // 
            // btnBateria
            // 
            this.btnBateria.BackgroundImage = global::Eletric_Circuit.Properties.Resources.battery_off;
            this.btnBateria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBateria.FlatAppearance.BorderSize = 0;
            this.btnBateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBateria.Location = new System.Drawing.Point(0, 200);
            this.btnBateria.Name = "btnBateria";
            this.btnBateria.Size = new System.Drawing.Size(100, 100);
            this.btnBateria.TabIndex = 4;
            this.btnBateria.UseVisualStyleBackColor = true;
            this.btnBateria.Click += new System.EventHandler(this.btnBateria_Click);
            // 
            // btnResistores
            // 
            this.btnResistores.BackgroundImage = global::Eletric_Circuit.Properties.Resources.resistor_off;
            this.btnResistores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnResistores.FlatAppearance.BorderSize = 0;
            this.btnResistores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResistores.Location = new System.Drawing.Point(0, 100);
            this.btnResistores.Name = "btnResistores";
            this.btnResistores.Size = new System.Drawing.Size(100, 100);
            this.btnResistores.TabIndex = 3;
            this.btnResistores.UseVisualStyleBackColor = true;
            this.btnResistores.Click += new System.EventHandler(this.btnResistores_Click);
            // 
            // telaResistor
            // 
            this.telaResistor.BackColor = System.Drawing.Color.Aqua;
            this.telaResistor.Location = new System.Drawing.Point(862, 10);
            this.telaResistor.Name = "telaResistor";
            this.telaResistor.Size = new System.Drawing.Size(10, 10);
            this.telaResistor.TabIndex = 2;
            // 
            // telaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 496);
            this.Controls.Add(this.telaResistor);
            this.Controls.Add(this.panCircuito);
            this.Controls.Add(this.panInformacao);
            this.Name = "telaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circuito Elétrico";
            this.panInformacao.ResumeLayout(false);
            this.panCircuito.ResumeLayout(false);
            this.panCircuito.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panInformacao;
        private System.Windows.Forms.Panel panCircuito;
        private System.Windows.Forms.Button btnCircuito;
        private System.Windows.Forms.Button btnResistores;
        private System.Windows.Forms.Button btnBateria;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TelaResistor telaResistor;
    }
}

