using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    public partial class frmAgents : Form
    {
        public frmAgents()
        {
            InitializeComponent();
        }

        private Agent agent;

        private void frmAgents_Load(object sender, EventArgs e)
        {
            // Connect to database and populate the list
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT * FROM Agents";
            
                /*AgentId AS ID, AgtFirstName AS NAME, AgtMiddleInitial AS Middle Initial, "
                + "AgtLastName AS Last Name, AgtBusPhone AS Phone, AgtEmail AS Email, AgtPosition, "
                + "AgencyId AS Agency ID, AgtPassword AS Password  "
                + "FROM Agents";*/

            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectStatement, connection); //c.con is the connection string
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            try
            {
                connection.Open();

                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dgvAgents.ReadOnly = true; 
                dgvAgents.DataSource = ds.Tables[0];
                var agentTable = new DataTable();
                dataAdapter.Fill(agentTable);
                dgvAgents.DataSource = agentTable;

                //Define the width for each column
                dgvAgents.Columns[0].Width = 60;
                dgvAgents.Columns[1].Width = 100;
                dgvAgents.Columns[2].Width = 60;
                dgvAgents.Columns[3].Width = 100;
                dgvAgents.Columns[4].Width = 150;
                dgvAgents.Columns[5].Width = 300;
                dgvAgents.Columns[6].Width = 100;
                dgvAgents.Columns[7].Width = 60;
                dgvAgents.Columns[8].Width = 100;     
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
