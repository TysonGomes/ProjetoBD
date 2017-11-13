/*
 * Created by SharpDevelop.
 * User: tgomes
 * Date: 08/11/2017
 * Time: 08:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProjetoBD
{
	partial class Pes_Ativi
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
			this.btn_pesquisa = new System.Windows.Forms.Button();
			this.dt_gr_vw_todos = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dt_gr_vw_todos)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_pesquisa
			// 
			this.btn_pesquisa.Location = new System.Drawing.Point(389, 209);
			this.btn_pesquisa.Name = "btn_pesquisa";
			this.btn_pesquisa.Size = new System.Drawing.Size(75, 23);
			this.btn_pesquisa.TabIndex = 0;
			this.btn_pesquisa.Text = "Pesquisa";
			this.btn_pesquisa.UseVisualStyleBackColor = true;
			this.btn_pesquisa.Click += new System.EventHandler(this.Btn_pesquisaClick);
			// 
			// dt_gr_vw_todos
			// 
			this.dt_gr_vw_todos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dt_gr_vw_todos.Location = new System.Drawing.Point(12, 47);
			this.dt_gr_vw_todos.Name = "dt_gr_vw_todos";
			this.dt_gr_vw_todos.Size = new System.Drawing.Size(359, 151);
			this.dt_gr_vw_todos.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(25, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Atividades";
			// 
			// Pes_Ativi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(491, 266);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dt_gr_vw_todos);
			this.Controls.Add(this.btn_pesquisa);
			this.Name = "Pes_Ativi";
			this.Text = "Pes_Ativi";
			((System.ComponentModel.ISupportInitialize)(this.dt_gr_vw_todos)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dt_gr_vw_todos;
		private System.Windows.Forms.Button btn_pesquisa;
	}
}
