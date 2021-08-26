using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MountainTrailsWebApp.Models
{
	public class TrailModels
	{
		[Key]
		public string IdTrail { get; set; }
		public string TrailName { get; set; }
		public int Duration { get; set; }
		public int Distance { get; set; }
		public int Climb { get; set; }
		public int Descend { get; set; }
		public string IdSeason { get; set; }
		public virtual List<SeasonModels> Seasons { get; set; }
		public string IdDifficulty { get; set; }
		public virtual DifficultyModels Difficulty { get; set; }
		public string IdMarkings { get; set; }
		public virtual List<TrailModels> Markings { get; set; }
		public string IdMountain { get; set; }
		public virtual List<MountainModels> Mountains { get; set; }
	}
}