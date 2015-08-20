namespace PKDexG6.Domain.Entities
{
	public partial class PKPkmnLocation : Entity<int>
	{
		public int PkmnID { get; set; }

		public int AreaID { get; set; }

		public int GamesID { get; set; }

		public int EncounterMethodID { get; set; }

		public int MinLevel { get; set; }

		public int MaxLevel { get; set; }

		public int? Rarity { get; set; }

		public virtual PKArea Area { get; set; }

		public virtual PKEncounterMethod EncounterMethod { get; set; }

		public virtual PKGame Game { get; set; }

		public virtual PKPkmn Pkmn { get; set; }
	}
}
