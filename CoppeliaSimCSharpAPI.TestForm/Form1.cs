﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoppeliaSimCSharpAPI.TestForm
{
    public partial class Form1 : Form
    {
        private int _id;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            _id = Api.Connect(textBoxAddress.Text, (int)numericUpDownPort.Value);
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            Api.Disconnect(_id);
        }
    }
}
