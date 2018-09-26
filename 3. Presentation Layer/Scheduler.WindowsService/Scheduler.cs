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


        public Scheduler()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            InitializeQueryTimer(3000);
        }

        protected override void OnStop()
        {
        }

        private void InitializeQueryTimer(int MilliSeconds)
        {
            _Timer = new Timer();
            _Timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            _Timer.Interval = MilliSeconds;
            _Timer.Enabled = true;
        }

        private async void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            await Task.Run(() => ExecuteLogic());
        }

        private async void ExecuteLogic()
        {
            // Include periodic logic here
        }


    }
}
