namespace MultiChoiceAdventure
{
    partial class Form1
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.blueText = new System.Windows.Forms.Label();
            this.blueButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.redText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(12, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(86, 17);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "OutputLabel";
            // 
            // blueText
            // 
            this.blueText.AutoSize = true;
            this.blueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueText.Location = new System.Drawing.Point(63, 363);
            this.blueText.Name = "blueText";
            this.blueText.Size = new System.Drawing.Size(83, 17);
            this.blueText.TabIndex = 1;
            this.blueText.Text = "Blue Output";
            // 
            // blueButton
            // 
            this.blueButton.Location = new System.Drawing.Point(17, 357);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(40, 30);
            this.blueButton.TabIndex = 2;
            this.blueButton.Text = "Blue";
            this.blueButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Red";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // redText
            // 
            this.redText.AutoSize = true;
            this.redText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redText.Location = new System.Drawing.Point(63, 327);
            this.redText.Name = "redText";
            this.redText.Size = new System.Drawing.Size(81, 17);
            this.redText.TabIndex = 3;
            this.redText.Text = "Red Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.redText);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.blueText);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label blueText;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label redText;
    }
}

