namespace ChatAnalyzer.Analyze
{
    partial class AnalyzeWordDialog
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
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.labelWord = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxKind = new System.Windows.Forms.GroupBox();
            this.radioButtonKindGeneral = new System.Windows.Forms.RadioButton();
            this.radioButtonKindPersonal = new System.Windows.Forms.RadioButton();
            this.groupBoxKind.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(13, 126);
            this.textBoxWord.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWord.Multiline = true;
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxWord.Size = new System.Drawing.Size(209, 64);
            this.textBoxWord.TabIndex = 0;
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Location = new System.Drawing.Point(13, 73);
            this.labelWord.Margin = new System.Windows.Forms.Padding(4);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(171, 45);
            this.labelWord.TabIndex = 1;
            this.labelWord.Text = "Слова и словосочитания\r\nдля анализа\r\n(перечислите через запятую):\r\n";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOK.Location = new System.Drawing.Point(13, 201);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(98, 28);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancel.Location = new System.Drawing.Point(125, 201);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(98, 28);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBoxKind
            // 
            this.groupBoxKind.Controls.Add(this.radioButtonKindGeneral);
            this.groupBoxKind.Controls.Add(this.radioButtonKindPersonal);
            this.groupBoxKind.Location = new System.Drawing.Point(13, 12);
            this.groupBoxKind.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxKind.Name = "groupBoxKind";
            this.groupBoxKind.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxKind.Size = new System.Drawing.Size(210, 53);
            this.groupBoxKind.TabIndex = 11;
            this.groupBoxKind.TabStop = false;
            this.groupBoxKind.Text = "Вид";
            // 
            // radioButtonKindGeneral
            // 
            this.radioButtonKindGeneral.AutoSize = true;
            this.radioButtonKindGeneral.Location = new System.Drawing.Point(137, 23);
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
            this.radioButtonKindPersonal.Location = new System.Drawing.Point(9, 23);
            this.radioButtonKindPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonKindPersonal.Name = "radioButtonKindPersonal";
            this.radioButtonKindPersonal.Size = new System.Drawing.Size(109, 19);
            this.radioButtonKindPersonal.TabIndex = 0;
            this.radioButtonKindPersonal.TabStop = true;
            this.radioButtonKindPersonal.Text = "Персональный";
            this.radioButtonKindPersonal.UseVisualStyleBackColor = true;
            // 
            // AnalyzeWordDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(235, 241);
            this.Controls.Add(this.groupBoxKind);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.textBoxWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AnalyzeWordDialog";
            this.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройка анализа";
            this.groupBoxKind.ResumeLayout(false);
            this.groupBoxKind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxWord;
        private Label labelWord;
        private Button buttonOK;
        private Button buttonCancel;
        private GroupBox groupBoxKind;
        private RadioButton radioButtonKindGeneral;
        private RadioButton radioButtonKindPersonal;
    }
}