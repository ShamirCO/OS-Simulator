namespace Programa_09
{
    partial class FormProcessControlBlock
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
            this.DataGridViewProcessControlBlock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProcessControlBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewProcessControlBlock
            // 
            this.DataGridViewProcessControlBlock.AllowUserToAddRows = false;
            this.DataGridViewProcessControlBlock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewProcessControlBlock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProcessControlBlock.Location = new System.Drawing.Point(12, 12);
            this.DataGridViewProcessControlBlock.Name = "DataGridViewProcessControlBlock";
            this.DataGridViewProcessControlBlock.ReadOnly = true;
            this.DataGridViewProcessControlBlock.RowHeadersVisible = false;
            this.DataGridViewProcessControlBlock.Size = new System.Drawing.Size(789, 137);
            this.DataGridViewProcessControlBlock.TabIndex = 0;
            // 
            // FormProcessControlBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 161);
            this.ControlBox = false;
            this.Controls.Add(this.DataGridViewProcessControlBlock);
            this.Name = "FormProcessControlBlock";
            this.Text = "Bloques de Control de los Procesos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormProcessControlBlock_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProcessControlBlock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewProcessControlBlock;
    }
}