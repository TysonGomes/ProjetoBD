/*
 * Created by SharpDevelop.
 * User: tgomes
 * Date: 08/11/2017
 * Time: 07:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProjetoBD
{
	partial class Pes_Disc
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
			this.dt_gr_vw_todos = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_pes = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dt_gr_vw_todos)).BeginInit();
			this.SuspendLayout();
			// 
			// dt_gr_vw_todos
			// 
			this.dt_gr_vw_todos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dt_gr_vw_todos.Location = new System.Drawing.Point(34, 39);
			this.dt_gr_vw_todos.Name = "dt_gr_vw_todos";
			this.dt_gr_vw_todos.Size = new System.Drawing.Size(278, 119);
			this.dt_gr_vw_todos.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(34, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Disciplina";
			// 
			// btn_pes
			// 
			this.btn_pes.Location = new System.Drawing.Point(353, 134);
			this.btn_pes.Name = "btn_pes";
			this.btn_pes.Size = new System.Drawing.Size(75, 23);
			this.btn_pes.TabIndex = 2;
			this.btn_pes.Text = "Pesquisar";
			this.btn_pes.UseVisualStyleBackColor = true;
			this.btn_pes.Click += new System.EventHandler(this.Btn_pesClick);
			// 
			// Pes_Disc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(486, 222);
			this.Controls.Add(this.btn_pes);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dt_gr_vw_todos);
			this.Name = "Pes_Disc";
			this.Text = "Pes_Disc";
			((System.ComponentModel.ISupportInitialize)(this.dt_gr_vw_todos)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btn_pes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dt_gr_vw_todos;
	}
}
