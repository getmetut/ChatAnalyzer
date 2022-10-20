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
            this.buttonOK.Location = new System.Drawing.Point(13, 140);
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
            this.buttonCancel.Location = new System.Drawing.Point(158, 140);
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
            this.groupBoxKind.Size = new System.Drawing.Size(247, 53);
            this.groupBoxKind.TabIndex = 9;
            this.groupBoxKind.TabStop = false;
            this.groupBoxKind.Text = "Вид";
            // 
            // radioButtonKindGeneral
            // 
            this.radioButtonKindGeneral.AutoSize = true;
            this.radioButtonKindGeneral.Location = new System.Drawing.Point(135, 22);
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
            this.radioButtonKindPersonal.Location = new System.Drawing.Point(9, 22);
            this.radioButtonKindPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonKindPersonal.Name = "radioButtonKindPersonal";
            this.radioButtonKindPersonal.Size = new System.Drawing.Size(109, 19);
            this.radioButtonKindPersonal.TabIndex = 0;
            this.radioButtonKindPersonal.TabStop = true;
            this.radioButtonKindPersonal.Text = "Персональный";
            this.radioButtonKindPersonal.UseVisualStyleBackColor = true;
            // 
            // groupBoxParticle
            // 
            this.groupBoxParticle.Controls.Add(this.radioButtonParticalYNo);
            this.groupBoxParticle.Controls.Add(this.radioButtonParticalYes);
            this.groupBoxParticle.Location = new System.Drawing.Point(13, 72);
            this.groupBoxParticle.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxParticle.Name = "groupBoxParticle";
            this.groupBoxParticle.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxParticle.Size = new System.Drawing.Size(247, 53);
            this.groupBoxParticle.TabIndex = 10;
            this.groupBoxParticle.TabStop = false;
            this.groupBoxParticle.Text = "Частицы";
            // 
            // radioButtonParticalYNo
            // 
            this.radioButtonParticalYNo.AutoSize = true;
            this.radioButtonParticalYNo.Location = new System.Drawing.Point(135, 22);
            this.radioButtonParticalYNo.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonParticalYNo.Name = "radioButtonParticalYNo";
            this.radioButtonParticalYNo.Size = new System.Drawing.Size(100, 19);
            this.radioButtonParticalYNo.TabIndex = 1;
            this.radioButtonParticalYNo.TabStop = true;
            this.radioButtonParticalYNo.Text = "Не учитывать";
            this.radioButtonParticalYNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonParticalYes
            // 
            this.radioButtonParticalYes.AutoSize = true;
            this.radioButtonParticalYes.Location = new System.Drawing.Point(10, 24);
            this.radioButtonParticalYes.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonParticalYes.Name = "radioButtonParticalYes";
            this.radioButtonParticalYes.Size = new System.Drawing.Size(83, 19);
            this.radioButtonParticalYes.TabIndex = 0;
            this.radioButtonParticalYes.TabStop = true;
            this.radioButtonParticalYes.Text = "Учитывать";
            this.radioButtonParticalYes.UseVisualStyleBackColor = true;
            // 
            // AnalyzeGeneralDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(273, 179);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxParticle);
            this.Controls.Add(this.groupBoxKind);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AnalyzeGeneralDialog";
            this.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
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