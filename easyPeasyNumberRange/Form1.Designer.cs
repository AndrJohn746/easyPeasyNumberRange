namespace easyPeasyNumberRange
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
            this.Title = new System.Windows.Forms.Label();
            this.startText = new System.Windows.Forms.Label();
            this.startNum = new System.Windows.Forms.TextBox();
            this.endNum = new System.Windows.Forms.TextBox();
            this.endText = new System.Windows.Forms.Label();
            this.answerText = new System.Windows.Forms.Label();
            this.ansButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(38, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(416, 118);
            this.Title.TabIndex = 0;
            this.Title.Text = "Getting Loopy";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startText
            // 
            this.startText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startText.Location = new System.Drawing.Point(50, 127);
            this.startText.Name = "startText";
            this.startText.Size = new System.Drawing.Size(404, 23);
            this.startText.TabIndex = 1;
            this.startText.Text = "Enter a starting number:";
            // 
            // startNum
            // 
            this.startNum.Location = new System.Drawing.Point(337, 128);
            this.startNum.Name = "startNum";
            this.startNum.Size = new System.Drawing.Size(100, 22);
            this.startNum.TabIndex = 2;
            // 
            // endNum
            // 
            this.endNum.Location = new System.Drawing.Point(337, 165);
            this.endNum.Name = "endNum";
            this.endNum.Size = new System.Drawing.Size(100, 22);
            this.endNum.TabIndex = 4;
            this.endNum.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // endText
            // 
            this.endText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endText.Location = new System.Drawing.Point(50, 164);
            this.endText.Name = "endText";
            this.endText.Size = new System.Drawing.Size(404, 23);
            this.endText.TabIndex = 3;
            this.endText.Text = "Enter a starting number:";
            this.endText.Click += new System.EventHandler(this.label1_Click);
            // 
            // answerText
            // 
            this.answerText.Location = new System.Drawing.Point(13, 228);
            this.answerText.Name = "answerText";
            this.answerText.Size = new System.Drawing.Size(478, 200);
            this.answerText.TabIndex = 5;
            this.answerText.Text = "Here is where your numbers will appear!\r\n\r\n(Limit of ~200 difference between the " +
    "two values)";
            this.answerText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ansButton
            // 
            this.ansButton.Location = new System.Drawing.Point(197, 202);
            this.ansButton.Name = "ansButton";
            this.ansButton.Size = new System.Drawing.Size(110, 23);
            this.ansButton.TabIndex = 6;
            this.ansButton.Text = "Show Values";
            this.ansButton.UseVisualStyleBackColor = true;
            this.ansButton.Click += new System.EventHandler(this.ansButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(503, 437);
            this.Controls.Add(this.ansButton);
            this.Controls.Add(this.answerText);
            this.Controls.Add(this.endNum);
            this.Controls.Add(this.endText);
            this.Controls.Add(this.startNum);
            this.Controls.Add(this.startText);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label startText;
        private System.Windows.Forms.TextBox startNum;
        private System.Windows.Forms.TextBox endNum;
        private System.Windows.Forms.Label endText;
        private System.Windows.Forms.Label answerText;
        private System.Windows.Forms.Button ansButton;
    }
}

