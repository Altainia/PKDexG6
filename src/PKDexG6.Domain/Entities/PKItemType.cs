namespace PKDexG6.Domain.Entities
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public partial class PKItemType : Entity<int>
	{
		public PKItemType()
		{
			Items = new HashSet<PKItem>();
		}

		[Required]
		[StringLength(50)]
		public string Label { get; set; }

		public virtual ICollection<PKItem> Items { get; set; }
	}
}
