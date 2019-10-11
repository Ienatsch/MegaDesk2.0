namespace MegaDesk.Forms
{
    partial class ViewAllQuotes
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
            this.allQuotesBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // allQuotesBox
            // 
            this.allQuotesBox.FormattingEnabled = true;
            this.allQuotesBox.Location = new System.Drawing.Point(66, 26);
            this.allQuotesBox.Name = "allQuotesBox";
            this.allQuotesBox.ScrollAlwaysVisible = true;
            this.allQuotesBox.Size = new System.Drawing.Size(367, 225);
            this.allQuotesBox.TabIndex = 0;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 291);
            this.Controls.Add(this.allQuotesBox);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox allQuotesBox;
    }
}