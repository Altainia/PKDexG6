namespace PKDexG6.Domain.Entities
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public partial class PKRegion : Entity<int>
	{
		public PKRegion()
		{
			Locations = new HashSet<PKLocation>();
		}

		[Required]
		[StringLength(50)]
		public string Label { get; set; }

		public virtual ICollection<PKLocation> Locations { get; set; }
	}
}
