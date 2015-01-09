using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    public partial class frmAgentModify : Form
    {
        public frmAgentModify()
        {
            InitializeComponent();
        }

        public Agent agent;
        public bool addAgent;

        //Additional methods
        private void DisplayAgent()
        {
            txtAgtFirstName.Text = agent.AgtFirstName;
            txtAgtMiddleInitial.Text = agent.AgtMiddleInitial;
            txtAgtLastName.Text = agent.AgtLastName;
            txtAgtBusPhone.Text = agent.AgtBusPhone;
            txtAgtEmail.Text = agent.AgtEmail;
            txtAgtPosition.Text = agent.AgtPosition;
            txtAgencyId.Text = agent.AgencyId;
            txtAgtPassword.Text = agent.AgtPassword;
        }

        private bool IsValidData()
        {
            return
                Validator.IsPresent(txtAgtFirstName) &&
                Validator.IsPresent(txtAgtMiddleInitial) &&
                Validator.IsPresent(txtAgtLastName) &&
                Validator.IsPresent(txtAgtBusPhone) &&
                Validator.IsPresent(txtAgtEmail) &&
                Validator.IsPresent(txtAgtPosition) &&
                Validator.IsPresent(txtAgencyId) &&
                Validator.IsPresent(txtAgtPassword);
        }

        private void PutAgentData(Agent agent)
        {
            agent.AgtFirstName = txtAgtFirstName.Text;
            agent.AgtMiddleInitial = txtAgtMiddleInitial.Text;
            agent.AgtLastName = txtAgtLastName.Text;
            agent.AgtBusPhone = txtAgtBusPhone.Text;
            agent.AgtEmail = txtAgtEmail.Text;
            agent.AgtPosition = txtAgtPosition.Text;
            agent.AgencyId = txtAgencyId.Text;
            agent.AgtPassword = txtAgtPassword.Text;
        }


        //Button Methods
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (addAgent)
                {
                    //Adding a new agent
                    agent = new Agent();
                    this.PutAgentData(agent);

                    try
                    {
                        agent.AgentId = AgentDB.AddAgent(agent);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else
                {
                    Agent newAgent = new Agent();
                    newAgent.AgentId = agent.AgentId;
                    this.PutAgentData(newAgent);
                    try
                    {
                        if (!AgentDB.UpdateAgent(agent, newAgent))
                        {
                            MessageBox.Show("Another user has updated or " +
                                "deleted that product.", "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
                            agent = newAgent;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgentModify_Load(object sender, EventArgs e)
        {
            if (addAgent)
            {
                this.Text = "Add Agent";
            }
            else
            {
                this.Text = "Modify Agent";
                this.DisplayAgent();
            }
        }

    }
}
