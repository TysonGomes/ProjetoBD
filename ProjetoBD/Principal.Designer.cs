/*
 * Created by SharpDevelop.
 * User: tgomes
 * Date: 31/10/2017
 * Time: 09:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProjetoBD
{
	partial class Principal
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
			this.mn_strip_pri = new System.Windows.Forms.MenuStrip();
			this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usr_tl_st_mn_it = new System.Windows.Forms.ToolStripMenuItem();
			this.ativ_tl_st_mn_it = new System.Windows.Forms.ToolStripMenuItem();
			this.dis_tl_st_mn_it = new System.Windows.Forms.ToolStripMenuItem();
			this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alunoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.turmaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.atividade2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.disciplina2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.turmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mn_strip_pri.SuspendLayout();
			this.SuspendLayout();
			// 
			// mn_strip_pri
			// 
			this.mn_strip_pri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cadastroToolStripMenuItem,
									this.consultaToolStripMenuItem});
			this.mn_strip_pri.Location = new System.Drawing.Point(0, 0);
			this.mn_strip_pri.Name = "mn_strip_pri";
			this.mn_strip_pri.Size = new System.Drawing.Size(673, 24);
			this.mn_strip_pri.TabIndex = 0;
			this.mn_strip_pri.Text = "menuStrip1";
			this.mn_strip_pri.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Mn_strip_priItemClicked);
			// 
			// cadastroToolStripMenuItem
			// 
			this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.usr_tl_st_mn_it,
									this.turmaToolStripMenuItem,
									this.ativ_tl_st_mn_it,
									this.dis_tl_st_mn_it});
			this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
			this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.cadastroToolStripMenuItem.Text = "Cadastro";
			this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.CadastroToolStripMenuItemClick);
			// 
			// usr_tl_st_mn_it
			// 
			this.usr_tl_st_mn_it.Name = "usr_tl_st_mn_it";
			this.usr_tl_st_mn_it.Size = new System.Drawing.Size(152, 22);
			this.usr_tl_st_mn_it.Text = "Usuario";
			this.usr_tl_st_mn_it.Click += new System.EventHandler(this.AlunoToolStripMenuItemClick);
			// 
			// ativ_tl_st_mn_it
			// 
			this.ativ_tl_st_mn_it.Name = "ativ_tl_st_mn_it";
			this.ativ_tl_st_mn_it.Size = new System.Drawing.Size(152, 22);
			this.ativ_tl_st_mn_it.Text = "Atividade";
			this.ativ_tl_st_mn_it.Click += new System.EventHandler(this.AtividadeToolStripMenuItemClick);
			// 
			// dis_tl_st_mn_it
			// 
			this.dis_tl_st_mn_it.Name = "dis_tl_st_mn_it";
			this.dis_tl_st_mn_it.Size = new System.Drawing.Size(152, 22);
			this.dis_tl_st_mn_it.Text = "Disciplina";
			this.dis_tl_st_mn_it.Click += new System.EventHandler(this.DisciplinaToolStripMenuItemClick);
			// 
			// consultaToolStripMenuItem
			// 
			this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.alunoToolStripMenuItem1,
									this.turmaToolStripMenuItem1,
									this.atividade2ToolStripMenuItem1,
									this.disciplina2ToolStripMenuItem});
			this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
			this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.consultaToolStripMenuItem.Text = "Consulta";
			// 
			// alunoToolStripMenuItem1
			// 
			this.alunoToolStripMenuItem1.Name = "alunoToolStripMenuItem1";
			this.alunoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.alunoToolStripMenuItem1.Text = "Usuario";
			this.alunoToolStripMenuItem1.Click += new System.EventHandler(this.AlunoToolStripMenuItem1Click);
			// 
			// turmaToolStripMenuItem1
			// 
			this.turmaToolStripMenuItem1.Name = "turmaToolStripMenuItem1";
			this.turmaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.turmaToolStripMenuItem1.Text = "Turma";
			this.turmaToolStripMenuItem1.Click += new System.EventHandler(this.ProfessorToolStripMenuItem1Click);
			// 
			// atividade2ToolStripMenuItem1
			// 
			this.atividade2ToolStripMenuItem1.Name = "atividade2ToolStripMenuItem1";
			this.atividade2ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.atividade2ToolStripMenuItem1.Text = "Atividade";
			this.atividade2ToolStripMenuItem1.Click += new System.EventHandler(this.Atividade2ToolStripMenuItem1Click);
			// 
			// disciplina2ToolStripMenuItem
			// 
			this.disciplina2ToolStripMenuItem.Name = "disciplina2ToolStripMenuItem";
			this.disciplina2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.disciplina2ToolStripMenuItem.Text = "Disciplina";
			this.disciplina2ToolStripMenuItem.Click += new System.EventHandler(this.Disciplina2ToolStripMenuItemClick);
			// 
			// turmaToolStripMenuItem
			// 
			this.turmaToolStripMenuItem.Name = "turmaToolStripMenuItem";
			this.turmaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.turmaToolStripMenuItem.Text = "Turma";
			this.turmaToolStripMenuItem.Click += new System.EventHandler(this.TurmaToolStripMenuItemClick);
			// 
			// Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(673, 287);
			this.Controls.Add(this.mn_strip_pri);
			this.MainMenuStrip = this.mn_strip_pri;
			this.Name = "Principal";
			this.Text = "Principal";
			this.Load += new System.EventHandler(this.PrincipalLoad);
			this.mn_strip_pri.ResumeLayout(false);
			this.mn_strip_pri.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem disciplina2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dis_tl_st_mn_it;
		private System.Windows.Forms.ToolStripMenuItem atividade2ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ativ_tl_st_mn_it;
		private System.Windows.Forms.ToolStripMenuItem usr_tl_st_mn_it;
		private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
		private System.Windows.Forms.MenuStrip mn_strip_pri;
		
		
		
		void Mn_strip_priItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
		{
			
		}
		
		
		
		
	}
}
