/*
 * Created by SharpDevelop.
 * User: tgomes
 * Date: 06/11/2017
 * Time: 11:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProjetoBD
{
	partial class Cad_Ativi
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txt_titulo = new System.Windows.Forms.TextBox();
			this.rtxt_desc = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_valor = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.msk_dt_ini = new System.Windows.Forms.MaskedTextBox();
			this.msk_dt_fim = new System.Windows.Forms.MaskedTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_qtd = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(22, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Titulo";
			// 
			// txt_titulo
			// 
			this.txt_titulo.Location = new System.Drawing.Point(64, 10);
			this.txt_titulo.Name = "txt_titulo";
			this.txt_titulo.Size = new System.Drawing.Size(187, 20);
			this.txt_titulo.TabIndex = 1;
			// 
			// rtxt_desc
			// 
			this.rtxt_desc.Location = new System.Drawing.Point(22, 99);
			this.rtxt_desc.Name = "rtxt_desc";
			this.rtxt_desc.Size = new System.Drawing.Size(211, 80);
			this.rtxt_desc.TabIndex = 2;
			this.rtxt_desc.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(22, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Descrição :";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(333, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Valor ";
			// 
			// txt_valor
			// 
			this.txt_valor.Location = new System.Drawing.Point(406, 73);
			this.txt_valor.Name = "txt_valor";
			this.txt_valor.Size = new System.Drawing.Size(62, 20);
			this.txt_valor.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(323, 115);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "data de inicio";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(323, 156);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "data  termino";
			// 
			// msk_dt_ini
			// 
			this.msk_dt_ini.Location = new System.Drawing.Point(406, 112);
			this.msk_dt_ini.Mask = "00/00/0000";
			this.msk_dt_ini.Name = "msk_dt_ini";
			this.msk_dt_ini.Size = new System.Drawing.Size(62, 20);
			this.msk_dt_ini.TabIndex = 8;
			this.msk_dt_ini.ValidatingType = typeof(System.DateTime);
			// 
			// msk_dt_fim
			// 
			this.msk_dt_fim.Location = new System.Drawing.Point(406, 153);
			this.msk_dt_fim.Mask = "00/00/0000";
			this.msk_dt_fim.Name = "msk_dt_fim";
			this.msk_dt_fim.Size = new System.Drawing.Size(62, 20);
			this.msk_dt_fim.TabIndex = 9;
			this.msk_dt_fim.ValidatingType = typeof(System.DateTime);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(22, 239);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "Cadastrar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(22, 192);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Qtde de Aluno";
			// 
			// txt_qtd
			// 
			this.txt_qtd.Location = new System.Drawing.Point(99, 189);
			this.txt_qtd.Name = "txt_qtd";
			this.txt_qtd.Size = new System.Drawing.Size(100, 20);
			this.txt_qtd.TabIndex = 12;
			// 
			// Cad_Ativi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(483, 291);
			this.Controls.Add(this.txt_qtd);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.msk_dt_fim);
			this.Controls.Add(this.msk_dt_ini);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_valor);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.rtxt_desc);
			this.Controls.Add(this.txt_titulo);
			this.Controls.Add(this.label1);
			this.Name = "Cad_Ativi";
			this.Text = "Cad_Ativi";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txt_qtd;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MaskedTextBox msk_dt_fim;
		private System.Windows.Forms.MaskedTextBox msk_dt_ini;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_valor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox rtxt_desc;
		private System.Windows.Forms.TextBox txt_titulo;
		private System.Windows.Forms.Label label1;
	}
}
