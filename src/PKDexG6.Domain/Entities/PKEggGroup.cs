namespace PKDexG6.Domain.Entities
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public partial class PKEggGroup : Entity<int>
	{
		public PKEggGroup()
		{
			Pkmn1 = new HashSet<PKPkmn>();
			Pkmn2 = new HashSet<PKPkmn>();
		}

		[Required]
		[StringLength(50)]
		public string Label { get; set; }

		[StringLength(1600)]
		public string Info { get; set; }

		public virtual ICollection<PKPkmn> Pkmn1 { get; set; }

		public virtual ICollection<PKPkmn> Pkmn2 { get; set; }
	}
}
