namespace ChatAnalyzer.Analyze
{
    partial class GeneralAnalyzeDialog
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
            this.groupBoxParticle = new System.Windows.Forms.GroupBox();
            this.radioButtonParticalYNo = new System.Windows.Forms.RadioButton();
            this.radioButtonParticalYes = new System.Windows.Forms.RadioButton();
            this.groupBoxKind.SuspendLayout();
            this.groupBoxParticle.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOK.Location = new System.Drawing.Point(15, 187);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(5);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(112, 37);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancel.Location = new System.Drawing.Point(181, 187);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 37);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxKind
            // 
            this.groupBoxKind.Controls.Add(this.radioButtonKindGeneral);
            this.groupBoxKind.Controls.Add(this.radioButtonKindPersonal);
            this.groupBoxKind.Location = new System.Drawing.Point(15, 15);
            this.groupBoxKind.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxKind.Name = "groupBoxKind";
            this.groupBoxKind.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxKind.Size = new System.Drawing.Size(282, 71);
            this.groupBoxKind.TabIndex = 9;
            this.groupBoxKind.TabStop = false;
            this.groupBoxKind.Text = "Вид";
            this.groupBoxKind.Enter += new System.EventHandler(this.groupBoxKind_Enter);
            // 
            // radioButtonKindGeneral
            // 
            this.radioButtonKindGeneral.AutoSize = true;
            this.radioButtonKindGeneral.Location = new System.Drawing.Point(154, 30);
            this.radioButtonKindGeneral.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonKindGeneral.Name = "radioButtonKindGeneral";
            this.radioButtonKindGeneral.Size = new System.Drawing.Size(80, 24);
            this.radioButtonKindGeneral.TabIndex = 1;
            this.radioButtonKindGeneral.TabStop = true;
            this.radioButtonKindGeneral.Text = "Общий";
            this.radioButtonKindGeneral.UseVisualStyleBackColor = true;
            // 
            // radioButtonKindPersonal
            // 
            this.radioButtonKindPersonal.AutoSize = true;
            this.radioButtonKindPersonal.Location = new System.Drawing.Point(10, 30);
            this.radioButtonKindPersonal.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonKindPersonal.Name = "radioButtonKindPersonal";
            this.radioButtonKindPersonal.Size = new System.Drawing.Size(136, 24);
            this.radioButtonKindPersonal.TabIndex = 0;
            this.radioButtonKindPersonal.TabStop = true;
            this.radioButtonKindPersonal.Text = "Персональный";
            this.radioButtonKindPersonal.UseVisualStyleBackColor = true;
            this.radioButtonKindPersonal.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBoxParticle
            // 
            this.groupBoxParticle.Controls.Add(this.radioButtonParticalYNo);
            this.groupBoxParticle.Controls.Add(this.radioButtonParticalYes);
            this.groupBoxParticle.Location = new System.Drawing.Point(15, 96);
            this.groupBoxParticle.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxParticle.Name = "groupBoxParticle";
            this.groupBoxParticle.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxParticle.Size = new System.Drawing.Size(282, 71);
            this.groupBoxParticle.TabIndex = 10;
            this.groupBoxParticle.TabStop = false;
            this.groupBoxParticle.Text = "Частицы";
            this.groupBoxParticle.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonParticalYNo
            // 
            this.radioButtonParticalYNo.AutoSize = true;
            this.radioButtonParticalYNo.Location = new System.Drawing.Point(154, 30);
            this.radioButtonParticalYNo.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonParticalYNo.Name = "radioButtonParticalYNo";
            this.radioButtonParticalYNo.Size = new System.Drawing.Size(124, 24);
            this.radioButtonParticalYNo.TabIndex = 1;
            this.radioButtonParticalYNo.TabStop = true;
            this.radioButtonParticalYNo.Text = "Не учитывать";
            this.radioButtonParticalYNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonParticalYes
            // 
            this.radioButtonParticalYes.AutoSize = true;
            this.radioButtonParticalYes.Location = new System.Drawing.Point(12, 32);
            this.radioButtonParticalYes.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonParticalYes.Name = "radioButtonParticalYes";
            this.radioButtonParticalYes.Size = new System.Drawing.Size(103, 24);
            this.radioButtonParticalYes.TabIndex = 0;
            this.radioButtonParticalYes.TabStop = true;
            this.radioButtonParticalYes.Text = "Учитывать";
            this.radioButtonParticalYes.UseVisualStyleBackColor = true;
            // 
            // GeneralAnalyzeDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(312, 239);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxParticle);
            this.Controls.Add(this.groupBoxKind);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Name = "GeneralAnalyzeDialog";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Настройка анализа";
            this.groupBoxKind.ResumeLayout(false);
            this.groupBoxKind.PerformLayout();
            this.groupBoxParticle.ResumeLayout(false);
            this.groupBoxParticle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonOK;
        private Button buttonCancel;
        private GroupBox groupBoxKind;
        private RadioButton radioButtonKindPersonal;
        private RadioButton radioButtonKindGeneral;
        private GroupBox groupBoxParticle;
        private RadioButton radioButtonParticalYNo;
        private RadioButton radioButtonParticalYes;
    }
}