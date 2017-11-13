/*
 * Created by SharpDevelop.
 * User: tgomes
 * Date: 27/10/2017
 * Time: 09:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProjetoBD
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Usuario
	{
		public static int id { get; set; } 
		public static string ra{ get; set; } 
		public static string nome{ get; set; } 
		public static string email{ get; set; } 
		public static string tipo{ get; set; } 
		public static string status{ get; set; } 
		public static string senha{ get; set; } 
		
		public static string pes{ get; set; } 
		
		/*public void pesquisa(String Sql)
		{
			Conn conn =new Conn();
			string query; 
    
	
    
    MySqlCommand cmd = new MySqlCommand(query, conn.connection);
    cmd.CommandType = CommandType.Text;

    conn.OpenConnection();
    MySqlDataReader dr= cmd.ExecuteReader();
    
    log_id= Convert.ToInt32(dr["log_id"].ToString());
	userlogin=dr["Nome"].ToString();		
	pass= Convert.ToInt32(dr["pass"].ToString());	
	
	
		}*/
	}
}

