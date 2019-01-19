using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using MultiplicationServiceLibrary;
using System.ServiceModel;

namespace WindowsServiceHost
{
    public partial class MyWcfService : ServiceBase
    {
        private ServiceHost host = null;

        public MyWcfService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            host = new ServiceHost(typeof(SimpleMultiplicationService), new Uri("net.tcp://localhost:9001/MyService"));
            host.Open();
        }

        protected override void OnStop()
        {
            if (host != null)
            {
                host.Close();
            }

            host = null;
        }
    }
}
