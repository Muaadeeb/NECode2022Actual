using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
	public class Auto
	{
		[Key] 
		public int Id { get; set; }

		public string Make { get; set; } = null!;
		public string Model { get; set; } = null!;
		public int Year { get; set; }
		public int Doors { get; set; }
		public bool IsAutomatic { get; set; } = true;
		public int IsElectric { get; set; }
		public int FuelEfficiencyCity { get; set; }
		public int FuelEfficiencyHwy { get; set; }
		public string ExteriorColor { get; set; } = null!;
		public string InteriorColor { get; set; } = null!;
		public string Engine { get; set; } = null!;
		public string DriveTrain { get; set; } = null!;
	}
}
