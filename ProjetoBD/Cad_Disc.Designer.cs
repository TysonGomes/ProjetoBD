/*
 * Created by SharpDevelop.
 * User: tgomes
 * Date: 07/11/2017
 * Time: 08:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProjetoBD
{
	partial class Cad_Disc
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
			this.txt_disc = new System.Windows.Forms.TextBox();
			this.btn_cadastrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(22, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome da Disciplina";
			// 
			// txt_disc
			// 
			this.txt_disc.Location = new System.Drawing.Point(128, 37);
			this.txt_disc.Name = "txt_disc";
			this.txt_disc.Size = new System.Drawing.Size(127, 20);
			this.txt_disc.TabIndex = 1;
			// 
			// btn_cadastrar
			// 
			this.btn_cadastrar.Location = new System.Drawing.Point(22, 90);
			this.btn_cadastrar.Name = "btn_cadastrar";
			this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
			this.btn_cadastrar.TabIndex = 2;
			this.btn_cadastrar.Text = "Cadastrar";
			this.btn_cadastrar.UseVisualStyleBackColor = true;
			this.btn_cadastrar.Click += new System.EventHandler(this.Btn_cadastrarClick);
			// 
			// Cad_Disc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(397, 139);
			this.Controls.Add(this.btn_cadastrar);
			this.Controls.Add(this.txt_disc);
			this.Controls.Add(this.label1);
			this.Name = "Cad_Disc";
			this.Text = "Cad_Disc";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btn_cadastrar;
		private System.Windows.Forms.TextBox txt_disc;
		private System.Windows.Forms.Label label1;
	}
}
