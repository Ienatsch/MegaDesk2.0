using System;
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
    public partial class DisplayQuote : Form
    {
        private static DeskQuote _submittedQuote;
        public DisplayQuote()
        {
            InitializeComponent();
            customerName.Text = _submittedQuote.GetCustomerName();
            width.Text = $"{_submittedQuote.GetWidth().ToString()} in";
            depth.Text = $"{_submittedQuote.GetDepth().ToString()} in";
            drawers.Text = _submittedQuote.GetNumDrawers().ToString();
            surfaceArea.Text = $"{_submittedQuote.GetSurfaceArea().ToString()} in";
            surfaceMaterial.Text = _submittedQuote.GetSurfaceMaterial();
            surfacePrice.Text = $"${_submittedQuote.GetSurfacePrice().ToString()}";
            deliveryMethod.Text = $"{_submittedQuote.GetRushOrderTime().ToString()} Day";
            deliveryPrice.Text = $"${_submittedQuote.GetRushOrderPrice().ToString()}";
            totalPrice.Text = $"${_submittedQuote.GetTotalPrice().ToString()}";
        }

        public static void GetSubmittedQuote(object quote)
        {
            _submittedQuote = (DeskQuote)quote; 
        }
    }
}
