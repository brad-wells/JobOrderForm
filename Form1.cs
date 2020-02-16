// Brad Wells
// CIS 129.7785
// Assignment 10
// 11/30/18

// This program allows users to enter a job order. After the order is created, it allows users to edit and view jobs. A rush job
// will add a surcharge to the order.
//******************************************************************************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace Asg10
{

    public partial class MainForm : Form
    {
        //ArrayList storedJobs = new ArrayList();
        public MainForm()
        {

            InitializeComponent();
            MainPanel.Controls.Clear();

        
            Job preLoadJob1 = new Job("1234", "Brad", "Wells", "1111111111", "iPhone", "11111", "guy", "wont turn on", "1", "1", "Saturday November 10 2018", "phone is junk", true, false, 25, false);
            Job preLoadJob2 = new Job("4567", "Kim", "Wells", "2222222222", "Samsung", "22222", "other guy", "screen cracked", "1", "1", "Sunday November 11 2018", "battery needs replaced", false, true, 25, true);

            AllJobsListBox.Items.Add(preLoadJob1);
            AllJobsListBox.Items.Add(preLoadJob2);

        }

        //*************************************************************************************************

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProductGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ProductionInfoGroupBox_Enter(object sender, EventArgs e)
        {

        }

        // this method pulls up a new job entry form
        private void CreateNewJobButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();

            //create a random job num
            Random n = new Random();
            Thread.Sleep(1);
            String j = n.Next(1111, 9999).ToString();
            JobNumberTextBox.Text = j;
            JobNumberTextBox.Enabled = false;

            MainPanel.Controls.Add(CustomerGroupBox);
            NameTextBox.Visible = true;
            LastNameTextBox.Visible = true;
            PhoneTextBox.Visible = true;
            MainPanel.Controls.Add(ProductGroupBox);
            ProductGroupBox.Controls.Remove(AllJobsListBox);
            MainPanel.Controls.Add(ProductionInfoGroupBox);
            MainPanel.Controls.Add(AddJobButton);
            MainPanel.Controls.Add(CostLabel);
            MainPanel.Controls.Add(TotalLabel);
            MainPanel.Controls.Remove(updateJobButton);

            YesCompletedCheckBox.Checked = false;
            YesPaidCheckBox.Checked = false;
            YesRushCheckBox.Checked = false;

            NameTextBox.Enabled = true;
            LastNameTextBox.Enabled = true;

        } // end CreateNewJobButton

        //*************************************************************************************************

        //this method pulls up a list of jobs 
        private void LookUpJobButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(SelectLabel);
            SelectLabel.Visible = true;
            MainPanel.Controls.Add(AllJobsListBox);
            //MainPanel.Controls.Add(RushListBox);
            AllJobsListBox.Visible = true;
            JobNumberTextBox.Enabled = false;
            NameTextBox.Enabled = false;
            LastNameTextBox.Enabled = false;

            MainPanel.Controls.Add(DeleteJobButton);
            DeleteJobButton.Visible = true;

            MainPanel.Controls.Add(updateJobButton);
            updateJobButton.Visible = true;

            MainPanel.Controls.Add(CostLabel);
            MainPanel.Controls.Add(TotalLabel);
            //int cost = (Convert.ToInt32(EstimatedComboBox.SelectedText) * 25);
            // CostLabel.Text = Convert.ToString(cost);

        } // end LookUpJobButton

        //*************************************************************************************************

        //this method creates a new job from the user input using the Job class
        public void AddJobButton_Click(object sender, EventArgs e)
        {
            //create a random num for job num
            // Random number = new Random();

            String jobNumber = JobNumberTextBox.Text;//number.Next(0001, 9999).ToString();//
            String name = NameTextBox.Text;
            String lastName = LastNameTextBox.Text;
            //int phone = Convert.ToInt32(PhoneTextBox.Text);
            String phone = PhoneTextBox.Text;
            String productType = productComboBox.Text;
            String serialNumber = SerialNumberTextBox.Text;
            String techName = TechNameTextBox.Text;
            String problem = ProblemRichTextBox1.Text;
            //int estimatedHours = Convert.ToInt32(EstimatedHoursTextBox.Text);
            String estimatedHours = EstimatedComboBox.Text;
            //int actualHours = Convert.ToInt32(ActualHoursTextBox.Text);
            String actualHours = ActualComboBox.Text;
            String promisedBy = PromisedByDateTimePicker.Text;
            String comments = CommentsRichTextBox.Text;
            //String completed = YesCompletedCheckBox.Text;
            bool completed = YesCompletedCheckBox.Checked;
            bool paid = YesPaidCheckBox.Checked;
            bool rush = YesRushCheckBox.Checked;
            // int cost = Convert.ToInt32(estimatedHours) * 25;
            double cost;
            bool color = false;
            if (!YesRushCheckBox.Checked==true)
            {
                cost = Convert.ToDouble(estimatedHours) * 25;
            }
            else
            {
                cost = Convert.ToDouble(estimatedHours) * (25) * (1.15);
                color = true;
               // jobNumber = ("RUSH " + JobNumberTextBox.Text);
            }
            CostLabel.Text = Convert.ToString(cost);
            CostLabel.Text = Convert.ToString(cost);

            //surround constructor with try block. this will ensure constructor can not be set until all validation rules are met
            try
            {
                Job newJob = new Job(jobNumber, name, lastName, phone,
                       productType, serialNumber,
                       techName, problem, estimatedHours,
                        actualHours, promisedBy,
                        comments, completed,
                        paid, cost, rush);

                //****************************************************************************************************************
                //trying different methods here to print text a different color based on rush status
                //    List<object> red = new List<object>();

                //    foreach (object s in AllJobsListBox.Items)
                //{
                //        // MessageBox.Show(s.ToString().IndexOf("R").ToString());
                //    if (s.ToString().IndexOf("R").Equals(0))
                //    {
                //            red.Add(s.ToString());
                //        //red.Add(s.ToString());
                //    }

                //}
                //    foreach(object r in red)
                //    {
                //        AllJobsListBox.ForeColor = Color.Red;
                //        AllJobsListBox.Items.Add(r.ToString());
                //    }
                // AllJobsListBox.Items.Add(red.ToString());
                //***************************************************************************************************

                //this loop is here to avoid duplicate jobs in list 
                for (int i = 0; i < AllJobsListBox.Items.Count; i++)                           //loop through all jobs
                {
                    String[] split = AllJobsListBox.Items[i].ToString().Split(',');        //for every job in the list, split the job num from the Last name(see Job.ToString)
                                                                                           // MessageBox.Show(split[0]);      //if you want to view the splits as they happen, uncomment
                    if (split[0].Contains(jobNumber))//(AllJobsListBox.Items[i].ToString().Contains(split[0]))  //split[0] will contain the job# check if it matches the current one 
                    {
                        AllJobsListBox.Items.RemoveAt(i);                                 //if it is already in the list, remove the old listing
                    }
                }

                //if (!newJob.ToString().Contains("RUSH"))
                //{
                AllJobsListBox.Items.Add(newJob);
                //}
                //else
                //{
                //    RushListBox.Items.Add(newJob);
                //}
                
                MessageBox.Show("Job#" + jobNumber + " successfully created!");
            }
            catch (Exception ex)                            //if the validaion rules are not met, catch the message from set rule, add it to a messagebox
            {
                MessageBox.Show(ex.Message + "\n\nPlease check your data and try again.");
            }

        }

        //*************************************************************************************************


        private void DeleteJobButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this job?", "Confirm Job Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {

                if (AllJobsListBox.SelectedIndex != -1)
                {
                    AllJobsListBox.Items.RemoveAt(AllJobsListBox.SelectedIndex);
                    if (AllJobsListBox.Items.Count > 0)
                    {
                        AllJobsListBox.SelectedIndex = 0;
                    }
                }
            }
        }

        //*************************************************************************************************

        private void YesCompletedCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        // this method allows you to select a job from the list box, and the form will fill in with the correct infomration
        public void AllJobsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //!AllJobsListBox.Visible;
            if (AllJobsListBox.SelectedIndex != -1)
            {
                Job j = (Job)AllJobsListBox.SelectedItem;

                AllJobsListBox.Visible = false;
                SelectLabel.Visible = false;

                MainPanel.Controls.Add(CustomerGroupBox);
                JobNumberTextBox.Text = j.JobNumber;
                NameTextBox.Text = j.Name;
                LastNameTextBox.Text = j.LastName;
                PhoneTextBox.Text = j.Phone;

                MainPanel.Controls.Add(ProductGroupBox);
                productComboBox.Text = j.ProductType;
                SerialNumberTextBox.Text = j.SerialNumber;
                TechNameTextBox.Text = j.TechName;
                ProblemRichTextBox1.Text = j.Problem;
                EstimatedComboBox.Text = j.EstimatedHours;
                ActualComboBox.Text = j.ActualHours;
                PromisedByDateTimePicker.Text = j.PromisedBy;


                MainPanel.Controls.Add(ProductionInfoGroupBox);
                CommentsRichTextBox.Text = j.Comments;
                YesCompletedCheckBox.Checked = j.Completed;
                YesPaidCheckBox.Checked = j.Paid;

                YesRushCheckBox.Checked = j.Rush;

                CostLabel.Text = Convert.ToString(j.Cost);



            }

        }

        //*************************************************************************************************


        private void updateJobButton_Click(object sender, EventArgs e)
        {
            //int jobNumber = Convert.ToInt32(JobNumberTextBox.Text);
            String jobNumber = JobNumberTextBox.Text;
            String name = NameTextBox.Text;
            String lastName = LastNameTextBox.Text;
            //int phone = Convert.ToInt32(PhoneTextBox.Text);
            String phone = PhoneTextBox.Text;
            String productType = productComboBox.Text;
            String serialNumber = SerialNumberTextBox.Text;
            String techName = TechNameTextBox.Text;
            String problem = ProblemRichTextBox1.Text;
            //int estimatedHours = Convert.ToInt32(EstimatedHoursTextBox.Text);
            String estimatedHours = EstimatedComboBox.Text;
            //int actualHours = Convert.ToInt32(ActualHoursTextBox.Text);
            String actualHours = ActualComboBox.Text;
            String promisedBy = PromisedByDateTimePicker.Text;
            String comments = CommentsRichTextBox.Text;
            //String completed = YesCompletedCheckBox.Text;
            bool completed = YesCompletedCheckBox.Checked;
            //String paid = "";
            bool paid = YesPaidCheckBox.Checked;
            double cost;
            if (!YesRushCheckBox.Checked == true)
            {
                cost = Convert.ToDouble(estimatedHours) * 25;
            }
            else
            {
                cost = Convert.ToDouble(estimatedHours) * (25) * (1.15);
                //jobNumber = ("RUSH " + JobNumberTextBox.Text);
            }
            CostLabel.Text = Convert.ToString(cost);
            bool rush = YesRushCheckBox.Checked;

            //surround constructor with try block. this will ensure constructor can not be set until all validation rules are met
            try
            {
                Job newJob = new Job(jobNumber, name, lastName, phone,
                       productType, serialNumber,
                       techName, problem, estimatedHours,
                        actualHours, promisedBy,
                        comments, completed,
                        paid, cost, rush);


                //this loop is here to avoid duplicate jobs in list after updates are made
                for (int i = 0; i < AllJobsListBox.Items.Count; i++)                           //loop through all jobs
                {
                    String[] split = AllJobsListBox.Items[i].ToString().Split(',');        //for every job in the list, split the job num from the Last name(see Job.ToString)
                                                                                           // MessageBox.Show(split[0]);      //if you want to view the splits as they happen, uncomment
                    if (split[0].Contains(jobNumber))//(AllJobsListBox.Items[i].ToString().Contains(split[0]))  //split[0] will contain the job# check if it matches the current one 
                    {
                        AllJobsListBox.Items.RemoveAt(i);                                 //if it is already in the list, remove the old listing
                    }
                }
                //AllJobsListBox.ForeColor = Color.Red;
                AllJobsListBox.Items.Add(newJob);                                    // and replace with the new one
                MessageBox.Show("Job#" + jobNumber + " successfully updated!");

            }
            catch (Exception ex)                            //if the validaion rules are not met, catch the message from set rule, add it to a messagebox
            {
                MessageBox.Show(ex.Message + "\n\nPlease check your data and try again.");
            }

        } // end UpdateJob Button

        //*************************************************************************************************

        //created to try to pass a rush job to the list box from RushJob class
        public void Add(String job)
        {
            AllJobsListBox.Items.Add(job);
        }

        //*************************************************************************************************

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Add Job \n Click the NEW JOB button to enter a new job. All items" +
                "indicated with a * are required. \n\n View and Edit \n Click VIEW JOB button. Select " +
                "the job you want to view. Edit your information and click the UPDATE button. \n\n Delete Job \n" +
                " Click the VIEW JOB button. Select the job you want to delete. Click the DELETE JOB button");
        }

        private void YesRushCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void CostLabel_Click(object sender, EventArgs e)
        {

        }

        //*************************************************************************************************

    } // end mainForm

    //*************************************************************************************************

    public class Job 
        
    {
        //private  MainForm f = new MainForm();
      // private readonly MainForm f = new MainForm();
        
        // I made them all strings, that way I an validate with throwing exceptions at the end of the form, rather than messages during and after
        public Job(String jobNumber, String name, String lastName, String phone,
                   String productType, String serialNumber,
                   String techName, String problem,String estimatedHours,
                   String actualHours, String promisedBy,
                   String comments, bool completed,
                   bool paid,double cost,bool rush)
        {
            this.JobNumber = jobNumber;
            this.Name = name;
            this.LastName = lastName;
            this.Phone = phone;
            this.ProductType = productType;
            this.SerialNumber = serialNumber;
            this.TechName = techName;
            this.Problem = problem;
            this.EstimatedHours = estimatedHours;
            this.ActualHours = actualHours;
            this.PromisedBy = promisedBy;
            this.Comments = comments;
            //this.Completed = completed;
            this.Completed = completed;
            this.Paid = paid;
            this.Cost = cost;
            this.Rush = rush;
            //this.f = f;
        }
        public Job(MainForm Mainform)
        {
            //f = Mainform;
        }

        private String jobNumber;

        public String JobNumber
        {
            get
            {
                return jobNumber;
            }
            set
            {
                if ( value.Length !=4 )
                {
                    // jobNumber = value;
                    throw new Exception("job number must be 4 digits");
                }

                if ( value.Any(c=>Char.IsLetter(c)))
                {
                    throw new Exception("job number must be numeric ex 1234");
                }
                else
                {
                    jobNumber = value;
                }

            }
        }
        //public int JobNumber { get; set; }

        private String name;

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public String LastName { get; set; }

        private String phone;
        public String Phone
        {

            get
            {
                return phone;
            }

            set
            {
                //string p = Convert.ToString(value);
                if( value.Any(c => char.IsLetter(c)))
                {
                    throw new Exception("Phone number must be numeric ex 1112223333");
                }
                if (value.Length != 10)
                {
                    throw new Exception("Phone number must have 10 digits");
                }
                //if (! value.Any(c => char.IsNumber(c)))
                //{
                //    throw new Exception("Phone must only contain numbers. ex 6166666666");
                //}
                else
                {
                    phone = value;
                }
            }
        }

        private String productType;
        public String ProductType {
            get
            {
                return productType;
            }
            set
            {
                if ( value == "-select-")
                {
                    throw new Exception("You must enter a product type");
                }
                else
                {
                    productType = value;
                }
            }
        }

        private String serialNumber;
        public String SerialNumber {
            get
            {
                return serialNumber;
            }
            set
            {
                if ( value.Any(c => char.IsLetter(c)))
                {
                    throw new Exception("Serial number is a numeric 5 digit value");
                }
                if ( value.Length !=5 )
                {
                    throw new Exception("Serial number needs to be 5 digits long");
                }
                else
                {
                    serialNumber = value;
                }
            }
        }

        public String TechName { get; set; }

        private String problem;
        public String Problem
        {
            get
            {
                return problem;
            }
            set
            {
                if ( value.Equals(""))
                {
                    throw new Exception("You must enter the problem");
                }
                else
                {
                    problem = value;
                }
            }
        }
        public String ActualHours { get; set; }

        private String estimatedHours;
        public String EstimatedHours
        {
            get
            {
                return estimatedHours;
            }

            set
            {
                // could use selected index -1
                if ( value.Equals("-select-") )
                {
                    throw new Exception("You must enter estimated hours");
                }
                if ( value.Equals("0")) 
                {
                    throw new Exception("You must select min of 1 estimated hours");
                }
                else
                {
                    estimatedHours = value;
                }
            }
        }

        public String PromisedBy { get; set; }

        public String Comments { get; set; }

        public bool Completed { get; set; }

        public bool Paid { get; set; }

        //private  int cost;
        //public int Cost {
        //    get
        //    {
        //        return cost;
        //    }
        //    set
        //    {
        //        if (Convert.ToString(value).Any(c => char.IsLetter(c)))
        //        {
        //            throw new Exception("You must enter a number for cost");
        //        }
        //        if (value==0)
        //        {
        //            throw new Exception("You must enter estimated hours to calculate the cost");
        //        }
        //        else
        //        {
        //            value = cost;
        //        }
        //    }
        //}
        public  double Cost { get; set; }

        private bool rush;
        public bool Rush {
            get
            {
                return rush ;
            }
            set
            {
                if ( value == true)
                {
                    RushJob rushJob = new RushJob(jobNumber,  name,  LastName,  phone,
                    productType,  serialNumber,
                   TechName,  Problem,  estimatedHours,
                    ActualHours,  PromisedBy,
                    Comments,  Completed,
                  Paid, Cost,  rush);

                    //this.Cost *= (int)1.15;
                    
                    

                    rush = true;
                    //********************************************************************
                    //????? I cant access the list box from here? why?
                    // Not sure where to go from here. using a message box, I can see that
                    // a rush job is being created, but I can not access the list box from 
                    // the Main Form. I have tried creating a method in the MainForm class, and creating an instance of 
                    //Mainform in this class to call it, but I get a null error. I have also tried messing with abstract classes, 
                    //and everything I make abstract makes something else not work correctly. 

                    // MessageBox.Show(rushJob.ToString());
                    // this.ToString().Replace(this.ToString(), "rushJob.ToString()");


                    //rushJob.ToString();
                    //this.ToString().Equals(rushJob.ToString());
                    //ListBox rushJobListBox = new ListBox();
                    //rushJobListBox.Items.Add(rushJob);
                    // rushJobListBox.BringToFront();
                    // f.Add(rushJob.ToString());
                    //AlljobsListBox.items.add(rushJob);
                    // f.AlljobsListBox.items.add(rushJob);


                }
                else
                {
                    rush = false;
                }
            }
        }

        //********************************************************************

        public override string ToString()
        {
            String display;
            if (!rush)
            {
                 display = String.Format("Job  #:{0}   ,    Last Name:  {1}", JobNumber, LastName);//  Name:{1}  Last Name:{2} Phone:{3} Product:{4} Serial:{5} Tech:{6} ActualHrs:{7} EstimatedHrs:{8} DueDate:{9} Comments:{10} paid:{11}", JobNumber, Name, LastName, Phone, ProductType, SerialNumber, TechName, ActualHours, EstimatedHours,
                                                                                                         //PromisedBy, Comments, Paid);
            }
            else
            {
                 display = String.Format("RUSH Job  #:{0}   ,    Last Name:  {1}", JobNumber, LastName);//  Name:{1}  Last Name:{2} Phone:{3} Product:{4} Serial:{5} Tech:{6} ActualHrs:{7} EstimatedHrs:{8} DueDate:{9} Comments:{10} paid:{11}", JobNumber, Name, LastName, Phone, ProductType, SerialNumber, TechName, ActualHours, EstimatedHours,
                 
            }
            return display;

           // String[] split = display.Split(',');
           // return split[1];
        }

        //********************************************************************


    } // end class Job

    //********************************************************************


    public class RushJob : Job
    {
        public RushJob(String jobNumber, String name, String lastName, String phone,
           String productType, String serialNumber,
           String techName, String problem, String estimatedHours,
           String actualHours, String promisedBy,
           String comments, bool completed,
           bool paid, double cost, bool rush) : base(jobNumber, name, lastName, phone, productType, serialNumber, techName, problem, estimatedHours, actualHours, promisedBy, comments, completed, paid, cost, rush)
        {
            this.Rush = rush;
            this.Cost = cost;

        }

        //public override int Cost{get;set;}

        //private bool rush;
        //public bool Rush 
        //{
        //    get
        //    {
        //        return rush;

        //    }
        //    set
        //    {
        //        if (value == true)
        //        {
        //            Cost *= (int)(.15);
                    
        //        }
        //    }
        //}
        public override string ToString()
        {
            String display = String.Format("RushJob  #:{0}   ,    Last Name:  {1}", JobNumber, LastName);//  Name:{1}  Last Name:{2} Phone:{3} Product:{4} Serial:{5} Tech:{6} ActualHrs:{7} EstimatedHrs:{8} DueDate:{9} Comments:{10} paid:{11}", JobNumber, Name, LastName, Phone, ProductType, SerialNumber, TechName, ActualHours, EstimatedHours,
                                                                                                         //PromisedBy, Comments, Paid);

            return display;

            // String[] split = display.Split(',');
            // return split[1];
        }
        //public String Print()
        //{
        //    return "Rush " + base.Print();
        //}

    } // end RushJob:Job

    //********************************************************************

} // end Namespace Asg10




