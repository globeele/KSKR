namespace lab_rab_1
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelRoM = new System.Windows.Forms.Label();
            this.labelCM = new System.Windows.Forms.Label();
            this.labelLyamM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butCalc = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.radioButtonElem = new System.Windows.Forms.RadioButton();
            this.radioButtonRaz = new System.Windows.Forms.RadioButton();
            this.textBoxTempLeft = new System.Windows.Forms.TextBox();
            this.textBoxTemRight = new System.Windows.Forms.TextBox();
            this.textBoxTempBegin = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Коэффициент теплопроводности:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelRoM);
            this.groupBox1.Controls.Add(this.labelCM);
            this.groupBox1.Controls.Add(this.labelLyamM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 98);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1 - медь";
            // 
            // labelRoM
            // 
            this.labelRoM.AutoSize = true;
            this.labelRoM.Location = new System.Drawing.Point(82, 76);
            this.labelRoM.Name = "labelRoM";
            this.labelRoM.Size = new System.Drawing.Size(41, 13);
            this.labelRoM.TabIndex = 6;
            this.labelRoM.Text = "label12";
            // 
            // labelCM
            // 
            this.labelCM.AutoSize = true;
            this.labelCM.Location = new System.Drawing.Point(177, 51);
            this.labelCM.Name = "labelCM";
            this.labelCM.Size = new System.Drawing.Size(41, 13);
            this.labelCM.TabIndex = 6;
            this.labelCM.Text = "label11";
            // 
            // labelLyamM
            // 
            this.labelLyamM.AutoSize = true;
            this.labelLyamM.Location = new System.Drawing.Point(195, 25);
            this.labelLyamM.Name = "labelLyamM";
            this.labelLyamM.Size = new System.Drawing.Size(41, 13);
            this.labelLyamM.TabIndex = 5;
            this.labelLyamM.Text = "label10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Плотность:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Коэффициент теплоемкости:";
            // 
            // butCalc
            // 
            this.butCalc.Location = new System.Drawing.Point(365, 193);
            this.butCalc.Name = "butCalc";
            this.butCalc.Size = new System.Drawing.Size(139, 55);
            this.butCalc.TabIndex = 10;
            this.butCalc.Text = "Вычислить";
            this.butCalc.UseVisualStyleBackColor = true;
            this.butCalc.Click += new System.EventHandler(this.butCalc_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Длина стержня:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Количество разбиений стержня:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(297, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Время:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(292, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Количество интервалов:";
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(98, 137);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(37, 20);
            this.textBoxLength.TabIndex = 16;
            this.textBoxLength.Text = "0,1";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(182, 167);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(37, 20);
            this.textBoxX.TabIndex = 17;
            this.textBoxX.Text = "15";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(355, 144);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(37, 20);
            this.textBoxTime.TabIndex = 18;
            this.textBoxTime.Text = "5";
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(429, 167);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(37, 20);
            this.textBoxT.TabIndex = 19;
            this.textBoxT.Text = "30";
            // 
            // radioButtonElem
            // 
            this.radioButtonElem.AutoSize = true;
            this.radioButtonElem.Location = new System.Drawing.Point(300, 70);
            this.radioButtonElem.Name = "radioButtonElem";
            this.radioButtonElem.Size = new System.Drawing.Size(166, 17);
            this.radioButtonElem.TabIndex = 22;
            this.radioButtonElem.Text = "Метод конечных элементов";
            this.radioButtonElem.UseVisualStyleBackColor = true;
            this.radioButtonElem.CheckedChanged += new System.EventHandler(this.radioButtonElem_CheckedChanged);
            // 
            // radioButtonRaz
            // 
            this.radioButtonRaz.AutoSize = true;
            this.radioButtonRaz.Checked = true;
            this.radioButtonRaz.Location = new System.Drawing.Point(300, 42);
            this.radioButtonRaz.Name = "radioButtonRaz";
            this.radioButtonRaz.Size = new System.Drawing.Size(236, 17);
            this.radioButtonRaz.TabIndex = 23;
            this.radioButtonRaz.TabStop = true;
            this.radioButtonRaz.Text = "Метод конечных разностей(Явная схема)";
            this.radioButtonRaz.UseVisualStyleBackColor = true;
            this.radioButtonRaz.CheckedChanged += new System.EventHandler(this.radioButtonRaz_CheckedChanged);
            // 
            // textBoxTempLeft
            // 
            this.textBoxTempLeft.Location = new System.Drawing.Point(775, 134);
            this.textBoxTempLeft.Name = "textBoxTempLeft";
            this.textBoxTempLeft.Size = new System.Drawing.Size(48, 20);
            this.textBoxTempLeft.TabIndex = 24;
            this.textBoxTempLeft.Text = "100";
            // 
            // textBoxTemRight
            // 
            this.textBoxTemRight.Location = new System.Drawing.Point(781, 160);
            this.textBoxTemRight.Name = "textBoxTemRight";
            this.textBoxTemRight.Size = new System.Drawing.Size(48, 20);
            this.textBoxTemRight.TabIndex = 26;
            this.textBoxTemRight.Text = "200";
            // 
            // textBoxTempBegin
            // 
            this.textBoxTempBegin.Location = new System.Drawing.Point(795, 187);
            this.textBoxTempBegin.Name = "textBoxTempBegin";
            this.textBoxTempBegin.Size = new System.Drawing.Size(48, 20);
            this.textBoxTempBegin.TabIndex = 28;
            this.textBoxTempBegin.Text = "22";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(609, 137);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(160, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Температура на левом конце:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(609, 163);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(166, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "Температура на правом конце:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(608, 190);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(181, 13);
            this.label19.TabIndex = 31;
            this.label19.Text = "Температура окружающей среды:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 308);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxTempBegin);
            this.Controls.Add(this.textBoxTemRight);
            this.Controls.Add(this.textBoxTempLeft);
            this.Controls.Add(this.radioButtonRaz);
            this.Controls.Add(this.radioButtonElem);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.butCalc);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab rab 1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelRoM;
        private System.Windows.Forms.Label labelCM;
        private System.Windows.Forms.Label labelLyamM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butCalc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.RadioButton radioButtonElem;
        private System.Windows.Forms.RadioButton radioButtonRaz;
        private System.Windows.Forms.TextBox textBoxTempLeft;
        private System.Windows.Forms.TextBox textBoxTemRight;
        private System.Windows.Forms.TextBox textBoxTempBegin;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}

