namespace HTK_FileManager
{
    partial class Configuracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            this.cbPuesto = new System.Windows.Forms.ComboBox();
            this.lbPuesto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSiglas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbPuesto
            // 
            this.cbPuesto.FormattingEnabled = true;
            this.cbPuesto.Items.AddRange(new object[] {
            "Asistente de Director",
            "Asistente Internacional Especializado de Soluciones",
            "Coordinador Especializado de Tranquilidad",
            "Coordinador Especilizado de Medios y Marca",
            "Director de Operaciones",
            "Director de Tecnología e Implementación",
            "Director de Ventas y Mercadotecnia",
            "Director General",
            "Ejecutivo de Auditoría",
            "Ejecutivo de Compras y Almacén",
            "Ejecutivo de Contabilidad",
            "Ejecutivo de Crédito y Cuentas",
            "Ejecutivo de Legal",
            "Ejecutivo de Recursos Humanos",
            "Ejecutivo Especializado de Servicio y Atención",
            "Ejecutivo Especializado de Soluciones",
            "Ejecutivo Especializado de Soluciones",
            "Ejecutivo Especializado de Soluciones",
            "Gerente de Administración",
            "Gerente de Auditoría",
            "Gerente de Comercio Internacional Especializado de Soluciones",
            "Gerente de Finanzas",
            "Gerente de Implementación",
            "Gerente de Innovación",
            "Gerente de Legal",
            "Gerente de Mercadotecnia",
            "Gerente de TI",
            "Gerente Especializado de Soluciones",
            "Líder de Implementación Especializada",
            "Líder de Implementación Especializada",
            "Líder de Innovación",
            "Líder de Software y Datos",
            "Líder de Soporte y Tranquilidad",
            "Líder de TI"});
            this.cbPuesto.Location = new System.Drawing.Point(58, 20);
            this.cbPuesto.Name = "cbPuesto";
            this.cbPuesto.Size = new System.Drawing.Size(264, 21);
            this.cbPuesto.TabIndex = 0;
            this.cbPuesto.SelectedIndexChanged += new System.EventHandler(this.cbPuesto_SelectedIndexChanged);
            // 
            // lbPuesto
            // 
            this.lbPuesto.AutoSize = true;
            this.lbPuesto.Location = new System.Drawing.Point(12, 23);
            this.lbPuesto.Name = "lbPuesto";
            this.lbPuesto.Size = new System.Drawing.Size(40, 13);
            this.lbPuesto.TabIndex = 1;
            this.lbPuesto.Text = "Puesto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Siglas";
            // 
            // lbSiglas
            // 
            this.lbSiglas.AutoSize = true;
            this.lbSiglas.Location = new System.Drawing.Point(387, 23);
            this.lbSiglas.Name = "lbSiglas";
            this.lbSiglas.Size = new System.Drawing.Size(16, 13);
            this.lbSiglas.TabIndex = 3;
            this.lbSiglas.Text = "---";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Guardar);
            // 
            // cbArea
            // 
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Items.AddRange(new object[] {
            "AU",
            "BE",
            "COM",
            "DEV",
            "OP"});
            this.cbArea.Location = new System.Drawing.Point(58, 47);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(108, 21);
            this.cbArea.TabIndex = 5;
            this.cbArea.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Área";
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 102);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbSiglas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPuesto);
            this.Controls.Add(this.cbPuesto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Configuracion";
            this.Text = "Configuración";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Configuracion_FormClosing);
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPuesto;
        private System.Windows.Forms.Label lbPuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSiglas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Label label2;
    }
}