namespace PKDexG6.Domain.Entities
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public partial class PKLocation : Entity<int>
	{
		public PKLocation()
		{
			Areas = new HashSet<PKArea>();
			Items = new HashSet<PKItemLocation>();
			EvolvesRequirement = new HashSet<PKPkmnEvolution>();
		}

		public int RegionID { get; set; }

		[Required]
		[StringLength(80)]
		public string Label { get; set; }

		public virtual ICollection<PKArea> Areas { get; set; }

		public virtual ICollection<PKItemLocation> Items { get; set; }

		public virtual PKRegion Region { get; set; }

		public virtual ICollection<PKPkmnEvolution> EvolvesRequirement { get; set; }
	}
}
