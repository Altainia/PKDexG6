namespace PKDexG6.Domain.Entities
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public partial class PKMove : Entity<int>
	{
		public PKMove()
		{
			EvolvesRequirements = new HashSet<PKPkmnEvolution>();
			Pkmn = new HashSet<PKPkmnMove>();
			Machines = new HashSet<PKMachine>();
		}

		public int TypeID { get; set; }

		public int CategoryID { get; set; }

		public int TargetID { get; set; }

		[Required]
		[StringLength(50)]
		public string Name { get; set; }

		[Required]
		[StringLength(200)]
		public string FlavorText { get; set; }

		[Required]
		[StringLength(800)]
		public string Details { get; set; }

		public int PowerPoints { get; set; }

		public int? Power { get; set; }

		public int? Accuracy { get; set; }

		public int Priority { get; set; }

		public virtual PKCategory Category { get; set; }

		public virtual PKTarget Target { get; set; }

		public virtual PKType Type { get; set; }

		public virtual ICollection<PKPkmnEvolution> EvolvesRequirements { get; set; }

		public virtual ICollection<PKPkmnMove> Pkmn { get; set; }

		public virtual ICollection<PKMachine> Machines { get; set; }
	}
}
