using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartHomeController
{
    public class SmartSecurityCamera : SmartDevice
    {
        // Private fields
        private string resolution;
        private bool recordingStatus;

        // Public properties
        public string Resolution
        {
            get { return resolution; }
            set { resolution = value; }
        }


        // SmartSecurityCamera constructor
        public SmartSecurityCamera(int deviceID, string deviceName, string cameraResolution) : base(deviceID, deviceName)
        {
            this.Resolution = cameraResolution;
            recordingStatus = false; // Default recording status

        }

        public override void GetStatus()
        {
            base.GetStatus();
            Console.WriteLine("This is a smart security camera");
            Console.WriteLine($"Resolution: {Resolution}");
        }

    }
}
