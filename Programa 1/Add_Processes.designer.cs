namespace Programa_09
{
    partial class FormAddProcesses
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
            this.NumericUpDownNumProcesses = new System.Windows.Forms.NumericUpDown();
            this.LabelNumProcesses = new System.Windows.Forms.Label();
            this.ButtonAcceptAddProcesses = new System.Windows.Forms.Button();
            this.ButtonCancelAddProcesses = new System.Windows.Forms.Button();
            this.LabelQuantumValue = new System.Windows.Forms.Label();
            this.NumericUpDownQuantumValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownNumProcesses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownQuantumValue)).BeginInit();
            this.SuspendLayout();
            // 
            // NumericUpDownNumProcesses
            // 
            this.NumericUpDownNumProcesses.Location = new System.Drawing.Point(12, 25);
            this.NumericUpDownNumProcesses.Name = "NumericUpDownNumProcesses";
            this.NumericUpDownNumProcesses.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownNumProcesses.TabIndex = 0;
            // 
            // LabelNumProcesses
            // 
            this.LabelNumProcesses.AutoSize = true;
            this.LabelNumProcesses.Location = new System.Drawing.Point(9, 9);
            this.LabelNumProcesses.Name = "LabelNumProcesses";
            this.LabelNumProcesses.Size = new System.Drawing.Size(109, 13);
            this.LabelNumProcesses.TabIndex = 1;
            this.LabelNumProcesses.Text = "Número de Procesos:";
            // 
            // ButtonAcceptAddProcesses
            // 
            this.ButtonAcceptAddProcesses.Location = new System.Drawing.Point(153, 25);
            this.ButtonAcceptAddProcesses.Name = "ButtonAcceptAddProcesses";
            this.ButtonAcceptAddProcesses.Size = new System.Drawing.Size(75, 23);
            this.ButtonAcceptAddProcesses.TabIndex = 2;
            this.ButtonAcceptAddProcesses.Text = "Aceptar";
            this.ButtonAcceptAddProcesses.UseVisualStyleBackColor = true;
            this.ButtonAcceptAddProcesses.Click += new System.EventHandler(this.ButtonAcceptAddProcesses_Click);
            // 
            // ButtonCancelAddProcesses
            // 
            this.ButtonCancelAddProcesses.Location = new System.Drawing.Point(153, 52);
            this.ButtonCancelAddProcesses.Name = "ButtonCancelAddProcesses";
            this.ButtonCancelAddProcesses.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancelAddProcesses.TabIndex = 3;
            this.ButtonCancelAddProcesses.Text = "Cancelar";
            this.ButtonCancelAddProcesses.UseVisualStyleBackColor = true;
            this.ButtonCancelAddProcesses.Click += new System.EventHandler(this.ButtonCancelAddProcesses_Click);
            // 
            // LabelQuantumValue
            // 
            this.LabelQuantumValue.AutoSize = true;
            this.LabelQuantumValue.Location = new System.Drawing.Point(9, 57);
            this.LabelQuantumValue.Name = "LabelQuantumValue";
            this.LabelQuantumValue.Size = new System.Drawing.Size(97, 13);
            this.LabelQuantumValue.TabIndex = 5;
            this.LabelQuantumValue.Text = "Valor del Quantum:";
            // 
            // NumericUpDownQuantumValue
            // 
            this.NumericUpDownQuantumValue.Location = new System.Drawing.Point(12, 73);
            this.NumericUpDownQuantumValue.Name = "NumericUpDownQuantumValue";
            this.NumericUpDownQuantumValue.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownQuantumValue.TabIndex = 4;
            // 
            // FormAddProcesses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 106);
            this.Controls.Add(this.LabelQuantumValue);
            this.Controls.Add(this.NumericUpDownQuantumValue);
            this.Controls.Add(this.ButtonCancelAddProcesses);
            this.Controls.Add(this.ButtonAcceptAddProcesses);
            this.Controls.Add(this.LabelNumProcesses);
            this.Controls.Add(this.NumericUpDownNumProcesses);
            this.Name = "FormAddProcesses";
            this.Text = "Procesos";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownNumProcesses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownQuantumValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumericUpDownNumProcesses;
        private System.Windows.Forms.Label LabelNumProcesses;
        private System.Windows.Forms.Button ButtonAcceptAddProcesses;
        private System.Windows.Forms.Button ButtonCancelAddProcesses;
        private System.Windows.Forms.Label LabelQuantumValue;
        private System.Windows.Forms.NumericUpDown NumericUpDownQuantumValue;
    }
}

