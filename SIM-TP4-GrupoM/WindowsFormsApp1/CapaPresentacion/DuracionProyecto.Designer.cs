namespace WindowsFormsApp1
{
    partial class DuracionProyecto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.txtCantidadVueltas = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gridTiempos = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTiempoMaximo = new System.Windows.Forms.TextBox();
            this.txtTiempoMinimo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPromedio45 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Vuelta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graficoLineas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.gridTiempos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoLineas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantidadVueltas
            // 
            this.txtCantidadVueltas.Location = new System.Drawing.Point(47, 61);
            this.txtCantidadVueltas.Name = "txtCantidadVueltas";
            this.txtCantidadVueltas.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadVueltas.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(153, 58);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // gridTiempos
            // 
            this.gridTiempos.AllowUserToAddRows = false;
            this.gridTiempos.AllowUserToDeleteRows = false;
            this.gridTiempos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTiempos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vuelta,
            this.A1,
            this.A2,
            this.A3,
            this.A4,
            this.A5,
            this.Final,
            this.Promedio});
            this.gridTiempos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridTiempos.Location = new System.Drawing.Point(47, 101);
            this.gridTiempos.Name = "gridTiempos";
            this.gridTiempos.Size = new System.Drawing.Size(406, 318);
            this.gridTiempos.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad de simulaciones del proyecto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tiempo Maximo";
            // 
            // txtTiempoMaximo
            // 
            this.txtTiempoMaximo.Enabled = false;
            this.txtTiempoMaximo.Location = new System.Drawing.Point(48, 482);
            this.txtTiempoMaximo.Name = "txtTiempoMaximo";
            this.txtTiempoMaximo.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoMaximo.TabIndex = 6;
            // 
            // txtTiempoMinimo
            // 
            this.txtTiempoMinimo.Enabled = false;
            this.txtTiempoMinimo.Location = new System.Drawing.Point(48, 533);
            this.txtTiempoMinimo.Name = "txtTiempoMinimo";
            this.txtTiempoMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoMinimo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 517);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tiempo Minimo";
            // 
            // txtPromedio45
            // 
            this.txtPromedio45.Enabled = false;
            this.txtPromedio45.Location = new System.Drawing.Point(229, 533);
            this.txtPromedio45.Name = "txtPromedio45";
            this.txtPromedio45.Size = new System.Drawing.Size(100, 20);
            this.txtPromedio45.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Promedio de tiempos menores a 45";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Enabled = false;
            this.txtPromedio.Location = new System.Drawing.Point(229, 482);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(100, 20);
            this.txtPromedio.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tiempo promedio";
            // 
            // Vuelta
            // 
            this.Vuelta.HeaderText = "Vuelta";
            this.Vuelta.Name = "Vuelta";
            // 
            // A1
            // 
            this.A1.HeaderText = "A1";
            this.A1.Name = "A1";
            // 
            // A2
            // 
            this.A2.HeaderText = "A2";
            this.A2.Name = "A2";
            // 
            // A3
            // 
            this.A3.HeaderText = "A3";
            this.A3.Name = "A3";
            // 
            // A4
            // 
            this.A4.HeaderText = "A4";
            this.A4.Name = "A4";
            // 
            // A5
            // 
            this.A5.HeaderText = "A5";
            this.A5.Name = "A5";
            // 
            // Final
            // 
            this.Final.HeaderText = "Final";
            this.Final.Name = "Final";
            // 
            // Promedio
            // 
            this.Promedio.HeaderText = "Promedio";
            this.Promedio.Name = "Promedio";
            // 
            // graficoLineas
            // 
            chartArea1.Name = "ChartArea1";
            this.graficoLineas.ChartAreas.Add(chartArea1);
            legend1.Name = "Promedio";
            legend1.Title = "Serie";
            this.graficoLineas.Legends.Add(legend1);
            this.graficoLineas.Location = new System.Drawing.Point(459, 101);
            this.graficoLineas.Name = "graficoLineas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Promedio";
            series1.Name = "Series1";
            this.graficoLineas.Series.Add(series1);
            this.graficoLineas.Size = new System.Drawing.Size(627, 485);
            this.graficoLineas.TabIndex = 13;
            this.graficoLineas.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Evolución de Promedio";
            this.graficoLineas.Titles.Add(title1);
            // 
            // DuracionProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 598);
            this.Controls.Add(this.graficoLineas);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPromedio45);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTiempoMinimo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTiempoMaximo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridTiempos);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtCantidadVueltas);
            this.Name = "DuracionProyecto";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridTiempos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoLineas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidadVueltas;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView gridTiempos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTiempoMaximo;
        private System.Windows.Forms.TextBox txtTiempoMinimo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPromedio45;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vuelta;
        private System.Windows.Forms.DataGridViewTextBoxColumn A1;
        private System.Windows.Forms.DataGridViewTextBoxColumn A2;
        private System.Windows.Forms.DataGridViewTextBoxColumn A3;
        private System.Windows.Forms.DataGridViewTextBoxColumn A4;
        private System.Windows.Forms.DataGridViewTextBoxColumn A5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Final;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promedio;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoLineas;
    }
}

