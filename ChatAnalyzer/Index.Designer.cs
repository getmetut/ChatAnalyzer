﻿using System.Windows.Forms.DataVisualization.Charting;

namespace ChatAnalyzer
{
    partial class Index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.menuStripIndexMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemResultSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemResultSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.excelFilexlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFiletxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAnalyze = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAnalyzeGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAnalyzeWords = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAnalyzeNextWords = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAnalyzeBadWords = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxAnalyzeButtons = new System.Windows.Forms.GroupBox();
            this.buttonAnalyzeBadWords = new System.Windows.Forms.Button();
            this.buttonAnalyzeNextWords = new System.Windows.Forms.Button();
            this.buttonAnalyzeWords = new System.Windows.Forms.Button();
            this.buttonAnalyzeGeneral = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.listBoxChats = new System.Windows.Forms.ListBox();
            this.labelChats = new System.Windows.Forms.Label();
            this.buttonResultSave = new System.Windows.Forms.Button();
            this.buttonChatsClean = new System.Windows.Forms.Button();
            this.buttonChatsAdd = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBoxResultInfo = new System.Windows.Forms.RichTextBox();
            this.tabControlResult = new System.Windows.Forms.TabControl();
            this.tabPageTable = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewResultP1 = new System.Windows.Forms.DataGridView();
            this.dataGridP1ColumnWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridP1ColumnRepetitions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridP1ColumnRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewResultP2 = new System.Windows.Forms.DataGridView();
            this.dataGridP2ColumnWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridP2ColumnRepetitions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridP2ColumnRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelNameP1 = new System.Windows.Forms.Label();
            this.labelNameP2 = new System.Windows.Forms.Label();
            this.tabPageChart = new System.Windows.Forms.TabPage();
            this.listBoxCharts = new System.Windows.Forms.ListBox();
            this.menuStripIndexMain.SuspendLayout();
            this.groupBoxAnalyzeButtons.SuspendLayout();
            this.tabControlResult.SuspendLayout();
            this.tabPageTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultP2)).BeginInit();
            this.tabPageChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripIndexMain
            // 
            resources.ApplyResources(this.menuStripIndexMain, "menuStripIndexMain");
            this.menuStripIndexMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripIndexMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemAnalyze,
            this.toolStripMenuItemHelp});
            this.menuStripIndexMain.Name = "menuStripIndexMain";
            // 
            // toolStripMenuItemFile
            // 
            resources.ApplyResources(this.toolStripMenuItemFile, "toolStripMenuItemFile");
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFileOpen,
            this.toolStripMenuItemResultSave,
            this.toolStripMenuItemResultSaveAs});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            // 
            // toolStripMenuItemFileOpen
            // 
            resources.ApplyResources(this.toolStripMenuItemFileOpen, "toolStripMenuItemFileOpen");
            this.toolStripMenuItemFileOpen.Name = "toolStripMenuItemFileOpen";
            // 
            // toolStripMenuItemResultSave
            // 
            resources.ApplyResources(this.toolStripMenuItemResultSave, "toolStripMenuItemResultSave");
            this.toolStripMenuItemResultSave.Name = "toolStripMenuItemResultSave";
            this.toolStripMenuItemResultSave.Click += new System.EventHandler(this.toolStripMenuItemResultSave_Click);
            // 
            // toolStripMenuItemResultSaveAs
            // 
            resources.ApplyResources(this.toolStripMenuItemResultSaveAs, "toolStripMenuItemResultSaveAs");
            this.toolStripMenuItemResultSaveAs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelFilexlsToolStripMenuItem,
            this.textFiletxtToolStripMenuItem});
            this.toolStripMenuItemResultSaveAs.Name = "toolStripMenuItemResultSaveAs";
            // 
            // excelFilexlsToolStripMenuItem
            // 
            resources.ApplyResources(this.excelFilexlsToolStripMenuItem, "excelFilexlsToolStripMenuItem");
            this.excelFilexlsToolStripMenuItem.Name = "excelFilexlsToolStripMenuItem";
            this.excelFilexlsToolStripMenuItem.Click += new System.EventHandler(this.excelFilexlsToolStripMenuItem_Click);
            // 
            // textFiletxtToolStripMenuItem
            // 
            resources.ApplyResources(this.textFiletxtToolStripMenuItem, "textFiletxtToolStripMenuItem");
            this.textFiletxtToolStripMenuItem.Name = "textFiletxtToolStripMenuItem";
            this.textFiletxtToolStripMenuItem.Click += new System.EventHandler(this.textFiletxtToolStripMenuItem_Click);
            // 
            // toolStripMenuItemAnalyze
            // 
            resources.ApplyResources(this.toolStripMenuItemAnalyze, "toolStripMenuItemAnalyze");
            this.toolStripMenuItemAnalyze.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAnalyzeGeneral,
            this.toolStripMenuItemAnalyzeWords,
            this.toolStripMenuItemAnalyzeNextWords,
            this.toolStripMenuItemAnalyzeBadWords});
            this.toolStripMenuItemAnalyze.Name = "toolStripMenuItemAnalyze";
            // 
            // toolStripMenuItemAnalyzeGeneral
            // 
            resources.ApplyResources(this.toolStripMenuItemAnalyzeGeneral, "toolStripMenuItemAnalyzeGeneral");
            this.toolStripMenuItemAnalyzeGeneral.Name = "toolStripMenuItemAnalyzeGeneral";
            this.toolStripMenuItemAnalyzeGeneral.Click += new System.EventHandler(this.toolStripMenuItemAnalyzeGeneral_Click);
            // 
            // toolStripMenuItemAnalyzeWords
            // 
            resources.ApplyResources(this.toolStripMenuItemAnalyzeWords, "toolStripMenuItemAnalyzeWords");
            this.toolStripMenuItemAnalyzeWords.Name = "toolStripMenuItemAnalyzeWords";
            this.toolStripMenuItemAnalyzeWords.Click += new System.EventHandler(this.toolStripMenuItemAnalyzeWords_Click);
            // 
            // toolStripMenuItemAnalyzeNextWords
            // 
            resources.ApplyResources(this.toolStripMenuItemAnalyzeNextWords, "toolStripMenuItemAnalyzeNextWords");
            this.toolStripMenuItemAnalyzeNextWords.Name = "toolStripMenuItemAnalyzeNextWords";
            this.toolStripMenuItemAnalyzeNextWords.Click += new System.EventHandler(this.toolStripMenuItemAnalyzeNextWords_Click);
            // 
            // toolStripMenuItemAnalyzeBadWords
            // 
            resources.ApplyResources(this.toolStripMenuItemAnalyzeBadWords, "toolStripMenuItemAnalyzeBadWords");
            this.toolStripMenuItemAnalyzeBadWords.Name = "toolStripMenuItemAnalyzeBadWords";
            // 
            // toolStripMenuItemHelp
            // 
            resources.ApplyResources(this.toolStripMenuItemHelp, "toolStripMenuItemHelp");
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            // 
            // groupBoxAnalyzeButtons
            // 
            resources.ApplyResources(this.groupBoxAnalyzeButtons, "groupBoxAnalyzeButtons");
            this.groupBoxAnalyzeButtons.Controls.Add(this.buttonAnalyzeBadWords);
            this.groupBoxAnalyzeButtons.Controls.Add(this.buttonAnalyzeNextWords);
            this.groupBoxAnalyzeButtons.Controls.Add(this.buttonAnalyzeWords);
            this.groupBoxAnalyzeButtons.Controls.Add(this.buttonAnalyzeGeneral);
            this.groupBoxAnalyzeButtons.Name = "groupBoxAnalyzeButtons";
            this.groupBoxAnalyzeButtons.TabStop = false;
            // 
            // buttonAnalyzeBadWords
            // 
            resources.ApplyResources(this.buttonAnalyzeBadWords, "buttonAnalyzeBadWords");
            this.buttonAnalyzeBadWords.Name = "buttonAnalyzeBadWords";
            this.buttonAnalyzeBadWords.UseVisualStyleBackColor = true;
            // 
            // buttonAnalyzeNextWords
            // 
            resources.ApplyResources(this.buttonAnalyzeNextWords, "buttonAnalyzeNextWords");
            this.buttonAnalyzeNextWords.Name = "buttonAnalyzeNextWords";
            this.buttonAnalyzeNextWords.UseVisualStyleBackColor = true;
            // 
            // buttonAnalyzeWords
            // 
            resources.ApplyResources(this.buttonAnalyzeWords, "buttonAnalyzeWords");
            this.buttonAnalyzeWords.Name = "buttonAnalyzeWords";
            this.buttonAnalyzeWords.UseVisualStyleBackColor = true;
            // 
            // buttonAnalyzeGeneral
            // 
            resources.ApplyResources(this.buttonAnalyzeGeneral, "buttonAnalyzeGeneral");
            this.buttonAnalyzeGeneral.Name = "buttonAnalyzeGeneral";
            this.buttonAnalyzeGeneral.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            resources.ApplyResources(this.labelResult, "labelResult");
            this.labelResult.Name = "labelResult";
            // 
            // listBoxChats
            // 
            resources.ApplyResources(this.listBoxChats, "listBoxChats");
            this.listBoxChats.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxChats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxChats.FormattingEnabled = true;
            this.listBoxChats.Name = "listBoxChats";
            // 
            // labelChats
            // 
            resources.ApplyResources(this.labelChats, "labelChats");
            this.labelChats.Name = "labelChats";
            // 
            // buttonResultSave
            // 
            resources.ApplyResources(this.buttonResultSave, "buttonResultSave");
            this.buttonResultSave.Name = "buttonResultSave";
            this.buttonResultSave.UseVisualStyleBackColor = true;
            this.buttonResultSave.Click += new System.EventHandler(this.buttonResultSave_Click);
            // 
            // buttonChatsClean
            // 
            resources.ApplyResources(this.buttonChatsClean, "buttonChatsClean");
            this.buttonChatsClean.Name = "buttonChatsClean";
            this.buttonChatsClean.UseVisualStyleBackColor = true;
            this.buttonChatsClean.Click += new System.EventHandler(this.buttonChatsClean_Click);
            // 
            // buttonChatsAdd
            // 
            resources.ApplyResources(this.buttonChatsAdd, "buttonChatsAdd");
            this.buttonChatsAdd.Name = "buttonChatsAdd";
            this.buttonChatsAdd.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            this.openFileDialog1.Multiselect = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.CheckPathExists = false;
            this.saveFileDialog1.FileName = "ChatAnalysisResult";
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            this.saveFileDialog1.OverwritePrompt = false;
            // 
            // textBoxResultInfo
            // 
            resources.ApplyResources(this.textBoxResultInfo, "textBoxResultInfo");
            this.textBoxResultInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxResultInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResultInfo.Name = "textBoxResultInfo";
            this.textBoxResultInfo.ReadOnly = true;
            // 
            // tabControlResult
            // 
            resources.ApplyResources(this.tabControlResult, "tabControlResult");
            this.tabControlResult.Controls.Add(this.tabPageTable);
            this.tabControlResult.Controls.Add(this.tabPageChart);
            this.tabControlResult.Name = "tabControlResult";
            this.tabControlResult.SelectedIndex = 0;
            // 
            // tabPageTable
            // 
            resources.ApplyResources(this.tabPageTable, "tabPageTable");
            this.tabPageTable.Controls.Add(this.tableLayoutPanel1);
            this.tabPageTable.Name = "tabPageTable";
            this.tabPageTable.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewResultP1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewResultP2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelNameP1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNameP2, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // dataGridViewResultP1
            // 
            resources.ApplyResources(this.dataGridViewResultP1, "dataGridViewResultP1");
            this.dataGridViewResultP1.AllowUserToAddRows = false;
            this.dataGridViewResultP1.AllowUserToDeleteRows = false;
            this.dataGridViewResultP1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultP1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridP1ColumnWord,
            this.dataGridP1ColumnRepetitions,
            this.dataGridP1ColumnRatio});
            this.dataGridViewResultP1.Name = "dataGridViewResultP1";
            this.dataGridViewResultP1.ReadOnly = true;
            this.dataGridViewResultP1.RowTemplate.Height = 25;
            // 
            // dataGridP1ColumnWord
            // 
            this.dataGridP1ColumnWord.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.dataGridP1ColumnWord, "dataGridP1ColumnWord");
            this.dataGridP1ColumnWord.Name = "dataGridP1ColumnWord";
            this.dataGridP1ColumnWord.ReadOnly = true;
            // 
            // dataGridP1ColumnRepetitions
            // 
            resources.ApplyResources(this.dataGridP1ColumnRepetitions, "dataGridP1ColumnRepetitions");
            this.dataGridP1ColumnRepetitions.Name = "dataGridP1ColumnRepetitions";
            this.dataGridP1ColumnRepetitions.ReadOnly = true;
            // 
            // dataGridP1ColumnRatio
            // 
            resources.ApplyResources(this.dataGridP1ColumnRatio, "dataGridP1ColumnRatio");
            this.dataGridP1ColumnRatio.Name = "dataGridP1ColumnRatio";
            this.dataGridP1ColumnRatio.ReadOnly = true;
            // 
            // dataGridViewResultP2
            // 
            resources.ApplyResources(this.dataGridViewResultP2, "dataGridViewResultP2");
            this.dataGridViewResultP2.AllowUserToAddRows = false;
            this.dataGridViewResultP2.AllowUserToDeleteRows = false;
            this.dataGridViewResultP2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultP2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridP2ColumnWord,
            this.dataGridP2ColumnRepetitions,
            this.dataGridP2ColumnRatio});
            this.dataGridViewResultP2.Name = "dataGridViewResultP2";
            this.dataGridViewResultP2.ReadOnly = true;
            this.dataGridViewResultP2.RowTemplate.Height = 25;
            // 
            // dataGridP2ColumnWord
            // 
            this.dataGridP2ColumnWord.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.dataGridP2ColumnWord, "dataGridP2ColumnWord");
            this.dataGridP2ColumnWord.Name = "dataGridP2ColumnWord";
            this.dataGridP2ColumnWord.ReadOnly = true;
            // 
            // dataGridP2ColumnRepetitions
            // 
            resources.ApplyResources(this.dataGridP2ColumnRepetitions, "dataGridP2ColumnRepetitions");
            this.dataGridP2ColumnRepetitions.Name = "dataGridP2ColumnRepetitions";
            this.dataGridP2ColumnRepetitions.ReadOnly = true;
            // 
            // dataGridP2ColumnRatio
            // 
            resources.ApplyResources(this.dataGridP2ColumnRatio, "dataGridP2ColumnRatio");
            this.dataGridP2ColumnRatio.Name = "dataGridP2ColumnRatio";
            this.dataGridP2ColumnRatio.ReadOnly = true;
            // 
            // labelNameP1
            // 
            resources.ApplyResources(this.labelNameP1, "labelNameP1");
            this.labelNameP1.Name = "labelNameP1";
            // 
            // labelNameP2
            // 
            resources.ApplyResources(this.labelNameP2, "labelNameP2");
            this.labelNameP2.Name = "labelNameP2";
            // 
            // tabPageChart
            // 
            resources.ApplyResources(this.tabPageChart, "tabPageChart");
            this.tabPageChart.Controls.Add(this.listBoxCharts);
            this.tabPageChart.Name = "tabPageChart";
            this.tabPageChart.UseVisualStyleBackColor = true;
            // 
            // listBoxCharts
            // 
            resources.ApplyResources(this.listBoxCharts, "listBoxCharts");
            this.listBoxCharts.FormattingEnabled = true;
            this.listBoxCharts.Name = "listBoxCharts";
            // 
            // Index
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.tabControlResult);
            this.Controls.Add(this.textBoxResultInfo);
            this.Controls.Add(this.listBoxChats);
            this.Controls.Add(this.buttonChatsAdd);
            this.Controls.Add(this.buttonChatsClean);
            this.Controls.Add(this.buttonResultSave);
            this.Controls.Add(this.labelChats);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.groupBoxAnalyzeButtons);
            this.Controls.Add(this.menuStripIndexMain);
            this.MainMenuStrip = this.menuStripIndexMain;
            this.Name = "Index";
            this.menuStripIndexMain.ResumeLayout(false);
            this.menuStripIndexMain.PerformLayout();
            this.groupBoxAnalyzeButtons.ResumeLayout(false);
            this.tabControlResult.ResumeLayout(false);
            this.tabPageTable.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultP2)).EndInit();
            this.tabPageChart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void InitializeCharts()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            //
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(3, 3);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(736, 294);
            this.chart.TabIndex = 17;
            this.chart.Text = "chart";

            this.tabPageChart.Controls.Add(this.chart);

            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
        }

        private MenuStrip menuStripIndexMain;
        private ToolStripMenuItem toolStripMenuItemFile;
        private ToolStripMenuItem toolStripMenuItemFileOpen;
        private ToolStripMenuItem toolStripMenuItemResultSaveAs;
        private ToolStripMenuItem toolStripMenuItemAnalyze;
        private ToolStripMenuItem toolStripMenuItemAnalyzeGeneral;
        private ToolStripMenuItem toolStripMenuItemAnalyzeWords;
        private ToolStripMenuItem toolStripMenuItemAnalyzeNextWords;
        private ToolStripMenuItem toolStripMenuItemAnalyzeBadWords;
        private ToolStripMenuItem toolStripMenuItemHelp;
        private GroupBox groupBoxAnalyzeButtons;
        private Button buttonAnalyzeBadWords;
        private Button buttonAnalyzeNextWords;
        private Button buttonAnalyzeWords;
        private Button buttonAnalyzeGeneral;
        private Label labelResult;
        private ListBox listBoxChats;
        private Label labelChats;
        private Button buttonResultSave;
        private Button buttonChatsClean;
        private Button buttonChatsAdd;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        internal RichTextBox textBoxResultInfo;
        private TabControl tabControlResult;
        private TabPage tabPageTable;
        private TabPage tabPageChart;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridViewResultP2;
        private DataGridView dataGridViewResultP1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart = new();
        private DataGridViewTextBoxColumn dataGridP1ColumnWord;
        private DataGridViewTextBoxColumn dataGridP1ColumnRepetitions;
        private DataGridViewTextBoxColumn dataGridP1ColumnRatio;
        private DataGridViewTextBoxColumn dataGridP2ColumnWord;
        private DataGridViewTextBoxColumn dataGridP2ColumnRepetitions;
        private DataGridViewTextBoxColumn dataGridP2ColumnRatio;
        private Label labelNameP1;
        private Label labelNameP2;
        private ToolStripMenuItem toolStripMenuItemResultSave;
        private ToolStripMenuItem excelFilexlsToolStripMenuItem;
        private ToolStripMenuItem textFiletxtToolStripMenuItem;
        private ListBox listBoxCharts;
    }
}