/*
 * Created by SharpDevelop.
 * User: CC2_PC34
 * Date: 30/10/2024
 * Time: 08:04 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoMAv2
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
		
		void BtnmatematicasClick(object sender, EventArgs e)
		{
			matematicas matematicas = new matematicas();
			matematicas.Show();
		}
		
		void BtninglesClick(object sender, EventArgs e)
		{
			ingles ingles = new ingles();
			ingles.Show();
		}
		
		void BtnfisicaClick(object sender, EventArgs e)
		{
			fisica fisica = new fisica();
			fisica.Show();
		}
		
		void Btnmateria1Click(object sender, EventArgs e)
		{
			artes artes = new artes();
			artes.Show();
		}
		
		void Btnmateria2Click(object sender, EventArgs e)
		{
			Humanidades Humanidades = new Humanidades();
			Humanidades.Show();
		}
	}
}
