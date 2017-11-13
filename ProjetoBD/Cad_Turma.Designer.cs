/*
 * Created by SharpDevelop.
 * User: tgomes
 * Date: 06/11/2017
 * Time: 14:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProjetoBD
{
	partial class Cad_Turma
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_semestre = new System.Windows.Forms.TextBox();
			this.txt_periodo = new System.Windows.Forms.TextBox();
			this.txt_let_tur = new System.Windows.Forms.TextBox();
			this.btn_cad_tur = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Semestre";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Periodo";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Letra  Turma";
			// 
			// txt_semestre
			// 
			this.txt_semestre.Location = new System.Drawing.Point(78, 51);
			this.txt_semestre.Name = "txt_semestre";
			this.txt_semestre.Size = new System.Drawing.Size(66, 20);
			this.txt_semestre.TabIndex = 3;
			// 
			// txt_periodo
			// 
			this.txt_periodo.Location = new System.Drawing.Point(78, 90);
			this.txt_periodo.Name = "txt_periodo";
			this.txt_periodo.Size = new System.Drawing.Size(92, 20);
			this.txt_periodo.TabIndex = 4;
			// 
			// txt_let_tur
			// 
			this.txt_let_tur.Location = new System.Drawing.Point(78, 125);
			this.txt_let_tur.Name = "txt_let_tur";
			this.txt_let_tur.Size = new System.Drawing.Size(66, 20);
			this.txt_let_tur.TabIndex = 5;
			// 
			// btn_cad_tur
			// 
			this.btn_cad_tur.Location = new System.Drawing.Point(29, 181);
			this.btn_cad_tur.Name = "btn_cad_tur";
			this.btn_cad_tur.Size = new System.Drawing.Size(75, 23);
			this.btn_cad_tur.TabIndex = 6;
			this.btn_cad_tur.Text = "Cadastrar";
			this.btn_cad_tur.UseVisualStyleBackColor = true;
			this.btn_cad_tur.Click += new System.EventHandler(this.Btn_cad_turClick);
			// 
			// Cad_Turma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(307, 238);
			this.Controls.Add(this.btn_cad_tur);
			this.Controls.Add(this.txt_let_tur);
			this.Controls.Add(this.txt_periodo);
			this.Controls.Add(this.txt_semestre);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Cad_Turma";
			this.Text = "Cad_Turma";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btn_cad_tur;
		private System.Windows.Forms.TextBox txt_let_tur;
		private System.Windows.Forms.TextBox txt_periodo;
		private System.Windows.Forms.TextBox txt_semestre;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
