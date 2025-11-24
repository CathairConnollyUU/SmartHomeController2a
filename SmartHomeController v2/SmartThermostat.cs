using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeController
{
    public class SmartThermostat : SmartDevice
    {

        // Private fields
        private double currentTemperature;
        private double targetTemperature;

        // Public properties
        public double CurrentTemperature
        {
            get { return currentTemperature; }
            set { currentTemperature = value; }
        }

        public double TargetTemperature
        {
            get { return targetTemperature; }
            set { targetTemperature = value; }
        }

        public SmartThermostat(int deviceID, string deviceName, double thermostatCurrentTemperature, double thermostatTargetTemperature) : base(deviceID, deviceName)
        {
            this.CurrentTemperature = thermostatCurrentTemperature;
            this.TargetTemperature = thermostatTargetTemperature;

        }

        public override void GetStatus()
        {
            base.GetStatus();
            Console.WriteLine($"Current temperature: {CurrentTemperature}, Target Temperature: {TargetTemperature}");
        }

    }
}
