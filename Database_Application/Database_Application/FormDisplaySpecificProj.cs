using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Database_Application
{
    public partial class FormDisplaySpecificProj : Form
    {
        public FormDisplaySpecificProj()
        {
            InitializeComponent();
        }

        private void pictureBoxHelp_Click(object sender, EventArgs e)
        {
            string msg = null;

            msg += "To Search a Project:";
            msg += "\r\n\r\n***Enter a value for a specific field belonging to the project requested (e.g., Project Name, Number, Location, Department Number, etc.)";
            msg += "\r\n***You may enter partial or complete value in the field";
            msg += "\r\n*** Press the GO button to start the search";

            MessageBox.Show(msg, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBoxGo_Click(object sender, EventArgs e)
        {
            //This event will search the specific project

            //First, validate that there is some data entered inside the search text box

            string search = textBoxSearch.Text;

            if (String.IsNullOrEmpty(search))
            {
                MessageBox.Show("No input! Try again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                textBoxSearch.Focus();
                return;
            }
            else
            {
                //Search text box is not empty; call user-defined external method to do project search
                Display_Specific_Project(search);
            }
        }

        private void Display_Specific_Project(string str)
        {
            //=====================================================
            //Retrieve all the non-sensitive data in PROJECT table
            //by directly coding SQL statements in this application 
            //=====================================================

            //Step 1: CONNECTION OBJECT
            //=========================
            //Define a SQL Connection Object using my connection string stored in Singh Class library

            SqlConnection objMyConn;                                //create SQL connection variable
            objMyConn = new SqlConnection();                        //create new SQL connection object instance
            objMyConn.ConnectionString = Singh.myConnectionString;//assign my connection string to property

            //Step 2: SQL COMMAND OBJECT
            //==========================
            //Define a SQL Command object and set properties
            SqlCommand objMyCmd;                                    //create SQL command variable
            objMyCmd = new SqlCommand();                            //create command object
            objMyCmd.CommandType = CommandType.Text;               //assign command type that is SQL text

            String sqlQuery;     //string to store the required query



            //Formulate SQL query to be used "piece-by-piece" to avoid a long code line
            sqlQuery = "SELECT pro_number, pro_name, pro_location, pro_dept_number";
            sqlQuery += "   FROM project";
            sqlQuery += "  WHERE pro_number LIKE " + "'" + '%' + str + '%' + "' OR";
            sqlQuery += "  pro_name LIKE " + "'" + '%' + str + '%' + "' OR";
            sqlQuery += "  pro_location LIKE " + "'" + '%' + str + '%' + "'  OR";
            sqlQuery += "  pro_dept_number LIKE " + "'" + '%' + str + '%' + "';";

            objMyCmd.CommandText = sqlQuery;          //assign formulated SQL Query to Command object
            objMyCmd.Connection = objMyConn;          //assign connection obj to Connection property

            //Step 3: DATA ADAPTER
            //====================
            //Define a Data Adapter object and set its properties

            SqlDataAdapter objMyDataAdapter;                         //create a SqlDataAdapter variable
            objMyDataAdapter = new SqlDataAdapter();                 //create an object instance for SqlDataAdapter
            objMyDataAdapter.SelectCommand = objMyCmd;               //assign the command to run (i.e., SQL Statement)


            try
            {
                //Step 4: OPEN CONNECTION & RUN via the DataAdapter
                //=================================================
                //Open the connection to BPA-SQLServer first using connection object
                objMyConn.Open();

                //Next, create the Data Set object to fill the result set with 
                DataSet objMyDataSet = new DataSet();


                //Next, EXECUTE the SPROC using the FILL method of the Data Adapter
                //Fill the returned result data into the data set object
                //Give an arbitrary name like "EmpSpecificData" to the result set returned

                objMyDataAdapter.Fill(objMyDataSet, "EmpSpecificData");

                //Check if the Result Set returned is empty 
                if (objMyDataSet.Tables["EmpSpecificData"].Rows.Count == 0)
                {
                    //Record does not exist; display error message
                    richTextBoxError.Text = "*****Display Error - No Results Returned!*****";

                }
                else
                {
                    dataGridViewDisplaySpecificEmp.DataSource = objMyDataSet.Tables["EmpSpecificData"];

                }

            }

            catch (Exception ex)
            {
                richTextBoxError.Text = ex.Message;
            }

            finally
            {
                //Always close the connection here
                //If the connection is currently open, close it.
                //If it is already closed, do not bother to close it again here since it will give an error

                if (Singh.myConnectionString != null && objMyConn.State == ConnectionState.Open)
                {
                    objMyConn.Close();
                }

                else
                {
                    //It is already closed; do not do anything; end the function
                }

            }

        }  //Display_All_Projects ()

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clear all form controls
            //Clear the DataGridView of old data
            dataGridViewDisplaySpecificEmp.DataSource = null;
            dataGridViewDisplaySpecificEmp.Rows.Clear();

            //CLear the ERROR RichTextBoxform control
            richTextBoxError.Text = "";
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {//Returns to FormMainMenu

            //Hide the current form first
            this.Hide();

            //Display the other form from this form
            FormMainMenu formOther = new FormMainMenu();   //must create a new object instance of the another form first
            formOther.Show();    //then show the form
        }
    }
}
