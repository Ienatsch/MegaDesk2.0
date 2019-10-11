namespace MegaDesk
{
    partial class MainMenu
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
            this.addQuote = new System.Windows.Forms.Button();
            this.searchQuotes = new System.Windows.Forms.Button();
            this.viewAllQuotes = new System.Windows.Forms.Button();
            this.exitApplication = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addQuote
            // 
            this.addQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuote.Location = new System.Drawing.Point(70, 41);
            this.addQuote.Name = "addQuote";
            this.addQuote.Size = new System.Drawing.Size(140, 60);
            this.addQuote.TabIndex = 0;
            this.addQuote.Text = "&Add Quote";
            this.addQuote.UseVisualStyleBackColor = true;
            this.addQuote.Click += new System.EventHandler(this.AddQuote_Click);
            this.addQuote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OpenFormsOnKeyPress);
            // 
            // searchQuotes
            // 
            this.searchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotes.Location = new System.Drawing.Point(284, 41);
            this.searchQuotes.Name = "searchQuotes";
            this.searchQuotes.Size = new System.Drawing.Size(140, 60);
            this.searchQuotes.TabIndex = 1;
            this.searchQuotes.Text = "&Search Quotes";
            this.searchQuotes.UseVisualStyleBackColor = true;
            this.searchQuotes.Click += new System.EventHandler(this.SearchQuotes_Click);
            // 
            // viewAllQuotes
            // 
            this.viewAllQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllQuotes.Location = new System.Drawing.Point(70, 125);
            this.viewAllQuotes.Name = "viewAllQuotes";
            this.viewAllQuotes.Size = new System.Drawing.Size(140, 60);
            this.viewAllQuotes.TabIndex = 2;
            this.viewAllQuotes.Text = "&View All Quotes";
            this.viewAllQuotes.UseVisualStyleBackColor = true;
            this.viewAllQuotes.Click += new System.EventHandler(this.ViewAllQuotes_Click);
            // 
            // exitApplication
            // 
            this.exitApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitApplication.Location = new System.Drawing.Point(284, 125);
            this.exitApplication.Name = "exitApplication";
            this.exitApplication.Size = new System.Drawing.Size(140, 60);
            this.exitApplication.TabIndex = 3;
            this.exitApplication.Text = "E&xit";
            this.exitApplication.UseVisualStyleBackColor = true;
            this.exitApplication.Click += new System.EventHandler(this.ExitApplication_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MegaDesk.Properties.Resources.deskPicture;
            this.pictureBox1.Location = new System.Drawing.Point(70, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 172);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitApplication);
            this.Controls.Add(this.viewAllQuotes);
            this.Controls.Add(this.searchQuotes);
            this.Controls.Add(this.addQuote);
            this.Name = "MainMenu";
            this.Text = "MegaDesk-Ienatsch";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OpenFormsOnKeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addQuote;
        private System.Windows.Forms.Button searchQuotes;
        private System.Windows.Forms.Button viewAllQuotes;
        private System.Windows.Forms.Button exitApplication;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

