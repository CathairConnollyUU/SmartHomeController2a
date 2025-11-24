using Microsoft.VisualBasic;
using SmartHomeController;
using System.Net.NetworkInformation;

public class Program
{
    private static List<SmartDevice> devices = new List<SmartDevice>();
    public static void Main()
    {
        SmartLight kitchenLight = new SmartLight(1, "Kitchen Light", 20.5, "Blue");
        SmartThermostat bathroomThermostat = new SmartThermostat(2, "Bathroom Thermostat", 19, 25);
        SmartSpeaker livingRoomSpeaker = new SmartSpeaker(3, "Living room speaker", 20);
        SmartSecurityCamera frontDoorCamera = new SmartSecurityCamera(4, "Front Door Camera", "2k");

        devices.Add(kitchenLight);
        devices.Add(bathroomThermostat);
        devices.Add(livingRoomSpeaker);
        devices.Add(frontDoorCamera);

        ViewAllDevices();
    }

    
    public static void ViewAllDevices()
    {
        Console.WriteLine("List all devices");
        //SmartDevice device = null;
        foreach (var device in devices)
        {
            device.GetStatus();
        }
    }
}
