namespace PKDexG6.Domain.Entities
{
	public partial class PKPkmnMove : Entity<int>
	{
		public int PkmnID { get; set; }

		public int MoveID { get; set; }

		public int LearnMethodID { get; set; }

		public int? XYData { get; set; }

		public int? ORASData { get; set; }

		public virtual PKLearnMethod LearnMethod { get; set; }

		public virtual PKMove Move { get; set; }

		public virtual PKPkmn Pkmn { get; set; }
	}
}
