/*
 * Created by SharpDevelop.
 * User: tgomes
 * Date: 06/11/2017
 * Time: 11:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoBD
{
	/// <summary>
	/// Description of Cad_Ativi.
	/// </summary>
	public partial class Cad_Ativi : Form
	{
		public Cad_Ativi()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
		/*	sql="insert into atividade (titulo,descricacao,quantidade_pontos,quantidade_alunos,data_inicio,datafim,id_professor,id_turma,id_disciplina) values ('"+txt_titulo.Text+"' ,'"+rtxt_desc.Text+"' ,'"+txt_qtd.Text+"','"+msk_dt_ini.Text+"','"++msk_dt_fim.Text++"');";
			
			if (conn.Insert(sql)){
			
			MessageBox.Show("Usuario cadastro com sucesso","Sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			txt_titulo.Clear();
		    rtxt_desc.Clear();
			txt_qtd.Clear();
			msk_dt_ini.Clear()
			msk_dt_fim.Clear();
			
		
			}
			else {
				MessageBox.Show("Deu errado");
				txt_titulo.Focus();
			}*/
		}
	}
}
