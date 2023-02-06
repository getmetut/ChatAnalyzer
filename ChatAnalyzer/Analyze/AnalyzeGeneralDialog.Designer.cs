namespace ChatAnalyzer.Analyze
{
    partial class AnalyzeGeneralDialog
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxKind = new System.Windows.Forms.GroupBox();
            this.radioButtonKindGeneral = new System.Windows.Forms.RadioButton();
            this.radioButtonKindPersonal = new System.Windows.Forms.RadioButton();
            this.textBoxMinAmount = new System.Windows.Forms.TextBox();
            this.labelMinAmount = new System.Windows.Forms.Label();
            this.labelConsider = new System.Windows.Forms.Label();
            this.checkBoxPartials = new System.Windows.Forms.CheckBox();
            this.checkBoxPrepositions = new System.Windows.Forms.CheckBox();
            this.checkBoxPronouns = new System.Windows.Forms.CheckBox();
            this.groupBoxKind.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOK.Location = new System.Drawing.Point(19, 191);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(98, 28);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancel.Location = new System.Drawing.Point(125, 191);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(98, 28);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBoxKind
            // 
            this.groupBoxKind.Controls.Add(this.radioButtonKindGeneral);
            this.groupBoxKind.Controls.Add(this.radioButtonKindPersonal);
            this.groupBoxKind.Location = new System.Drawing.Point(13, 11);
            this.groupBoxKind.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxKind.Name = "groupBoxKind";
            this.groupBoxKind.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxKind.Size = new System.Drawing.Size(210, 53);
            this.groupBoxKind.TabIndex = 9;
            this.groupBoxKind.TabStop = false;
            this.groupBoxKind.Text = "Вид";
            // 
            // radioButtonKindGeneral
            // 
            this.radioButtonKindGeneral.AutoSize = true;
            this.radioButtonKindGeneral.Checked = true;
            this.radioButtonKindGeneral.Location = new System.Drawing.Point(136, 22);
            this.radioButtonKindGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonKindGeneral.Name = "radioButtonKindGeneral";
            this.radioButtonKindGeneral.Size = new System.Drawing.Size(66, 19);
            this.radioButtonKindGeneral.TabIndex = 1;
            this.radioButtonKindGeneral.TabStop = true;
            this.radioButtonKindGeneral.Text = "Общий";
            this.radioButtonKindGeneral.UseVisualStyleBackColor = true;
            // 
            // radioButtonKindPersonal
            // 
            this.radioButtonKindPersonal.AutoSize = true;
            this.radioButtonKindPersonal.Location = new System.Drawing.Point(8, 22);
            this.radioButtonKindPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonKindPersonal.Name = "radioButtonKindPersonal";
            this.radioButtonKindPersonal.Size = new System.Drawing.Size(109, 19);
            this.radioButtonKindPersonal.TabIndex = 0;
            this.radioButtonKindPersonal.Text = "Персональный";
            this.radioButtonKindPersonal.UseVisualStyleBackColor = true;
            // 
            // textBoxMinAmount
            // 
            this.textBoxMinAmount.Location = new System.Drawing.Point(160, 160);
            this.textBoxMinAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMinAmount.Name = "textBoxMinAmount";
            this.textBoxMinAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxMinAmount.Size = new System.Drawing.Size(63, 23);
            this.textBoxMinAmount.TabIndex = 11;
            this.textBoxMinAmount.Text = "50";
            // 
            // labelMinAmount
            // 
            this.labelMinAmount.AutoSize = true;
            this.labelMinAmount.Location = new System.Drawing.Point(13, 153);
            this.labelMinAmount.Margin = new System.Windows.Forms.Padding(4);
            this.labelMinAmount.Name = "labelMinAmount";
            this.labelMinAmount.Size = new System.Drawing.Size(143, 30);
            this.labelMinAmount.TabIndex = 12;
            this.labelMinAmount.Text = "Минимальное\r\nколичество повторений:";
            // 
            // labelConsider
            // 
            this.labelConsider.AutoSize = true;
            this.labelConsider.Location = new System.Drawing.Point(13, 72);
            this.labelConsider.Margin = new System.Windows.Forms.Padding(4);
            this.labelConsider.Name = "labelConsider";
            this.labelConsider.Size = new System.Drawing.Size(85, 15);
            this.labelConsider.TabIndex = 13;
            this.labelConsider.Text = "Не учитывать:";
            // 
            // checkBoxPartials
            // 
            this.checkBoxPartials.AutoSize = true;
            this.checkBoxPartials.Checked = true;
            this.checkBoxPartials.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPartials.Location = new System.Drawing.Point(123, 72);
            this.checkBoxPartials.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxPartials.Name = "checkBoxPartials";
            this.checkBoxPartials.Size = new System.Drawing.Size(74, 19);
            this.checkBoxPartials.TabIndex = 14;
            this.checkBoxPartials.Text = "Частицы";
            this.checkBoxPartials.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrepositions
            // 
            this.checkBoxPrepositions.AutoSize = true;
            this.checkBoxPrepositions.Checked = true;
            this.checkBoxPrepositions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPrepositions.Location = new System.Drawing.Point(123, 99);
            this.checkBoxPrepositions.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxPrepositions.Name = "checkBoxPrepositions";
            this.checkBoxPrepositions.Size = new System.Drawing.Size(80, 19);
            this.checkBoxPrepositions.TabIndex = 15;
            this.checkBoxPrepositions.Text = "Предлоги";
            this.checkBoxPrepositions.UseVisualStyleBackColor = true;
            // 
            // checkBoxPronouns
            // 
            this.checkBoxPronouns.AutoSize = true;
            this.checkBoxPronouns.Checked = true;
            this.checkBoxPronouns.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPronouns.Location = new System.Drawing.Point(123, 126);
            this.checkBoxPronouns.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxPronouns.Name = "checkBoxPronouns";
            this.checkBoxPronouns.Size = new System.Drawing.Size(103, 19);
            this.checkBoxPronouns.TabIndex = 16;
            this.checkBoxPronouns.Text = "Местоимения";
            this.checkBoxPronouns.UseVisualStyleBackColor = true;
            // 
            // AnalyzeGeneralDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(239, 231);
            this.Controls.Add(this.checkBoxPronouns);
            this.Controls.Add(this.checkBoxPrepositions);
            this.Controls.Add(this.checkBoxPartials);
            this.Controls.Add(this.labelConsider);
            this.Controls.Add(this.labelMinAmount);
            this.Controls.Add(this.textBoxMinAmount);
            this.Controls.Add(this.groupBoxKind);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(255, 270);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(255, 270);
            this.Name = "AnalyzeGeneralDialog";
            this.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройка анализа";
            this.groupBoxKind.ResumeLayout(false);
            this.groupBoxKind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonOK;
        private Button buttonCancel;
        private GroupBox groupBoxKind;
        private RadioButton radioButtonKindPersonal;
        private RadioButton radioButtonKindGeneral;
        private TextBox textBoxMinAmount;
        private Label labelMinAmount;
        private Label labelConsider;
        private CheckBox checkBoxPartials;
        private CheckBox checkBoxPrepositions;
        private CheckBox checkBoxPronouns;
    }
}