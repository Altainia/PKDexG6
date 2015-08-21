namespace PKDexG6.Data
{
	using Microsoft.Data.Entity;
	using Domain.Entities;

	public partial class PKDexContext : DbContext
	{
		//public PKDexContext()
		//	: base("name=PKDexContext")
		//{
		//}

		public virtual DbSet<PKAbility> G6DexAbilities { get; set; }
		public virtual DbSet<PKArea> G6DexAreas { get; set; }
		public virtual DbSet<PKBerry> G6DexBerries { get; set; }
		public virtual DbSet<PKCategory> G6DexCategories { get; set; }
		public virtual DbSet<PKColor> G6DexColors { get; set; }
		public virtual DbSet<PKEggGroup> G6DexEggGroups { get; set; }
		public virtual DbSet<PKEncounterMethod> G6DexEncounterMethods { get; set; }
		public virtual DbSet<PKEvolutionMethod> G6DexEvolutionMethods { get; set; }
		public virtual DbSet<PKGame> G6DexGames { get; set; }
		public virtual DbSet<PKGrowthType> G6DexGrowthTypes { get; set; }
		public virtual DbSet<PKItemLocation> G6DexItemLocations { get; set; }
		public virtual DbSet<PKItem> G6DexItems { get; set; }
		public virtual DbSet<PKItemType> G6DexItemTypes { get; set; }
		public virtual DbSet<PKLearnMethod> G6DexLearnMethods { get; set; }
		public virtual DbSet<PKLocation> G6DexLocations { get; set; }
		public virtual DbSet<PKMove> G6DexMoves { get; set; }
		public virtual DbSet<PKPkmn> G6DexPkmn { get; set; }
		public virtual DbSet<PKPkmnEvolution> G6DexPkmnEvolutions { get; set; }
		public virtual DbSet<PKPkmnLocation> G6DexPkmnLocations { get; set; }
		public virtual DbSet<PKPkmnMove> G6DexPkmnMoves { get; set; }
		public virtual DbSet<PKRegion> G6DexRegions { get; set; }
		public virtual DbSet<PKTarget> G6DexTargets { get; set; }
		public virtual DbSet<PKMachine> G6DexMachines { get; set; }
		public virtual DbSet<PKType> G6DexTypes { get; set; }

		//protected override void OnModelCreating(ModelBuilder modelBuilder)
		//{
		//	#region Ability
		//	modelBuilder.Entity<PKAbility>(b =>
		//	{
		//		b.Table("G6DexAbilities");
		//		b.Collection(c => c.Pkmn1).InverseReference().ForeignKey(m => m.AbilityID1);
		//		b.Collection(c => c.Pkmn2).InverseReference().ForeignKey(m => m.AbilityID2);
		//		b.Collection(c => c.Pkmn3).InverseReference().ForeignKey(m => m.AbilityID3);
		//	});
		//	#endregion

		//	#region Area
		//	modelBuilder.Entity<PKArea>().ToTable("G6DexAreas");

		//	modelBuilder.Entity<PKArea>()
		//		.HasMany(e => e.PkmnLocations)
		//		.WithRequired(e => e.Area)
		//		.HasForeignKey(e => e.AreaID)
		//		.WillCascadeOnDelete(false);
		//	#endregion

		//	#region Berry
		//	modelBuilder.Entity<PKBerry>().ToTable("G6DexBerries");
		//	#endregion

		//	#region Category
		//	modelBuilder.Entity<PKCategory>().ToTable("G6DexCategories");

		//	modelBuilder.Entity<PKCategory>()
		//		.HasMany(e => e.Moves)
		//		.WithRequired(e => e.Category)
		//		.HasForeignKey(e => e.CategoryID)
		//		.WillCascadeOnDelete(false);
		//	#endregion

		//	#region Color
		//	modelBuilder.Entity<PKColor>().ToTable("G6DexColors");

		//	modelBuilder.Entity<PKColor>()
		//		.HasMany(e => e.Berries)
		//		.WithRequired(e => e.Color)
		//		.HasForeignKey(e => e.ColorID)
		//		.WillCascadeOnDelete(false);
		//	#endregion

		//	#region EggGroup
		//	modelBuilder.Entity<PKEggGroup>().ToTable("G6DexEggGroups");

		//	modelBuilder.Entity<PKEggGroup>()
		//		.HasMany(e => e.Pkmn1)
		//		.WithOptional(e => e.EggGroup1)
		//		.HasForeignKey(e => e.EggGroupID1);

		//	modelBuilder.Entity<PKEggGroup>()
		//		.HasMany(e => e.Pkmn2)
		//		.WithOptional(e => e.EggGroup2)
		//		.HasForeignKey(e => e.EggGroupID2);
		//	#endregion

		//	#region EncounterMethod
		//	modelBuilder.Entity<PKEncounterMethod>().ToTable("G6DexEncounterMethods");

		//	modelBuilder.Entity<PKEncounterMethod>()
		//		.HasMany(e => e.PkmnLocations)
		//		.WithRequired(e => e.EncounterMethod)
		//		.HasForeignKey(e => e.EncounterMethodID)
		//		.WillCascadeOnDelete(false);
		//	#endregion

		//	#region EvolutionMethod
		//	modelBuilder.Entity<PKEvolutionMethod>().ToTable("G6DexEvolutionMethods");

		//	modelBuilder.Entity<PKEvolutionMethod>()
		//		.HasMany(e => e.PkmnEvolutions)
		//		.WithRequired(e => e.Method)
		//		.HasForeignKey(e => e.EvolveMethodID)
		//		.WillCascadeOnDelete(false);
		//	#endregion

		//	#region Game
		//	modelBuilder.Entity<PKGame>().ToTable("G6DexGames");

		//	modelBuilder.Entity<PKGame>()
		//		.HasMany(e => e.PkmnLocations)
		//		.WithRequired(e => e.Game)
		//		.HasForeignKey(e => e.GamesID)
		//		.WillCascadeOnDelete(false);
		//	#endregion

		//	#region GrowthType
		//	modelBuilder.Entity<PKGrowthType>().ToTable("G6DexGrowthTypes");

		//	modelBuilder.Entity<PKGrowthType>()
		//		.HasMany(e => e.Pkmn)
		//		.WithRequired(e => e.GrowthType)
		//		.HasForeignKey(e => e.GrowthTypeID)
		//		.WillCascadeOnDelete(false);
		//	#endregion

		//	#region ItemLocation
		//	modelBuilder.Entity<PKItemLocation>().ToTable("G6DexItemLocations");
		//	#endregion

		//	#region Item
		//	modelBuilder.Entity<PKItem>().ToTable("G6DexItems");

		//	modelBuilder.Entity<PKItem>()
		//		.HasMany(e => e.Berries)
		//		.WithRequired(e => e.Item)
		//		.HasForeignKey(e => e.ItemID)
		//		.WillCascadeOnDelete(false);

		//	modelBuilder.Entity<PKItem>()
		//		.HasMany(e => e.Locations)
		//		.WithRequired(e => e.Item)
		//		.HasForeignKey(e => e.ItemID)
		//		.WillCascadeOnDelete(false);

		//	modelBuilder.Entity<PKItem>()
		//		.HasMany(e => e.WildItem1)
		//		.WithOptional(e => e.WildItem1)
		//		.HasForeignKey(e => e.ItemID1);

		//	modelBuilder.Entity<PKItem>()
		//		.HasMany(e => e.WildItem2)
		//		.WithOptional(e => e.WildItem2)
		//		.HasForeignKey(e => e.ItemID2);

		//	modelBuilder.Entity<PKItem>()
		//		.HasMany(e => e.EvolvesRequirement)
		//		.WithOptional(e => e.ItemAsRequirement)
		//		.HasForeignKey(e => e.ItemID);

		//	modelBuilder.Entity<PKItem>()
		//		.HasMany(e => e.Machines)
		//		.WithRequired(e => e.Item)
		//		.HasForeignKey(e => e.ItemID)
		//		.WillCascadeOnDelete(false);
		//	#endregion

		//	#region ItemType
		//	modelBuilder.Entity<PKItemType>().ToTable("G6DexItemTypes");

		//	modelBuilder.Entity<PKItemType>()
		//		.HasMany(e => e.Items)
		//		.WithRequired(e => e.ItemType)
		//		.HasForeignKey(e => e.ItemTypeID)
		//		.WillCascadeOnDelete(false);
		//	#endregion

		//	#region LearnMethod
		//	modelBuilder.Entity<PKLearnMethod>().ToTable("G6DexLearnMethods");

		//	modelBuilder.Entity<PKLearnMethod>()
		//		.HasMany(e => e.Moves)
		//		.WithRequired(e => e.LearnMethod)
		//		.HasForeignKey(e => e.LearnMethodID)
		//		.WillCascadeOnDelete(false);
		//	#endregion

		//	#region Location
		//	modelBuilder.Entity<PKLocation>().ToTable("G6DexLocations");

		//	modelBuilder.Entity<PKLocation>()
		//		.HasMany(e => e.Areas)
		//		.WithRequired(e => e.Location)
		//		.HasForeignKey(e => e.LocationID)
		//		.WillCascadeOnDelete(false);

		//	modelBuilder.Entity<PKLocation>()
		//		.HasMany(e => e.Items)
		//		.WithRequired(e => e.Location)
		//		.HasForeignKey(e => e.LocationID)
		//		.WillCascadeOnDelete(false);

		//	modelBuilder.Entity<PKLocation>()
		//		.HasMany(e => e.EvolvesRequirement)
		//		.WithOptional(e => e.LocationAsRequirement)
		//		.HasForeignKey(e => e.LocationID);
		//	#endregion

		//	#region Move
		//	modelBuilder.Entity<PKMove>().ToTable("G6DexMoves");

		//	modelBuilder.Entity<PKMove>()
		//		.HasMany(e => e.EvolvesRequirements)
		//		.WithOptional(e => e.MoveAsRequirement)
		//		.HasForeignKey(e => e.MoveID);

		//	modelBuilder.Entity<PKMove>()
		//		.HasMany(e => e.Pkmn)
		//		.WithRequired(e => e.Move)
		//		.HasForeignKey(e => e.MoveID)
		//		.WillCascadeOnDelete(false);

		//	modelBuilder.Entity<PKMove>()
		//		.HasMany(e => e.Machines)
		//		.WithRequired(e => e.Move)
		//		.HasForeignKey(e => e.MoveID)
		//		.WillCascadeOnDelete(false);
		//	#endregion

		//	#region Pkmn
		//	modelBuilder.Entity<PKPkmn>().ToTable("G6DexPkmn");

		//	modelBuilder.Entity<PKPkmn>()
		//		.Property(e => e.Height)
		//		.HasPrecision(6, 2);

		//	modelBuilder.Entity<PKPkmn>()
		//		.Property(e => e.Weight)
		//		.HasPrecision(6, 2);

		//	modelBuilder.Entity<PKPkmn>()
		//		.Property(e => e.MaleChance)
		//		.HasPrecision(6, 2);

		//	modelBuilder.Entity<PKPkmn>()
		//		.HasMany(e => e.EvolvesTo)
		//		.WithRequired(e => e.PkmnFrom)
		//		.HasForeignKey(e => e.PkmnFromID)
		//		.WillCascadeOnDelete(false);

		//	modelBuilder.Entity<PKPkmn>()
		//		.HasMany(e => e.EvolvesFrom)
		//		.WithRequired(e => e.PkmnTo)
		//		.HasForeignKey(e => e.PkmnToID)
		//		.WillCascadeOnDelete(false);

		//	modelBuilder.Entity<PKPkmn>()
		//		.HasMany(e => e.EvolvesRequirement)
		//		.WithOptional(e => e.PkmnAsRequirement)
		//		.HasForeignKey(e => e.PkmnID);

		//	modelBuilder.Entity<PKPkmn>()
		//		.HasMany(e => e.Locations)
		//		.WithRequired(e => e.Pkmn)
		//		.HasForeignKey(e => e.PkmnID)
		//		.WillCascadeOnDelete(false);

		//	modelBuilder.Entity<PKPkmn>()
		//		.HasMany(e => e.Moves)
		//		.WithRequired(e => e.Pkmn)
		//		.HasForeignKey(e => e.PkmnID)
		//		.WillCascadeOnDelete(false);
		//	#endregion

		//	#region PkmnEvolution
		//	modelBuilder.Entity<PKPkmnEvolution>().ToTable("G6DexPkmnEvolutions");
		//	#endregion

		//	#region PkmnLocation
		//	modelBuilder.Entity<PKPkmnLocation>().ToTable("G6DexPkmnLocations");
		//	#endregion

		//	#region PkmnMove
		//	modelBuilder.Entity<PKPkmnMove>().ToTable("G6DexPkmnMoves");
		//	#endregion

		//	#region Region
		//	modelBuilder.Entity<PKRegion>().ToTable("G6DexRegions");

		//	modelBuilder.Entity<PKRegion>()
		//		.HasMany(e => e.Locations)
		//		.WithRequired(e => e.Region)
		//		.HasForeignKey(e => e.RegionID)
		//		.WillCascadeOnDelete(false);
		//	#endregion

		//	#region Target
		//	modelBuilder.Entity<PKTarget>().ToTable("G6DexTargets");

		//	modelBuilder.Entity<PKTarget>()
		//		.HasMany(e => e.Moves)
		//		.WithRequired(e => e.Target)
		//		.HasForeignKey(e => e.TargetID)
		//		.WillCascadeOnDelete(false);
		//	#endregion

		//	#region Machine
		//	modelBuilder.Entity<PKMachine>().ToTable("G6DexMachines");
		//	#endregion

		//	#region Type
		//	modelBuilder.Entity<PKType>().ToTable("G6DexTypes");

		//	modelBuilder.Entity<PKType>()
		//		.HasMany(e => e.Berries)
		//		.WithRequired(e => e.NaturalGiftType)
		//		.HasForeignKey(e => e.NaturalGiftTypeID)
		//		.WillCascadeOnDelete(false);

		//	modelBuilder.Entity<PKType>()
		//		.HasMany(e => e.Moves)
		//		.WithRequired(e => e.Type)
		//		.HasForeignKey(e => e.TypeID)
		//		.WillCascadeOnDelete(false);

		//	modelBuilder.Entity<PKType>()
		//		.HasMany(e => e.Pkmn1)
		//		.WithRequired(e => e.Type1)
		//		.HasForeignKey(e => e.TypeID1)
		//		.WillCascadeOnDelete(false);

		//	modelBuilder.Entity<PKType>()
		//		.HasMany(e => e.Pkmn2)
		//		.WithOptional(e => e.Type2)
		//		.HasForeignKey(e => e.TypeID2);
		//	#endregion
		//}
	}
}
