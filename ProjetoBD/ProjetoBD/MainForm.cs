/*
 * Created by SharpDevelop.
 * User: tgomes
 * Date: 30/10/2017
 * Time: 15:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoBD
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Txt_senhaTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Btn_loginClick(object sender, EventArgs e)
		{
			string sql;
			Conn conn = new Conn();
			 	sql="SELECT * FROM usuario where nome ='"+txt_usuario.Text+"' and senha='"+txt_senha.Text+"';";
                conn.pesquisa(sql);	
                			
 			 if (conn.Login (sql)){
				
				MessageBox.Show("Bem Vindo "+txt_usuario.Text);	
			
				Principal P = new Principal();
                P.ShowDialog();
                
                   MainForm M = new MainForm();
                	M.Width=695;
                	M.Height=330;
                	M.Hide();
                	
			}
			
			else {
				MessageBox.Show("Deu errado");
			}
		}
	}
}
