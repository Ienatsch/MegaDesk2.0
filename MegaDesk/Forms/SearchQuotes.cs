using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk.Forms
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
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

            var deskQuote = new DeskQuote();
            var quotes = deskQuote.GetAllQuotes();

        }      
    }
}
