using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ViewOrder
{
	[Serializable]
	public class Vehicle
	{	
		public string FName { get; set; }
		public string LName { get; set; }
		public string DeliveryAddress { get; set; }
		public DateTime DeliveryDate { get; set; }
		public string VehicleName { get; set; }
		public string Engines { get; set; }
		public string InteriorColors { get; set; }
		public string ExteriorColors { get; set; }
		public string TrimLevel { get; set; }
		public List<string> Options = new List<string>();
		public decimal Cost { get; set; }
	}
}
