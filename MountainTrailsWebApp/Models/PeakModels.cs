using System.ComponentModel.DataAnnotations;

namespace MountainTrailsWebApp.Models
{
	public class PeakModels
	{
		[Key]
		public string IdPeak { get; set; }
		public string PeakName { get; set; }
		public int Height { get; set; }
		public string IdMountain { get; set; }
		public virtual MountainModels Mountain { get; set; }
	}
}