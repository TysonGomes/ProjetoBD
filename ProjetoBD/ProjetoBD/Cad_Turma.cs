/*
 * Created by SharpDevelop.
 * User: tgomes
 * Date: 06/11/2017
 * Time: 14:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoBD
{
	/// <summary>
	/// Description of Cad_Turma.
	/// </summary>
	public partial class Cad_Turma : Form
	{
		public Cad_Turma()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Btn_cad_turClick(object sender, EventArgs e)
		{
			Conn conn = new Conn();
			string sql;
			Conn con =new Conn();
			sql="insert into turma (semestre,periodo,letra_turma) values('"+txt_semestre.Text+"' ,'"+txt_periodo.Text+"' ,'"+txt_let_tur.Text+"');";
			if (conn.Insert(sql)){
			
			MessageBox.Show("Turma cadastrada com sucesso","Sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			txt_semestre.Clear();
			txt_periodo.Clear();
			txt_let_tur.Clear();
			
			}

			else{
			MessageBox.Show("Deu errado =/","Deu errado =/",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			
			}

			
		}
	}
	}
