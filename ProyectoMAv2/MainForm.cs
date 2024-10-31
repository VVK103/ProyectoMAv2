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
			Matematicas Matematicas = new Matematicas();
			Matematicas.Show();
		}
		
		void BtninglesClick(object sender, EventArgs e)
		{
			Ingles Ingles = new Ingles();
			Ingles.Show();
		}
		
		void BtnfisicaClick(object sender, EventArgs e)
		{
			Fisica Fisica = new Fisica();
			Fisica.Show();
		}
		
		void Btnmateria1Click(object sender, EventArgs e)
		{
			c c = new c();
			c.Show();
		}
		
		void Btnmateria2Click(object sender, EventArgs e)
		{
			humanidades humanidades = new humanidades();
			humanidades.Show();
		}
	}
}
