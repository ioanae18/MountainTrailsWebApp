using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MountainTrailsWebApp.Models
{
	public class MarkingModels
	{
		[Key]
		public string IdMarking { get; set; }
		public string MarkingState { get; set; }
		public string MarkingDetails { get; set; }
		public string IdTrail { get; set; }
		public virtual List<TrailModels> Trails { get; set; }
	}
}