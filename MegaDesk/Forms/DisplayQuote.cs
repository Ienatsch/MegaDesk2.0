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
            _submittedQuote.TotalPrice = _submittedQuote.CalcTotalPrice();
            InitializeComponent();
            customerName.Text = _submittedQuote.Name;
            width.Text = $"{_submittedQuote.Width.ToString()} in";
            depth.Text = $"{_submittedQuote.Depth.ToString()} in";
            drawers.Text = _submittedQuote.NumDrawers.ToString();
            surfaceArea.Text = $"{_submittedQuote.SurfaceArea.ToString()} in";
            surfaceMaterial.Text = _submittedQuote.SurfaceMaterial;
            surfacePrice.Text = $"${_submittedQuote.SurfacePrice.ToString()}";
            deliveryMethod.Text = $"{_submittedQuote.RushOrderTime.ToString()} Day";
            deliveryPrice.Text = $"${_submittedQuote.RushOrderPrice.ToString()}";
            totalPrice.Text = $"${_submittedQuote.TotalPrice.ToString()}";
        }

        public static void GetSubmittedQuote(object quote)
        {
            _submittedQuote = (DeskQuote)quote; 
        }
    }
}
