namespace PKDexG6.Domain.Entities
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public partial class PKGame : Entity<int>
	{
		public PKGame()
		{
			PkmnLocations = new HashSet<PKPkmnLocation>();
		}

		[Required]
		[StringLength(20)]
		public string Label { get; set; }

		public virtual ICollection<PKPkmnLocation> PkmnLocations { get; set; }
	}
}
