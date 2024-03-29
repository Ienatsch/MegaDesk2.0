﻿using System.Windows.Forms;

namespace MegaDesk.Forms
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();

            // Gets all quotes stored in quotes.json
            var deskQuote = new DeskQuote();
            var allQuotes = deskQuote.GetAllQuotes();

            // Inserts each quote found into grid view
            foreach (DeskQuote quote in allQuotes)
            {
                DataGridViewRow row = new DataGridViewRow();
                for (int i = 0; i < 8; i++)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell());
                }
                row.Cells[0].Value = quote.Name;
                row.Cells[1].Value = quote.QuoteDate.ToString("d");
                row.Cells[2].Value = quote.Width + " in";
                row.Cells[3].Value = quote.Depth + " in";
                row.Cells[4].Value = quote.NumDrawers;
                row.Cells[5].Value = quote.SurfaceMaterial;
                row.Cells[6].Value = quote.RushOrderTime + " Day";
                row.Cells[7].Value = "$" + quote.TotalPrice.ToString("0.00"); 
                viewAllQuotesGrid.Rows.Add(row);
            }
        }
    }
}
