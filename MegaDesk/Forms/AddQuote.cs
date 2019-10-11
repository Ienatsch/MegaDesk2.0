using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk.Forms
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();

            // Add surface materials to dropdown box
            foreach (var item in Enum.GetValues(typeof(SurfaceMaterial)))
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
                if (width < 24 || width > 96)
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
            if (Int32.TryParse(depthBox.Text, out int width))
            {
                if (width < 12 || width > 48)
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
            newQuote.SetCustomerName($"{firstName.Text}  {lastName.Text}");
            try
            {
                newQuote.SetWidth(Int32.Parse(width.Text));
            }
            catch
            {
                width.BackColor = Color.Red;
                return;
            }

            try
            {
                newQuote.SetDepth(Int32.Parse(depth.Text));
            }
            catch
            {
                depth.BackColor = Color.Red;
                return;
            }
            newQuote.SetNumDrawers((int)numDrawers.Value);
            newQuote.SetSurfaceMaterial(surfaceMaterial.Text);
            newQuote.SetSurfacePrice();
            if (rushOrder.Text == "Standard - 14 Day")
            {
                newQuote.SetRushOrder(false);
                newQuote.SetRushOrderTime(14);
            }
            else
            {
                newQuote.SetRushOrder(true);
                newQuote.SetRushOrderTime(Int32.Parse(rushOrder.Text[0].ToString()));
            }
            newQuote.CalcTotalPrice();
            DisplayQuote.GetSubmittedQuote(newQuote);
            Form displayQuoteForm = new DisplayQuote();
            displayQuoteForm.ShowDialog();
        }
    }
}
