using Scheduler.ClassLibrary.Common;
using Scheduler.DataModel;
using Scheduler.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadControls();
        }

        private void LoadControls()
        {
            dtStartDate.Value = DateTime.Today;
            dtEndDate.Value = DateTime.Today.AddYears(1);

            LoadPartnerTypes();
            LoadRecurrenceFrequency();
        }

        private void LoadPartnerTypes()
        {
            List<ComboItem> comboItems = new List<ComboItem>();

            foreach (int initializer in Enum.GetValues(typeof(Enumerations.PartnerType)))
            {
                comboItems.Add(new ComboItem(initializer, Enum.GetName(typeof(Enumerations.PartnerType), initializer)));
            }

            if (comboItems.Count > 0)
            {
                ddlPartnerType.DataSource = comboItems;
                ddlPartnerType.DisplayMember = "Value";
                ddlPartnerType.ValueMember = "Id";
                ddlPartnerType.SelectedIndex = 0;
            }
        }

        private void LoadRecurrenceFrequency()
        {
            List<ComboItem> comboItems = new List<ComboItem>();

            foreach (int initializer in Enum.GetValues(typeof(Enumerations.RecurrenceFrequency)))
            {
                comboItems.Add(new ComboItem(initializer, Enum.GetName(typeof(Enumerations.RecurrenceFrequency), initializer)));
            }

            if (comboItems.Count > 0)
            {
                ddlRecurrence.DataSource = comboItems;
                ddlRecurrence.DisplayMember = "Value";
                ddlRecurrence.ValueMember = "Id";
                ddlRecurrence.SelectedIndex = 0;
            }
        }

        private void btnAddScheduler_Click(object sender, EventArgs e)
        {
            // Temporarily hard-coded
            TScheduler scheduler = new TScheduler();
            scheduler.Name = "schedulerTest1";
            scheduler.Description = "";
            scheduler.ActionType = 1;
            scheduler.TransactionType = 1;
            scheduler.PartnerType = 2;
            scheduler.PartnerId = 301;
            scheduler.CreationDate = DateTime.Now;
            scheduler.StartDate = DateTime.Now;
            scheduler.EndDate = DateTime.Now.AddYears(1);
            scheduler.RecurrenceFrequency = (int)Enumerations.RecurrenceFrequency.Daily;
            scheduler.Enabled = true;







        }



    }
}
