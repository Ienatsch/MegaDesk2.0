using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
        }
    }
}
