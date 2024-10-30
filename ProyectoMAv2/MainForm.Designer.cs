/*
 * Created by SharpDevelop.
 * User: CC2_PC34
 * Date: 30/10/2024
 * Time: 08:04 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoMAv2
{
	partial class MainForm
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
			this.Lblmaterias = new System.Windows.Forms.Label();
			this.Btnmateria2 = new System.Windows.Forms.Button();
			this.Btnmateria1 = new System.Windows.Forms.Button();
			this.Btnfisica = new System.Windows.Forms.Button();
			this.Btningles = new System.Windows.Forms.Button();
			this.Btnmatematicas = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Lblmaterias
			// 
			this.Lblmaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lblmaterias.Location = new System.Drawing.Point(117, 22);
			this.Lblmaterias.Name = "Lblmaterias";
			this.Lblmaterias.Size = new System.Drawing.Size(82, 24);
			this.Lblmaterias.TabIndex = 11;
			this.Lblmaterias.Text = "Materias";
			// 
			// Btnmateria2
			// 
			this.Btnmateria2.Location = new System.Drawing.Point(112, 242);
			this.Btnmateria2.Name = "Btnmateria2";
			this.Btnmateria2.Size = new System.Drawing.Size(87, 39);
			this.Btnmateria2.TabIndex = 10;
			this.Btnmateria2.Text = "Humanidades";
			this.Btnmateria2.UseVisualStyleBackColor = true;
			this.Btnmateria2.Click += new System.EventHandler(this.Btnmateria2Click);
			// 
			// Btnmateria1
			// 
			this.Btnmateria1.Location = new System.Drawing.Point(112, 198);
			this.Btnmateria1.Name = "Btnmateria1";
			this.Btnmateria1.Size = new System.Drawing.Size(87, 39);
			this.Btnmateria1.TabIndex = 9;
			this.Btnmateria1.Text = "Artes";
			this.Btnmateria1.UseVisualStyleBackColor = true;
			this.Btnmateria1.Click += new System.EventHandler(this.Btnmateria1Click);
			// 
			// Btnfisica
			// 
			this.Btnfisica.Location = new System.Drawing.Point(112, 154);
			this.Btnfisica.Name = "Btnfisica";
			this.Btnfisica.Size = new System.Drawing.Size(87, 39);
			this.Btnfisica.TabIndex = 8;
			this.Btnfisica.Text = "Fisica";
			this.Btnfisica.UseVisualStyleBackColor = true;
			this.Btnfisica.Click += new System.EventHandler(this.BtnfisicaClick);
			// 
			// Btningles
			// 
			this.Btningles.Location = new System.Drawing.Point(112, 110);
			this.Btningles.Name = "Btningles";
			this.Btningles.Size = new System.Drawing.Size(87, 39);
			this.Btningles.TabIndex = 7;
			this.Btningles.Text = "Ingles";
			this.Btningles.UseVisualStyleBackColor = true;
			this.Btningles.Click += new System.EventHandler(this.BtninglesClick);
			// 
			// Btnmatematicas
			// 
			this.Btnmatematicas.Location = new System.Drawing.Point(112, 66);
			this.Btnmatematicas.Name = "Btnmatematicas";
			this.Btnmatematicas.Size = new System.Drawing.Size(87, 39);
			this.Btnmatematicas.TabIndex = 6;
			this.Btnmatematicas.Text = "Matematicas";
			this.Btnmatematicas.UseVisualStyleBackColor = true;
			this.Btnmatematicas.Click += new System.EventHandler(this.BtnmatematicasClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(305, 358);
			this.Controls.Add(this.Lblmaterias);
			this.Controls.Add(this.Btnmateria2);
			this.Controls.Add(this.Btnmateria1);
			this.Controls.Add(this.Btnfisica);
			this.Controls.Add(this.Btningles);
			this.Controls.Add(this.Btnmatematicas);
			this.Name = "MainForm";
			this.Text = "ProyectoMAv2";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button Btnmatematicas;
		private System.Windows.Forms.Button Btningles;
		private System.Windows.Forms.Button Btnfisica;
		private System.Windows.Forms.Button Btnmateria1;
		private System.Windows.Forms.Button Btnmateria2;
		private System.Windows.Forms.Label Lblmaterias;
	}
}
