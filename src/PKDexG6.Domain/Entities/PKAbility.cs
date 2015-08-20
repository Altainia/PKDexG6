namespace PKDexG6.Domain.Entities
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public partial class PKAbility : Entity<int>
	{
		public PKAbility()
		{
			Pkmn1 = new HashSet<PKPkmn>();
			Pkmn2 = new HashSet<PKPkmn>();
			Pkmn3 = new HashSet<PKPkmn>();
		}

		[Required]
		[StringLength(50)]
		public string Name { get; set; }

		[Required]
		[StringLength(1600)]
		public string Description { get; set; }

		[Required]
		[StringLength(200)]
		public string FlavorText { get; set; }

		public virtual ICollection<PKPkmn> Pkmn1 { get; set; }

		public virtual ICollection<PKPkmn> Pkmn2 { get; set; }

		public virtual ICollection<PKPkmn> Pkmn3 { get; set; }
	}
}
