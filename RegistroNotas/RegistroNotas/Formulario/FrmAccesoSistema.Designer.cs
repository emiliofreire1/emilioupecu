
namespace RegistroNotas.Formulario
{
	partial class FrmAccesoSistema
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccesoSistema));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtClave = new System.Windows.Forms.TextBox();
			this.BtnIngreso = new System.Windows.Forms.Button();
			this.BtnCancelar = new System.Windows.Forms.Button();
			this.MskCI = new System.Windows.Forms.MaskedTextBox();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "No Cédula";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Clave";
			// 
			// TxtClave
			// 
			this.TxtClave.Location = new System.Drawing.Point(83, 47);
			this.TxtClave.Name = "TxtClave";
			this.TxtClave.PasswordChar = '*';
			this.TxtClave.Size = new System.Drawing.Size(100, 20);
			this.TxtClave.TabIndex = 3;
			this.TxtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// BtnIngreso
			// 
			this.BtnIngreso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BtnIngreso.ImageIndex = 5;
			this.BtnIngreso.ImageList = this.imageList1;
			this.BtnIngreso.Location = new System.Drawing.Point(19, 81);
			this.BtnIngreso.Name = "BtnIngreso";
			this.BtnIngreso.Size = new System.Drawing.Size(75, 49);
			this.BtnIngreso.TabIndex = 4;
			this.BtnIngreso.Text = "Ingreso";
			this.BtnIngreso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.BtnIngreso.UseVisualStyleBackColor = true;
			this.BtnIngreso.Click += new System.EventHandler(this.BtnIngreso_Click);
			// 
			// BtnCancelar
			// 
			this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BtnCancelar.ImageIndex = 2;
			this.BtnCancelar.ImageList = this.imageList1;
			this.BtnCancelar.Location = new System.Drawing.Point(108, 81);
			this.BtnCancelar.Name = "BtnCancelar";
			this.BtnCancelar.Size = new System.Drawing.Size(75, 49);
			this.BtnCancelar.TabIndex = 5;
			this.BtnCancelar.Text = "Cancelar";
			this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.BtnCancelar.UseVisualStyleBackColor = true;
			this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
			// 
			// MskCI
			// 
			this.MskCI.Location = new System.Drawing.Point(83, 15);
			this.MskCI.Mask = "##########";
			this.MskCI.Name = "MskCI";
			this.MskCI.Size = new System.Drawing.Size(100, 20);
			this.MskCI.TabIndex = 1;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "3floppy3_mount.ico");
			this.imageList1.Images.SetKeyName(1, "#DOC29B.ICO");
			this.imageList1.Images.SetKeyName(2, "50.ico");
			this.imageList1.Images.SetKeyName(3, "28.ICO");
			this.imageList1.Images.SetKeyName(4, "kappfinder.ico");
			this.imageList1.Images.SetKeyName(5, "1441532841_accept-database.ico");
			// 
			// FrmAccesoSistema
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(208, 142);
			this.Controls.Add(this.MskCI);
			this.Controls.Add(this.BtnCancelar);
			this.Controls.Add(this.BtnIngreso);
			this.Controls.Add(this.TxtClave);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmAccesoSistema";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Acceso al Sistema";
			this.Load += new System.EventHandler(this.FrmAccesoSistema_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtClave;
		private System.Windows.Forms.Button BtnIngreso;
		private System.Windows.Forms.Button BtnCancelar;
		private System.Windows.Forms.MaskedTextBox MskCI;
		private System.Windows.Forms.ImageList imageList1;
	}
}