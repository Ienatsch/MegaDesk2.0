namespace MegaDesk.Forms
{
    partial class searchQuotes
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
            this.searchMaterials = new System.Windows.Forms.ComboBox();
            this.searchedQuotes = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchQuotesBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchedQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // searchMaterials
            // 
            this.searchMaterials.FormattingEnabled = true;
            this.searchMaterials.Location = new System.Drawing.Point(232, 92);
            this.searchMaterials.Name = "searchMaterials";
            this.searchMaterials.Size = new System.Drawing.Size(292, 21);
            this.searchMaterials.TabIndex = 0;
            // 
            // searchedQuotes
            // 
            this.searchedQuotes.AllowUserToAddRows = false;
            this.searchedQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchedQuotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Date,
            this.Width,
            this.Depth,
            this.Drawers,
            this.Material,
            this.Price});
            this.searchedQuotes.Location = new System.Drawing.Point(28, 156);
            this.searchedQuotes.Name = "searchedQuotes";
            this.searchedQuotes.Size = new System.Drawing.Size(732, 189);
            this.searchedQuotes.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Width
            // 
            this.Width.HeaderText = "Width";
            this.Width.Name = "Width";
            this.Width.ReadOnly = true;
            // 
            // Depth
            // 
            this.Depth.HeaderText = "Depth";
            this.Depth.Name = "Depth";
            this.Depth.ReadOnly = true;
            // 
            // Drawers
            // 
            this.Drawers.HeaderText = "Drawers";
            this.Drawers.Name = "Drawers";
            this.Drawers.ReadOnly = true;
            // 
            // Material
            // 
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // searchQuotesBtn
            // 
            this.searchQuotesBtn.Location = new System.Drawing.Point(370, 371);
            this.searchQuotesBtn.Name = "searchQuotesBtn";
            this.searchQuotesBtn.Size = new System.Drawing.Size(75, 23);
            this.searchQuotesBtn.TabIndex = 2;
            this.searchQuotesBtn.Text = "Search";
            this.searchQuotesBtn.UseVisualStyleBackColor = true;
            this.searchQuotesBtn.Click += new System.EventHandler(this.GetQuotesByMaterial);
            // 
            // searchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchQuotesBtn);
            this.Controls.Add(this.searchedQuotes);
            this.Controls.Add(this.searchMaterials);
            this.Text = "SearchQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.searchedQuotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox searchMaterials;
        private System.Windows.Forms.DataGridView searchedQuotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button searchQuotesBtn;
    }
}