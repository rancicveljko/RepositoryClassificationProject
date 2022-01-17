
namespace WebClientForm
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
            this.tbURI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendCall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbURI
            // 
            this.tbURI.Location = new System.Drawing.Point(163, 12);
            this.tbURI.Name = "tbURI";
            this.tbURI.Size = new System.Drawing.Size(625, 22);
            this.tbURI.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "API Call URI";
            // 
            // btnSendCall
            // 
            this.btnSendCall.Location = new System.Drawing.Point(291, 185);
            this.btnSendCall.Name = "btnSendCall";
            this.btnSendCall.Size = new System.Drawing.Size(219, 26);
            this.btnSendCall.TabIndex = 2;
            this.btnSendCall.Text = "Send call";
            this.btnSendCall.UseVisualStyleBackColor = true;
            this.btnSendCall.Click += new System.EventHandler(this.btnSendCall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSendCall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbURI);
            this.Name = "Form1";
            this.Text = "Web Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbURI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendCall;
    }
}

