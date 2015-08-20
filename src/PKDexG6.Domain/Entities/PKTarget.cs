namespace PKDexG6.Domain.Entities
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public partial class PKTarget : Entity<int>
	{
		public PKTarget()
		{
			Moves = new HashSet<PKMove>();
		}

		[Required]
		[StringLength(50)]
		public string Label { get; set; }

		public virtual ICollection<PKMove> Moves { get; set; }
	}
}
