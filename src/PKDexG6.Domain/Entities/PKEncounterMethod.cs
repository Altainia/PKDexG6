namespace PKDexG6.Domain.Entities
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public partial class PKEncounterMethod : Entity<int>
	{
		public PKEncounterMethod()
		{
			PkmnLocations = new HashSet<PKPkmnLocation>();
		}

		[Required]
		[StringLength(50)]
		public string Label { get; set; }

		public virtual ICollection<PKPkmnLocation> PkmnLocations { get; set; }
	}
}
