namespace PKDexG6.Domain.Entities
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public partial class PKArea : Entity<int>
	{
		public PKArea()
		{
			PkmnLocations = new HashSet<PKPkmnLocation>();
		}

		public int LocationID { get; set; }

		[StringLength(50)]
		public string Label { get; set; }

		public virtual PKLocation Location { get; set; }

		public virtual ICollection<PKPkmnLocation> PkmnLocations { get; set; }
	}
}
