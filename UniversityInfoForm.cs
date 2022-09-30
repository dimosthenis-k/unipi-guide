﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unipi_tour_guide
{
    public partial class UniversityInfoForm : Form
    {
        public UniversityInfoForm()
        {
            InitializeComponent();
        }

        private void UniversityInfoForm_Load(object sender, EventArgs e)
        {   

            // form background color
            this.BackColor = ColorTranslator.FromHtml("#222C54");

            lblocation.ForeColor = ColorTranslator.FromHtml("#F7F2EB");
            lbhistory.ForeColor = ColorTranslator.FromHtml("#F7F2EB");
            lbroam.ForeColor = ColorTranslator.FromHtml("#F7F2EB");
        }
    }
}
