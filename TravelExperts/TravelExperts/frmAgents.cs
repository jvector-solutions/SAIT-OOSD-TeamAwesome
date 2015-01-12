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
            fillDataTable();//fills table with current information
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAgentModify addAgentForm = new frmAgentModify();
            addAgentForm.addAgent = true;
            DialogResult result = addAgentForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                agent = addAgentForm.agent;
                txtAgentId.Text = agent.AgentId.ToString();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //Get agent from selection
            this.GetAgent(Convert.ToInt32(dgvAgents.SelectedRows[0].Cells[0].Value));

            frmAgentModify modifyAgentForm = new frmAgentModify();
            modifyAgentForm.addAgent = false;
            modifyAgentForm.agent = agent;
            
            DialogResult result = modifyAgentForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                agent = modifyAgentForm.agent;
                this.fillDataTable();
            }
            else if (result == DialogResult.Retry)
            {
                this.GetAgent(agent.AgentId);
                this.fillDataTable();
                /*
                if (agent != null)
                    this.fillDataTable();
                else
                    this.ClearControls();
                 * */
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
 
            DialogResult result =
                MessageBox.Show("Do you want to delete "
                + dgvAgents.SelectedRows[0].Cells[1].Value.ToString() + " "
                + dgvAgents.SelectedRows[0].Cells[3].Value.ToString() + "?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    //Get agent from selection
                    this.GetAgent(Convert.ToInt32(dgvAgents.SelectedRows[0].Cells[0].Value));

                    if (!AgentDB.DeleteAgent(agent))
                    {
                        MessageBox.Show("Another user has updated or deleted that agent", "Database Error");
                        this.GetAgent(agent.AgentId);

                        if (agent != null)
                            this.fillDataTable();///check this exception later//this.DisplayProduct();
                        else
                        { 
                            ReloadGridView();//reload gridView 
                        }
                    }
                    else
                    {
                        ReloadGridView();//reload gridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnGetAgent_Click(object sender, EventArgs e)
        {
            string searchMe = txtAgentId.Text;
            dgvAgents.DataSource = AgentDB.SearchAgents(searchMe);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Additional methods --------------------------------
        private void fillDataTable()
        {
            //Connect to database and populate the list
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT * FROM Agents";


            /*
             * "SELECT AgentId AS ID, AgtFirstName AS Name, AgtMiddleInitial AS [Middle Initial], "
                + "AgtLastName AS [Last Name], AgtBusPhone AS Phone, AgtEmail AS Email, AgtPosition AS Position, "
                + "AgencyId AS Agency ID "
                + "FROM Agents";
             */

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

                dgvAgents.Columns[0].Width = 60;//Define the width for each column
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
        } //Method to fill data table

        private void GetAgent(int agentId)
        {
            try
            {
                agent = AgentDB.GetAgent(agentId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void ReloadGridView()
        {
            foreach (DataGridViewRow item in dgvAgents.SelectedRows)
            { dgvAgents.Rows.RemoveAt(item.Index); }
        } //Reload the GridView after updates

    }
}