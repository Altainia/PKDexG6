namespace PKDexG6.Domain.Entities
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public partial class PKColor : Entity<int>
	{
		public PKColor()
		{
			Berries = new HashSet<PKBerry>();
		}

		[Required]
		[StringLength(10)]
		public string Label { get; set; }

		public virtual ICollection<PKBerry> Berries { get; set; }
	}
}
