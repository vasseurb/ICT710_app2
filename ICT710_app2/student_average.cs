/**********************************
 * Program: ICT710_app2
 * Author:  Brian Vasseur
 * Date:    May 19, 2019
 * Purpose: This program is designed to accept a list of student grades
 *          and calculate Max, Min and Average
 *          
 *          This example uses the Validating method on the input textbox eliminating
 *          the need for further validation in other calculations.
 *          
 *          Data entries are written to a readonly textbox with scrollbars
 *          to allow users to review their entries.
 *          
 *          btn_record      - logs text input and returns for another value
 *          btn_calculate   - calculates the entries and writes output
 *          btn_exit        - turns off validation and closes the form
 *          
 *          The AutoValidate.Disable code was provided from StackOverflow
 *          https://stackoverflow.com/users/2835128/sylvain-raymond
 *          Allows for a cancel button and form close.
 *          
 *  **********************************/

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ICT710_app2
{
    public partial class frm_student_average : Form
    {
        //class variables declared here
        int     grade_cnt       = 0;
        int     grade_sum       = 0;
        int     grade_highest   = 0;
        int     grade_lowest    = 100;
 
        public frm_student_average()
        {
            InitializeComponent();
        }

        private void frm_student_average_Load(object sender, EventArgs e)
        {
        }

        // To capture the Upper right "X" click
        // Disable validation to allow the program to exit
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x10) // The upper right "X" was clicked
            {
                AutoValidate = AutoValidate.Disable; //Deactivate all validations
            }
            base.WndProc(ref m);
        }

        // To capture the "Esc" key
        // Turn off validation and close the form
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                AutoValidate = AutoValidate.Disable;
                btn_exit.PerformClick();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        
        // Validate user input before leaving textbox
        private void txt_student_grade_Validating(object sender, CancelEventArgs e)
        {
            // Validate the field on entry vs having other events and methods
            // duplicating validation logic

            int student_mark;
            bool result = Int32.TryParse(txt_student_grade.Text, out student_mark);

            if (!result) //TryParse above did not find an integer
            {
                txt_student_grade.Clear();  //reset the default mark
                MessageBox.Show("Mark must be between 0 and 100.");
                e.Cancel = true;            //cancel validation and try again
            }
            else
            {
                // Valid Mark must be between 0 and 100
                student_mark = Convert.ToInt32(txt_student_grade.Text);
                if (student_mark > 100 || student_mark < 0)
                {
                    txt_student_grade.Text = "0";
                    MessageBox.Show("Mark must be between 0 and 100.");
                    e.Cancel = true;
                }
                else
                {
                    // convert the number we were testing back to a string
                    txt_student_grade.Text = Convert.ToString(student_mark);
                    //MessageBox.Show(txt_std_grade.Text);
                }
            }
        }

        // Store the mark and go back for more
        private void btn_record_Click(object sender, EventArgs e)
        {
            int student_mark = Convert.ToInt32(txt_student_grade.Text);
            if (student_mark > grade_highest)
                grade_highest = student_mark;
            if (student_mark < grade_lowest)
                grade_lowest = student_mark;
            grade_cnt++;
            grade_sum += student_mark;

            txt_entry_list.Text += txt_student_grade.Text + "\r\n"; //list of entries
            txt_student_grade.Clear();
            txt_student_grade.Focus(); //clear the input and get another grade
        }

        // Do the calculations on the data entered
        // NOTE: CausesValidation property = False as "txt_student_grade" may be null
        // Required because of the txt_student_grade_Validating method
        private void btn_calculate_Click(object sender, EventArgs e)
        {
            if (grade_cnt == 0) // Make sure you have data to calculate first
            {
                MessageBox.Show("No data entered, please try again.");
                txt_student_grade.Focus(); // have the user enter at least one grade
            }
            else
            {
                double grade_average = ((double)grade_sum / grade_cnt); //grade_sum was int
                txt_results.Text = "Highest Mark\t" + grade_highest + "\r\n";
                txt_results.Text += "Lowest Mark\t" + grade_lowest + "\r\n";
                txt_results.Text += "Average Mark\t" + grade_average.ToString("f1");
            }
        }

        // Exit the program
        private void btn_exit_Click(object sender, EventArgs e)
        {
            // Stop the validation of any controls so the form can close.
            // Note: The CausesValidation property of this <Cancel> button
            //       must also be set to false.

            AutoValidate = AutoValidate.Disable;
            this.Close();

        }

    }
}
