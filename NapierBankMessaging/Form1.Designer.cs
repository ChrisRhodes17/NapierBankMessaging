
namespace NapierBankMessaging
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
            this.txtList = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.txtMessIn = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtMessOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(807, 25);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(389, 426);
            this.txtList.TabIndex = 23;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(542, 381);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(128, 38);
            this.btnDisplay.TabIndex = 22;
            this.btnDisplay.Text = "Display Data";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Processed Body Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Message Body Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Message Header";
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(12, 43);
            this.txtHeader.Multiline = true;
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(387, 60);
            this.txtHeader.TabIndex = 15;
            // 
            // txtMessIn
            // 
            this.txtMessIn.Location = new System.Drawing.Point(12, 152);
            this.txtMessIn.Multiline = true;
            this.txtMessIn.Name = "txtMessIn";
            this.txtMessIn.Size = new System.Drawing.Size(387, 206);
            this.txtMessIn.TabIndex = 14;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(340, 381);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 38);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(137, 381);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(90, 38);
            this.btnProcess.TabIndex = 12;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtMessOut
            // 
            this.txtMessOut.Location = new System.Drawing.Point(413, 48);
            this.txtMessOut.Multiline = true;
            this.txtMessOut.Name = "txtMessOut";
            this.txtMessOut.Size = new System.Drawing.Size(387, 310);
            this.txtMessOut.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(803, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "List Display";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 463);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMessOut);
            this.Controls.Add(this.txtHeader);
            this.Controls.Add(this.txtMessIn);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProcess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.TextBox txtMessIn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtMessOut;
        private System.Windows.Forms.Label label2;
    }
}

