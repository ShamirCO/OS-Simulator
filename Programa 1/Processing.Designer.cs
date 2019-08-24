namespace Programa_09
{
    partial class FormProcessing
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
            this.DataGridViewReadyProcesses = new System.Windows.Forms.DataGridView();
            this.LabelRemainingNewProcesses = new System.Windows.Forms.Label();
            this.LabelReadyProcesses = new System.Windows.Forms.Label();
            this.LabelCurrentProcess = new System.Windows.Forms.Label();
            this.DataGridViewCurrentProcess = new System.Windows.Forms.DataGridView();
            this.LabelCompletedProcesses = new System.Windows.Forms.Label();
            this.DataGridViewCompletedProcesses = new System.Windows.Forms.DataGridView();
            this.LabelCounter = new System.Windows.Forms.Label();
            this.LabelNumOfRemainingNewProcesses = new System.Windows.Forms.Label();
            this.LabelCounterNumber = new System.Windows.Forms.Label();
            this.TimerProcessEstimatedTime = new System.Windows.Forms.Timer(this.components);
            this.DataGridViewBlockedProcesses = new System.Windows.Forms.DataGridView();
            this.LabelBlockedProcesses = new System.Windows.Forms.Label();
            this.ButtonAddProcesses = new System.Windows.Forms.Button();
            this.ButtonExecute = new System.Windows.Forms.Button();
            this.LabelQuantum = new System.Windows.Forms.Label();
            this.LabelQuantumValue = new System.Windows.Forms.Label();
            this.DataGridViewMemory = new System.Windows.Forms.DataGridView();
            this.FrameNumberPtOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrameProcessPtOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrameSlot0PtOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrameSlot1PtOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrameSlot2PtOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrameSlot3PtOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrameSlot4PtOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrameNumberPtTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrameProcessPtTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrameSlot0PtTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrameSlot1PtTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrameSlot2PtTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrameSlot3PtTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrameSlot4PtTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelMemory = new System.Windows.Forms.Label();
            this.LabelNextNewProcess = new System.Windows.Forms.Label();
            this.LabelNextNewProcessID = new System.Windows.Forms.Label();
            this.LabelNextNewProcessIDValue = new System.Windows.Forms.Label();
            this.LabelNextNewProcessSize = new System.Windows.Forms.Label();
            this.LabelNextNewProcessSizeValue = new System.Windows.Forms.Label();
            this.LabelNextSuspendedProcessSizeValue = new System.Windows.Forms.Label();
            this.LabelNextSuspendedProcessSize = new System.Windows.Forms.Label();
            this.LabelNextSuspendedProcessIDValue = new System.Windows.Forms.Label();
            this.LabelNextSuspendedProcessID = new System.Windows.Forms.Label();
            this.LabelNextSuspendedProcess = new System.Windows.Forms.Label();
            this.LabelNumOfRemainingSuspendedProcesses = new System.Windows.Forms.Label();
            this.LabelRemainingSuspendedProcesses = new System.Windows.Forms.Label();
            this.LabelVirtualMemory = new System.Windows.Forms.Label();
            this.DataGridViewVirtualMemory = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewReadyProcesses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCurrentProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCompletedProcesses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBlockedProcesses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVirtualMemory)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewReadyProcesses
            // 
            this.DataGridViewReadyProcesses.AllowUserToAddRows = false;
            this.DataGridViewReadyProcesses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewReadyProcesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewReadyProcesses.Location = new System.Drawing.Point(15, 63);
            this.DataGridViewReadyProcesses.Name = "DataGridViewReadyProcesses";
            this.DataGridViewReadyProcesses.ReadOnly = true;
            this.DataGridViewReadyProcesses.RowHeadersVisible = false;
            this.DataGridViewReadyProcesses.Size = new System.Drawing.Size(303, 199);
            this.DataGridViewReadyProcesses.TabIndex = 1;
            // 
            // LabelRemainingNewProcesses
            // 
            this.LabelRemainingNewProcesses.AutoSize = true;
            this.LabelRemainingNewProcesses.Location = new System.Drawing.Point(12, 9);
            this.LabelRemainingNewProcesses.Name = "LabelRemainingNewProcesses";
            this.LabelRemainingNewProcesses.Size = new System.Drawing.Size(195, 13);
            this.LabelRemainingNewProcesses.TabIndex = 2;
            this.LabelRemainingNewProcesses.Text = "Número de Procesos en Estado Nuevo:";
            // 
            // LabelReadyProcesses
            // 
            this.LabelReadyProcesses.AutoSize = true;
            this.LabelReadyProcesses.Location = new System.Drawing.Point(12, 47);
            this.LabelReadyProcesses.Name = "LabelReadyProcesses";
            this.LabelReadyProcesses.Size = new System.Drawing.Size(84, 13);
            this.LabelReadyProcesses.TabIndex = 4;
            this.LabelReadyProcesses.Text = "Procesos Listos:";
            // 
            // LabelCurrentProcess
            // 
            this.LabelCurrentProcess.AutoSize = true;
            this.LabelCurrentProcess.Location = new System.Drawing.Point(321, 47);
            this.LabelCurrentProcess.Name = "LabelCurrentProcess";
            this.LabelCurrentProcess.Size = new System.Drawing.Size(114, 13);
            this.LabelCurrentProcess.TabIndex = 5;
            this.LabelCurrentProcess.Text = "Proceso en Ejecución:";
            // 
            // DataGridViewCurrentProcess
            // 
            this.DataGridViewCurrentProcess.AllowUserToAddRows = false;
            this.DataGridViewCurrentProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCurrentProcess.Location = new System.Drawing.Point(324, 63);
            this.DataGridViewCurrentProcess.Name = "DataGridViewCurrentProcess";
            this.DataGridViewCurrentProcess.ReadOnly = true;
            this.DataGridViewCurrentProcess.RowHeadersVisible = false;
            this.DataGridViewCurrentProcess.Size = new System.Drawing.Size(203, 155);
            this.DataGridViewCurrentProcess.TabIndex = 6;
            // 
            // LabelCompletedProcesses
            // 
            this.LabelCompletedProcesses.AutoSize = true;
            this.LabelCompletedProcesses.Location = new System.Drawing.Point(12, 273);
            this.LabelCompletedProcesses.Name = "LabelCompletedProcesses";
            this.LabelCompletedProcesses.Size = new System.Drawing.Size(112, 13);
            this.LabelCompletedProcesses.TabIndex = 7;
            this.LabelCompletedProcesses.Text = "Procesos Terminados:";
            // 
            // DataGridViewCompletedProcesses
            // 
            this.DataGridViewCompletedProcesses.AllowUserToAddRows = false;
            this.DataGridViewCompletedProcesses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewCompletedProcesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCompletedProcesses.Location = new System.Drawing.Point(15, 289);
            this.DataGridViewCompletedProcesses.Name = "DataGridViewCompletedProcesses";
            this.DataGridViewCompletedProcesses.ReadOnly = true;
            this.DataGridViewCompletedProcesses.RowHeadersVisible = false;
            this.DataGridViewCompletedProcesses.Size = new System.Drawing.Size(303, 177);
            this.DataGridViewCompletedProcesses.TabIndex = 8;
            // 
            // LabelCounter
            // 
            this.LabelCounter.AutoSize = true;
            this.LabelCounter.Location = new System.Drawing.Point(12, 477);
            this.LabelCounter.Name = "LabelCounter";
            this.LabelCounter.Size = new System.Drawing.Size(56, 13);
            this.LabelCounter.TabIndex = 9;
            this.LabelCounter.Text = "Contador: ";
            // 
            // LabelNumOfRemainingNewProcesses
            // 
            this.LabelNumOfRemainingNewProcesses.AutoSize = true;
            this.LabelNumOfRemainingNewProcesses.Location = new System.Drawing.Point(202, 9);
            this.LabelNumOfRemainingNewProcesses.Name = "LabelNumOfRemainingNewProcesses";
            this.LabelNumOfRemainingNewProcesses.Size = new System.Drawing.Size(13, 13);
            this.LabelNumOfRemainingNewProcesses.TabIndex = 11;
            this.LabelNumOfRemainingNewProcesses.Text = "0";
            // 
            // LabelCounterNumber
            // 
            this.LabelCounterNumber.AutoSize = true;
            this.LabelCounterNumber.Location = new System.Drawing.Point(60, 477);
            this.LabelCounterNumber.Name = "LabelCounterNumber";
            this.LabelCounterNumber.Size = new System.Drawing.Size(13, 13);
            this.LabelCounterNumber.TabIndex = 12;
            this.LabelCounterNumber.Text = "0";
            // 
            // TimerProcessEstimatedTime
            // 
            this.TimerProcessEstimatedTime.Interval = 1000;
            this.TimerProcessEstimatedTime.Tick += new System.EventHandler(this.TimerProcessEstimatedTime_Tick);
            // 
            // DataGridViewBlockedProcesses
            // 
            this.DataGridViewBlockedProcesses.AllowUserToAddRows = false;
            this.DataGridViewBlockedProcesses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewBlockedProcesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewBlockedProcesses.Location = new System.Drawing.Point(324, 252);
            this.DataGridViewBlockedProcesses.Name = "DataGridViewBlockedProcesses";
            this.DataGridViewBlockedProcesses.ReadOnly = true;
            this.DataGridViewBlockedProcesses.RowHeadersVisible = false;
            this.DataGridViewBlockedProcesses.Size = new System.Drawing.Size(203, 243);
            this.DataGridViewBlockedProcesses.TabIndex = 13;
            // 
            // LabelBlockedProcesses
            // 
            this.LabelBlockedProcesses.AutoSize = true;
            this.LabelBlockedProcesses.Location = new System.Drawing.Point(322, 236);
            this.LabelBlockedProcesses.Name = "LabelBlockedProcesses";
            this.LabelBlockedProcesses.Size = new System.Drawing.Size(113, 13);
            this.LabelBlockedProcesses.TabIndex = 14;
            this.LabelBlockedProcesses.Text = "Procesos Bloqueados:";
            // 
            // ButtonAddProcesses
            // 
            this.ButtonAddProcesses.Location = new System.Drawing.Point(223, 472);
            this.ButtonAddProcesses.Name = "ButtonAddProcesses";
            this.ButtonAddProcesses.Size = new System.Drawing.Size(95, 23);
            this.ButtonAddProcesses.TabIndex = 15;
            this.ButtonAddProcesses.Text = "Agregar Procesos";
            this.ButtonAddProcesses.UseVisualStyleBackColor = true;
            this.ButtonAddProcesses.Click += new System.EventHandler(this.ButtonAddProcesses_Click);
            // 
            // ButtonExecute
            // 
            this.ButtonExecute.Location = new System.Drawing.Point(122, 472);
            this.ButtonExecute.Name = "ButtonExecute";
            this.ButtonExecute.Size = new System.Drawing.Size(95, 23);
            this.ButtonExecute.TabIndex = 16;
            this.ButtonExecute.Text = "Ejecutar";
            this.ButtonExecute.UseVisualStyleBackColor = true;
            this.ButtonExecute.Click += new System.EventHandler(this.ButtonExecute_Click);
            // 
            // LabelQuantum
            // 
            this.LabelQuantum.AutoSize = true;
            this.LabelQuantum.Location = new System.Drawing.Point(530, 9);
            this.LabelQuantum.Name = "LabelQuantum";
            this.LabelQuantum.Size = new System.Drawing.Size(97, 13);
            this.LabelQuantum.TabIndex = 17;
            this.LabelQuantum.Text = "Valor del Quantum:";
            // 
            // LabelQuantumValue
            // 
            this.LabelQuantumValue.AutoSize = true;
            this.LabelQuantumValue.Location = new System.Drawing.Point(622, 9);
            this.LabelQuantumValue.Name = "LabelQuantumValue";
            this.LabelQuantumValue.Size = new System.Drawing.Size(13, 13);
            this.LabelQuantumValue.TabIndex = 18;
            this.LabelQuantumValue.Text = "0";
            // 
            // DataGridViewMemory
            // 
            this.DataGridViewMemory.AllowUserToAddRows = false;
            this.DataGridViewMemory.AllowUserToDeleteRows = false;
            this.DataGridViewMemory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMemory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FrameNumberPtOne,
            this.FrameProcessPtOne,
            this.FrameSlot0PtOne,
            this.FrameSlot1PtOne,
            this.FrameSlot2PtOne,
            this.FrameSlot3PtOne,
            this.FrameSlot4PtOne,
            this.FrameNumberPtTwo,
            this.FrameProcessPtTwo,
            this.FrameSlot0PtTwo,
            this.FrameSlot1PtTwo,
            this.FrameSlot2PtTwo,
            this.FrameSlot3PtTwo,
            this.FrameSlot4PtTwo});
            this.DataGridViewMemory.Location = new System.Drawing.Point(533, 63);
            this.DataGridViewMemory.Name = "DataGridViewMemory";
            this.DataGridViewMemory.ReadOnly = true;
            this.DataGridViewMemory.RowHeadersVisible = false;
            this.DataGridViewMemory.Size = new System.Drawing.Size(403, 432);
            this.DataGridViewMemory.TabIndex = 19;
            // 
            // FrameNumberPtOne
            // 
            this.FrameNumberPtOne.FillWeight = 91.18541F;
            this.FrameNumberPtOne.HeaderText = "No. Marco";
            this.FrameNumberPtOne.Name = "FrameNumberPtOne";
            this.FrameNumberPtOne.ReadOnly = true;
            this.FrameNumberPtOne.Width = 50;
            // 
            // FrameProcessPtOne
            // 
            this.FrameProcessPtOne.FillWeight = 100.9938F;
            this.FrameProcessPtOne.HeaderText = "Proceso";
            this.FrameProcessPtOne.Name = "FrameProcessPtOne";
            this.FrameProcessPtOne.ReadOnly = true;
            this.FrameProcessPtOne.Width = 55;
            // 
            // FrameSlot0PtOne
            // 
            this.FrameSlot0PtOne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FrameSlot0PtOne.HeaderText = "";
            this.FrameSlot0PtOne.Name = "FrameSlot0PtOne";
            this.FrameSlot0PtOne.ReadOnly = true;
            this.FrameSlot0PtOne.Width = 19;
            // 
            // FrameSlot1PtOne
            // 
            this.FrameSlot1PtOne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FrameSlot1PtOne.HeaderText = "";
            this.FrameSlot1PtOne.Name = "FrameSlot1PtOne";
            this.FrameSlot1PtOne.ReadOnly = true;
            this.FrameSlot1PtOne.Width = 19;
            // 
            // FrameSlot2PtOne
            // 
            this.FrameSlot2PtOne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FrameSlot2PtOne.HeaderText = "";
            this.FrameSlot2PtOne.Name = "FrameSlot2PtOne";
            this.FrameSlot2PtOne.ReadOnly = true;
            this.FrameSlot2PtOne.Width = 19;
            // 
            // FrameSlot3PtOne
            // 
            this.FrameSlot3PtOne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FrameSlot3PtOne.HeaderText = "";
            this.FrameSlot3PtOne.Name = "FrameSlot3PtOne";
            this.FrameSlot3PtOne.ReadOnly = true;
            this.FrameSlot3PtOne.Width = 19;
            // 
            // FrameSlot4PtOne
            // 
            this.FrameSlot4PtOne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FrameSlot4PtOne.HeaderText = "";
            this.FrameSlot4PtOne.Name = "FrameSlot4PtOne";
            this.FrameSlot4PtOne.ReadOnly = true;
            this.FrameSlot4PtOne.Width = 19;
            // 
            // FrameNumberPtTwo
            // 
            this.FrameNumberPtTwo.HeaderText = "No. Marco";
            this.FrameNumberPtTwo.Name = "FrameNumberPtTwo";
            this.FrameNumberPtTwo.ReadOnly = true;
            this.FrameNumberPtTwo.Width = 50;
            // 
            // FrameProcessPtTwo
            // 
            this.FrameProcessPtTwo.HeaderText = "Proceso";
            this.FrameProcessPtTwo.Name = "FrameProcessPtTwo";
            this.FrameProcessPtTwo.ReadOnly = true;
            this.FrameProcessPtTwo.Width = 55;
            // 
            // FrameSlot0PtTwo
            // 
            this.FrameSlot0PtTwo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FrameSlot0PtTwo.HeaderText = "";
            this.FrameSlot0PtTwo.Name = "FrameSlot0PtTwo";
            this.FrameSlot0PtTwo.ReadOnly = true;
            this.FrameSlot0PtTwo.Width = 19;
            // 
            // FrameSlot1PtTwo
            // 
            this.FrameSlot1PtTwo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FrameSlot1PtTwo.HeaderText = "";
            this.FrameSlot1PtTwo.Name = "FrameSlot1PtTwo";
            this.FrameSlot1PtTwo.ReadOnly = true;
            this.FrameSlot1PtTwo.Width = 19;
            // 
            // FrameSlot2PtTwo
            // 
            this.FrameSlot2PtTwo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FrameSlot2PtTwo.HeaderText = "";
            this.FrameSlot2PtTwo.Name = "FrameSlot2PtTwo";
            this.FrameSlot2PtTwo.ReadOnly = true;
            this.FrameSlot2PtTwo.Width = 19;
            // 
            // FrameSlot3PtTwo
            // 
            this.FrameSlot3PtTwo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FrameSlot3PtTwo.HeaderText = "";
            this.FrameSlot3PtTwo.Name = "FrameSlot3PtTwo";
            this.FrameSlot3PtTwo.ReadOnly = true;
            this.FrameSlot3PtTwo.Width = 19;
            // 
            // FrameSlot4PtTwo
            // 
            this.FrameSlot4PtTwo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FrameSlot4PtTwo.HeaderText = "";
            this.FrameSlot4PtTwo.Name = "FrameSlot4PtTwo";
            this.FrameSlot4PtTwo.ReadOnly = true;
            this.FrameSlot4PtTwo.Width = 19;
            // 
            // LabelMemory
            // 
            this.LabelMemory.AutoSize = true;
            this.LabelMemory.Location = new System.Drawing.Point(530, 47);
            this.LabelMemory.Name = "LabelMemory";
            this.LabelMemory.Size = new System.Drawing.Size(50, 13);
            this.LabelMemory.TabIndex = 20;
            this.LabelMemory.Text = "Memoria:";
            // 
            // LabelNextNewProcess
            // 
            this.LabelNextNewProcess.AutoSize = true;
            this.LabelNextNewProcess.Location = new System.Drawing.Point(12, 28);
            this.LabelNextNewProcess.Name = "LabelNextNewProcess";
            this.LabelNextNewProcess.Size = new System.Drawing.Size(96, 13);
            this.LabelNextNewProcess.TabIndex = 21;
            this.LabelNextNewProcess.Text = "Siguiente Proceso:";
            // 
            // LabelNextNewProcessID
            // 
            this.LabelNextNewProcessID.AutoSize = true;
            this.LabelNextNewProcessID.Location = new System.Drawing.Point(103, 28);
            this.LabelNextNewProcessID.Name = "LabelNextNewProcessID";
            this.LabelNextNewProcessID.Size = new System.Drawing.Size(21, 13);
            this.LabelNextNewProcessID.TabIndex = 22;
            this.LabelNextNewProcessID.Text = "ID:";
            // 
            // LabelNextNewProcessIDValue
            // 
            this.LabelNextNewProcessIDValue.AutoSize = true;
            this.LabelNextNewProcessIDValue.Location = new System.Drawing.Point(119, 28);
            this.LabelNextNewProcessIDValue.Name = "LabelNextNewProcessIDValue";
            this.LabelNextNewProcessIDValue.Size = new System.Drawing.Size(13, 13);
            this.LabelNextNewProcessIDValue.TabIndex = 23;
            this.LabelNextNewProcessIDValue.Text = "0";
            // 
            // LabelNextNewProcessSize
            // 
            this.LabelNextNewProcessSize.AutoSize = true;
            this.LabelNextNewProcessSize.Location = new System.Drawing.Point(138, 28);
            this.LabelNextNewProcessSize.Name = "LabelNextNewProcessSize";
            this.LabelNextNewProcessSize.Size = new System.Drawing.Size(49, 13);
            this.LabelNextNewProcessSize.TabIndex = 24;
            this.LabelNextNewProcessSize.Text = "Tamaño:";
            // 
            // LabelNextNewProcessSizeValue
            // 
            this.LabelNextNewProcessSizeValue.AutoSize = true;
            this.LabelNextNewProcessSizeValue.Location = new System.Drawing.Point(182, 28);
            this.LabelNextNewProcessSizeValue.Name = "LabelNextNewProcessSizeValue";
            this.LabelNextNewProcessSizeValue.Size = new System.Drawing.Size(13, 13);
            this.LabelNextNewProcessSizeValue.TabIndex = 25;
            this.LabelNextNewProcessSizeValue.Text = "0";
            // 
            // LabelNextSuspendedProcessSizeValue
            // 
            this.LabelNextSuspendedProcessSizeValue.AutoSize = true;
            this.LabelNextSuspendedProcessSizeValue.Location = new System.Drawing.Point(491, 28);
            this.LabelNextSuspendedProcessSizeValue.Name = "LabelNextSuspendedProcessSizeValue";
            this.LabelNextSuspendedProcessSizeValue.Size = new System.Drawing.Size(13, 13);
            this.LabelNextSuspendedProcessSizeValue.TabIndex = 32;
            this.LabelNextSuspendedProcessSizeValue.Text = "0";
            // 
            // LabelNextSuspendedProcessSize
            // 
            this.LabelNextSuspendedProcessSize.AutoSize = true;
            this.LabelNextSuspendedProcessSize.Location = new System.Drawing.Point(447, 28);
            this.LabelNextSuspendedProcessSize.Name = "LabelNextSuspendedProcessSize";
            this.LabelNextSuspendedProcessSize.Size = new System.Drawing.Size(49, 13);
            this.LabelNextSuspendedProcessSize.TabIndex = 31;
            this.LabelNextSuspendedProcessSize.Text = "Tamaño:";
            // 
            // LabelNextSuspendedProcessIDValue
            // 
            this.LabelNextSuspendedProcessIDValue.AutoSize = true;
            this.LabelNextSuspendedProcessIDValue.Location = new System.Drawing.Point(428, 28);
            this.LabelNextSuspendedProcessIDValue.Name = "LabelNextSuspendedProcessIDValue";
            this.LabelNextSuspendedProcessIDValue.Size = new System.Drawing.Size(13, 13);
            this.LabelNextSuspendedProcessIDValue.TabIndex = 30;
            this.LabelNextSuspendedProcessIDValue.Text = "0";
            // 
            // LabelNextSuspendedProcessID
            // 
            this.LabelNextSuspendedProcessID.AutoSize = true;
            this.LabelNextSuspendedProcessID.Location = new System.Drawing.Point(412, 28);
            this.LabelNextSuspendedProcessID.Name = "LabelNextSuspendedProcessID";
            this.LabelNextSuspendedProcessID.Size = new System.Drawing.Size(21, 13);
            this.LabelNextSuspendedProcessID.TabIndex = 29;
            this.LabelNextSuspendedProcessID.Text = "ID:";
            // 
            // LabelNextSuspendedProcess
            // 
            this.LabelNextSuspendedProcess.AutoSize = true;
            this.LabelNextSuspendedProcess.Location = new System.Drawing.Point(321, 28);
            this.LabelNextSuspendedProcess.Name = "LabelNextSuspendedProcess";
            this.LabelNextSuspendedProcess.Size = new System.Drawing.Size(96, 13);
            this.LabelNextSuspendedProcess.TabIndex = 28;
            this.LabelNextSuspendedProcess.Text = "Siguiente Proceso:";
            // 
            // LabelNumOfRemainingSuspendedProcesses
            // 
            this.LabelNumOfRemainingSuspendedProcesses.AutoSize = true;
            this.LabelNumOfRemainingSuspendedProcesses.Location = new System.Drawing.Point(489, 9);
            this.LabelNumOfRemainingSuspendedProcesses.Name = "LabelNumOfRemainingSuspendedProcesses";
            this.LabelNumOfRemainingSuspendedProcesses.Size = new System.Drawing.Size(13, 13);
            this.LabelNumOfRemainingSuspendedProcesses.TabIndex = 27;
            this.LabelNumOfRemainingSuspendedProcesses.Text = "0";
            // 
            // LabelRemainingSuspendedProcesses
            // 
            this.LabelRemainingSuspendedProcesses.AutoSize = true;
            this.LabelRemainingSuspendedProcesses.Location = new System.Drawing.Point(321, 9);
            this.LabelRemainingSuspendedProcesses.Name = "LabelRemainingSuspendedProcesses";
            this.LabelRemainingSuspendedProcesses.Size = new System.Drawing.Size(173, 13);
            this.LabelRemainingSuspendedProcesses.TabIndex = 26;
            this.LabelRemainingSuspendedProcesses.Text = "Número de Procesos Suspendidos:";
            // 
            // LabelVirtualMemory
            // 
            this.LabelVirtualMemory.AutoSize = true;
            this.LabelVirtualMemory.Location = new System.Drawing.Point(939, 47);
            this.LabelVirtualMemory.Name = "LabelVirtualMemory";
            this.LabelVirtualMemory.Size = new System.Drawing.Size(82, 13);
            this.LabelVirtualMemory.TabIndex = 34;
            this.LabelVirtualMemory.Text = "Memoria Virtual:";
            // 
            // DataGridViewVirtualMemory
            // 
            this.DataGridViewVirtualMemory.AllowUserToAddRows = false;
            this.DataGridViewVirtualMemory.AllowUserToDeleteRows = false;
            this.DataGridViewVirtualMemory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewVirtualMemory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.DataGridViewVirtualMemory.Location = new System.Drawing.Point(942, 63);
            this.DataGridViewVirtualMemory.Name = "DataGridViewVirtualMemory";
            this.DataGridViewVirtualMemory.ReadOnly = true;
            this.DataGridViewVirtualMemory.RowHeadersVisible = false;
            this.DataGridViewVirtualMemory.Size = new System.Drawing.Size(403, 432);
            this.DataGridViewVirtualMemory.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 91.18541F;
            this.dataGridViewTextBoxColumn1.HeaderText = "No. Marco";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 100.9938F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Proceso";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 55;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.HeaderText = "";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 19;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.HeaderText = "";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 19;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.HeaderText = "";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 19;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.HeaderText = "";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 19;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn7.HeaderText = "";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 19;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "No. Marco";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Proceso";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 55;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn10.HeaderText = "";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 19;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn11.HeaderText = "";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 19;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn12.HeaderText = "";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 19;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn13.HeaderText = "";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 19;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn14.HeaderText = "";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 19;
            // 
            // FormProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 510);
            this.Controls.Add(this.LabelVirtualMemory);
            this.Controls.Add(this.DataGridViewVirtualMemory);
            this.Controls.Add(this.LabelNextSuspendedProcessSizeValue);
            this.Controls.Add(this.LabelNextSuspendedProcessSize);
            this.Controls.Add(this.LabelNextSuspendedProcessIDValue);
            this.Controls.Add(this.LabelNextSuspendedProcessID);
            this.Controls.Add(this.LabelNextSuspendedProcess);
            this.Controls.Add(this.LabelNumOfRemainingSuspendedProcesses);
            this.Controls.Add(this.LabelRemainingSuspendedProcesses);
            this.Controls.Add(this.LabelNextNewProcessSizeValue);
            this.Controls.Add(this.LabelNextNewProcessSize);
            this.Controls.Add(this.LabelNextNewProcessIDValue);
            this.Controls.Add(this.LabelNextNewProcessID);
            this.Controls.Add(this.LabelNextNewProcess);
            this.Controls.Add(this.LabelMemory);
            this.Controls.Add(this.DataGridViewMemory);
            this.Controls.Add(this.LabelQuantumValue);
            this.Controls.Add(this.LabelQuantum);
            this.Controls.Add(this.ButtonExecute);
            this.Controls.Add(this.ButtonAddProcesses);
            this.Controls.Add(this.LabelBlockedProcesses);
            this.Controls.Add(this.DataGridViewBlockedProcesses);
            this.Controls.Add(this.LabelCounterNumber);
            this.Controls.Add(this.LabelNumOfRemainingNewProcesses);
            this.Controls.Add(this.LabelCounter);
            this.Controls.Add(this.DataGridViewCompletedProcesses);
            this.Controls.Add(this.LabelCompletedProcesses);
            this.Controls.Add(this.DataGridViewCurrentProcess);
            this.Controls.Add(this.LabelCurrentProcess);
            this.Controls.Add(this.LabelReadyProcesses);
            this.Controls.Add(this.LabelRemainingNewProcesses);
            this.Controls.Add(this.DataGridViewReadyProcesses);
            this.Name = "FormProcessing";
            this.Text = "Procesamiento";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBatchProcessing_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewReadyProcesses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCurrentProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCompletedProcesses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBlockedProcesses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVirtualMemory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridViewReadyProcesses;
        private System.Windows.Forms.Label LabelRemainingNewProcesses;
        private System.Windows.Forms.Label LabelReadyProcesses;
        private System.Windows.Forms.Label LabelCurrentProcess;
        private System.Windows.Forms.DataGridView DataGridViewCurrentProcess;
        private System.Windows.Forms.Label LabelCompletedProcesses;
        private System.Windows.Forms.DataGridView DataGridViewCompletedProcesses;
        private System.Windows.Forms.Label LabelCounter;
        private System.Windows.Forms.Label LabelNumOfRemainingNewProcesses;
        private System.Windows.Forms.Label LabelCounterNumber;
        private System.Windows.Forms.Timer TimerProcessEstimatedTime;
        private System.Windows.Forms.DataGridView DataGridViewBlockedProcesses;
        private System.Windows.Forms.Label LabelBlockedProcesses;
        private System.Windows.Forms.Button ButtonAddProcesses;
        private System.Windows.Forms.Button ButtonExecute;
        private System.Windows.Forms.Label LabelQuantum;
        private System.Windows.Forms.Label LabelQuantumValue;
        private System.Windows.Forms.DataGridView DataGridViewMemory;
        private System.Windows.Forms.Label LabelMemory;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrameNumberPtOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrameProcessPtOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrameSlot0PtOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrameSlot1PtOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrameSlot2PtOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrameSlot3PtOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrameSlot4PtOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrameNumberPtTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrameProcessPtTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrameSlot0PtTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrameSlot1PtTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrameSlot2PtTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrameSlot3PtTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrameSlot4PtTwo;
        private System.Windows.Forms.Label LabelNextNewProcess;
        private System.Windows.Forms.Label LabelNextNewProcessID;
        private System.Windows.Forms.Label LabelNextNewProcessIDValue;
        private System.Windows.Forms.Label LabelNextNewProcessSize;
        private System.Windows.Forms.Label LabelNextNewProcessSizeValue;
        private System.Windows.Forms.Label LabelNextSuspendedProcessSizeValue;
        private System.Windows.Forms.Label LabelNextSuspendedProcessSize;
        private System.Windows.Forms.Label LabelNextSuspendedProcessIDValue;
        private System.Windows.Forms.Label LabelNextSuspendedProcessID;
        private System.Windows.Forms.Label LabelNextSuspendedProcess;
        private System.Windows.Forms.Label LabelNumOfRemainingSuspendedProcesses;
        private System.Windows.Forms.Label LabelRemainingSuspendedProcesses;
        private System.Windows.Forms.Label LabelVirtualMemory;
        private System.Windows.Forms.DataGridView DataGridViewVirtualMemory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}