/*
 * Created by SharpDevelop.
 * User: tgomes
 * Date: 31/10/2017
 * Time: 09:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoBD
{
	/// <summary>
	/// Description of Principal.
	/// </summary>
	public partial class Principal : Form
	{
		public Principal()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
				//string tipo;
           //tipo = Usuario.tipo;
			
			//if (tipo == "aluno"){		
			//this.cadastroToolStripMenuItem.Visible = false;
           //}
			
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		
		void CadastroToolStripMenuItemClick(object sender, EventArgs e)
		{
		
		}
		
		void AlunoToolStripMenuItemClick(object sender, EventArgs e)
		{
		
			Cad_usuario CA =new Cad_usuario();
			CA.ShowDialog();
		
		}
		
		void AlunoToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Pes_usuario PU = new Pes_usuario();
			PU.ShowDialog();
		}
		
		void AtividadeToolStripMenuItemClick(object sender, EventArgs e)
		{
			Cad_Ativi CA = new Cad_Ativi();
			CA.ShowDialog();
		}
		
		void DisciplinaToolStripMenuItemClick(object sender, EventArgs e)
		{
			Cad_Disc CD = new Cad_Disc();
			CD.ShowDialog();
		}
		
		
		void ProfessorToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Pes_Turma PT = new Pes_Turma();
			PT.ShowDialog();
		}
		
		void Atividade2ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Pes_Ativi PA = new Pes_Ativi();
			PA.ShowDialog();
		}
		void Disciplina2ToolStripMenuItemClick(object sender, EventArgs e)
		{
			Pes_Disc PD = new Pes_Disc();
			PD.ShowDialog();
		}
		void TurmaToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			Cad_Turma CT = new Cad_Turma();
			CT.ShowDialog();
		}
		
		void PrincipalLoad(object sender, EventArgs e)
		{
			
			
			string tipo;
           tipo = Usuario.tipo;
			
			if (tipo == "aluno"){	
			this.cadastroToolStripMenuItem.Visible = false;
           }}
	}
}
