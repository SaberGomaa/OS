using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS
{
    public partial class Form_process : Form
    {
        public static int no_of_process;
        public static bool MainFCFSflag;
        public static bool RRflag;
        public static bool SJF_premptive;
        public static bool SJF_non_premptive;
        public static bool P_premptive;
        public static bool P_non_premptive;

        public Form_process()
        {
            InitializeComponent();
        }
        #region هياخد عدد البروسيس ونوع الالجورزم ع ينقلك للصفحة اللى بعدها
        private void btn_ok_number_of_process_Click(object sender, EventArgs e)
        {
            no_of_process = (int)numeric_numProcess.Value;
            MainFCFSflag = (bool)radioButton1.Checked;
            P_non_premptive = (bool)radioButton5.Checked;


            if (MainFCFSflag)
            {
                data_input_sjf_fcfs data = new data_input_sjf_fcfs();
                data.Show();
                data.Location = this.Location;
                //form2.StartPosition = this.StartPosition;
                Hide();
            }
            else if (P_non_premptive || P_premptive)
            {
                data_input_p data_p = new data_input_p();
                data_p.Show();
                data_p.Location = this.Location;
                //form2.StartPosition = this.StartPosition;
                Hide();
            }

        }

        #endregion

        #region empty event
        private void checkBox_FCFS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Form_process_Load(object sender, EventArgs e)
        {

        }
        private void numeric_numProcess_ValueChanged(object sender, EventArgs e)
        {

        }
      

        private void numeric_numProcess_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Priority_N_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void groupbox_algorithm_Enter(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void groupBox_numberProcess_Enter(object sender, EventArgs e)
        {

        }
    }
}
