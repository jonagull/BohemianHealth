using System;
using System.ComponentModel.DataAnnotations;

namespace BohemianHealth.Models
{
	public class DailyStatusLog
	{
		public int ID { get; set; }

		[DataType(DataType.Date)] // A [DataType] attribute that specifies the type of data in the Date property. With this attribute: The user isn't required to enter time information in the date field, Only the date is displayed, not time information.
		public DateTime? Date { get; set; }
		public float Weight { get; set; }
		public int OxygenSaturation { get; set; }
		public int Sleep { get; set; }
		public string? Mood { get; set; }
		public string? Description { get; set; }
	}
}

