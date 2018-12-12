using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Application
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }
        //******************************************************
        private void buttonDisplayAllEmp_Click(object sender, EventArgs e)
        {
            //Open FormDisplayAllEmp when this button is clicked.

            //Hide the current form first
            this.Hide();

            //Display the other form from this form
            FormDisplayAllEmp formOther = new FormDisplayAllEmp();   //must create a new object instance of the another form first
            formOther.Show();    //then show the form

        }
        //*******************************************************
        private void buttonDisplaySpecificEmp_Click(object sender, EventArgs e)
        {
            //Open FormDisplaySpecificEmp when this button is clicked.

            //Hide the current form first
            this.Hide();

            //Display the other form from this form
            FormDisplaySpecificEmp formOther = new FormDisplaySpecificEmp();   //must create a new object instance of the another form first
            formOther.Show();    //then show the form
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDisplayAllProj formOther = new FormDisplayAllProj();
            formOther.Show();
        }

        private void DisplaySpecificProj_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDisplaySpecificProj formOther = new FormDisplaySpecificProj();
            formOther.Show();
        }



        //*******************************************************



    } //partial class
} //namespace
