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
            this.toolStripMenuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAnalyze = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAnalyzeGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAnalyzeWord = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAnalyzeWords = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAnalyzePhrase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAnalyzeBadWords = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxAnalyzeButtons = new System.Windows.Forms.GroupBox();
            this.buttonAnalyzeBadWords = new System.Windows.Forms.Button();
            this.buttonAnalyzePhrase = new System.Windows.Forms.Button();
            this.buttonAnalyzeWords = new System.Windows.Forms.Button();
            this.buttonAnalyzeWord = new System.Windows.Forms.Button();
            this.buttonAnalyzeGeneral = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.listBoxChats = new System.Windows.Forms.ListBox();
            this.labelChats = new System.Windows.Forms.Label();
            this.buttonResultSave = new System.Windows.Forms.Button();
            this.buttonChatsRemove = new System.Windows.Forms.Button();
            this.buttonChatsAdd = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBoxIndexAnalyze = new System.Windows.Forms.RichTextBox();
            this.textBoxPerson2 = new System.Windows.Forms.RichTextBox();
            this.textBoxPerson1 = new System.Windows.Forms.RichTextBox();
            this.menuStripIndexMain.SuspendLayout();
            this.groupBoxAnalyzeButtons.SuspendLayout();
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
            this.toolStripMenuItemFileSave,
            this.toolStripMenuItemFileSaveAs});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            // 
            // toolStripMenuItemFileOpen
            // 
            resources.ApplyResources(this.toolStripMenuItemFileOpen, "toolStripMenuItemFileOpen");
            this.toolStripMenuItemFileOpen.Name = "toolStripMenuItemFileOpen";
            // 
            // toolStripMenuItemFileSave
            // 
            resources.ApplyResources(this.toolStripMenuItemFileSave, "toolStripMenuItemFileSave");
            this.toolStripMenuItemFileSave.Name = "toolStripMenuItemFileSave";
            // 
            // toolStripMenuItemFileSaveAs
            // 
            resources.ApplyResources(this.toolStripMenuItemFileSaveAs, "toolStripMenuItemFileSaveAs");
            this.toolStripMenuItemFileSaveAs.Name = "toolStripMenuItemFileSaveAs";
            // 
            // toolStripMenuItemAnalyze
            // 
            resources.ApplyResources(this.toolStripMenuItemAnalyze, "toolStripMenuItemAnalyze");
            this.toolStripMenuItemAnalyze.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAnalyzeGeneral,
            this.toolStripMenuItemAnalyzeWord,
            this.toolStripMenuItemAnalyzeWords,
            this.toolStripMenuItemAnalyzePhrase,
            this.toolStripMenuItemAnalyzeBadWords});
            this.toolStripMenuItemAnalyze.Name = "toolStripMenuItemAnalyze";
            // 
            // toolStripMenuItemAnalyzeGeneral
            // 
            resources.ApplyResources(this.toolStripMenuItemAnalyzeGeneral, "toolStripMenuItemAnalyzeGeneral");
            this.toolStripMenuItemAnalyzeGeneral.Name = "toolStripMenuItemAnalyzeGeneral";
            // 
            // toolStripMenuItemAnalyzeWord
            // 
            resources.ApplyResources(this.toolStripMenuItemAnalyzeWord, "toolStripMenuItemAnalyzeWord");
            this.toolStripMenuItemAnalyzeWord.Name = "toolStripMenuItemAnalyzeWord";
            // 
            // toolStripMenuItemAnalyzeWords
            // 
            resources.ApplyResources(this.toolStripMenuItemAnalyzeWords, "toolStripMenuItemAnalyzeWords");
            this.toolStripMenuItemAnalyzeWords.Name = "toolStripMenuItemAnalyzeWords";
            // 
            // toolStripMenuItemAnalyzePhrase
            // 
            resources.ApplyResources(this.toolStripMenuItemAnalyzePhrase, "toolStripMenuItemAnalyzePhrase");
            this.toolStripMenuItemAnalyzePhrase.Name = "toolStripMenuItemAnalyzePhrase";
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
            this.groupBoxAnalyzeButtons.Controls.Add(this.buttonAnalyzePhrase);
            this.groupBoxAnalyzeButtons.Controls.Add(this.buttonAnalyzeWords);
            this.groupBoxAnalyzeButtons.Controls.Add(this.buttonAnalyzeWord);
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
            // buttonAnalyzePhrase
            // 
            resources.ApplyResources(this.buttonAnalyzePhrase, "buttonAnalyzePhrase");
            this.buttonAnalyzePhrase.Name = "buttonAnalyzePhrase";
            this.buttonAnalyzePhrase.UseVisualStyleBackColor = true;
            // 
            // buttonAnalyzeWords
            // 
            resources.ApplyResources(this.buttonAnalyzeWords, "buttonAnalyzeWords");
            this.buttonAnalyzeWords.Name = "buttonAnalyzeWords";
            this.buttonAnalyzeWords.UseVisualStyleBackColor = true;
            // 
            // buttonAnalyzeWord
            // 
            resources.ApplyResources(this.buttonAnalyzeWord, "buttonAnalyzeWord");
            this.buttonAnalyzeWord.Name = "buttonAnalyzeWord";
            this.buttonAnalyzeWord.UseVisualStyleBackColor = true;
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
            this.listBoxChats.FormattingEnabled = true;
            this.listBoxChats.Name = "listBoxChats";
            this.listBoxChats.SelectedIndexChanged += new System.EventHandler(this.listBoxChats_SelectedIndexChanged);
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
            // 
            // buttonChatsRemove
            // 
            resources.ApplyResources(this.buttonChatsRemove, "buttonChatsRemove");
            this.buttonChatsRemove.Name = "buttonChatsRemove";
            this.buttonChatsRemove.UseVisualStyleBackColor = true;
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
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "FileName";
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // textBoxIndexAnalyze
            // 
            resources.ApplyResources(this.textBoxIndexAnalyze, "textBoxIndexAnalyze");
            this.textBoxIndexAnalyze.Name = "textBoxIndexAnalyze";
            this.textBoxIndexAnalyze.TextChanged += new System.EventHandler(this.textBoxIndexAnalyze_TextChanged_1);
            // 
            // textBoxPerson2
            // 
            resources.ApplyResources(this.textBoxPerson2, "textBoxPerson2");
            this.textBoxPerson2.Name = "textBoxPerson2";
            this.textBoxPerson2.ReadOnly = true;
            // 
            // textBoxPerson1
            // 
            resources.ApplyResources(this.textBoxPerson1, "textBoxPerson1");
            this.textBoxPerson1.Name = "textBoxPerson1";
            this.textBoxPerson1.ReadOnly = true;
            // 
            // Index
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxPerson1);
            this.Controls.Add(this.textBoxPerson2);
            this.Controls.Add(this.textBoxIndexAnalyze);
            this.Controls.Add(this.buttonChatsAdd);
            this.Controls.Add(this.buttonChatsRemove);
            this.Controls.Add(this.buttonResultSave);
            this.Controls.Add(this.labelChats);
            this.Controls.Add(this.listBoxChats);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.groupBoxAnalyzeButtons);
            this.Controls.Add(this.menuStripIndexMain);
            this.MainMenuStrip = this.menuStripIndexMain;
            this.Name = "Index";
            this.menuStripIndexMain.ResumeLayout(false);
            this.menuStripIndexMain.PerformLayout();
            this.groupBoxAnalyzeButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStripIndexMain;
        private ToolStripMenuItem toolStripMenuItemFile;
        private ToolStripMenuItem toolStripMenuItemFileOpen;
        private ToolStripMenuItem toolStripMenuItemFileSave;
        private ToolStripMenuItem toolStripMenuItemFileSaveAs;
        private ToolStripMenuItem toolStripMenuItemAnalyze;
        private ToolStripMenuItem toolStripMenuItemAnalyzeGeneral;
        private ToolStripMenuItem toolStripMenuItemAnalyzeWord;
        private ToolStripMenuItem toolStripMenuItemAnalyzeWords;
        private ToolStripMenuItem toolStripMenuItemAnalyzePhrase;
        private ToolStripMenuItem toolStripMenuItemAnalyzeBadWords;
        private ToolStripMenuItem toolStripMenuItemHelp;
        private GroupBox groupBoxAnalyzeButtons;
        private Button buttonAnalyzeBadWords;
        private Button buttonAnalyzePhrase;
        private Button buttonAnalyzeWords;
        private Button buttonAnalyzeWord;
        private Button buttonAnalyzeGeneral;
        private Label labelResult;
        private ListBox listBoxChats;
        private Label labelChats;
        private Button buttonResultSave;
        private Button buttonChatsRemove;
        private Button buttonChatsAdd;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private RichTextBox textBoxIndexAnalyze;
        private RichTextBox textBoxPerson2;
        public RichTextBox textBoxPerson1;
    }
}