using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventProducerBL;
using EventProducerBL.Communication;
using EventProducerBL.LoggingService;

namespace DetecorPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void _btn_fire_Click(object sender, EventArgs e)
        {
            var securityEvent = new SecurityEvent()
            {
                PhysicalLocation = "Upper Floor",
                DetectorId = 1,
                EventDescription = "Fire Fire !!!!",
                DetectorType = EnumsDedectorType.Fire
            };

            EventProducer.Instance().LogSecurityEvent(securityEvent);
        }


        private void _btn_motion_Click(object sender, EventArgs e)
        {
            var securityEvent = new SeveritySecurityEvent()
            {
                PhysicalLocation = "Yard",
                DetectorId = 12,
                EventDescription = "Suspicius character",
                DetectorType = EnumsDedectorType.Security,
                Severity = EnumsSeverity.High
            };

            EventProducer.Instance().LogSecurityEvent(securityEvent);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                Random random = new Random();
                List<SecurityEvent> list = new List<SecurityEvent>();

                for (int i = 0; i < 100000; i++)
                {
                    var securityEvent = new SecurityEvent()
                    {
                        PhysicalLocation = "Some Where " +i,
                        DetectorId = i,
                        EventDescription = "Help "+ i,
                        DetectorType = (EnumsDedectorType) random.Next(0,1),
                    };

                    list.Add(securityEvent);
                 //   Task task = new Task(() => EventProducer.Instance().LogSecurityEvent(securityEvent));
                 //    task.Start();


                }


                list.AsParallel().ForAll(se => EventProducer.Instance().LogSecurityEvent(se));

            });
        }



       
    }
}
