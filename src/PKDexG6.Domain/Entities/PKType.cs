namespace PKDexG6.Domain.Entities
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public partial class PKType : Entity<int>
	{
		public PKType()
		{
			Berries = new HashSet<PKBerry>();
			Moves = new HashSet<PKMove>();
			Pkmn1 = new HashSet<PKPkmn>();
			Pkmn2 = new HashSet<PKPkmn>();
		}

		[Required]
		[StringLength(16)]
		public string Label { get; set; }

		public virtual ICollection<PKBerry> Berries { get; set; }

		public virtual ICollection<PKMove> Moves { get; set; }

		public virtual ICollection<PKPkmn> Pkmn1 { get; set; }

		public virtual ICollection<PKPkmn> Pkmn2 { get; set; }
	}
}
