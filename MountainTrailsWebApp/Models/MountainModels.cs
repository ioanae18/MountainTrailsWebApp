using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MountainTrailsWebApp.Models
{
	public class MountainModels
	{
		[Key]
		public string IdMountain { get; set; }
		public string MountainName { get; set; }
		public string Group { get; set; }
		public string Division { get; set; }
		public string IdCounty { get; set; }
		public virtual List<CountyModels> Counties{ get; set; }
		public string IdTrail { get; set; }
		public virtual List<TrailModels> Trails { get; set; }
		public string IdPeak { get; set; }
		public virtual List<PeakModels> Peaks { get; set; }
	}
}