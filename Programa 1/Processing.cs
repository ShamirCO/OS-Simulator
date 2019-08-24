using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using NCalc;
using Newtonsoft.Json;
using System.IO;

namespace Programa_09
{
    public partial class FormProcessing : Form
    {
        // Constants
        private enum ProcessAttributes { ID, Operation, EstimatedTime, TimeElapsed, TimeRemaining, Quantum };
        private enum OperationType { Addition, Subtraction, Multiplication, Division, Modulo };
        private const int MaximumProcessesInMemory = 3, MaximumBlockTime = 10;

        // Variables
        private Queue<Process> newProcessesQueue;
        private Queue<Process> readyProcessesQueue;
        private List<Process> blockedProcessesList;
        private List<Process> completedProcessesList;
        private DataTable readyProcessesDataTable;
        private DataTable currentProcessDataTable;
        private DataTable blockedProcessesDataTable;
        private DataTable completedProcessesDataTable;
        private Process currentProcess;
        private Random numberGenerator;
        private Memory globalMemory;
        private VirtualMemory globalVirtualMemory;
        private int globalQuantum;
        private int globalProcessID;

        // Form Methods
        public FormProcessing()
        {
            InitializeComponent();

            newProcessesQueue = new Queue<Process>();
            readyProcessesQueue = new Queue<Process>();
            blockedProcessesList = new List<Process>();
            completedProcessesList = new List<Process>();
            readyProcessesDataTable = new DataTable();
            currentProcessDataTable = new DataTable();
            blockedProcessesDataTable = new DataTable();
            completedProcessesDataTable = new DataTable();
            numberGenerator = new Random();
            globalMemory = new Memory();
            globalVirtualMemory = new VirtualMemory();
            globalProcessID = 1;

            InitializeTools();
        }

        private void ButtonAddProcesses_Click(object sender, EventArgs e)
        {
            using (FormAddProcesses addProcessesForm = new FormAddProcesses())
            {
                if (addProcessesForm.ShowDialog() == DialogResult.OK)
                {
                    int numOfProcesses = addProcessesForm.GetNumOfProcesses();
                    globalQuantum = addProcessesForm.GetQuantumValue();

                    ResetTools();

                    for (int i = 0; i < numOfProcesses; i++)
                    {
                        newProcessesQueue.Enqueue(GetNewProcess(globalProcessID++));
                    }

                    ButtonAddProcesses.Enabled = false;
                    ButtonExecute.Enabled = true;

                    LabelNumOfRemainingNewProcesses.Text = newProcessesQueue.Count.ToString();
                    LabelQuantumValue.Text = globalQuantum.ToString();
                }
            }
        }

        private void ButtonExecute_Click(object sender, EventArgs e)
        {
            KeyPreview = true;

            ButtonExecute.Enabled = false;

            SetReadyProcessesDataGridView();
            SetCurrentProcessDataGridView();

            TimerProcessEstimatedTime.Enabled = true;
        }

        private void TimerProcessEstimatedTime_Tick(object sender, EventArgs e)
        {
            DataRow blockedProcessesRow;
            Process blockedProcess;

            LabelCounterNumber.Text = (Convert.ToInt32(LabelCounterNumber.Text) + 1).ToString();

            SetReadyProcessesDataGridView();

            for (int i = 0; i < blockedProcessesList.Count; i++)
            {
                blockedProcessesRow = blockedProcessesDataTable.Rows[i];

                blockedProcessesRow["TT"] = Convert.ToInt32(blockedProcessesRow["TT"]) + 1;

                if (blockedProcessesRow["TT"].ToString() == MaximumBlockTime.ToString())
                {
                    blockedProcess = blockedProcessesList[i];

                    readyProcessesQueue.Enqueue(blockedProcess);

                    AddReadyProcessesDataGridViewRow(blockedProcess);

                    blockedProcessesDataTable.Rows[i].Delete();
                    blockedProcessesList.RemoveAt(i);

                    UpdateMemoryDataGridViewProcessColor(blockedProcess, Color.Blue);
                    UpdateVirtualMemoryDataGridViewProcessColor(blockedProcess, Color.Blue);

                    i--;
                }
            }

            if (currentProcess == null)
            {
                if (readyProcessesQueue.Count != 0)
                {
                    SetCurrentProcessDataGridView();
                }

                return;
            }

            DataRow currentProcessTimeElapsedRow = currentProcessDataTable.Rows[(int)ProcessAttributes.TimeElapsed],
                currentProcessTimeRemainingRow = currentProcessDataTable.Rows[(int)ProcessAttributes.TimeRemaining],
                currentProcessQuantum = currentProcessDataTable.Rows[(int)ProcessAttributes.Quantum];

            currentProcessTimeElapsedRow["Datos"] = ++currentProcess.BurstTime;
            currentProcessTimeRemainingRow["Datos"] = currentProcess.EstimatedTime - currentProcess.BurstTime;
            currentProcessQuantum["Datos"] = Convert.ToInt32(currentProcessQuantum["Datos"]) + 1;

            if (currentProcess.BurstTime == currentProcess.EstimatedTime)
            {
                completedProcessesList.Add(currentProcess);

                AddCompletedProcessToDataGridView(false);

                UpdateReadyProcessesCurrentProcessDataGridView();
            }
            else if (currentProcessQuantum["Datos"].ToString() == globalQuantum.ToString())
            {
                readyProcessesQueue.Enqueue(currentProcess);

                AddReadyProcessesDataGridViewRow(currentProcess);

                UpdateMemoryDataGridViewProcessColor(currentProcess, Color.Blue);

                SetCurrentProcessDataGridView();
            }
        }

        private void FormBatchProcessing_KeyDown(object sender, KeyEventArgs keyPressed)
        {
            if (TimerProcessEstimatedTime.Enabled == true)
            {
                if (keyPressed.KeyCode == Keys.P || keyPressed.KeyCode == Keys.M)
                {
                    TimerProcessEstimatedTime.Enabled = false;
                }
                else if (keyPressed.KeyCode == Keys.N)
                {
                    newProcessesQueue.Enqueue(GetNewProcess(globalProcessID++));

                    LabelNumOfRemainingNewProcesses.Text = newProcessesQueue.Count.ToString();

                    LabelNextNewProcessIDValue.Text = newProcessesQueue.Peek().ID.ToString();
                    LabelNextNewProcessSizeValue.Text = newProcessesQueue.Peek().Size.ToString();
                }
                else if (keyPressed.KeyCode == Keys.T)
                {
                    TimerProcessEstimatedTime.Enabled = false;

                    using (FormProcessControlBlock processControlBlockForm = new FormProcessControlBlock(newProcessesQueue,
                        readyProcessesQueue, currentProcess, blockedProcessesList, completedProcessesList, Convert.ToInt32(LabelCounterNumber.Text)))
                    {
                        if (processControlBlockForm.ShowDialog() == DialogResult.OK)
                        {
                            TimerProcessEstimatedTime.Enabled = true;
                        }
                    }
                }
                else if (keyPressed.KeyCode == Keys.S)
                {
                    if (blockedProcessesList.Count != 0)
                    {
                        Queue<Process> suspendedProcessesQueue = JsonConvert.DeserializeObject<Queue<Process>>(File.ReadAllText("Procesos Suspendidos.txt"));
                        Process newSuspendedProcess = blockedProcessesList[0];

                        if (suspendedProcessesQueue.Count == 0)
                        {
                            LabelNextSuspendedProcessIDValue.Text = newSuspendedProcess.ID.ToString();
                            LabelNextSuspendedProcessSizeValue.Text = newSuspendedProcess.Size.ToString();
                        }

                        LabelNumOfRemainingSuspendedProcesses.Text = suspendedProcessesQueue.Count.ToString();

                        suspendedProcessesQueue.Enqueue(newSuspendedProcess);

                        RemoveMemoryDataGridViewProcess(newSuspendedProcess);
                        RemoveVirtualMemoryDataGridViewProcess(newSuspendedProcess);

                        globalMemory.Remove(newSuspendedProcess);
                        globalVirtualMemory.Remove(newSuspendedProcess);

                        blockedProcessesList.RemoveAt(0);
                        blockedProcessesDataTable.Rows[0].Delete();

                        File.WriteAllText("Procesos Suspendidos.txt", JsonConvert.SerializeObject(suspendedProcessesQueue, Formatting.Indented));
                    }
                }
                else if (keyPressed.KeyCode == Keys.R)
                {
                    Queue<Process> suspendedProcessesQueue = JsonConvert.DeserializeObject<Queue<Process>>(File.ReadAllText("Procesos Suspendidos.txt"));

                    if (suspendedProcessesQueue.Count != 0 && globalMemory.Add(suspendedProcessesQueue.Peek()))
                    {
                        DataRow blockedProcessesRow = blockedProcessesDataTable.NewRow();
                        Process newBlockedProcess = suspendedProcessesQueue.Dequeue();

                        LabelNumOfRemainingSuspendedProcesses.Text = LabelNumOfRemainingSuspendedProcesses.Text = suspendedProcessesQueue.Count.ToString();

                        if (suspendedProcessesQueue.Count != 0)
                        {
                            LabelNextSuspendedProcessIDValue.Text = suspendedProcessesQueue.Peek().ID.ToString();
                            LabelNextSuspendedProcessSizeValue.Text = suspendedProcessesQueue.Peek().Size.ToString();
                        }
                        else
                        {
                            LabelNextSuspendedProcessIDValue.Text = "0";
                            LabelNextSuspendedProcessSizeValue.Text = "0";
                        }

                        blockedProcessesRow["ID"] = newBlockedProcess.ID;
                        blockedProcessesRow["TT"] = 0;

                        blockedProcessesDataTable.Rows.Add(blockedProcessesRow);

                        blockedProcessesList.Add(newBlockedProcess);

                        AddMemoryDataGridViewProcess(newBlockedProcess);
                        UpdateMemoryDataGridViewProcessColor(newBlockedProcess, Color.Purple);

                        File.WriteAllText("Procesos Suspendidos.txt", JsonConvert.SerializeObject(suspendedProcessesQueue, Formatting.Indented));
                    }
                }
                else if (keyPressed.KeyCode == Keys.U)
                {
                    List<int> processIndices;
                    int frameIndex, virtualMemoryIndex;

                    foreach (Process readyProcess in readyProcessesQueue)
                    {
                        processIndices = globalMemory.FindIndices(readyProcess);

                        if (processIndices.Count != 1)
                        {
                            frameIndex = processIndices[processIndices.Count - 1];
                            virtualMemoryIndex = globalVirtualMemory.AddFrame(new Frame(globalMemory.Frames[frameIndex]));

                            if (virtualMemoryIndex == -1)
                            {
                                return;
                            }

                            RemoveMemoryDataGridViewFrame(frameIndex);
                            globalMemory.RemoveFrame(frameIndex);

                            AddVirtualMemoryDataGridViewFrame(virtualMemoryIndex, Color.Blue);
                        }
                    }

                    foreach (Process blockedProcess in blockedProcessesList)
                    {
                        processIndices = globalMemory.FindIndices(blockedProcess);

                        if (processIndices.Count != 1)
                        {
                            frameIndex = processIndices[processIndices.Count - 1];
                            virtualMemoryIndex = globalVirtualMemory.AddFrame(new Frame(globalMemory.Frames[frameIndex]));

                            if (virtualMemoryIndex == -1)
                            {
                                return;
                            }

                            RemoveMemoryDataGridViewFrame(frameIndex);
                            globalMemory.RemoveFrame(frameIndex);

                            AddVirtualMemoryDataGridViewFrame(virtualMemoryIndex, Color.Purple);
                        }
                    }
                }
                else if (currentProcess != null)
                {
                    if (keyPressed.KeyCode == Keys.I)
                    {
                        DataRow blockedProcessesRow = blockedProcessesDataTable.NewRow();

                        blockedProcessesRow["ID"] = currentProcess.ID;
                        blockedProcessesRow["TT"] = 0;

                        blockedProcessesDataTable.Rows.Add(blockedProcessesRow);

                        blockedProcessesList.Add(currentProcess);

                        UpdateMemoryDataGridViewProcessColor(currentProcess, Color.Purple);

                        if (readyProcessesQueue.Count != 0)
                        {
                            SetCurrentProcessDataGridView();
                        }
                        else
                        {
                            ClearCurrentProcessDataGridView();

                            currentProcess = null;
                        }
                    }
                    else if (keyPressed.KeyCode == Keys.E)
                    {
                        completedProcessesList.Add(currentProcess);

                        AddCompletedProcessToDataGridView(true);

                        UpdateReadyProcessesCurrentProcessDataGridView();
                    }
                }
            }
            else
            {
                if (keyPressed.KeyCode == Keys.C)
                {
                    TimerProcessEstimatedTime.Enabled = true;
                }
            }
        }

        // User Methods
        private void InitializeTools()
        {
            ButtonExecute.Enabled = false;

            InitializeReadyProcessesDataGridView();
            InitializeCurrentProcessDataGridView();
            InitializeBlockedProcessesDataGridView();
            InitilizeCompletedProcessesDataGridView();
            InitializeMemoryDataGridView();
            InitializeVirtualMemoryDataGridView();
        }

        private void InitializeReadyProcessesDataGridView()
        {
            readyProcessesDataTable.Columns.Add("ID");
            readyProcessesDataTable.Columns.Add("TME");
            readyProcessesDataTable.Columns.Add("TR");

            DataGridViewReadyProcesses.DataSource = readyProcessesDataTable;
        }

        private void InitializeCurrentProcessDataGridView()
        {
            DataRow attributeRow = currentProcessDataTable.NewRow();

            currentProcessDataTable.Columns.Add("Campos");
            currentProcessDataTable.Columns.Add("Datos");

            attributeRow = currentProcessDataTable.NewRow();
            attributeRow["Campos"] = "ID";
            currentProcessDataTable.Rows.Add(attributeRow);

            attributeRow = currentProcessDataTable.NewRow();
            attributeRow["Campos"] = "OPE";
            currentProcessDataTable.Rows.Add(attributeRow);

            attributeRow = currentProcessDataTable.NewRow();
            attributeRow["Campos"] = "TME";
            currentProcessDataTable.Rows.Add(attributeRow);

            attributeRow = currentProcessDataTable.NewRow();
            attributeRow["Campos"] = "TT";
            currentProcessDataTable.Rows.Add(attributeRow);

            attributeRow = currentProcessDataTable.NewRow();
            attributeRow["Campos"] = "TR";
            currentProcessDataTable.Rows.Add(attributeRow);

            attributeRow = currentProcessDataTable.NewRow();
            attributeRow["Campos"] = "Quantum";
            currentProcessDataTable.Rows.Add(attributeRow);

            DataGridViewCurrentProcess.DataSource = currentProcessDataTable;
        }

        private void InitializeBlockedProcessesDataGridView()
        {
            blockedProcessesDataTable.Columns.Add("ID");
            blockedProcessesDataTable.Columns.Add("TT");

            DataGridViewBlockedProcesses.DataSource = blockedProcessesDataTable;
        }

        private void InitilizeCompletedProcessesDataGridView()
        {
            completedProcessesDataTable.Columns.Add("ID");
            completedProcessesDataTable.Columns.Add("OPE");
            completedProcessesDataTable.Columns.Add("RES");

            DataGridViewCompletedProcesses.DataSource = completedProcessesDataTable;
        }

        private void InitializeMemoryDataGridView()
        {
            int i, j = -1, k, OSCellPosition;

            for (i = 0; i < Memory.NumberOfFrames; i += 2)
            {
                DataGridViewMemory.Rows.Add(i.ToString(), "", "", "", "", "", "", (i + 1).ToString());
            }

            for (i = 0; i < Memory.NumberOfFramesOccupiedByOS; i++)
            {
                if (i % 2 == 0)
                {
                    j++;

                    OSCellPosition = 1;
                }
                else
                {
                    OSCellPosition = 8;
                }

                DataGridViewMemory.Rows[j].Cells[OSCellPosition].Value = "OS";

                OSCellPosition++;

                for (k = 0; k < Frame.NumberOfSlots; k++)
                {
                    DataGridViewMemory.Rows[j].Cells[OSCellPosition + k].Style.BackColor = Color.Black;
                }
            }
        }

        private void InitializeVirtualMemoryDataGridView()
        {
            for (int i = 0; i < VirtualMemory.NumberOfFrames; i += 2)
            {
                DataGridViewVirtualMemory.Rows.Add(i.ToString(), "", "", "", "", "", "", (i + 1).ToString());
            }
        }

        private Process GetNewProcess(int newProcessID)
        {
            Process newProcess = new Process(newProcessID);
            string newProcessOperation;

            newProcess.Size = numberGenerator.Next(7, 35);

            newProcessOperation = numberGenerator.Next(1, 101).ToString();

            switch (numberGenerator.Next(0, 5))
            {
                case (int)OperationType.Addition:
                    newProcessOperation += "+";
                    break;

                case (int)OperationType.Subtraction:
                    newProcessOperation += "-";
                    break;

                case (int)OperationType.Multiplication:
                    newProcessOperation += "*";
                    break;

                case (int)OperationType.Division:
                    newProcessOperation += "/";
                    break;

                case (int)OperationType.Modulo:
                    newProcessOperation += "%";
                    break;
            }

            newProcessOperation += numberGenerator.Next(1, 101).ToString();

            newProcess.Operation = newProcessOperation;

            newProcess.EstimatedTime = numberGenerator.Next(7, 19);

            return newProcess;
        }

        private void SetReadyProcessesDataGridView()
        {
            Process readyProcess;
            DataRow readyProcessesRow;

            while (newProcessesQueue.Count != 0 && globalMemory.Add(newProcessesQueue.Peek()))
            {
                readyProcess = newProcessesQueue.Dequeue();
                readyProcess.ArrivalTime = Convert.ToInt32(LabelCounterNumber.Text);

                readyProcessesRow = readyProcessesDataTable.NewRow();
                readyProcessesRow["ID"] = readyProcess.ID;
                readyProcessesRow["TME"] = readyProcess.EstimatedTime;
                readyProcessesRow["TR"] = readyProcess.EstimatedTime - readyProcess.BurstTime;
                readyProcessesDataTable.Rows.Add(readyProcessesRow);

                readyProcessesQueue.Enqueue(readyProcess);

                LabelNumOfRemainingNewProcesses.Text = (Convert.ToInt32(LabelNumOfRemainingNewProcesses.Text) - 1).ToString();

                AddMemoryDataGridViewProcess(readyProcess);

                if (newProcessesQueue.Count != 0)
                {
                    LabelNextNewProcessIDValue.Text = newProcessesQueue.Peek().ID.ToString();
                    LabelNextNewProcessSizeValue.Text = newProcessesQueue.Peek().Size.ToString();
                }
                else
                {
                    LabelNextNewProcessIDValue.Text = "0";
                    LabelNextNewProcessSizeValue.Text = "0";
                }
            }
        }

        private void AddReadyProcessesDataGridViewRow(Process readyProcess)
        {
            DataRow readyProcessesRow = readyProcessesDataTable.NewRow();

            readyProcessesRow["ID"] = readyProcess.ID;
            readyProcessesRow["TME"] = readyProcess.EstimatedTime;
            readyProcessesRow["TR"] = readyProcess.EstimatedTime - readyProcess.BurstTime;

            readyProcessesDataTable.Rows.Add(readyProcessesRow);
        }

        private void SetCurrentProcessDataGridView()
        {
            while (true)
            {
                currentProcess = readyProcessesQueue.Dequeue();

                if (ReturnCurrentProcessToMemory())
                {
                    break;
                }

                readyProcessesQueue.Enqueue(currentProcess);

                readyProcessesDataTable.Rows[0].Delete();
                AddReadyProcessesDataGridViewRow(currentProcess);
            }

            if (currentProcess.ResponseTime == -1)
            {
                currentProcess.ResponseTime = Convert.ToInt32(LabelCounterNumber.Text) - currentProcess.ArrivalTime;
            }

            currentProcessDataTable.Rows[(int)ProcessAttributes.ID]["Datos"] = currentProcess.ID;
            currentProcessDataTable.Rows[(int)ProcessAttributes.Operation]["Datos"] = currentProcess.Operation;
            currentProcessDataTable.Rows[(int)ProcessAttributes.EstimatedTime]["Datos"] = currentProcess.EstimatedTime;
            currentProcessDataTable.Rows[(int)ProcessAttributes.TimeElapsed]["Datos"] = currentProcess.BurstTime;
            currentProcessDataTable.Rows[(int)ProcessAttributes.TimeRemaining]["Datos"] = currentProcess.EstimatedTime - currentProcess.BurstTime;
            currentProcessDataTable.Rows[(int)ProcessAttributes.Quantum]["Datos"] = 0;

            readyProcessesDataTable.Rows[0].Delete();

            UpdateMemoryDataGridViewProcessColor(currentProcess, Color.Red);
        }

        private bool ReturnCurrentProcessToMemory()
        {
            List<int> currentProcessVirtualMemoryFramesIndices = globalVirtualMemory.FindIndices(currentProcess);

            if (currentProcessVirtualMemoryFramesIndices.Count == 0)
            {
                return true;
            }

            List<int> framesToSwapIndices = globalMemory.FindIndicesToSwap(currentProcessVirtualMemoryFramesIndices.Count);

            if (framesToSwapIndices.Count == 0)
            {
                return false;
            }

            for (int i = 0; i < framesToSwapIndices.Count; i++)
            {
                RemoveMemoryDataGridViewFrame(framesToSwapIndices[i]);
                RemoveVirtualMemoryDataGridViewFrame(currentProcessVirtualMemoryFramesIndices[i]);

                SwapFrames(framesToSwapIndices[i], currentProcessVirtualMemoryFramesIndices[i]);

                if (!globalVirtualMemory.Frames[currentProcessVirtualMemoryFramesIndices[i]].IsEmpty())
                {
                    if (!blockedProcessesList.Contains(globalVirtualMemory.Frames[currentProcessVirtualMemoryFramesIndices[i]].CurrentProcess))
                    {
                        AddVirtualMemoryDataGridViewFrame(currentProcessVirtualMemoryFramesIndices[i], Color.Blue);
                    }
                    else
                    {
                        AddVirtualMemoryDataGridViewFrame(currentProcessVirtualMemoryFramesIndices[i], Color.Purple);
                    }
                }

                AddMemoryDataGridViewFrame(framesToSwapIndices[i], Color.Blue);
            }

            return true;
        }

        private void SwapFrames(int memoryFrameIndex, int virtualMemoryFrameIndex)
        {
            Frame auxiliaryFrame = globalMemory.Frames[memoryFrameIndex];

            globalMemory.Frames[memoryFrameIndex] = globalVirtualMemory.Frames[virtualMemoryFrameIndex];
            globalVirtualMemory.Frames[virtualMemoryFrameIndex] = auxiliaryFrame;
        }

        private void AddMemoryDataGridViewProcess(Process processToAdd)
        {
            List<int> processToAddFramesIndices = globalMemory.FindIndices(processToAdd);
            int i, processToAddCellIndex;

            foreach (int frameIndex in processToAddFramesIndices)
            {
                if (frameIndex % 2 == 0)
                {
                    processToAddCellIndex = 1;
                }
                else
                {
                    processToAddCellIndex = 8;
                }

                DataGridViewMemory.Rows[frameIndex / 2].Cells[processToAddCellIndex].Value = processToAdd.ID;

                processToAddCellIndex++;

                for (i = 0; i < globalMemory.Frames[frameIndex].SlotsOccupied; i++)
                {
                    DataGridViewMemory.Rows[frameIndex / 2].Cells[processToAddCellIndex + i].Style.BackColor = Color.Blue;
                }
            }
        }

        private void AddMemoryDataGridViewFrame(int frameIndex, Color frameColor)
        {
            int i, processToAddCellIndex;

            if (frameIndex % 2 == 0)
            {
                processToAddCellIndex = 1;
            }
            else
            {
                processToAddCellIndex = 8;
            }

            DataGridViewMemory.Rows[frameIndex / 2].Cells[processToAddCellIndex].Value = globalMemory.Frames[frameIndex].CurrentProcess.ID;

            processToAddCellIndex++;

            for (i = 0; i < globalMemory.Frames[frameIndex].SlotsOccupied; i++)
            {
                DataGridViewMemory.Rows[frameIndex / 2].Cells[processToAddCellIndex + i].Style.BackColor = frameColor;
            }
        }

        private void AddVirtualMemoryDataGridViewFrame(int frameIndex, Color frameColor)
        {
            int i, processToAddCellIndex;

            if (frameIndex % 2 == 0)
            {
                processToAddCellIndex = 1;
            }
            else
            {
                processToAddCellIndex = 8;
            }

            // Swaping is done with spaces in blank.
            DataGridViewVirtualMemory.Rows[frameIndex / 2].Cells[processToAddCellIndex].Value = globalVirtualMemory.Frames[frameIndex].CurrentProcess.ID;

            processToAddCellIndex++;

            for (i = 0; i < globalVirtualMemory.Frames[frameIndex].SlotsOccupied; i++)
            {
                DataGridViewVirtualMemory.Rows[frameIndex / 2].Cells[processToAddCellIndex + i].Style.BackColor = frameColor;
            }
        }

        private void UpdateMemoryDataGridViewProcessColor(Process processToUpdate, Color newColor)
        {
            List<int> processToUpdateFramesIndices = globalMemory.FindIndices(processToUpdate);
            int i, processToUpdateCellIndex;

            foreach (int frameIndex in processToUpdateFramesIndices)
            {
                if (frameIndex % 2 == 0)
                {
                    processToUpdateCellIndex = 2;
                }
                else
                {
                    processToUpdateCellIndex = 9;
                }

                for (i = 0; i < globalMemory.Frames[frameIndex].SlotsOccupied; i++)
                {
                    DataGridViewMemory.Rows[frameIndex / 2].Cells[processToUpdateCellIndex + i].Style.BackColor = newColor;
                }
            }
        }

        private void UpdateVirtualMemoryDataGridViewProcessColor(Process processToUpdate, Color newColor)
        {
            List<int> processToUpdateFramesIndices = globalVirtualMemory.FindIndices(processToUpdate);
            int i, processToUpdateCellIndex;

            foreach (int frameIndex in processToUpdateFramesIndices)
            {
                if (frameIndex % 2 == 0)
                {
                    processToUpdateCellIndex = 2;
                }
                else
                {
                    processToUpdateCellIndex = 9;
                }

                for (i = 0; i < globalVirtualMemory.Frames[frameIndex].SlotsOccupied; i++)
                {
                    DataGridViewVirtualMemory.Rows[frameIndex / 2].Cells[processToUpdateCellIndex + i].Style.BackColor = newColor;
                }
            }
        }

        private void RemoveMemoryDataGridViewProcess(Process processToRemove)
        {
            List<int> processToRemoveFramesIndices = globalMemory.FindIndices(processToRemove);
            int i, processToRemoveCellIndex;

            foreach (int frameIndex in processToRemoveFramesIndices)
            {
                if (frameIndex % 2 == 0)
                {
                    processToRemoveCellIndex = 1;
                }
                else
                {
                    processToRemoveCellIndex = 8;
                }

                DataGridViewMemory.Rows[frameIndex / 2].Cells[processToRemoveCellIndex].Value = "";

                processToRemoveCellIndex++;

                for (i = 0; i < globalMemory.Frames[frameIndex].SlotsOccupied; i++)
                {
                    DataGridViewMemory.Rows[frameIndex / 2].Cells[processToRemoveCellIndex + i].Style.BackColor = Color.White;
                }
            }
        }

        private void RemoveVirtualMemoryDataGridViewProcess(Process processToRemove)
        {
            List<int> processToRemoveFramesIndices = globalVirtualMemory.FindIndices(processToRemove);
            int i, processToRemoveCellIndex;

            foreach (int frameIndex in processToRemoveFramesIndices)
            {
                if (frameIndex % 2 == 0)
                {
                    processToRemoveCellIndex = 1;
                }
                else
                {
                    processToRemoveCellIndex = 8;
                }

                DataGridViewVirtualMemory.Rows[frameIndex / 2].Cells[processToRemoveCellIndex].Value = "";

                processToRemoveCellIndex++;

                for (i = 0; i < globalVirtualMemory.Frames[frameIndex].SlotsOccupied; i++)
                {
                    DataGridViewVirtualMemory.Rows[frameIndex / 2].Cells[processToRemoveCellIndex + i].Style.BackColor = Color.White;
                }
            }
        }

        private void RemoveMemoryDataGridViewFrame(int frameIndex)
        {
            int i, processToRemoveCellIndex;

            if (frameIndex % 2 == 0)
            {
                processToRemoveCellIndex = 1;
            }
            else
            {
                processToRemoveCellIndex = 8;
            }

            DataGridViewMemory.Rows[frameIndex / 2].Cells[processToRemoveCellIndex].Value = "";

            processToRemoveCellIndex++;

            for (i = 0; i < globalMemory.Frames[frameIndex].SlotsOccupied; i++)
            {
                DataGridViewMemory.Rows[frameIndex / 2].Cells[processToRemoveCellIndex + i].Style.BackColor = Color.White;
            }
        }

        private void RemoveVirtualMemoryDataGridViewFrame(int frameIndex)
        {
            int i, processToRemoveCellIndex;

            if (frameIndex % 2 == 0)
            {
                processToRemoveCellIndex = 1;
            }
            else
            {
                processToRemoveCellIndex = 8;
            }

            DataGridViewVirtualMemory.Rows[frameIndex / 2].Cells[processToRemoveCellIndex].Value = "";

            processToRemoveCellIndex++;

            for (i = 0; i < globalVirtualMemory.Frames[frameIndex].SlotsOccupied; i++)
            {
                DataGridViewVirtualMemory.Rows[frameIndex / 2].Cells[processToRemoveCellIndex + i].Style.BackColor = Color.White;
            }
        }

        private void ClearCurrentProcessDataGridView()
        {
            for (int i = 0; i < currentProcessDataTable.Rows.Count; i++)
            {
                currentProcessDataTable.Rows[i]["Datos"] = string.Empty;
            }
        }

        private void AddCompletedProcessToDataGridView(bool error)
        {
            DataRow completedProcessRow = completedProcessesDataTable.NewRow();

            if (error)
            {
                currentProcess.Result = "ERROR";
            }
            else
            {
                Expression processOperation = new Expression(currentProcess.Operation);

                currentProcess.Result = processOperation.Evaluate().ToString();
            }

            currentProcess.CompletionTime = Convert.ToInt32(LabelCounterNumber.Text);
            currentProcess.TurnAroundTime = currentProcess.CompletionTime - currentProcess.ArrivalTime;
            currentProcess.WaitingTime = currentProcess.TurnAroundTime - currentProcess.BurstTime;

            completedProcessRow["ID"] = currentProcess.ID;
            completedProcessRow["OPE"] = currentProcess.Operation;
            completedProcessRow["RES"] = currentProcess.Result;

            RemoveMemoryDataGridViewProcess(currentProcess);

            globalMemory.Remove(currentProcess);

            completedProcessesDataTable.Rows.Add(completedProcessRow);
        }

        private void UpdateReadyProcessesCurrentProcessDataGridView()
        {
            ClearCurrentProcessDataGridView();

            currentProcess = null;

            if (readyProcessesQueue.Count != 0)
            {
                SetCurrentProcessDataGridView();
            }
            else if (blockedProcessesList.Count == 0)
            {
                Queue<Process> suspendedProcessesQueue = JsonConvert.DeserializeObject<Queue<Process>>(File.ReadAllText("Procesos Suspendidos.txt"));

                if (suspendedProcessesQueue.Count != 0)
                {
                    return;
                }

                ButtonAddProcesses.Enabled = true;

                TimerProcessEstimatedTime.Enabled = false;

                using (FormProcessControlBlock processControlBlockForm = new FormProcessControlBlock(newProcessesQueue, readyProcessesQueue,
                    currentProcess, blockedProcessesList, completedProcessesList, Convert.ToInt32(LabelCounterNumber.Text)))
                {
                    processControlBlockForm.ShowDialog();
                }
            }
        }

        private void ResetTools()
        {
            completedProcessesDataTable.Rows.Clear();

            completedProcessesList.Clear();

            LabelCounterNumber.Text = "0";

            globalProcessID = 1;
        }
    }
}
