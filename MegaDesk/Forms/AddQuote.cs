using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk.Forms
{
    public partial class AddQuote : Form
    {
        private const int MinWidth = 24;
        private const int MaxWidth = 96;
        private const int MinDepth = 12;
        private const int MaxDepth = 48;

        public AddQuote()
        {
            InitializeComponent();           

            // Add surface materials to dropdown box
                foreach (var item in Enum.GetValues(typeof(SurfaceMaterials)))
            {
                surfaceMaterial.Items.Add(item);
            }

            surfaceMaterial.SelectedIndex = 0;
            rushOrder.SelectedIndex = 0;
        }

        private void ValidateFirstName(object sender, CancelEventArgs e)
        {
            TextBox firstNameBox = (TextBox) sender;
            if (String.IsNullOrEmpty(firstNameBox.Text))
            {
                firstNameBox.BackColor = Color.Red;
            }
            else
            {
                firstNameBox.BackColor = Color.White;
            }
        }

        private void ValidateLastName(object sender, CancelEventArgs e)
        {
            TextBox lastNameBox = (TextBox)sender;
            if (String.IsNullOrEmpty(lastNameBox.Text))
            {
                lastNameBox.BackColor = Color.Red;
            }
            else
            {
                lastNameBox.BackColor = Color.White;
            }
        }

        private void ValidateWidth(object sender, CancelEventArgs e)
        {
            TextBox widthBox = (TextBox)sender;
            if (Int32.TryParse(widthBox.Text, out int width))
            {
                if (width < MinWidth || width > MaxWidth)
                {
                    widthBox.BackColor = Color.Red;
                }
                else
                {
                    widthBox.BackColor = Color.White;
                }
            }
            else
            {
                widthBox.BackColor = Color.Red;
            }
        }

        private void ValidateDepth(object sender, CancelEventArgs e)
        {
            TextBox depthBox = (TextBox)sender;
            if (Int32.TryParse(depthBox.Text, out int depth))
            {
                if (depth < MinDepth || depth > MaxDepth)
                {
                    depthBox.BackColor = Color.Red;
                }
                else
                {
                    depthBox.BackColor = Color.White;
                }
            }
            else
            {
                depthBox.BackColor = Color.Red;
            }
        }

        private void ValidateDepthIsInt(object sender, KeyPressEventArgs e)
        {
            char depthInput = e.KeyChar;
            TextBox depthBox = (TextBox)sender;

            if (!char.IsDigit(depthInput) && !char.IsControl(depthInput))
            {
                depthBox.BackColor = Color.Red;
            }

        }

        private void SubmitQuote_Click(object sender, EventArgs e)
        {
            DeskQuote newQuote = new DeskQuote();
            newQuote.Name = $"{firstName.Text}  {lastName.Text}";

            newQuote.QuoteDate = DateTime.Today;

            // Disallows submission if width is NaN
            try
            {
                newQuote.Width = Int32.Parse(width.Text);
            }
            catch
            {
                width.BackColor = Color.Red;
                return;
            }
            // Disallows submission if depth is NaN
            try
            {
                newQuote.Depth = Int32.Parse(depth.Text);
            }
            catch
            {
                depth.BackColor = Color.Red;
                return;
            }

            newQuote.SurfaceArea = newQuote.CalcSurfaceArea();
            newQuote.NumDrawers = (int)numDrawers.Value;
            newQuote.SurfaceMaterial = surfaceMaterial.Text;
                if (Enum.TryParse(newQuote.SurfaceMaterial, out SurfaceMaterials material))
                {
                    newQuote.SurfacePrice = (int)material;
                }
            if (rushOrder.Text == "Standard - 14 Day")
            {
                newQuote.RushOrder = false;
                newQuote.RushOrderTime = 14;
                newQuote.RushOrderPrice = newQuote.CalcRushOrderPrice();
            }
            else
            {
                newQuote.RushOrder = true;
                newQuote.RushOrderTime = Int32.Parse(rushOrder.Text.Split(' ')[0]);
                newQuote.RushOrderPrice = newQuote.CalcRushOrderPrice();
            }
            newQuote.TotalPrice = newQuote.CalcTotalPrice();
        
            // Writes Quote to JSON file
            StreamWriter sw = new StreamWriter("../../Data/quotes.json", true);
            var serializedQuote = JsonConvert.SerializeObject(newQuote);
            sw.WriteLine(serializedQuote);
            sw.Close();

            // Opens up submitted quote in DisplayQuote form
            DisplayQuote.GetSubmittedQuote(newQuote);
            Form displayQuoteForm = new DisplayQuote();
            displayQuoteForm.ShowDialog();
            
        }
    }
}
