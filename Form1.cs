using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pinautomaat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            debugForm debugPanel = new debugForm();
            this.AddOwnedForm(debugPanel);
            debugPanel.Show();

            keypadForm keypadForm = new keypadForm();
            this.AddOwnedForm(keypadForm);
            keypadForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
