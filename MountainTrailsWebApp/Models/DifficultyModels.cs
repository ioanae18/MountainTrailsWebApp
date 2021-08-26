using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MountainTrailsWebApp.Models
{
	public class DifficultyModels
	{
		[Key]
		public string IdDifficulty { get; set; }
		public string DifficultyName { get; set; }
		public string IdTrail { get; set; }
		public virtual List<TrailModels> Trails { get; set; }
	}
}