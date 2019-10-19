using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MegaDesk.Forms
{
    public partial class searchQuotes : Form
    {
        private readonly List<DeskQuote> _allQuotes;

        public searchQuotes()
        {
            InitializeComponent();

            // Populates search combo box with materials
            List<string> materials = new List<string>();
            foreach (var item in Enum.GetValues(typeof(SurfaceMaterials)))
            {
                materials.Add(item.ToString());
            }

            foreach (var material in materials)
            {
                searchMaterials.Items.Add(material);
            }

            searchMaterials.SelectedIndex = 0;

            // Gets all quotes stored in quotes.json
            var deskQuote = new DeskQuote();
            _allQuotes = deskQuote.GetAllQuotes();
        }

        private void GetQuotesByMaterial(object sender, EventArgs e)
        {
            // Gets quotes that use selected material
            IEnumerable<DeskQuote> quotes = _allQuotes.Where(x => x.SurfaceMaterial == searchMaterials.Text);

            // Clears grid view for new searches
            searchedQuotes.Rows.Clear();

            // Inserts each quote found into grid view
            foreach (DeskQuote quote in quotes)
            {
                DataGridViewRow row = new DataGridViewRow();   

                for (int i = 0; i < 7; i++)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell());
                }
                row.Cells[0].Value = quote.Name;
                row.Cells[1].Value = quote.QuoteDate.ToString("d");
                row.Cells[2].Value = quote.Width + " in";
                row.Cells[3].Value = quote.Depth + " in";
                row.Cells[4].Value = quote.NumDrawers;
                row.Cells[5].Value = quote.SurfaceMaterial;
                row.Cells[6].Value = "$" + quote.TotalPrice;
                searchedQuotes.Rows.Add(row);               
            }
        }
    }
}
