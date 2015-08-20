namespace PKDexG6.Domain.Entities
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public partial class PKLearnMethod : Entity<int>
	{
		public PKLearnMethod()
		{
			Moves = new HashSet<PKPkmnMove>();
		}

		[Required]
		[StringLength(50)]
		public string Label { get; set; }

		public virtual ICollection<PKPkmnMove> Moves { get; set; }
	}
}
