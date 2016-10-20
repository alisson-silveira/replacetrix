using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Replacetrix
{
    public partial class InputForm : Form
    {
        public InputForm(string label)
        {
            InitializeComponent();
            label1.Text = label;
        }

        public string InputText { get; set; }

        private void InputForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InputText = TxtInput.Text;
                Close();
            }
            
        }

       
    }
}
