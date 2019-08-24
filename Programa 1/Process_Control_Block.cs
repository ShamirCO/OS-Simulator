using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Programa_09
{
    public partial class FormProcessControlBlock : Form
    {
        private enum ProcessStatus { New, Ready, Executing, Blocked, Completed, Suspended };

        private DataTable processControlBlockDataTable;
        private Queue<Process> newProcessesQueue;
        private Queue<Process> readyProcessesQueue;
        private Process currentProcess;
        private List<Process> blockedProcessesList;
        private List<Process> completedProcessesList;
        private Queue<Process> suspendedProcessesQueue;
        private int counterNumber;

        public FormProcessControlBlock(Queue<Process> newNewProcessesQueue, Queue<Process> newReadyProcessesQueue, Process newCurrentProcess,
            List<Process> newBlockedProcessesList, List<Process> newCompletedProcessesList, int newCounterNumber)
        {
            InitializeComponent();

            KeyPreview = true;

            processControlBlockDataTable = new DataTable();
            newProcessesQueue = newNewProcessesQueue;
            readyProcessesQueue = newReadyProcessesQueue;
            currentProcess = newCurrentProcess;
            blockedProcessesList = newBlockedProcessesList;
            completedProcessesList = newCompletedProcessesList;
            suspendedProcessesQueue = JsonConvert.DeserializeObject<Queue<Process>>(File.ReadAllText("Procesos Suspendidos.txt"));
            counterNumber = newCounterNumber;

            InitializeProcessControlBlockDataGridView();
            SetProcessControlBlockDataGridView();
        }

        private void FormProcessControlBlock_KeyDown(object sender, KeyEventArgs keyPressed)
        {
            if (keyPressed.KeyCode == Keys.C)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void InitializeProcessControlBlockDataGridView()
        {
            processControlBlockDataTable.Columns.Add("ID");
            processControlBlockDataTable.Columns.Add("Estado");
            processControlBlockDataTable.Columns.Add("OPE");
            processControlBlockDataTable.Columns.Add("RES");

            processControlBlockDataTable.Columns.Add("Tiempo de Llegada");
            processControlBlockDataTable.Columns.Add("Tiempo de Finalización");
            processControlBlockDataTable.Columns.Add("Tiempo de Retorno");
            processControlBlockDataTable.Columns.Add("Tiempo de Respuesta");
            processControlBlockDataTable.Columns.Add("Tiempo de Espera");
            processControlBlockDataTable.Columns.Add("Tiempo de Servicio");
            processControlBlockDataTable.Columns.Add("TR");
            processControlBlockDataTable.Columns.Add("TME");

            DataGridViewProcessControlBlock.DataSource = processControlBlockDataTable;
        }

        public void SetProcessControlBlockDataGridView()
        {
            foreach (Process newProcess in newProcessesQueue)
            {
                SetProcessControlBlockRow(newProcess, (int)ProcessStatus.New);
            }

            foreach (Process readyProcess in readyProcessesQueue)
            {
                SetProcessControlBlockRow(readyProcess, (int)ProcessStatus.Ready);
            }

            SetProcessControlBlockRow(currentProcess, (int)ProcessStatus.Executing);

            foreach (Process blockedProcess in blockedProcessesList)
            {
                SetProcessControlBlockRow(blockedProcess, (int)ProcessStatus.Blocked);
            }

            foreach (Process completedProcess in completedProcessesList)
            {
                SetProcessControlBlockRow(completedProcess, (int)ProcessStatus.Completed);
            }

            foreach (Process suspendedProcess in suspendedProcessesQueue)
            {
                SetProcessControlBlockRow(suspendedProcess, (int)ProcessStatus.Suspended);
            }
        }

        public void SetProcessControlBlockRow(Process currentProcess, int status)
        {
            if (currentProcess == null)
            {
                return;
            }

            DataRow processControlBlockRow = processControlBlockDataTable.NewRow();

            processControlBlockRow["ID"] = currentProcess.ID;
            processControlBlockRow["OPE"] = currentProcess.Operation;
            processControlBlockRow["RES"] = currentProcess.Result;

            switch (status)
            {
                case (int)ProcessStatus.New:

                    processControlBlockRow["Estado"] = "Nuevo";

                    break;

                case (int)ProcessStatus.Ready:

                    processControlBlockRow["Estado"] = "Listo";

                    processControlBlockRow["Tiempo de Llegada"] = currentProcess.ArrivalTime;

                    if (currentProcess.ResponseTime != -1)
                    {
                        processControlBlockRow["Tiempo de Respuesta"] = currentProcess.ResponseTime;
                    }

                    processControlBlockRow["Tiempo de Espera"] = counterNumber - currentProcess.ArrivalTime - currentProcess.BurstTime;
                    processControlBlockRow["Tiempo de Servicio"] = currentProcess.BurstTime;

                    break;

                case (int)ProcessStatus.Executing:

                    processControlBlockRow["Estado"] = "En ejecución";

                    processControlBlockRow["Tiempo de Llegada"] = currentProcess.ArrivalTime;
                    processControlBlockRow["Tiempo de Respuesta"] = currentProcess.ResponseTime;
                    processControlBlockRow["Tiempo de Espera"] = counterNumber - currentProcess.ArrivalTime - currentProcess.BurstTime;
                    processControlBlockRow["Tiempo de Servicio"] = currentProcess.BurstTime;

                    break;

                case (int)ProcessStatus.Blocked:

                    processControlBlockRow["Estado"] = "Bloqueado";

                    processControlBlockRow["Tiempo de Llegada"] = currentProcess.ArrivalTime;
                    processControlBlockRow["Tiempo de Respuesta"] = currentProcess.ResponseTime;
                    processControlBlockRow["Tiempo de Espera"] = counterNumber - currentProcess.ArrivalTime - currentProcess.BurstTime;
                    processControlBlockRow["Tiempo de Servicio"] = currentProcess.BurstTime;

                    break;

                case (int)ProcessStatus.Completed:

                    processControlBlockRow["Estado"] = "Terminado";

                    processControlBlockRow["Tiempo de Llegada"] = currentProcess.ArrivalTime;
                    processControlBlockRow["Tiempo de Finalización"] = currentProcess.CompletionTime;
                    processControlBlockRow["Tiempo de Retorno"] = currentProcess.TurnAroundTime;
                    processControlBlockRow["Tiempo de Respuesta"] = currentProcess.ResponseTime;
                    processControlBlockRow["Tiempo de Espera"] = currentProcess.WaitingTime;
                    processControlBlockRow["Tiempo de Servicio"] = currentProcess.BurstTime;

                    break;

                case (int)ProcessStatus.Suspended:

                    processControlBlockRow["Estado"] = "Suspendido";

                    processControlBlockRow["Tiempo de Llegada"] = currentProcess.ArrivalTime;
                    processControlBlockRow["Tiempo de Respuesta"] = currentProcess.ResponseTime;
                    processControlBlockRow["Tiempo de Espera"] = counterNumber - currentProcess.ArrivalTime - currentProcess.BurstTime;
                    processControlBlockRow["Tiempo de Servicio"] = currentProcess.BurstTime;

                    break;
            }

            processControlBlockRow["TR"] = currentProcess.EstimatedTime - currentProcess.BurstTime;

            processControlBlockRow["TME"] = currentProcess.EstimatedTime;

            processControlBlockDataTable.Rows.Add(processControlBlockRow);
        }
    }
}
