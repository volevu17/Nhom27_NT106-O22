namespace file_explorer
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
            this.back_btn = new System.Windows.Forms.Button();
            this.forward_btn = new System.Windows.Forms.Button();
            this.browser_btn = new System.Windows.Forms.Button();
            this.path_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(16, 17);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(100, 28);
            this.back_btn.TabIndex = 0;
            this.back_btn.Text = "Go back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // forward_btn
            // 
            this.forward_btn.Location = new System.Drawing.Point(124, 17);
            this.forward_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.forward_btn.Name = "forward_btn";
            this.forward_btn.Size = new System.Drawing.Size(100, 28);
            this.forward_btn.TabIndex = 1;
            this.forward_btn.Text = "Go Forward";
            this.forward_btn.UseVisualStyleBackColor = true;
            this.forward_btn.Click += new System.EventHandler(this.forward_btn_Click);
            // 
            // browser_btn
            // 
            this.browser_btn.Location = new System.Drawing.Point(907, 15);
            this.browser_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browser_btn.Name = "browser_btn";
            this.browser_btn.Size = new System.Drawing.Size(100, 28);
            this.browser_btn.TabIndex = 2;
            this.browser_btn.Text = "Browser";
            this.browser_btn.UseVisualStyleBackColor = true;
            this.browser_btn.Click += new System.EventHandler(this.browser_btn_Click);
            // 
            // path_text
            // 
            this.path_text.Location = new System.Drawing.Point(304, 17);
            this.path_text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.path_text.Multiline = true;
            this.path_text.Name = "path_text";
            this.path_text.Size = new System.Drawing.Size(593, 24);
            this.path_text.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Path:";
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(16, 53);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(988, 726);
            this.webBrowser.TabIndex = 5;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1020, 794);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.path_text);
            this.Controls.Add(this.browser_btn);
            this.Controls.Add(this.forward_btn);
            this.Controls.Add(this.back_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "File explorer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button forward_btn;
        private System.Windows.Forms.Button browser_btn;
        private System.Windows.Forms.TextBox path_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

