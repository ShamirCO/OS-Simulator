using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_09
{
    public partial class FormAddProcesses : Form
    {
        public FormAddProcesses()
        {
            InitializeComponent();
        }

        private void ButtonAcceptAddProcesses_Click(object sender, EventArgs e)
        {
            if (NumericUpDownNumProcesses.Value <= 0)
            {
                MessageBox.Show("El número de procesos debe ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (NumericUpDownQuantumValue.Value <= 0)
            {
                MessageBox.Show("El valor del quantum debe ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void ButtonCancelAddProcesses_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        // METHODS
        public int GetNumOfProcesses()
        {
            return (int)NumericUpDownNumProcesses.Value;
        }

        public int GetQuantumValue()
        {
            return (int)NumericUpDownQuantumValue.Value;
        }
    }
}
