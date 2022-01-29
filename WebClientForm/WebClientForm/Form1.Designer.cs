
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendCall = new System.Windows.Forms.Button();
            this.cbApiUri = new System.Windows.Forms.ComboBox();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // cbApiUri
            // 
            this.cbApiUri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApiUri.FormattingEnabled = true;
            this.cbApiUri.Items.AddRange(new object[] {
            "http://api.authorstream.com/GetTagBasedPresentations.ashx?UserName=veljko.rancic@" +
                "elfak.rs&Password=!Nesto123&DeveloperKey=qSsHNAgz/v0=&Tag=funny"});
            this.cbApiUri.Location = new System.Drawing.Point(129, 14);
            this.cbApiUri.Name = "cbApiUri";
            this.cbApiUri.Size = new System.Drawing.Size(659, 24);
            this.cbApiUri.TabIndex = 3;
            this.cbApiUri.SelectedIndexChanged += new System.EventHandler(this.cbApiUri_SelectedIndexChanged);
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(129, 67);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(165, 22);
            this.tbFileName.TabIndex = 4;
            this.tbFileName.TextChanged += new System.EventHandler(this.tbFileName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output file name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.cbApiUri);
            this.Controls.Add(this.btnSendCall);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Web Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendCall;
        private System.Windows.Forms.ComboBox cbApiUri;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label label2;
    }
}

