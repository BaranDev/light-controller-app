using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using Xamarin.Forms;
using YeelightAPI.Models;

namespace YeelightAPI
{
   
    public class DeviceEqualityComparer : IEqualityComparer<Device>
    {
        public bool Equals(Device x, Device y)
        {
            // Compare Hostname and Port properties for equality
            return x.Hostname == y.Hostname && x.Port == y.Port;
        }

        public int GetHashCode(Device obj)
        {
            // Generate a hash code based on the Hostname and Port properties
            return obj.Hostname.GetHashCode() ^ obj.Port.GetHashCode();
        }
    }

    public class DeviceModelEqualityComparer : IEqualityComparer<DeviceModel>
    {
        public bool Equals(DeviceModel x, DeviceModel y)
        {
            if (ReferenceEquals(x, y))
                return true;

            if (ReferenceEquals(x, null) || ReferenceEquals(y, null))
                return false;

            // Compare the properties that define the uniqueness of DeviceModel objects
            return x.Hostname == y.Hostname && x.Port == y.Port && x.Id == y.Id;
        }

        public int GetHashCode(DeviceModel obj)
        {
            unchecked
            {
                int hashCode = obj.Hostname?.GetHashCode() ?? 0;
                hashCode = (hashCode * 397) ^ obj.Port;
                hashCode = (hashCode * 397) ^ (obj.Id?.GetHashCode() ?? 0);
                return hashCode;
            }
        }
    }


    public class StorageController
    {
        private string filePath;

        public StorageController(string filePath)
        {
            this.filePath = filePath;
        }

        // Summary:
        //     Saves the devices to the XML file.
        //
        public void SaveDevices(List<Device> devices)
        {
            // Clear duplicates in devices based on Hostname and Port
            devices = devices.Distinct(new DeviceEqualityComparer()).ToList();

            DeviceModel[] deviceModels = new DeviceModel[devices.Count];

            for (int i = 0; i < devices.Count; i++)
            {
                deviceModels[i] = ConvertToDeviceModel(devices[i]);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(DeviceModel[]));

            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fileStream, deviceModels);
            }
        }

        public List<DeviceModel> LoadDevices()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DeviceModel[]));

            if (!File.Exists(filePath))
            {
                return new List<DeviceModel>();
            }

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                DeviceModel[] deviceModels = (DeviceModel[])serializer.Deserialize(fileStream);

                HashSet<DeviceModel> uniqueDeviceModels = new HashSet<DeviceModel>(new DeviceModelEqualityComparer());

                foreach (DeviceModel deviceModel in deviceModels)
                {
                    uniqueDeviceModels.Add(deviceModel);
                }

                return uniqueDeviceModels.ToList();
            }
        }
    



    private DeviceModel ConvertToDeviceModel(Device device)
        {
            DeviceModel deviceModel = new DeviceModel
            {
                Hostname = device.Hostname,
                Port = device.Port,
                Id = device.Id,
                Name = device.Name
            };

            return deviceModel;
        }

        private Device ConvertToDevice(DeviceModel deviceModel)
        {
            Device device = new Device(deviceModel.Hostname,deviceModel.Port,false);
            device.SetName(deviceModel.Name);
            //device.Id = deviceModel.Id;
            return device;
        }
    }
}
