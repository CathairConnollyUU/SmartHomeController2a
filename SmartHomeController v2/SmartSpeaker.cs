using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeController
{
    public class SmartSpeaker : SmartDevice
    {
        // Private fields
        private int volume;
        private bool isPlaying;

        // Public properties
        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public bool IsPlaying
        {
            get { return isPlaying; }
            set { isPlaying = value; }
        }

        public SmartSpeaker(int deviceID, string deviceName, int speakerVolume) : base(deviceID, deviceName)
        {
            this.Volume = speakerVolume;

        }

        public override void GetStatus()
        {
            base.GetStatus();
            Console.WriteLine("This is a smart speaker");
            Console.WriteLine($"Speaker Volume: {Volume}");
        }
    }
}
