/*
 * Created by SharpDevelop.
 * User: tgomes
 * Date: 31/10/2017
 * Time: 16:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProjetoBD
{
	partial class Pes_usuario
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
			((System.ComponentModel.ISupportInitialize)(this.dt_gr_vw_todos)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_pesquisa
			// 
			this.btn_pesquisa.Location = new System.Drawing.Point(394, 212);
			this.btn_pesquisa.Name = "btn_pesquisa";
			this.btn_pesquisa.Size = new System.Drawing.Size(75, 23);
			this.btn_pesquisa.TabIndex = 1;
			this.btn_pesquisa.Text = "Pesquisar";
			this.btn_pesquisa.UseVisualStyleBackColor = true;
			this.btn_pesquisa.Click += new System.EventHandler(this.Btn_pesquisaClick);
			// 
			// dt_gr_vw_todos
			// 
			this.dt_gr_vw_todos.AllowUserToAddRows = false;
			this.dt_gr_vw_todos.AllowUserToDeleteRows = false;
			this.dt_gr_vw_todos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dt_gr_vw_todos.Location = new System.Drawing.Point(12, 21);
			this.dt_gr_vw_todos.Name = "dt_gr_vw_todos";
			this.dt_gr_vw_todos.ReadOnly = true;
			this.dt_gr_vw_todos.Size = new System.Drawing.Size(457, 152);
			this.dt_gr_vw_todos.TabIndex = 0;
			this.dt_gr_vw_todos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dt_gr_vw_todosCellContentClick);
			// 
			// Pes_usuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 265);
			this.Controls.Add(this.dt_gr_vw_todos);
			this.Controls.Add(this.btn_pesquisa);
			this.Name = "Pes_usuario";
			this.Text = "Pes_usuario";
			((System.ComponentModel.ISupportInitialize)(this.dt_gr_vw_todos)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView dt_gr_vw_todos;
		private System.Windows.Forms.Button btn_pesquisa;
		
		
		
		
		
		/*void Dt_gr_vw_todosCellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
		Conn conn = new Conn();
			int linha = 0;
            string sql;
            string id;
            
            
            linha = dt_gr_vw_todos.CurrentRow.Index;
            id = dt_gr_vw_todos.Rows[linha].Cells[0].Value.ToString();
            sql= "SELECT * FROM usuario where id="+id+";";
            conn.pesquisa(sql);
            Usuario.pes="ativo";
            Cad_usuario CA =new Cad_usuario();
            CA.ShowDialog();
		}*/
	}
}
