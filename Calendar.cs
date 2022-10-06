﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unipi_tour_guide
{
    public partial class Calendar : Form
    {
        int month, year;
        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text =monthname +""+year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"))+1;
            /*for (int i=1; i<dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                flowLayoutPanel1.Controls.Add(ucblank);

            }*/
            
            for (int i=1; i<days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                flowLayoutPanel1.Controls.Add(ucdays);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            month--;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthname + "" + year;
            flowLayoutPanel1.Controls.Clear();

            DateTime now = DateTime.Now;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            /*for (int i=1; i<dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                flowLayoutPanel1.Controls.Add(ucblank);

            }*/

            for (int i = 1; i < days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                flowLayoutPanel1.Controls.Add(ucdays);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            month++;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthname + "" + year;

            DateTime now = DateTime.Now;
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            /*for (int i=1; i<dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                flowLayoutPanel1.Controls.Add(ucblank);

            }*/

            for (int i = 1; i < days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                flowLayoutPanel1.Controls.Add(ucdays);
            }
        }
    }
}