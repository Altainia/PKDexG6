namespace PKDexG6.Domain.Entities
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public partial class PKItem : Entity<int>
	{
		public PKItem()
		{
			Berries = new HashSet<PKBerry>();
			Locations = new HashSet<PKItemLocation>();
			WildItem1 = new HashSet<PKPkmn>();
			WildItem2 = new HashSet<PKPkmn>();
			EvolvesRequirement = new HashSet<PKPkmnEvolution>();
			Machines = new HashSet<PKMachine>();
		}

		public int ItemTypeID { get; set; }

		[Required]
		[StringLength(50)]
		public string Name { get; set; }

		[Required]
		[StringLength(300)]
		public string FlavorText { get; set; }

		[Required]
		[StringLength(1600)]
		public string Details { get; set; }

		public int? SellPrice { get; set; }

		public int? FlingDamage { get; set; }

		public virtual ICollection<PKBerry> Berries { get; set; }

		public virtual ICollection<PKItemLocation> Locations { get; set; }

		public virtual PKItemType ItemType { get; set; }

		public virtual ICollection<PKPkmn> WildItem1 { get; set; }

		public virtual ICollection<PKPkmn> WildItem2 { get; set; }

		public virtual ICollection<PKPkmnEvolution> EvolvesRequirement { get; set; }

		public virtual ICollection<PKMachine> Machines { get; set; }
	}
}
