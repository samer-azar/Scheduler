
using System.ServiceProcess;
using System.Threading.Tasks;
using System.Timers;

namespace Scheduler.WindowsService
{
    public partial class Scheduler : ServiceBase
    {
        #region GLOBAL_VARIABLES

        public Timer _Timer;

        #endregion

        #region CONSTRUCTOR

        public Scheduler()
        {
            InitializeComponent();
        }

        #endregion

        #region EVENT_HANDLERS

        protected override void OnStart(string[] args)
        {
            InitializeQueryTimer(3000);
        }

        protected override void OnStop()
        {
        }

        private async void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            await Task.Run(() => ExecuteLogic());
        }

        #endregion

        #region FORM_METHODS

        private void InitializeQueryTimer(int MilliSeconds)
        {
            _Timer = new Timer();
            _Timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            _Timer.Interval = MilliSeconds;
            _Timer.Enabled = true;
        }

        private async void ExecuteLogic()
        {
            // Get scheduler settings
            //List<BusinessLogicLibrary.Model.Scheduler> jobSchedulerSettings = SchedulerBlo.GetDetailedActiveSchedulers();

        }

        #endregion

    }
}
