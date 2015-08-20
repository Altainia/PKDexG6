namespace PKDexG6.Domain.Entities
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public partial class PKEvolutionMethod : Entity<int>
	{
		public PKEvolutionMethod()
		{
			PkmnEvolutions = new HashSet<PKPkmnEvolution>();
		}

		[Required]
		[StringLength(50)]
		public string Label { get; set; }

		public virtual ICollection<PKPkmnEvolution> PkmnEvolutions { get; set; }
	}
}
