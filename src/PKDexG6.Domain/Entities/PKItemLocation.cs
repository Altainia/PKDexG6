namespace PKDexG6.Domain.Entities
{
	public partial class PKItemLocation : Entity<int>
	{
		public int LocationID { get; set; }

		public int ItemID { get; set; }

		public bool IsInShop { get; set; }

		public virtual PKItem Item { get; set; }

		public virtual PKLocation Location { get; set; }
	}
}
