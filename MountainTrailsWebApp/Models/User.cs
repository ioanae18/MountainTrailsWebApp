namespace MountainTrailsWebApp.Models
{
	public class User
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public bool isEmployee { get; set; }
		public Gender UserGender { get; set; }

		public enum Gender
		{
			Male,
			Female
		}
	}
}