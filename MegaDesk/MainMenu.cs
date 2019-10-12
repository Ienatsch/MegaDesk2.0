using System;
using System.Windows.Forms;
using MegaDesk.Forms;

namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            // Allows key press capture at form level
            KeyPreview = true;
        }

        // Opens Add Quote form on button click
        private void AddQuote_Click(object sender, EventArgs e)
        {
            object quote = new object();
            Form addQuoteForm = new AddQuote();
            addQuoteForm.ShowDialog();
        }

        // Opens View All Quotes form on button click
        private void ViewAllQuotes_Click(object sender, EventArgs e)
        {
            Form viewQuotesForm = new ViewAllQuotes();
            viewQuotesForm.ShowDialog();
        }

        // Opens Search Quotes form on button click
        private void SearchQuotes_Click(object sender, EventArgs e)
        {
            Form searchQuotesForm = new SearchQuotes();
            searchQuotesForm.ShowDialog();
        }

        // Exits application on button click
        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Opens related form on key press
        private void OpenFormsOnKeyPress(object sender, KeyPressEventArgs e)
        {
            var key = e.KeyChar;
            switch (key)
            {
                case 'a':
                    Form addQuoteForm = new AddQuote();
                    addQuoteForm.ShowDialog();
                    break;
                case 'v':
                    Form viewQuotesForm = new ViewAllQuotes();
                    viewQuotesForm.ShowDialog();
                    break;
                case 's':
                    Form searchQuotesForm = new SearchQuotes();
                    searchQuotesForm.ShowDialog();
                    break;
                case 'x':
                    Application.Exit();
                    break;
            }

            // Prevents event from firing multiple times
            e.Handled = true;
        }
    }
}
