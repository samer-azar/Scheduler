using Scheduler.BusinessLogicLibrary.Common;
using Scheduler.BusinessLogicLibrary.Model;
using Scheduler.DataModel;
using Scheduler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class MainForm : Form
    {
        #region GLOBAL_VARIABLES

        List<HourListBoxItem> _ListBoxItems;

        #endregion

        #region CONSTRUCTORS

        public MainForm()
        {
            InitializeComponent();
            LoadControls();
        }

        #endregion

        #region METHODS

        private void LoadControls()
        {
            dtStartDate.Value = DateTime.Today;
            dtEndDate.Value = DateTime.Today.AddYears(1);
            _ListBoxItems = new List<HourListBoxItem>();

            LoadPartnerTypes();
            LoadRecurrenceFrequency();
        }

        private void RefreshListbox()
        {
            lbHours.DataSource = null;
            if (_ListBoxItems.Count > 0)
            {
                lbHours.DataSource = _ListBoxItems;
                lbHours.DisplayMember = "Value";
                lbHours.ValueMember = "Id";
            }
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

        #endregion

        #region EVENT_HANDLERS

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

        private void btnAddHour_Click(object sender, EventArgs e)
        {
            HourListBoxItem ListBoxItem = new HourListBoxItem(_ListBoxItems.Count, dpExecutionTime.Value.ToLongTimeString(), dpExecutionTime.Value);
            _ListBoxItems.Add(ListBoxItem);
            RefreshListbox();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (lbHours.Items.Count > 0)
            {
                HourListBoxItem selectedItem = (HourListBoxItem)lbHours.SelectedItem;
                _ListBoxItems.Remove(selectedItem);
                RefreshListbox();
            }
        }


        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            // Declarations
            SchedulerExecution execution;
            List<JobScheduler> jobSchedulerSettings;
            List<SchedulerExecution> schedulerExecutions;

            // Map settings to nearest execution
            jobSchedulerSettings = SchedulerBlo.GetDetailedActiveSchedulers();

            if (jobSchedulerSettings != null)
            {
                // Get all scheduler executions(in TSchedulerExecution)
                schedulerExecutions = SchedulerBlo.GetCurrentExecutions();

                // Iterate through each setting
                foreach (JobScheduler jobScheduler in jobSchedulerSettings)
                {
                    foreach (SchedulerSettings setting in jobScheduler.Settings)
                    {
                        // TODO: add the logics related to daily, weekly monthly... As for now logic runs everyday by specified hours
                        // Try to find an execution row for this setting
                        execution = schedulerExecutions.Where(x => x.SchedulerSettingsId == setting.SchedulerSettingsId).FirstOrDefault();
                        if (execution == null)
                        {
                            // If the setting does not have the nearest corresponding row in TPioSchedulerExecution, create it
                            execution = new SchedulerExecution(setting.SchedulerSettingsId,
                                                               SetUpcomingSchedulerExecution(setting.ExecutionTime, jobScheduler.RecurrenceFrequency),
                                                               (int)Enumerations.Status.Scheduled);
                            SchedulerBlo.CreateExecution(out execution);

                        }
                        // If the setting has a nearest corresponding row in TPIOSchedulerExecution, run logic
                    }
                }
            }
        }


        public DateTime SetUpcomingSchedulerExecution(DateTime dExecutionTime, int iRecurrenceFrequency)
        {
            switch (iRecurrenceFrequency)
            {
                case (int)Enumerations.RecurrenceFrequency.OneTime:
                    break;
                case (int)Enumerations.RecurrenceFrequency.ByHour:
                    break;
                case (int)Enumerations.RecurrenceFrequency.Hourly:
                    break;
                case (int)Enumerations.RecurrenceFrequency.Daily:
                    break;
                case (int)Enumerations.RecurrenceFrequency.Weekly:
                    break;
                case (int)Enumerations.RecurrenceFrequency.Monthly:
                    break;
                default:
                    break;
            }


            return null;
        }


    }
}
