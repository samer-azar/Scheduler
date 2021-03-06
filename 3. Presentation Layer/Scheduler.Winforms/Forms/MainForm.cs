﻿using Newtonsoft.Json;
using Scheduler.BusinessLogicLibrary.Common;
using Scheduler.BusinessLogicLibrary.Model;
using Scheduler.LoggerLibrary.Common;
using Scheduler.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

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
            JobScheduler scheduler = new JobScheduler();
            scheduler.Name = "schedulerTest1";
            scheduler.Description = "";
            scheduler.ActionTye = 1;
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
            try
            {
                ManageSchedulerExecutions();
                ExecuteLogic();
            }
            catch (Exception ex)
            {
                Logger.Log(Logger.GetCurrentMethod(), ex.Message, ex.StackTrace);
                throw;
            }
        }

        private void ManageSchedulerExecutions()
        {
            // Declarations
            DateTime? dUpcomingExecution;
            SchedulerExecution execution;
            SchedulerLog executionLog;
            SchedulerSettings oSetting;
            List<JobScheduler> jobSchedulers;
            List<SchedulerExecution> schedulerExecutions;
            List<SchedulerLog> lastSchedulerExecutionLogs;

            // Get active schedulers with their corresponding settings
            jobSchedulers = SchedulerBlo.GetDetailedActiveSchedulers();

            if (jobSchedulers != null)
            {
                // Get all scheduler executions(in TSchedulerExecution)
                schedulerExecutions = SchedulerBlo.GetCurrentExecutions();

                // Get latest scheduler execution logs(in TSchedulerExecutionLog)
                lastSchedulerExecutionLogs = SchedulerBlo.GetLatestExecutionLogs();

                // Iterate through each scheduler
                foreach (JobScheduler jobScheduler in jobSchedulers)
                {
                    // Validate the scheduler end date
                    if (jobScheduler.EndDate != null && jobScheduler.EndDate < DateTime.Now)
                    {
                        // Diable scheduler when end date has expired
                        jobScheduler.Enabled = false;
                        SchedulerBlo.SetSchedulerState(jobScheduler);
                    }
                    else
                    {
                        // Iterate through each scheduler setting
                        foreach (SchedulerSettings setting in jobScheduler.Settings)
                        {
                            // Try to find an execution for this setting
                            execution = schedulerExecutions.Where(x => x.SchedulerSettingsId == setting.SchedulerSettingsId).FirstOrDefault();

                            // Find the latest execution log for this setting
                            executionLog = lastSchedulerExecutionLogs
                                            .Where(x => x.SchedulerSettingsId == setting.SchedulerSettingsId)
                                            .OrderByDescending(x => x.ExecutionTimeStamp)
                                            .FirstOrDefault();

                            // Assign setting to a new object in order to pass it as ref(since setting is a foreach iteration variable)
                            oSetting = setting;

                            // Get upcoming scheduler execution
                            int action = 0;
                            dUpcomingExecution = SchedulerBlo.GetUpcomingSchedulerExecution(jobScheduler.RecurrenceFrequency, ref execution,
                                                                                            executionLog.ExecutionTimeStamp, ref oSetting, ref action);

                            switch (action)
                            {
                                case (int)Enumerations.RecordActionStatus.Keep:
                                    break;

                                case (int)Enumerations.RecordActionStatus.Insert:
                                    execution = new SchedulerExecution(setting.SchedulerSettingsId, jobScheduler.SchedulerId, dUpcomingExecution, (int)Enumerations.ExecutionStatus.Scheduled);
                                    SchedulerBlo.CreateExecution(ref execution);
                                    break;

                                case (int)Enumerations.RecordActionStatus.Update:
                                    execution = new SchedulerExecution(execution.SchedulerExecutionId, jobScheduler.SchedulerId, setting.SchedulerSettingsId, dUpcomingExecution, (int)Enumerations.ExecutionStatus.Scheduled);
                                    SchedulerBlo.UpdateExecution(execution);
                                    break;

                                case (int)Enumerations.RecordActionStatus.Delete:
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private void ExecuteLogic()
        {
            // Declarations
            string sUrl;
            JobScheduler jobScheculer;
            HttpResponseMessage response;
            List<SchedulerExecution> schedulerExecutions;

            // Get all scheduler executions(in TSchedulerExecution)
            schedulerExecutions = SchedulerBlo.GetCurrentExecutions();

            foreach (SchedulerExecution schedulerExecution in schedulerExecutions)
            {
                // If the execution is scheduled(pending) and execution time has passed, run logic
                if (schedulerExecution.Status.Equals((int)Enumerations.ExecutionStatus.Scheduled)
                    && schedulerExecution.ExecutionTimeStamp < DateTime.Now)
                {
                    // Get the corresponding job scheduler
                    jobScheculer = SchedulerBlo.GetJobScheduler(schedulerExecution.SchedulerId);

                    using (var client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");
                        // Compose the URL
                        client.BaseAddress = new Uri(Helper.GetRegistryKeyValue(Constants._PioRegistryPath, Constants._PioServer));
                        // AccountPayablePath in Registry = api/AccountsPayable/PaymentOrders?payerId={0}&dateFrom={1}&dateTo={2}
                        sUrl = string.Format("{0}{1}",
                                        client.BaseAddress,
                                        string.Format(Helper.GetRegistryKeyValue(Constants._PioRegistryPath, Constants._Pio_AccountPayable),
                                                jobScheculer.PartnerId,
                                                "2018-04-01T00:00:00",
                                                "2018-04-03T00:00:00"));

                        response = client.GetAsync(sUrl).Result;
                        if (response.IsSuccessStatusCode)
                        {

                        }
                    }
                }



                // Take the XML file from the shared folder, send to PIO

                // Request from PIO the XML file and store it on the shared folder
                // File Name:       TATAPPO_<<PoNum>><<Date of File PreparationYYYYMMDD>>_<<incremental#>>.XML
                //              RES_TATAPPO_<<PoNum>><<Date of File PreparationYYYYMMDD>>_<<incremental#>>.XML


                /*
                switch (jobScheculer.PartnerType)
                        {
                            case (int)Enumerations.PartnerType.Bank:
                                break;
                            case (int)Enumerations.PartnerType.Payer:
                                break;
                            case (int)Enumerations.PartnerType.Sprovider:
                                break;
                            case (int)Enumerations.PartnerType.NApplicable:
                                break;
                            case (int)Enumerations.PartnerType.Distributor:
                                break;
                            case (int)Enumerations.PartnerType.Reinsurer:
                                break;
                            case (int)Enumerations.PartnerType.HealthProvider:
                                break;
                        }

                        switch (jobScheculer.ActionTye)
                        {
                            case (int)Enumerations.ActionType.Push:
                                // Push data from NC DBs to shared folder accessed by client via SFTP

                                break;

                            case (int)Enumerations.ActionType.Pull:
                                break;

                            case (int)Enumerations.ActionType.Inbound:
                                break;

                            case (int)Enumerations.ActionType.Outbound:
                                break;
                        }
                */

            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            string sUrl;
            HttpResponseMessage response;
            PaymentOrder_Response formattedResponse;
            PaymentOrders_Response finalResponse;
            List<List<PaymentOrder>> paymentOrders;

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");
                // Compose the URL
                client.BaseAddress = new Uri(Helper.GetRegistryKeyValue(Constants._PioRegistryPath, Constants._PioServer));
                // AccountPayablePath in Registry = api/AccountsPayable/PaymentOrders?payerId={0}&dateFrom={1}&dateTo={2}
                sUrl = string.Format("{0}{1}",
                                client.BaseAddress,
                                string.Format(Helper.GetRegistryKeyValue(Constants._PioRegistryPath, Constants._Pio_AccountPayable),
                                        301,
                                        "2018-04-01T00:00:00",
                                        "2018-04-03T00:00:00"));

                response = client.GetAsync(sUrl).Result;
                if (response.IsSuccessStatusCode)
                {
                    formattedResponse = JsonConvert.DeserializeObject<PaymentOrder_Response>(response.Content.ReadAsStringAsync().Result);
                    if (!formattedResponse.Message.GetType().Equals(typeof(string)))
                    {
                        formattedResponse = new PaymentOrder_Response(
                                                    formattedResponse.SuccessCode,
                                                    JsonConvert.DeserializeObject<List<List<PaymentOrder>>>(formattedResponse.Message.ToString()));
                        paymentOrders = (List<List<PaymentOrder>>)formattedResponse.Message;

                        foreach (List<PaymentOrder> paymentOrderList in paymentOrders)
                        {
                            finalResponse = new PaymentOrders_Response(formattedResponse.SuccessCode, paymentOrderList);
                            WriteXmlFile(finalResponse);
                        }

                    }
                }
            }
        }

        private void WriteXmlFile(PaymentOrders_Response formattedResponse)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(PaymentOrders_Response));
            string sXml, sXmlFilePath;
            XmlDocument xmlDocument = new XmlDocument();

            using (var stringWriter = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(stringWriter))
                {
                    xmlSerializer.Serialize(writer, formattedResponse);
                    sXml = stringWriter.ToString();

                    xmlDocument.LoadXml(sXml);
                    //C:\Users\samer.azar\Desktop\test\TATAPPO_{0}{1}_{2}.xml => TATAPPO_<<PONum>><<Date of File PreparationYYYYMMDD>>_<<incremental#>>.XML
                    sXmlFilePath = string.Format(
                                            Helper.GetRegistryKeyValue(Constants._PioRegistryPath,
                                                                        Constants._Pio_AccountPayable_SftpPath),
                                            formattedResponse.Message.Select(x => x.INVOICE_NUM).FirstOrDefault(),
                                            DateTime.Today.ToString("yyyyMMdd"),
                                            1);
                    if (!File.Exists(sXmlFilePath))
                        xmlDocument.Save(sXmlFilePath);

                }
            }
        }
    }
}
