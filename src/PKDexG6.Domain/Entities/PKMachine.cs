namespace PKDexG6.Domain.Entities
{
	public partial class PKMachine : Entity<int>
	{
		public int ItemID { get; set; }

		public int MoveID { get; set; }

		public virtual PKItem Item { get; set; }

		public virtual PKMove Move { get; set; }
	}
}
