namespace PKDexG6.Domain.Entities
{
	public partial class PKPkmnEvolution : Entity<int>
	{
		public int PkmnFromID { get; set; }

		public int PkmnToID { get; set; }

		public int EvolveMethodID { get; set; }

		public int? MoveID { get; set; }

		public int? ItemID { get; set; }

		public int? LocationID { get; set; }

		public int? PkmnID { get; set; }

		public int? EvolveData { get; set; }

		public virtual PKEvolutionMethod Method { get; set; }

		public virtual PKItem ItemAsRequirement { get; set; }

		public virtual PKLocation LocationAsRequirement { get; set; }

		public virtual PKMove MoveAsRequirement { get; set; }

		public virtual PKPkmn PkmnFrom { get; set; }

		public virtual PKPkmn PkmnTo { get; set; }

		public virtual PKPkmn PkmnAsRequirement { get; set; }
	}
}
