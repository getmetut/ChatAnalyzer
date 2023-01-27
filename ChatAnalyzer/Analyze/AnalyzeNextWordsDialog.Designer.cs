namespace ChatAnalyzer.Analyze
{
    partial class AnalyzeNextWordsDialog
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
            this.groupBoxKind = new System.Windows.Forms.GroupBox();
            this.radioButtonKindGeneral = new System.Windows.Forms.RadioButton();
            this.radioButtonKindPersonal = new System.Windows.Forms.RadioButton();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelWord = new System.Windows.Forms.Label();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.labelAmountWords = new System.Windows.Forms.Label();
            this.textBoxAmountWords = new System.Windows.Forms.TextBox();
            this.labelMinRepeat = new System.Windows.Forms.Label();
            this.textBoxMinRepeat = new System.Windows.Forms.TextBox();
            this.groupBoxKind.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxKind
            // 
            this.groupBoxKind.Controls.Add(this.radioButtonKindGeneral);
            this.groupBoxKind.Controls.Add(this.radioButtonKindPersonal);
            this.groupBoxKind.Location = new System.Drawing.Point(14, 14);
            this.groupBoxKind.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxKind.Name = "groupBoxKind";
            this.groupBoxKind.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxKind.Size = new System.Drawing.Size(210, 53);
            this.groupBoxKind.TabIndex = 16;
            this.groupBoxKind.TabStop = false;
            this.groupBoxKind.Text = "Вид";
            // 
            // radioButtonKindGeneral
            // 
            this.radioButtonKindGeneral.AutoSize = true;
            this.radioButtonKindGeneral.Location = new System.Drawing.Point(138, 24);
            this.radioButtonKindGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonKindGeneral.Name = "radioButtonKindGeneral";
            this.radioButtonKindGeneral.Size = new System.Drawing.Size(66, 19);
            this.radioButtonKindGeneral.TabIndex = 1;
            this.radioButtonKindGeneral.Text = "Общий";
            this.radioButtonKindGeneral.UseVisualStyleBackColor = true;
            // 
            // radioButtonKindPersonal
            // 
            this.radioButtonKindPersonal.AutoSize = true;
            this.radioButtonKindPersonal.Checked = true;
            this.radioButtonKindPersonal.Location = new System.Drawing.Point(10, 24);
            this.radioButtonKindPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonKindPersonal.Name = "radioButtonKindPersonal";
            this.radioButtonKindPersonal.Size = new System.Drawing.Size(109, 19);
            this.radioButtonKindPersonal.TabIndex = 0;
            this.radioButtonKindPersonal.TabStop = true;
            this.radioButtonKindPersonal.Text = "Персональный";
            this.radioButtonKindPersonal.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancel.Location = new System.Drawing.Point(126, 208);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(98, 28);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOK.Location = new System.Drawing.Point(14, 208);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(98, 28);
            this.buttonOK.TabIndex = 14;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Location = new System.Drawing.Point(14, 75);
            this.labelWord.Margin = new System.Windows.Forms.Padding(4);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(108, 15);
            this.labelWord.TabIndex = 13;
            this.labelWord.Text = "Начальные слова:\r\n";
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(14, 98);
            this.textBoxWord.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxWord.Size = new System.Drawing.Size(210, 23);
            this.textBoxWord.TabIndex = 12;
            // 
            // labelAmountWords
            // 
            this.labelAmountWords.AutoSize = true;
            this.labelAmountWords.Location = new System.Drawing.Point(14, 129);
            this.labelAmountWords.Margin = new System.Windows.Forms.Padding(4);
            this.labelAmountWords.Name = "labelAmountWords";
            this.labelAmountWords.Size = new System.Drawing.Size(117, 30);
            this.labelAmountWords.TabIndex = 17;
            this.labelAmountWords.Text = "Количество\r\nпоследующих слов:\r\n";
            // 
            // textBoxAmountWords
            // 
            this.textBoxAmountWords.Location = new System.Drawing.Point(165, 136);
            this.textBoxAmountWords.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAmountWords.Name = "textBoxAmountWords";
            this.textBoxAmountWords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAmountWords.Size = new System.Drawing.Size(59, 23);
            this.textBoxAmountWords.TabIndex = 18;
            this.textBoxAmountWords.Text = "1";
            this.textBoxAmountWords.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelMinRepeat
            // 
            this.labelMinRepeat.AutoSize = true;
            this.labelMinRepeat.Location = new System.Drawing.Point(14, 167);
            this.labelMinRepeat.Margin = new System.Windows.Forms.Padding(4);
            this.labelMinRepeat.Name = "labelMinRepeat";
            this.labelMinRepeat.Size = new System.Drawing.Size(143, 30);
            this.labelMinRepeat.TabIndex = 19;
            this.labelMinRepeat.Text = "Минимальное\r\nколичество повторений:\r\n";
            // 
            // textBoxMinRepeat
            // 
            this.textBoxMinRepeat.Location = new System.Drawing.Point(165, 174);
            this.textBoxMinRepeat.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMinRepeat.Name = "textBoxMinRepeat";
            this.textBoxMinRepeat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMinRepeat.Size = new System.Drawing.Size(59, 23);
            this.textBoxMinRepeat.TabIndex = 20;
            this.textBoxMinRepeat.Text = "1";
            this.textBoxMinRepeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AnalyzeNextWordsDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(239, 249);
            this.Controls.Add(this.textBoxMinRepeat);
            this.Controls.Add(this.labelMinRepeat);
            this.Controls.Add(this.textBoxAmountWords);
            this.Controls.Add(this.labelAmountWords);
            this.Controls.Add(this.groupBoxKind);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.textBoxWord);
            this.MaximumSize = new System.Drawing.Size(255, 288);
            this.MinimumSize = new System.Drawing.Size(255, 288);
            this.Name = "AnalyzeNextWordsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AnalyzeNextWordsDialog";
            this.groupBoxKind.ResumeLayout(false);
            this.groupBoxKind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxKind;
        private RadioButton radioButtonKindGeneral;
        private RadioButton radioButtonKindPersonal;
        private Button buttonCancel;
        private Button buttonOK;
        private Label labelWord;
        private TextBox textBoxWord;
        private Label labelAmountWords;
        private TextBox textBoxAmountWords;
        private Label labelMinRepeat;
        private TextBox textBoxMinRepeat;
    }
}