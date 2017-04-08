namespace My_Second_Interface
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.VisualizationPanel = new System.Windows.Forms.Panel();
            this.DataInputPanel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.DataInputPanel0 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DataOutputPanel = new System.Windows.Forms.Panel();
            this.cancel_button = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataInputPanel1.SuspendLayout();
            this.DataInputPanel0.SuspendLayout();
            this.DataOutputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // VisualizationPanel
            // 
            this.VisualizationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VisualizationPanel.Location = new System.Drawing.Point(586, 39);
            this.VisualizationPanel.Name = "VisualizationPanel";
            this.VisualizationPanel.Size = new System.Drawing.Size(636, 723);
            this.VisualizationPanel.TabIndex = 0;
            // 
            // DataInputPanel1
            // 
            this.DataInputPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataInputPanel1.Controls.Add(this.label4);
            this.DataInputPanel1.Location = new System.Drawing.Point(12, 39);
            this.DataInputPanel1.Name = "DataInputPanel1";
            this.DataInputPanel1.Size = new System.Drawing.Size(568, 467);
            this.DataInputPanel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(283, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Это панель 1";
            // 
            // DataInputPanel0
            // 
            this.DataInputPanel0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataInputPanel0.Controls.Add(this.label3);
            this.DataInputPanel0.Location = new System.Drawing.Point(12, 39);
            this.DataInputPanel0.Name = "DataInputPanel0";
            this.DataInputPanel0.Size = new System.Drawing.Size(568, 467);
            this.DataInputPanel0.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(226, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Это панель 0";
            // 
            // DataOutputPanel
            // 
            this.DataOutputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataOutputPanel.Controls.Add(this.cancel_button);
            this.DataOutputPanel.Controls.Add(this.progressBar1);
            this.DataOutputPanel.Controls.Add(this.textBox1);
            this.DataOutputPanel.Location = new System.Drawing.Point(12, 512);
            this.DataOutputPanel.Name = "DataOutputPanel";
            this.DataOutputPanel.Size = new System.Drawing.Size(568, 250);
            this.DataOutputPanel.TabIndex = 2;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(488, 222);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 222);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(479, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(560, 213);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Информация о процессе работы:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберете способ задания функции:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Задать функцию вручную",
            "Прикрепить .dll файл"});
            this.comboBox1.Location = new System.Drawing.Point(263, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(592, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Визуализация процесса:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1234, 774);
            this.Controls.Add(this.DataInputPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DataOutputPanel);
            this.Controls.Add(this.DataInputPanel0);
            this.Controls.Add(this.VisualizationPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "ПГМ-1";
            this.DataInputPanel1.ResumeLayout(false);
            this.DataInputPanel1.PerformLayout();
            this.DataInputPanel0.ResumeLayout(false);
            this.DataInputPanel0.PerformLayout();
            this.DataOutputPanel.ResumeLayout(false);
            this.DataOutputPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel VisualizationPanel;
        private System.Windows.Forms.Panel DataInputPanel0;
        private System.Windows.Forms.Panel DataOutputPanel;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel DataInputPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

