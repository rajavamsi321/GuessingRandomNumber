namespace GuessingRandomNumber
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
            this.txtBoxMsg = new System.Windows.Forms.TextBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.txtBoxAnswer = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxMsg
            // 
            this.txtBoxMsg.BackColor = System.Drawing.Color.White;
            this.txtBoxMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxMsg.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMsg.ForeColor = System.Drawing.Color.Black;
            this.txtBoxMsg.Location = new System.Drawing.Point(195, 101);
            this.txtBoxMsg.Name = "txtBoxMsg";
            this.txtBoxMsg.Size = new System.Drawing.Size(406, 27);
            this.txtBoxMsg.TabIndex = 0;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(248, 175);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(162, 17);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.Text = "Enter the guess Number";
            // 
            // txtBoxAnswer
            // 
            this.txtBoxAnswer.Location = new System.Drawing.Point(461, 170);
            this.txtBoxAnswer.Name = "txtBoxAnswer";
            this.txtBoxAnswer.Size = new System.Drawing.Size(116, 22);
            this.txtBoxAnswer.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(474, 220);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(87, 36);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBoxAnswer);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.txtBoxMsg);
            this.Name = "Form1";
            this.Text = "Guess Random Number";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxMsg;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.TextBox txtBoxAnswer;
        private System.Windows.Forms.Button btnSubmit;
    }
}

