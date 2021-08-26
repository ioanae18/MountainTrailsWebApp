using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MountainTrailsWebApp.Models
{
	public class SeasonModels
	{
		[Key]
		public string IdSeason { get; set; }
		public string SeasonName { get; set; }
		public string IdTrail { get; set; }
		public virtual List<TrailModels> Trails { get; set; }
	}
}