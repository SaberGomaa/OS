//for result and it's calculation
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
    public partial class Results : Form
    {
        #region properity 
        int[] waitingTime_c;
        int[] turnaroundTime_c;
        int[] start_c;
        int[] end_c;
        int[] proc_c;
        float avg_waiting_c;
        float avg_turnaround_c;
        int lastValid_c;
        #endregion

        //int interval = 45;

        Color[] colors;

        #region constractor 
        public Results()
        {
            InitializeComponent();

            waitingTime_c = new int[2000];
            turnaroundTime_c = new int[2000];
            start_c = new int[2000];
            end_c = new int[2000];
            proc_c = new int[2000];

            change_name();
            set_colors();
            set_names();
            set_waits();
            set_turn();

            set_values();
            play();
        }
        #endregion


        #region  check if checked is Priority or FCFS
        private void change_name() { 
           
           
            if (Form_process.P_non_premptive)
            {
                label2.Text = "Priority non-Premptive";
                P_alg sch = new P_alg(data_input_p.arrivalTime, data_input_p.cpu_brustTime, data_input_p.priority, Form_process.no_of_process);
                lastValid_c = sch.lastValid;
                sch.computePriority_N();
                avg_turnaround_c = sch.avg_turnaround;
                avg_waiting_c = sch.avg_waiting;
                for (int i = 0; i < sch.lastValid; i++)
                {
                    start_c[i] = sch.start[i];
                    end_c[i] = sch.end[i];
                    proc_c[i] = sch.proc[i];
                }
                for (int i = 0; i < Form_process.no_of_process; i++)
                {
                    waitingTime_c[i] = sch.waitingTime[i];
                    turnaroundTime_c[i] = sch.turnaroundTime[i];
                }
            }
            
           
            else 
            {
                label2.Text = "FCFS";
                FCFS_alg sch = new FCFS_alg(data_input_sjf_fcfs.arrivalTime, data_input_sjf_fcfs.cpu_brustTime, data_input_sjf_fcfs.priority,Form_process.no_of_process);
                sch.computeFCFS();
                lastValid_c = sch.lastValid;
                avg_turnaround_c = sch.avg_turnaround;
                avg_waiting_c = sch.avg_waiting;
                for (int i = 0; i < sch.lastValid; i++) {
                    start_c[i] = sch.start[i];
                    end_c[i] = sch.end[i];
                    proc_c[i] = sch.proc[i];
                }
                for (int i = 0; i < Form_process.no_of_process; i++)
                {
                    waitingTime_c[i] = sch.waitingTime[i];
                    turnaroundTime_c[i] = sch.turnaroundTime[i];
                }
            }
        }
        #endregion


        #region calculate the waiting time for all process
        private void set_waits(){
            Label old_lb = new Label();
            old_lb = this.lbl_p1_waitingTime;
            this.lbl_p1_waitingTime.Text = waitingTime_c[0].ToString();
            old_lb.Visible = true;
            int y = 60;
            for (int i = 1; i < Form_process.no_of_process; i++)
            {
                Label new_lb = new Label();
                new_lb.Size = old_lb.Size;
                new_lb.Location = new Point(old_lb.Location.X, old_lb.Location.Y + y);
                int x = i + 1;
                new_lb.Name = "lbl_p"+x+"_waitingTime";
                new_lb.Text = waitingTime_c[i].ToString();
                new_lb.Font = old_lb.Font;
                new_lb.BackColor = old_lb.BackColor;
                new_lb.TextAlign = old_lb.TextAlign;
                new_lb.Size = old_lb.Size;
                new_lb.Visible = true;
                this.panel81.Controls.Add(new_lb);
                y = y + 60;
            }
        }
        #endregion


        #region calculate the turnaroundTime for all process
        private void set_turn() {
            Label old_lb = new Label();
            old_lb = this.lbl_p1_turnaroundTime;
            this.lbl_p1_turnaroundTime.Text= turnaroundTime_c[0].ToString();
            old_lb.Visible = true;
            int y = 60;
            for (int i = 1; i < Form_process.no_of_process; i++)
            {
                Label new_lb = new Label();
                new_lb.Size = old_lb.Size;
                new_lb.Location = new Point(old_lb.Location.X, old_lb.Location.Y + y);
                int x = i + 1;
                new_lb.Name = "lbl_p" + x + "_turnaroundTime";
                new_lb.Text = turnaroundTime_c[i].ToString();
                new_lb.Font = old_lb.Font;
                new_lb.BackColor = old_lb.BackColor;
                new_lb.TextAlign = old_lb.TextAlign;
                new_lb.Size = old_lb.Size;
                new_lb.Visible = true;
                this.panel81.Controls.Add(new_lb);
                y = y + 60;
            }
        }
        #endregion

        #region name for process
        private void set_names()
        {
            Label old_lb = new Label();
            old_lb = this.lbl_p1;
            old_lb.Visible = true;
            int y = 60;
            for (int i = 1; i < Form_process.no_of_process; i++)
            {
                Label new_lb = new Label();
                new_lb.Size = old_lb.Size;
                new_lb.Location = new Point(old_lb.Location.X, old_lb.Location.Y + y);
                int x = i + 1;
                new_lb.Text = "Process " + x;
                new_lb.Font = old_lb.Font;
                new_lb.BackColor = old_lb.BackColor;
                new_lb.TextAlign = old_lb.TextAlign;
                new_lb.Visible = true;
                this.panel81.Controls.Add(new_lb);
                y = y + 60;
            }
            
        }
        #endregion

        #region give collers for gant chart "evry process take coller"
        private void set_colors()
        {
            colors = new Color[15];
            colors[0] = Color.Red;
            colors[1] = Color.Yellow;
            colors[2]= Color.Violet;
            colors[3]= Color.Blue;
            colors[4]= Color.Lime;
            colors[5]= Color.Chocolate;
            colors[6]= Color.Aqua;
            colors[7]= Color.DarkGreen;
            colors[8]= Color.Maroon;
            colors[9]= Color.Pink;
            colors[10]= Color.Silver;
            colors[11]= Color.BlanchedAlmond;
            colors[12]= Color.Cyan;
            colors[13]= Color.Fuchsia;
            colors[14] = Color.Gold;
            Panel old_lb = new Panel();
            old_lb = this.panel_ex_1;
            old_lb.Visible = true;
            int y = 60;
            for (int i = 1; i < Form_process.no_of_process; i++)
            {
                Panel new_lb = new Panel();
                new_lb.Size = old_lb.Size;
                new_lb.Location = new Point(old_lb.Location.X, old_lb.Location.Y + y);
                int x = i + 1;
                new_lb.BackColor = colors[i%15];
                new_lb.Visible = true;
                this.panel81.Controls.Add(new_lb);
                y = y + 60;
            }
        }
        #endregion


        #region button for when you click back button for privious page
        private void btn_back_Click(object sender, EventArgs e)
        {
            
           
             if (Form_process.P_non_premptive)
            {
                data_input_p data = new data_input_p();
                data.Show();
                Hide();
            }
            
            else
            {
                data_input_sjf_fcfs data = new data_input_sjf_fcfs();
                data.Show();
                Hide();
            }
        }

        #endregion



        #region for showing and display Gant Chart
        private void play()
        {
            int p;
            Label l = new Label();
            int x = this.label3.Location.X;
            int y = this.label3.Location.Y;
            int len= (end_c[0]-start_c[0])*45 ;
            this.label3.Size = new System.Drawing.Size(len, 30);
            p = proc_c[0];
            //====================================================
            Label flag = new Label();
            flag = this.label4;
            flag.Location = new Point(this.label4.Location.X-45+len, this.label4.Location.Y);
            flag.Visible = true;
            this.tabPage_GanttChart.Controls.Add(flag);
            Label n = new Label();
            n = this.label5;
            n.Location = new Point(this.label5.Location.X-45+len, this.label5.Location.Y);
            n.Visible = true;
            n.Text = end_c[0].ToString();
            this.tabPage_GanttChart.Controls.Add(n);
            //=====================================================
            string name = 'P' + (p + 1).ToString(); 
            if (p == -1)
            {
                this.label3.BackColor = Color.Gray;
                this.label3.Text = " "; 
            }
            else
            {
                this.label3.BackColor = colors[p%15];
                this.label3.Text = name; 
            }
            l = this.label3;
            x = x + len;
            l.Font = this.label3.Font;
            l.ForeColor = this.label3.ForeColor;
            this.tabPage_GanttChart.Controls.Add(l);
            for(int i=1; i<=lastValid_c ;i++)
            {
                 Label l2 = new Label();
                 l2.TextAlign = l.TextAlign;
                 l2.Location = new Point (x,y);
                 len=(end_c[i]-start_c[i])*45;
                 p=proc_c[i];
                 l2.Size=new System.Drawing.Size(len,30);
                 name = "P" + (p+1).ToString();
                 if (p == -1)
                 { 
                     l2.Text = " ";
                     l2.BackColor = Color.Gray;
                 }
                 else
                 { 
                     l2.Text = name;
                     l2.BackColor = colors[p%15];
                 }
                 l2.Font = this.label3.Font;
                 l2.ForeColor = this.label3.ForeColor;
                 x = x + len ;
                 this.tabPage_GanttChart.Controls.Add(l2);
                 //===============================================
                 Label flag2 = new Label();
                 Label n2 = new Label();
                 flag2.BackColor=Color.Black;
                 flag2.Size = this.label4.Size;
                 flag2.Location = new Point(flag.Location.X + len, flag.Location.Y);
                 flag2.Visible = true;

                 n2.Size = this.label5.Size;
                 n2.Location = new Point(n.Location.X + len, n.Location.Y);
                 n2.Visible = true;
                 n2.Text = end_c[i].ToString();
                 this.tabPage_GanttChart.Controls.Add(flag2);
                 this.tabPage_GanttChart.Controls.Add(n2);
                 //=================================================
                 l = l2;
                 n = n2;
                 flag = flag2;
            }
        }
        #endregion

        #region for calculating avg waiting and turnaround
        private void set_values() {
            this.lbl_avg_waitingTime.Text = avg_waiting_c.ToString();
            this.lbl_contextSwitch.Text = avg_turnaround_c.ToString();
        }
        #endregion

        #region events معمولة وخلاص ملهاش لازمة بس متشيلهاش
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel_ex_1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tabPage_GanttChart_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_p1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_avg_wait_Click(object sender, EventArgs e)
        {

        }

        private void lbl_avg_waitingTime_Click(object sender, EventArgs e)
        {

        }

        private void lbl_freeTime_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }
    }
}
