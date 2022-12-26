namespace ProcessManager
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.runChromeButton = new System.Windows.Forms.Button();
            this.runVSCodeButton = new System.Windows.Forms.Button();
            this.stopProcessButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.setPriorityOfChoosenThreadButton = new System.Windows.Forms.Button();
            this.runCalcButton = new System.Windows.Forms.Button();
            this.runMSWordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(623, 355);
            this.dataGridView1.TabIndex = 0;
            // 
            // runChromeButton
            // 
            this.runChromeButton.BackColor = System.Drawing.Color.Gray;
            this.runChromeButton.Location = new System.Drawing.Point(746, 34);
            this.runChromeButton.Name = "runChromeButton";
            this.runChromeButton.Size = new System.Drawing.Size(147, 29);
            this.runChromeButton.TabIndex = 1;
            this.runChromeButton.Text = "Run Chrome";
            this.runChromeButton.UseVisualStyleBackColor = false;
            this.runChromeButton.Click += new System.EventHandler(this.runChromeButton_Click);
            // 
            // runVSCodeButton
            // 
            this.runVSCodeButton.BackColor = System.Drawing.Color.Gray;
            this.runVSCodeButton.Location = new System.Drawing.Point(746, 85);
            this.runVSCodeButton.Name = "runVSCodeButton";
            this.runVSCodeButton.Size = new System.Drawing.Size(147, 29);
            this.runVSCodeButton.TabIndex = 2;
            this.runVSCodeButton.Text = "Run VSCode";
            this.runVSCodeButton.UseVisualStyleBackColor = false;
            this.runVSCodeButton.Click += new System.EventHandler(this.runVSCodeButton_Click);
            // 
            // stopProcessButton
            // 
            this.stopProcessButton.Location = new System.Drawing.Point(12, 421);
            this.stopProcessButton.Name = "stopProcessButton";
            this.stopProcessButton.Size = new System.Drawing.Size(147, 29);
            this.stopProcessButton.TabIndex = 3;
            this.stopProcessButton.Text = "Stop";
            this.stopProcessButton.UseVisualStyleBackColor = true;
            this.stopProcessButton.Click += new System.EventHandler(this.stopProcessButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Text";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(746, 378);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // setPriorityOfChoosenThreadButton
            // 
            this.setPriorityOfChoosenThreadButton.Location = new System.Drawing.Point(681, 421);
            this.setPriorityOfChoosenThreadButton.Name = "setPriorityOfChoosenThreadButton";
            this.setPriorityOfChoosenThreadButton.Size = new System.Drawing.Size(300, 29);
            this.setPriorityOfChoosenThreadButton.TabIndex = 5;
            this.setPriorityOfChoosenThreadButton.Text = "Set Choosen Process Thread priority";
            this.setPriorityOfChoosenThreadButton.UseVisualStyleBackColor = true;
            this.setPriorityOfChoosenThreadButton.Click += new System.EventHandler(this.setPriorityOfChoosenThreadButton_Click);
            // 
            // runCalcButton
            // 
            this.runCalcButton.BackColor = System.Drawing.Color.Gray;
            this.runCalcButton.Location = new System.Drawing.Point(746, 132);
            this.runCalcButton.Name = "runCalcButton";
            this.runCalcButton.Size = new System.Drawing.Size(147, 29);
            this.runCalcButton.TabIndex = 6;
            this.runCalcButton.Text = "Run Calculator";
            this.runCalcButton.UseVisualStyleBackColor = false;
            this.runCalcButton.Click += new System.EventHandler(this.runCalcButton_Click);
            // 
            // runMSWordButton
            // 
            this.runMSWordButton.BackColor = System.Drawing.Color.Gray;
            this.runMSWordButton.Location = new System.Drawing.Point(746, 175);
            this.runMSWordButton.Name = "runMSWordButton";
            this.runMSWordButton.Size = new System.Drawing.Size(147, 29);
            this.runMSWordButton.TabIndex = 7;
            this.runMSWordButton.Text = "Run MSWord";
            this.runMSWordButton.UseVisualStyleBackColor = false;
            this.runMSWordButton.Click += new System.EventHandler(this.runMSWordButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(995, 488);
            this.Controls.Add(this.runMSWordButton);
            this.Controls.Add(this.runCalcButton);
            this.Controls.Add(this.setPriorityOfChoosenThreadButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.stopProcessButton);
            this.Controls.Add(this.runVSCodeButton);
            this.Controls.Add(this.runChromeButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button runChromeButton;
        private Button runVSCodeButton;
        private Button stopProcessButton;
        private ComboBox comboBox1;
        private Button setPriorityOfChoosenThreadButton;
        private Button runCalcButton;
        private Button runMSWordButton;
    }
}