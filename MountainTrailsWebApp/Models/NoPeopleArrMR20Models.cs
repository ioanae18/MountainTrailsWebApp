using System.ComponentModel.DataAnnotations;

namespace MountainTrailsWebApp.Models
{
	public class NoPeopleArrMR20Models
	{
		[Key]
		public string ArrivalId { get; set; }
		public int Hotels { get; set; }
		public int Hostels { get; set; }
		public int Motels { get; set; }
		public int Villas { get; set; }
		public int Cabins { get; set; }
		public int Campings { get; set; }
		public int Stops { get; set; }
		public int Pensions { get; set; }
		public int Village { get; set; }
		public int Stars { get; set; }
	}
}