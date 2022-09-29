using System;
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
    public partial class calendarForm : Form
    {
        int month, year;

        public calendarForm()
        {
            InitializeComponent();
        }

        private void calendarForm_Load(object sender, EventArgs e)
        {
            displayDays(); 
        }
        // creating calendar day function
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = monthname + " " + year;

            // getting the first day of the month
            DateTime startOfMonth = new DateTime(year, month, 1);

            // getting count of specific months days
            int days = DateTime.DaysInMonth(year, month);

            // converting startOfMonth to int
            int daysOfWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;


            if (daysOfWeek == 0)
            {
                daysOfWeek = 7;
            }

            // creating blank usercontrol
            for (int i = 1; i < daysOfWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            // creating usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnprev_Click(object sender, EventArgs e)
        {
           
            // clearing container
            daycontainer.Controls.Clear();

            // decrementing month
            month--;

            // displaying month year header
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = monthname + " " + year;


            // getting the first day of the month
            DateTime startOfMonth = new DateTime(year, month, 1);

            // getting count of specific months days
            int days = DateTime.DaysInMonth(year, month);

            // converting startOfMonth to int
            int daysOfWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            // creating blank usercontrol
            for (int i = 1; i < daysOfWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            // creating usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }


        }

        private void btnnext_Click(object sender, EventArgs e)
        {
      
            // clearing container
            daycontainer.Controls.Clear();

            // incrementing month
            //month++;

            // handling 13month exception
            if (month != 12)
            {
                month++;
            }
            else
            {
                month = 1;
                year++;
            }



            // displaying month year header
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbdate.Text = monthname + " " + year;

            // getting the first day of the month
            DateTime startOfMonth = new DateTime(year, month, 1);

            // getting count of specific months days
            int days = DateTime.DaysInMonth(year, month);

            // converting startOfMonth to int
            int daysOfWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            // creating blank usercontrol
            for (int i = 1; i < daysOfWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            // creating usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }



        }
    }
}
