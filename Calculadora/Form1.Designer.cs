﻿
namespace Calculadora
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.botao7 = new System.Windows.Forms.Button();
            this.botao8 = new System.Windows.Forms.Button();
            this.botao9 = new System.Windows.Forms.Button();
            this.boatodivisao = new System.Windows.Forms.Button();
            this.botaoApagar = new System.Windows.Forms.Button();
            this.botao4 = new System.Windows.Forms.Button();
            this.botao5 = new System.Windows.Forms.Button();
            this.botao6 = new System.Windows.Forms.Button();
            this.botaomulti = new System.Windows.Forms.Button();
            this.botaoApagaTudo = new System.Windows.Forms.Button();
            this.botao1 = new System.Windows.Forms.Button();
            this.botao2 = new System.Windows.Forms.Button();
            this.boato3 = new System.Windows.Forms.Button();
            this.botaosubtracao = new System.Windows.Forms.Button();
            this.botaoIgual = new System.Windows.Forms.Button();
            this.botaozero = new System.Windows.Forms.Button();
            this.botaoponto = new System.Windows.Forms.Button();
            this.botaoadicao = new System.Windows.Forms.Button();
            this.botaofatorial = new System.Windows.Forms.Button();
            this.botaoelevado2 = new System.Windows.Forms.Button();
            this.botaosqrt = new System.Windows.Forms.Button();
            this.botao1divididoporx = new System.Windows.Forms.Button();
            this.botaopi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(13, 39);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(250, 20);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            this.txtResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResultado_KeyPress);
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.BackColor = System.Drawing.Color.White;
            this.lblOperacao.Location = new System.Drawing.Point(27, 42);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(0, 13);
            this.lblOperacao.TabIndex = 2;
            // 
            // botao7
            // 
            this.botao7.Location = new System.Drawing.Point(15, 120);
            this.botao7.Name = "botao7";
            this.botao7.Size = new System.Drawing.Size(43, 32);
            this.botao7.TabIndex = 3;
            this.botao7.Text = "7";
            this.botao7.UseVisualStyleBackColor = true;
            this.botao7.Click += new System.EventHandler(this.botao7_Click);
            // 
            // botao8
            // 
            this.botao8.Location = new System.Drawing.Point(65, 120);
            this.botao8.Name = "botao8";
            this.botao8.Size = new System.Drawing.Size(43, 32);
            this.botao8.TabIndex = 4;
            this.botao8.Text = "8";
            this.botao8.UseVisualStyleBackColor = true;
            this.botao8.Click += new System.EventHandler(this.botao8_Click);
            // 
            // botao9
            // 
            this.botao9.Location = new System.Drawing.Point(114, 120);
            this.botao9.Name = "botao9";
            this.botao9.Size = new System.Drawing.Size(43, 32);
            this.botao9.TabIndex = 5;
            this.botao9.Text = "9";
            this.botao9.UseVisualStyleBackColor = true;
            this.botao9.Click += new System.EventHandler(this.botao9_Click);
            // 
            // boatodivisao
            // 
            this.boatodivisao.Location = new System.Drawing.Point(163, 120);
            this.boatodivisao.Name = "boatodivisao";
            this.boatodivisao.Size = new System.Drawing.Size(43, 32);
            this.boatodivisao.TabIndex = 6;
            this.boatodivisao.Text = "/";
            this.boatodivisao.UseVisualStyleBackColor = true;
            this.boatodivisao.Click += new System.EventHandler(this.boatoDivisao_Click);
            // 
            // botaoApagar
            // 
            this.botaoApagar.Location = new System.Drawing.Point(213, 120);
            this.botaoApagar.Name = "botaoApagar";
            this.botaoApagar.Size = new System.Drawing.Size(44, 32);
            this.botaoApagar.TabIndex = 7;
            this.botaoApagar.Text = "CE";
            this.botaoApagar.UseVisualStyleBackColor = true;
            this.botaoApagar.Click += new System.EventHandler(this.botaoApagar_Click);
            // 
            // botao4
            // 
            this.botao4.Location = new System.Drawing.Point(16, 158);
            this.botao4.Name = "botao4";
            this.botao4.Size = new System.Drawing.Size(43, 32);
            this.botao4.TabIndex = 8;
            this.botao4.Text = "4";
            this.botao4.UseVisualStyleBackColor = true;
            this.botao4.Click += new System.EventHandler(this.botao4_Click);
            // 
            // botao5
            // 
            this.botao5.Location = new System.Drawing.Point(65, 158);
            this.botao5.Name = "botao5";
            this.botao5.Size = new System.Drawing.Size(43, 32);
            this.botao5.TabIndex = 9;
            this.botao5.Text = "5";
            this.botao5.UseVisualStyleBackColor = true;
            this.botao5.Click += new System.EventHandler(this.botao5_Click);
            // 
            // botao6
            // 
            this.botao6.Location = new System.Drawing.Point(114, 158);
            this.botao6.Name = "botao6";
            this.botao6.Size = new System.Drawing.Size(43, 32);
            this.botao6.TabIndex = 10;
            this.botao6.Text = "6";
            this.botao6.UseVisualStyleBackColor = true;
            this.botao6.Click += new System.EventHandler(this.botao6_Click);
            // 
            // botaomulti
            // 
            this.botaomulti.Location = new System.Drawing.Point(163, 158);
            this.botaomulti.Name = "botaomulti";
            this.botaomulti.Size = new System.Drawing.Size(43, 32);
            this.botaomulti.TabIndex = 11;
            this.botaomulti.Text = "x";
            this.botaomulti.UseVisualStyleBackColor = true;
            this.botaomulti.Click += new System.EventHandler(this.botaoMultiplicacao_Click);
            // 
            // botaoApagaTudo
            // 
            this.botaoApagaTudo.Location = new System.Drawing.Point(212, 158);
            this.botaoApagaTudo.Name = "botaoApagaTudo";
            this.botaoApagaTudo.Size = new System.Drawing.Size(43, 32);
            this.botaoApagaTudo.TabIndex = 12;
            this.botaoApagaTudo.Text = "C";
            this.botaoApagaTudo.UseVisualStyleBackColor = true;
            this.botaoApagaTudo.Click += new System.EventHandler(this.botaoApagaTudo_Click);
            // 
            // botao1
            // 
            this.botao1.Location = new System.Drawing.Point(16, 196);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(43, 32);
            this.botao1.TabIndex = 13;
            this.botao1.Text = "1";
            this.botao1.UseVisualStyleBackColor = true;
            this.botao1.Click += new System.EventHandler(this.botao1_Click);
            // 
            // botao2
            // 
            this.botao2.Location = new System.Drawing.Point(65, 196);
            this.botao2.Name = "botao2";
            this.botao2.Size = new System.Drawing.Size(43, 32);
            this.botao2.TabIndex = 14;
            this.botao2.Text = "2";
            this.botao2.UseVisualStyleBackColor = true;
            this.botao2.Click += new System.EventHandler(this.botao2_Click);
            // 
            // boato3
            // 
            this.boato3.Location = new System.Drawing.Point(114, 196);
            this.boato3.Name = "boato3";
            this.boato3.Size = new System.Drawing.Size(43, 32);
            this.boato3.TabIndex = 15;
            this.boato3.Text = "3";
            this.boato3.UseVisualStyleBackColor = true;
            this.boato3.Click += new System.EventHandler(this.boato3_Click);
            // 
            // botaosubtracao
            // 
            this.botaosubtracao.Location = new System.Drawing.Point(164, 196);
            this.botaosubtracao.Name = "botaosubtracao";
            this.botaosubtracao.Size = new System.Drawing.Size(43, 32);
            this.botaosubtracao.TabIndex = 16;
            this.botaosubtracao.Text = "-";
            this.botaosubtracao.UseVisualStyleBackColor = true;
            this.botaosubtracao.Click += new System.EventHandler(this.botaoSubtracao_Click);
            // 
            // botaoIgual
            // 
            this.botaoIgual.Location = new System.Drawing.Point(213, 196);
            this.botaoIgual.Name = "botaoIgual";
            this.botaoIgual.Size = new System.Drawing.Size(43, 70);
            this.botaoIgual.TabIndex = 17;
            this.botaoIgual.Text = "=";
            this.botaoIgual.UseVisualStyleBackColor = true;
            this.botaoIgual.Click += new System.EventHandler(this.botaoIgual_Click);
            // 
            // botaozero
            // 
            this.botaozero.Location = new System.Drawing.Point(16, 234);
            this.botaozero.Name = "botaozero";
            this.botaozero.Size = new System.Drawing.Size(92, 32);
            this.botaozero.TabIndex = 18;
            this.botaozero.Text = "0";
            this.botaozero.UseVisualStyleBackColor = true;
            this.botaozero.Click += new System.EventHandler(this.botaoZero_Click);
            // 
            // botaoponto
            // 
            this.botaoponto.Location = new System.Drawing.Point(114, 234);
            this.botaoponto.Name = "botaoponto";
            this.botaoponto.Size = new System.Drawing.Size(43, 32);
            this.botaoponto.TabIndex = 19;
            this.botaoponto.Text = ".";
            this.botaoponto.UseVisualStyleBackColor = true;
            this.botaoponto.Click += new System.EventHandler(this.botaoPonto_Click);
            // 
            // botaoadicao
            // 
            this.botaoadicao.Location = new System.Drawing.Point(164, 234);
            this.botaoadicao.Name = "botaoadicao";
            this.botaoadicao.Size = new System.Drawing.Size(43, 32);
            this.botaoadicao.TabIndex = 20;
            this.botaoadicao.Text = "+";
            this.botaoadicao.UseVisualStyleBackColor = true;
            this.botaoadicao.Click += new System.EventHandler(this.botaoAdicao_Click);
            // 
            // botaofatorial
            // 
            this.botaofatorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaofatorial.Location = new System.Drawing.Point(16, 82);
            this.botaofatorial.Name = "botaofatorial";
            this.botaofatorial.Size = new System.Drawing.Size(43, 32);
            this.botaofatorial.TabIndex = 21;
            this.botaofatorial.Text = "n!";
            this.botaofatorial.UseVisualStyleBackColor = true;
            this.botaofatorial.Click += new System.EventHandler(this.button1_Click);
            // 
            // botaoelevado2
            // 
            this.botaoelevado2.Location = new System.Drawing.Point(65, 82);
            this.botaoelevado2.Name = "botaoelevado2";
            this.botaoelevado2.Size = new System.Drawing.Size(43, 32);
            this.botaoelevado2.TabIndex = 22;
            this.botaoelevado2.Text = "x^2";
            this.botaoelevado2.UseVisualStyleBackColor = true;
            this.botaoelevado2.Click += new System.EventHandler(this.button2_Click);
            // 
            // botaosqrt
            // 
            this.botaosqrt.Location = new System.Drawing.Point(114, 82);
            this.botaosqrt.Name = "botaosqrt";
            this.botaosqrt.Size = new System.Drawing.Size(43, 32);
            this.botaosqrt.TabIndex = 23;
            this.botaosqrt.Text = "√";
            this.botaosqrt.UseVisualStyleBackColor = true;
            this.botaosqrt.Click += new System.EventHandler(this.botaosqrt_Click);
            // 
            // botao1divididoporx
            // 
            this.botao1divididoporx.Location = new System.Drawing.Point(163, 82);
            this.botao1divididoporx.Name = "botao1divididoporx";
            this.botao1divididoporx.Size = new System.Drawing.Size(43, 32);
            this.botao1divididoporx.TabIndex = 24;
            this.botao1divididoporx.Text = "1/x";
            this.botao1divididoporx.UseVisualStyleBackColor = true;
            this.botao1divididoporx.Click += new System.EventHandler(this.botao1divididoporx_Click);
            // 
            // botaopi
            // 
            this.botaopi.Font = new System.Drawing.Font("Calisto MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaopi.Location = new System.Drawing.Point(212, 82);
            this.botaopi.Name = "botaopi";
            this.botaopi.Size = new System.Drawing.Size(43, 32);
            this.botaopi.TabIndex = 25;
            this.botaopi.Text = "π";
            this.botaopi.UseVisualStyleBackColor = true;
            this.botaopi.Click += new System.EventHandler(this.botaopi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculadora.Properties.Resources.Cwgf;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 305);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 298);
            this.Controls.Add(this.botaopi);
            this.Controls.Add(this.botao1divididoporx);
            this.Controls.Add(this.botaosqrt);
            this.Controls.Add(this.botaoelevado2);
            this.Controls.Add(this.botaofatorial);
            this.Controls.Add(this.botaoadicao);
            this.Controls.Add(this.botaoponto);
            this.Controls.Add(this.botaozero);
            this.Controls.Add(this.botaoIgual);
            this.Controls.Add(this.botaosubtracao);
            this.Controls.Add(this.boato3);
            this.Controls.Add(this.botao2);
            this.Controls.Add(this.botao1);
            this.Controls.Add(this.botaoApagaTudo);
            this.Controls.Add(this.botaomulti);
            this.Controls.Add(this.botao6);
            this.Controls.Add(this.botao5);
            this.Controls.Add(this.botao4);
            this.Controls.Add(this.botaoApagar);
            this.Controls.Add(this.boatodivisao);
            this.Controls.Add(this.botao9);
            this.Controls.Add(this.botao8);
            this.Controls.Add(this.botao7);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Button botao7;
        private System.Windows.Forms.Button botao8;
        private System.Windows.Forms.Button botao9;
        private System.Windows.Forms.Button boatodivisao;
        private System.Windows.Forms.Button botaoApagar;
        private System.Windows.Forms.Button botao4;
        private System.Windows.Forms.Button botao5;
        private System.Windows.Forms.Button botao6;
        private System.Windows.Forms.Button botaomulti;
        private System.Windows.Forms.Button botaoApagaTudo;
        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.Button botao2;
        private System.Windows.Forms.Button boato3;
        private System.Windows.Forms.Button botaosubtracao;
        private System.Windows.Forms.Button botaoIgual;
        private System.Windows.Forms.Button botaozero;
        private System.Windows.Forms.Button botaoponto;
        private System.Windows.Forms.Button botaoadicao;
        private System.Windows.Forms.Button botaofatorial;
        private System.Windows.Forms.Button botaoelevado2;
        private System.Windows.Forms.Button botaosqrt;
        private System.Windows.Forms.Button botao1divididoporx;
        private System.Windows.Forms.Button botaopi;
    }
}

