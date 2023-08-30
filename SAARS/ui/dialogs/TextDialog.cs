using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAARS.ui.dialogs
{
    public partial class TextDialog : Form
    {
        public delegate void ValueSubmittedHandler(string value);
        public event ValueSubmittedHandler ValueSubmitted;

        public TextDialog(string currentValue, string title)
        {
            InitializeComponent();
            if (currentValue != "Click to input")
            {
                mainTxtBox.Text = currentValue;
            }
            titleLabel.Text = title;
            this.Text = title;
        }

        private void TextDialog_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string data = mainTxtBox.Text;
            ValueSubmitted?.Invoke(data);
            this.Close();
        }
    }
}
