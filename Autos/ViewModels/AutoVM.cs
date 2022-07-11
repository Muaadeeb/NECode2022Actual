using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
	// ReSharper disable once InconsistentNaming
	public class AutoVM
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Please enter a vehicle make (Ford, Chevy, Tesla, ...")]
		public string Make { get; set; } = null!;
		[Required(ErrorMessage = "Please enter a model (Explorer, F150, ...)")]
		public string Model { get; set; } = null!;

		[Range(1900, 2040, ErrorMessage = "Year ranges allowed 1900-2024)")]
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

		// TODO:
		//public double Price { get; set; }
		public double Price { get; set; }
	}
}
