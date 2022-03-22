
namespace RegistroNotas.Formulario
{
	partial class FrmGraficos
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.button1 = new System.Windows.Forms.Button();
			this.DgvNotas = new System.Windows.Forms.DataGridView();
			this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button2 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvNotas)).BeginInit();
			this.SuspendLayout();
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(412, 38);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(372, 361);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Seleccionar Archivo";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// DgvNotas
			// 
			this.DgvNotas.AllowUserToAddRows = false;
			this.DgvNotas.AllowUserToDeleteRows = false;
			this.DgvNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.DgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombres,
            this.Nota1,
            this.Nota2,
            this.Promedio});
			this.DgvNotas.Location = new System.Drawing.Point(12, 48);
			this.DgvNotas.Name = "DgvNotas";
			this.DgvNotas.ReadOnly = true;
			this.DgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DgvNotas.Size = new System.Drawing.Size(378, 351);
			this.DgvNotas.TabIndex = 5;
			// 
			// Nombres
			// 
			this.Nombres.HeaderText = "Nombres";
			this.Nombres.Name = "Nombres";
			this.Nombres.ReadOnly = true;
			this.Nombres.Width = 74;
			// 
			// Nota1
			// 
			this.Nota1.HeaderText = "Nota1";
			this.Nota1.Name = "Nota1";
			this.Nota1.ReadOnly = true;
			this.Nota1.Width = 61;
			// 
			// Nota2
			// 
			this.Nota2.HeaderText = "Nota2";
			this.Nota2.Name = "Nota2";
			this.Nota2.ReadOnly = true;
			this.Nota2.Width = 61;
			// 
			// Promedio
			// 
			this.Promedio.HeaderText = "Promedio";
			this.Promedio.Name = "Promedio";
			this.Promedio.ReadOnly = true;
			this.Promedio.Width = 76;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(412, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(107, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "Graficar Datos";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// FrmGraficos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.DgvNotas);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.chart1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmGraficos";
			this.Text = "Graficos de Notas";
			this.Load += new System.EventHandler(this.FrmGraficos_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvNotas)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView DgvNotas;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nota1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nota2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Promedio;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}