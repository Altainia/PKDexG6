namespace PKDexG6.Domain.Entities
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public partial class PKGrowthType : Entity<int>
	{
		public PKGrowthType()
		{
			Pkmn = new HashSet<PKPkmn>();
		}

		[Required]
		[StringLength(50)]
		public string Label { get; set; }

		public virtual ICollection<PKPkmn> Pkmn { get; set; }
	}
}
