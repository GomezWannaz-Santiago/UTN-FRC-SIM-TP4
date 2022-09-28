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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuracionProyecto));
            this.txtCantidadVueltas = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gridTiempos = new System.Windows.Forms.DataGridView();
            this.Vuelta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.graficoLineas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridTiempos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoLineas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCantidadVueltas
            // 
            this.txtCantidadVueltas.Location = new System.Drawing.Point(483, 56);
            this.txtCantidadVueltas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidadVueltas.Name = "txtCantidadVueltas";
            this.txtCantidadVueltas.Size = new System.Drawing.Size(211, 22);
            this.txtCantidadVueltas.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._41692_check_yes_ok_tick_correct_icon;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Location = new System.Drawing.Point(719, 44);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(54, 47);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // gridTiempos
            // 
            this.gridTiempos.AllowUserToAddRows = false;
            this.gridTiempos.AllowUserToDeleteRows = false;
            this.gridTiempos.BackgroundColor = System.Drawing.Color.White;
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
            this.gridTiempos.Location = new System.Drawing.Point(67, 119);
            this.gridTiempos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridTiempos.Name = "gridTiempos";
            this.gridTiempos.RowHeadersWidth = 51;
            this.gridTiempos.Size = new System.Drawing.Size(601, 386);
            this.gridTiempos.TabIndex = 2;
            // 
            // Vuelta
            // 
            this.Vuelta.HeaderText = "Vuelta";
            this.Vuelta.MinimumWidth = 6;
            this.Vuelta.Name = "Vuelta";
            this.Vuelta.Width = 125;
            // 
            // A1
            // 
            this.A1.HeaderText = "A1";
            this.A1.MinimumWidth = 6;
            this.A1.Name = "A1";
            this.A1.Width = 125;
            // 
            // A2
            // 
            this.A2.HeaderText = "A2";
            this.A2.MinimumWidth = 6;
            this.A2.Name = "A2";
            this.A2.Width = 125;
            // 
            // A3
            // 
            this.A3.HeaderText = "A3";
            this.A3.MinimumWidth = 6;
            this.A3.Name = "A3";
            this.A3.Width = 125;
            // 
            // A4
            // 
            this.A4.HeaderText = "A4";
            this.A4.MinimumWidth = 6;
            this.A4.Name = "A4";
            this.A4.Width = 125;
            // 
            // A5
            // 
            this.A5.HeaderText = "A5";
            this.A5.MinimumWidth = 6;
            this.A5.Name = "A5";
            this.A5.Width = 125;
            // 
            // Final
            // 
            this.Final.HeaderText = "Final";
            this.Final.MinimumWidth = 6;
            this.Final.Name = "Final";
            this.Final.Width = 125;
            // 
            // Promedio
            // 
            this.Promedio.HeaderText = "Promedio";
            this.Promedio.MinimumWidth = 6;
            this.Promedio.Name = "Promedio";
            this.Promedio.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(69, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad de simulaciones del proyecto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(963, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tiempo Maximo";
            // 
            // txtTiempoMaximo
            // 
            this.txtTiempoMaximo.Enabled = false;
            this.txtTiempoMaximo.Location = new System.Drawing.Point(1193, 56);
            this.txtTiempoMaximo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTiempoMaximo.Name = "txtTiempoMaximo";
            this.txtTiempoMaximo.Size = new System.Drawing.Size(211, 22);
            this.txtTiempoMaximo.TabIndex = 6;
            // 
            // txtTiempoMinimo
            // 
            this.txtTiempoMinimo.Enabled = false;
            this.txtTiempoMinimo.Location = new System.Drawing.Point(1193, 102);
            this.txtTiempoMinimo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTiempoMinimo.Name = "txtTiempoMinimo";
            this.txtTiempoMinimo.Size = new System.Drawing.Size(211, 22);
            this.txtTiempoMinimo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(963, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tiempo Minimo";
            // 
            // txtPromedio45
            // 
            this.txtPromedio45.Enabled = false;
            this.txtPromedio45.Location = new System.Drawing.Point(483, 102);
            this.txtPromedio45.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPromedio45.Name = "txtPromedio45";
            this.txtPromedio45.Size = new System.Drawing.Size(211, 22);
            this.txtPromedio45.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(69, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Promedio de tiempos menores a 45";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Enabled = false;
            this.txtPromedio.Location = new System.Drawing.Point(1193, 148);
            this.txtPromedio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(211, 22);
            this.txtPromedio.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(963, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tiempo promedio";
            // 
            // graficoLineas
            // 
            chartArea1.Name = "ChartArea1";
            this.graficoLineas.ChartAreas.Add(chartArea1);
            legend1.Name = "Promedio";
            legend1.Title = "Serie";
            this.graficoLineas.Legends.Add(legend1);
            this.graficoLineas.Location = new System.Drawing.Point(680, 56);
            this.graficoLineas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.graficoLineas.Name = "graficoLineas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Promedio";
            series1.Name = "Series1";
            this.graficoLineas.Series.Add(series1);
            this.graficoLineas.Size = new System.Drawing.Size(801, 481);
            this.graficoLineas.TabIndex = 13;
            this.graficoLineas.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Evolución de Promedio";
            this.graficoLineas.Titles.Add(title1);
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(483, 148);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(211, 22);
            this.txtFecha.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(69, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(334, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fecha a fijar con el 90% de confianza: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtFecha);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtTiempoMaximo);
            this.panel2.Controls.Add(this.btnConfirmar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtCantidadVueltas);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTiempoMinimo);
            this.panel2.Controls.Add(this.txtPromedio);
            this.panel2.Controls.Add(this.txtPromedio45);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(-6, 552);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1500, 254);
            this.panel2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(57, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(506, 56);
            this.label7.TabIndex = 17;
            this.label7.Text = "Simulacion Montecarlo";
            // 
            // DuracionProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1493, 796);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.graficoLineas);
            this.Controls.Add(this.gridTiempos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "DuracionProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duracion Proyecto";
            ((System.ComponentModel.ISupportInitialize)(this.gridTiempos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoLineas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
    }
}

