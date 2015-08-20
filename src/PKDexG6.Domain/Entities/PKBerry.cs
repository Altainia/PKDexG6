namespace PKDexG6.Domain.Entities
{
	public partial class PKBerry : Entity<int>
	{
		public int ItemID { get; set; }

		public int NaturalGiftTypeID { get; set; }

		public int NaturalGiftPower { get; set; }

		public int ColorID { get; set; }

		public int GrowthHoursXY { get; set; }

		public int GrowthHoursORAS { get; set; }

		public int MinYieldXY { get; set; }

		public int MinYieldORAS { get; set; }

		public int MaxYieldXY { get; set; }

		public int MaxYieldORAS { get; set; }

		public virtual PKColor Color { get; set; }

		public virtual PKItem Item { get; set; }

		public virtual PKType NaturalGiftType { get; set; }
	}
}
