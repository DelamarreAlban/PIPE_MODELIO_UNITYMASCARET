namespace Unity_Modelio_Mascaret_MODEL_PIPE
{
    partial class Unity_Modelio_Mascaret_MODEL_PIPE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputfileTextBox = new System.Windows.Forms.TextBox();
            this.outputfileTextBox = new System.Windows.Forms.TextBox();
            this.setInputButton = new System.Windows.Forms.Button();
            this.setOutputButton = new System.Windows.Forms.Button();
            this.startPipeButton = new System.Windows.Forms.Button();
            this.stopPipeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input file :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output file :";
            // 
            // inputfileTextBox
            // 
            this.inputfileTextBox.Location = new System.Drawing.Point(93, 19);
            this.inputfileTextBox.Name = "inputfileTextBox";
            this.inputfileTextBox.Size = new System.Drawing.Size(229, 20);
            this.inputfileTextBox.TabIndex = 2;
            // 
            // outputfileTextBox
            // 
            this.outputfileTextBox.Location = new System.Drawing.Point(93, 64);
            this.outputfileTextBox.Name = "outputfileTextBox";
            this.outputfileTextBox.Size = new System.Drawing.Size(229, 20);
            this.outputfileTextBox.TabIndex = 3;
            // 
            // setInputButton
            // 
            this.setInputButton.Location = new System.Drawing.Point(351, 17);
            this.setInputButton.Name = "setInputButton";
            this.setInputButton.Size = new System.Drawing.Size(75, 23);
            this.setInputButton.TabIndex = 4;
            this.setInputButton.Text = "Browse";
            this.setInputButton.UseVisualStyleBackColor = true;
            this.setInputButton.Click += new System.EventHandler(this.setInputButton_Click);
            // 
            // setOutputButton
            // 
            this.setOutputButton.Location = new System.Drawing.Point(351, 64);
            this.setOutputButton.Name = "setOutputButton";
            this.setOutputButton.Size = new System.Drawing.Size(75, 23);
            this.setOutputButton.TabIndex = 5;
            this.setOutputButton.Text = "Browse";
            this.setOutputButton.UseVisualStyleBackColor = true;
            this.setOutputButton.Click += new System.EventHandler(this.setOutputButton_Click);
            // 
            // startPipeButton
            // 
            this.startPipeButton.Location = new System.Drawing.Point(25, 156);
            this.startPipeButton.Name = "startPipeButton";
            this.startPipeButton.Size = new System.Drawing.Size(75, 23);
            this.startPipeButton.TabIndex = 6;
            this.startPipeButton.Text = "Start";
            this.startPipeButton.UseVisualStyleBackColor = true;
            this.startPipeButton.Click += new System.EventHandler(this.startPipeButton_Click);
            // 
            // stopPipeButton
            // 
            this.stopPipeButton.Location = new System.Drawing.Point(132, 156);
            this.stopPipeButton.Name = "stopPipeButton";
            this.stopPipeButton.Size = new System.Drawing.Size(75, 23);
            this.stopPipeButton.TabIndex = 7;
            this.stopPipeButton.Text = "Stop";
            this.stopPipeButton.UseVisualStyleBackColor = true;
            this.stopPipeButton.Click += new System.EventHandler(this.stopPipeButton_Click);
            // 
            // Unity_Modelio_Mascaret_MODEL_PIPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 191);
            this.Controls.Add(this.stopPipeButton);
            this.Controls.Add(this.startPipeButton);
            this.Controls.Add(this.setOutputButton);
            this.Controls.Add(this.setInputButton);
            this.Controls.Add(this.outputfileTextBox);
            this.Controls.Add(this.inputfileTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Unity_Modelio_Mascaret_MODEL_PIPE";
            this.Text = "Unity_Modelio_Mascaret_MODEL_PIPE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputfileTextBox;
        private System.Windows.Forms.TextBox outputfileTextBox;
        private System.Windows.Forms.Button setInputButton;
        private System.Windows.Forms.Button setOutputButton;
        private System.Windows.Forms.Button startPipeButton;
        private System.Windows.Forms.Button stopPipeButton;
    }
}

