namespace PKDexG6.Domain.Entities
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public partial class PKPkmn : Entity<int>
	{
		public PKPkmn()
		{
			EvolvesTo = new HashSet<PKPkmnEvolution>();
			EvolvesFrom = new HashSet<PKPkmnEvolution>();
			EvolvesRequirement = new HashSet<PKPkmnEvolution>();
			Locations = new HashSet<PKPkmnLocation>();
			Moves = new HashSet<PKPkmnMove>();
		}

		public int NatDex { get; set; }

		public int FormNo { get; set; }

		public int TypeID1 { get; set; }

		public int? TypeID2 { get; set; }

		public int AbilityID1 { get; set; }

		public int? AbilityID2 { get; set; }

		public int? AbilityID3 { get; set; }

		public int? EggGroupID1 { get; set; }

		public int? EggGroupID2 { get; set; }

		public int GrowthTypeID { get; set; }

		public int? ItemID1 { get; set; }

		public int? ItemID2 { get; set; }

		public int ItemChance1 { get; set; }

		public int ItemChance2 { get; set; }

		public int BAtk { get; set; }

		public int BDef { get; set; }

		public int BSat { get; set; }

		public int BSdf { get; set; }

		public int BSpe { get; set; }

		public int BHtp { get; set; }

		public int EVAtk { get; set; }

		public int EVDef { get; set; }

		public int EVSat { get; set; }

		public int EVSdf { get; set; }

		public int EVSpe { get; set; }

		public int EVHtp { get; set; }

		public int ExpYield { get; set; }

		public int EggSteps { get; set; }

		public int Happiness { get; set; }

		public decimal Height { get; set; }

		public decimal Weight { get; set; }

		[Required]
		[StringLength(50)]
		public string Classification { get; set; }

		[Required]
		[StringLength(50)]
		public string Name { get; set; }

		public decimal? MaleChance { get; set; }

		public int CaptureRate { get; set; }

		[Required]
		[StringLength(300)]
		public string DexX { get; set; }

		[Required]
		[StringLength(300)]
		public string DexY { get; set; }

		[Required]
		[StringLength(300)]
		public string DexOR { get; set; }

		[Required]
		[StringLength(300)]
		public string DexAS { get; set; }

		[StringLength(50)]
		public string FormName { get; set; }

		public virtual PKAbility Ability1 { get; set; }

		public virtual PKAbility Ability2 { get; set; }

		public virtual PKAbility Ability3 { get; set; }

		public virtual PKEggGroup EggGroup1 { get; set; }

		public virtual PKEggGroup EggGroup2 { get; set; }

		public virtual PKGrowthType GrowthType { get; set; }

		public virtual PKItem WildItem1 { get; set; }

		public virtual PKItem WildItem2 { get; set; }

		public virtual PKType Type1 { get; set; }

		public virtual PKType Type2 { get; set; }

		public virtual ICollection<PKPkmnEvolution> EvolvesTo { get; set; }

		public virtual ICollection<PKPkmnEvolution> EvolvesFrom { get; set; }

		public virtual ICollection<PKPkmnEvolution> EvolvesRequirement { get; set; }

		public virtual ICollection<PKPkmnLocation> Locations { get; set; }

		public virtual ICollection<PKPkmnMove> Moves { get; set; }
	}
}
