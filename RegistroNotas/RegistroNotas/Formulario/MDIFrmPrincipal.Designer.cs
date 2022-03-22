
namespace RegistroNotas.Formulario
{
	partial class MDIFrmPrincipal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIFrmPrincipal));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.lenguajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.españolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inglesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registroDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registroNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.graficarNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.registroUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registroUsuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.accesoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lenguajeToolStripMenuItem,
            this.sistemaToolStripMenuItem,
            this.registroDeNotasToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// lenguajeToolStripMenuItem
			// 
			this.lenguajeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.españolToolStripMenuItem,
            this.inglesToolStripMenuItem});
			this.lenguajeToolStripMenuItem.Name = "lenguajeToolStripMenuItem";
			this.lenguajeToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.lenguajeToolStripMenuItem.Text = "Lenguaje";
			// 
			// españolToolStripMenuItem
			// 
			this.españolToolStripMenuItem.Name = "españolToolStripMenuItem";
			this.españolToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
			this.españolToolStripMenuItem.Text = "Español";
			this.españolToolStripMenuItem.Click += new System.EventHandler(this.españolToolStripMenuItem_Click);
			// 
			// inglesToolStripMenuItem
			// 
			this.inglesToolStripMenuItem.Name = "inglesToolStripMenuItem";
			this.inglesToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
			this.inglesToolStripMenuItem.Text = "Ingles";
			this.inglesToolStripMenuItem.Click += new System.EventHandler(this.inglesToolStripMenuItem_Click);
			// 
			// sistemaToolStripMenuItem
			// 
			this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroUsuariosToolStripMenuItem,
            this.registroUsuariosToolStripMenuItem1,
            this.accesoSistemaToolStripMenuItem,
            this.salirToolStripMenuItem});
			this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
			this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.sistemaToolStripMenuItem.Text = "Sistema";
			// 
			// registroDeNotasToolStripMenuItem
			// 
			this.registroDeNotasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroNotasToolStripMenuItem,
            this.graficarNotasToolStripMenuItem});
			this.registroDeNotasToolStripMenuItem.Enabled = false;
			this.registroDeNotasToolStripMenuItem.Name = "registroDeNotasToolStripMenuItem";
			this.registroDeNotasToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
			this.registroDeNotasToolStripMenuItem.Text = "Registro de Notas";
			// 
			// registroNotasToolStripMenuItem
			// 
			this.registroNotasToolStripMenuItem.Name = "registroNotasToolStripMenuItem";
			this.registroNotasToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.registroNotasToolStripMenuItem.Text = "Registro Notas";
			this.registroNotasToolStripMenuItem.Click += new System.EventHandler(this.registroNotasToolStripMenuItem_Click);
			// 
			// graficarNotasToolStripMenuItem
			// 
			this.graficarNotasToolStripMenuItem.Name = "graficarNotasToolStripMenuItem";
			this.graficarNotasToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.graficarNotasToolStripMenuItem.Text = "Graficar Notas";
			this.graficarNotasToolStripMenuItem.Click += new System.EventHandler(this.graficarNotasToolStripMenuItem_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
			this.imageList1.Images.SetKeyName(5, "112.ICO");
			// 
			// registroUsuariosToolStripMenuItem
			// 
			this.registroUsuariosToolStripMenuItem.Name = "registroUsuariosToolStripMenuItem";
			this.registroUsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.registroUsuariosToolStripMenuItem.Text = "Registro Usuarios";
			// 
			// registroUsuariosToolStripMenuItem1
			// 
			this.registroUsuariosToolStripMenuItem1.Name = "registroUsuariosToolStripMenuItem1";
			this.registroUsuariosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.registroUsuariosToolStripMenuItem1.Text = "Registro Usuarios";
			this.registroUsuariosToolStripMenuItem1.Click += new System.EventHandler(this.registroUsuariosToolStripMenuItem1_Click);
			// 
			// accesoSistemaToolStripMenuItem
			// 
			this.accesoSistemaToolStripMenuItem.Image = global::RegistroNotas.Properties.Resources.users_accept;
			this.accesoSistemaToolStripMenuItem.Name = "accesoSistemaToolStripMenuItem";
			this.accesoSistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.accesoSistemaToolStripMenuItem.Text = "Acceso Sistema";
			this.accesoSistemaToolStripMenuItem.Click += new System.EventHandler(this.accesoSistemaToolStripMenuItem_Click);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Image = global::RegistroNotas.Properties.Resources.shutdown_32;
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
			// 
			// MDIFrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MDIFrmPrincipal";
			this.Text = "Registro de Notas UPS";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Activated += new System.EventHandler(this.MDIFrmPrincipal_Activated);
			this.Load += new System.EventHandler(this.MDIFrmPrincipal_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem accesoSistemaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registroDeNotasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registroNotasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lenguajeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem españolToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inglesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem graficarNotasToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolStripMenuItem registroUsuariosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registroUsuariosToolStripMenuItem1;
	}
}