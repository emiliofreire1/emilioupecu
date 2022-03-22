
namespace RegistroNotas.Formulario
{
	partial class FrmRegistroNotas
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.TxtNombres = new System.Windows.Forms.TextBox();
			this.TxtNota1 = new System.Windows.Forms.TextBox();
			this.TxtNota2 = new System.Windows.Forms.TextBox();
			this.TxtSuma = new System.Windows.Forms.TextBox();
			this.TxtPromedio = new System.Windows.Forms.TextBox();
			this.BtnRegistrar = new System.Windows.Forms.Button();
			this.BtnCancelar = new System.Windows.Forms.Button();
			this.RTxtNotas = new System.Windows.Forms.RichTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.TxtObservacion = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre Estudiante";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(30, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nota 1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(30, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nota 2";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(30, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Suma";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(30, 125);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Promedio";
			// 
			// TxtNombres
			// 
			this.TxtNombres.Location = new System.Drawing.Point(143, 13);
			this.TxtNombres.Name = "TxtNombres";
			this.TxtNombres.Size = new System.Drawing.Size(234, 20);
			this.TxtNombres.TabIndex = 5;
			// 
			// TxtNota1
			// 
			this.TxtNota1.Location = new System.Drawing.Point(143, 42);
			this.TxtNota1.Name = "TxtNota1";
			this.TxtNota1.Size = new System.Drawing.Size(75, 20);
			this.TxtNota1.TabIndex = 6;
			this.TxtNota1.Text = "0";
			this.TxtNota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TxtNota1.Leave += new System.EventHandler(this.TxtNota1_Leave);
			// 
			// TxtNota2
			// 
			this.TxtNota2.Location = new System.Drawing.Point(143, 68);
			this.TxtNota2.Name = "TxtNota2";
			this.TxtNota2.Size = new System.Drawing.Size(75, 20);
			this.TxtNota2.TabIndex = 7;
			this.TxtNota2.Text = "0";
			this.TxtNota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TxtNota2.Leave += new System.EventHandler(this.TxtNota2_Leave);
			// 
			// TxtSuma
			// 
			this.TxtSuma.Enabled = false;
			this.TxtSuma.Location = new System.Drawing.Point(143, 95);
			this.TxtSuma.Name = "TxtSuma";
			this.TxtSuma.Size = new System.Drawing.Size(75, 20);
			this.TxtSuma.TabIndex = 8;
			this.TxtSuma.Text = "0";
			this.TxtSuma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// TxtPromedio
			// 
			this.TxtPromedio.Enabled = false;
			this.TxtPromedio.Location = new System.Drawing.Point(143, 122);
			this.TxtPromedio.Name = "TxtPromedio";
			this.TxtPromedio.Size = new System.Drawing.Size(75, 20);
			this.TxtPromedio.TabIndex = 9;
			this.TxtPromedio.Text = "0";
			this.TxtPromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// BtnRegistrar
			// 
			this.BtnRegistrar.Location = new System.Drawing.Point(33, 180);
			this.BtnRegistrar.Name = "BtnRegistrar";
			this.BtnRegistrar.Size = new System.Drawing.Size(75, 23);
			this.BtnRegistrar.TabIndex = 10;
			this.BtnRegistrar.Text = "Registrar";
			this.BtnRegistrar.UseVisualStyleBackColor = true;
			this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
			// 
			// BtnCancelar
			// 
			this.BtnCancelar.Location = new System.Drawing.Point(143, 180);
			this.BtnCancelar.Name = "BtnCancelar";
			this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
			this.BtnCancelar.TabIndex = 11;
			this.BtnCancelar.Text = "Cancelar";
			this.BtnCancelar.UseVisualStyleBackColor = true;
			// 
			// RTxtNotas
			// 
			this.RTxtNotas.Location = new System.Drawing.Point(30, 209);
			this.RTxtNotas.Name = "RTxtNotas";
			this.RTxtNotas.Size = new System.Drawing.Size(347, 140);
			this.RTxtNotas.TabIndex = 12;
			this.RTxtNotas.Text = "";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(30, 152);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Observacion";
			// 
			// TxtObservacion
			// 
			this.TxtObservacion.Enabled = false;
			this.TxtObservacion.Location = new System.Drawing.Point(143, 149);
			this.TxtObservacion.Name = "TxtObservacion";
			this.TxtObservacion.Size = new System.Drawing.Size(100, 20);
			this.TxtObservacion.TabIndex = 14;
			// 
			// FrmRegistroNotas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 374);
			this.Controls.Add(this.TxtObservacion);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.RTxtNotas);
			this.Controls.Add(this.BtnCancelar);
			this.Controls.Add(this.BtnRegistrar);
			this.Controls.Add(this.TxtPromedio);
			this.Controls.Add(this.TxtSuma);
			this.Controls.Add(this.TxtNota2);
			this.Controls.Add(this.TxtNota1);
			this.Controls.Add(this.TxtNombres);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmRegistroNotas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registro de Notas";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TxtNombres;
		private System.Windows.Forms.TextBox TxtNota1;
		private System.Windows.Forms.TextBox TxtNota2;
		private System.Windows.Forms.TextBox TxtSuma;
		private System.Windows.Forms.TextBox TxtPromedio;
		private System.Windows.Forms.Button BtnRegistrar;
		private System.Windows.Forms.Button BtnCancelar;
		private System.Windows.Forms.RichTextBox RTxtNotas;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TxtObservacion;
	}
}