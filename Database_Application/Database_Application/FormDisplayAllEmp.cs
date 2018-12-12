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
    public partial class FormDisplayAllEmp : Form
    {
        public FormDisplayAllEmp()
        {
            InitializeComponent();
        }
        //******************************************************
        private void FormDisplayAllEmp_Load(object sender, EventArgs e)
        {
            //When the form loads, do some initial housekeeping

            //Clear the DataGridView of old data
            dataGridViewDisplayAllEmp.DataSource = null;
            dataGridViewDisplayAllEmp.Rows.Clear();

            //CLear the ERROR RichTextBoxform control located under the DataGridView
            richTextBoxError.Text = "";

            //Call user-defined external method to fill the DataGridView
            Display_All_Employees(); 
        }
        //*****************************************************
        private void Display_All_Employees()
        {
            //==============================================================
            //Retrieve all the non-sensitive data in EMPLOYEE table
            //by coding SQL statements directly in this application 
            //==============================================================

            //Step 1: CONNECTION OBJECT
            //=========================
            //Define a SQL Connection Object using my connection string stored in Singh Class library

            SqlConnection objMyConn;                                //create SQL connection variable
            objMyConn = new SqlConnection();                        //create new SQL connection object instance
            objMyConn.ConnectionString = Singh.myConnectionString;  //assign my connection string to property

            //Step 2: SQL COMMAND OBJECT
            //==========================
            //Define a SQL Command object and set properties
            SqlCommand objMyCmd;                                    //create SQL command variable
            objMyCmd = new SqlCommand();                            //create new command object
            objMyCmd.CommandType = CommandType.Text;               //assign command type that is an SQL text

            String sqlQuery;     //string to store the required SQL query

            //Formulate SQL query to be used "piece-by-piece" to avoid a long code line
            //AVOID displying employee sensitive information
            sqlQuery = "SELECT emp_ssn, emp_last_name, emp_first_name, emp_address,   ";
            sqlQuery += " emp_city, emp_state, emp_zip, emp_parking_space, emp_gender, emp_dpt_number, emp_superssn ";
            sqlQuery += "   FROM employee";


            objMyCmd.CommandText = sqlQuery;          //assign formulated SQL Query to Command object
            objMyCmd.Connection = objMyConn;          //assign connection obj to Connection property

            //Step 3: DATA ADAPTER
            //====================
            //Define a Data Adapter object and set its properties

            SqlDataAdapter objMyDataAdapter;                 //create a SqlDataAdapter variable
            objMyDataAdapter = new SqlDataAdapter();        //create an object instance for SqlDataAdapter
            objMyDataAdapter.SelectCommand = objMyCmd;     //assign the command (i.e., SQL Statement) to run stored in command obj


            try   //Now, we will open database and run SQL; error may occur
            {
                //Step 4: OPEN CONNECTION & RUN via the DataAdapter
                //=================================================
                //Open the connection to BPA-SQLServer first using connection object
                objMyConn.Open();

                //Next, create the Data Set object to fill it with the returned result from SQL Server
                DataSet objMyDataSet = new DataSet();


                //Next, EXECUTE the SQL query using the "FILL" method of the Data Adapter
                //Fill the returned result data into the data set object
                //Give an arbitrary name (any name) like "EmpAllData" to the result set returned

                objMyDataAdapter.Fill(objMyDataSet, "EmpAllData");

                //Check if the Result Set returned is empty 
                if (objMyDataSet.Tables["EmpAllData"].Rows.Count == 0)  //if there are no rows in result, it is indeed empty
                {
                    //Result set is empty; display error message in the error text box
                    richTextBoxError.Text = "*****Display Error - No Results Returned!*****";

                }
                else
                {
                    //Result is returned; assign result to to be displayed in DataGridView
                    dataGridViewDisplayAllEmp.DataSource = objMyDataSet.Tables["EmpAllData"];
               

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
                    //It is already closed; do not do anything; just move on
                }

            }

        }  //Display_All_Employees()

        //*******************************************************
        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clear all form controls
            //Clear the DataGridView of old data
            dataGridViewDisplayAllEmp.DataSource = null;
            dataGridViewDisplayAllEmp.Rows.Clear();

            //CLear the ERROR RichTextBoxform control
            richTextBoxError.Text = "";
        }
        //********************************************************
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            //Returns to FormMainMenu

            //Hide the current form first
            this.Hide();

            //Display the other form from this form
            FormMainMenu formOther = new FormMainMenu();   //must create a new object instance of the another form first
            formOther.Show();    //then show the form
        }
        
        //*******************************************************




    } //partial class
} //namespace
