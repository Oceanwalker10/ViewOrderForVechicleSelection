using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
namespace ViewOrder
{
	public class Control
	{
		// store data from the xml
		public static List<Vehicle> vehicleList = new List<Vehicle>();

		public static void ReadVehicles(string filename)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Vehicle[]));
			FileStream fs = new FileStream(filename, FileMode.Open);
			Vehicle[] vehicle;
			vehicle = (Vehicle[])serializer.Deserialize(fs);
			vehicleList.AddRange(vehicle);
		}
	}
}
