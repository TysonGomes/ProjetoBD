/*
 * Created by SharpDevelop.
 * User: tgomes
 * Date: 07/11/2017
 * Time: 08:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoBD
{
	/// <summary>
	/// Description of Cad_Disc.
	/// </summary>
	public partial class Cad_Disc : Form
	{
		public Cad_Disc()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Btn_cadastrarClick(object sender, EventArgs e)
		{
			Conn conn = new Conn();
			string sql;
			Conn con =new Conn();
			sql="insert into disciplina (nome) values('"+txt_disc.Text+"');";
			if (conn.Insert(sql)){
			
			MessageBox.Show("Turma cadastrada com sucesso","Sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			txt_disc.Clear();
			
			
			}

			else{
			MessageBox.Show("Deu errado =/","Deu errado =/",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			
			}
		}
	}
}
