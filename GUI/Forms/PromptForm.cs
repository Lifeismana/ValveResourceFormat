using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class PromptForm : Form
    {
        public string ResultText => inputTextBox.Text;

        public PromptForm(string title)
        {
            InitializeComponent();

            Text = title;
            textLabel.Text = string.Concat(title, ":");
        }

        private void PromptForm_Load(object sender, EventArgs e)
        {
            ActiveControl = inputTextBox;
        }
    }
}
