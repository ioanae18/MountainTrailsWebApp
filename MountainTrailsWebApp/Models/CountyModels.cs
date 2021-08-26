using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MountainTrailsWebApp.Models
{
	public class CountyModels
	{
		[Key]
		public string IdCounty { get; set; }
		public string CountyName { get; set; }
		public string CountyAbv { get; set; }
		public string IdMountain { get; set; }
		public virtual List<MountainModels> Mountains { get; set; }
	}
}