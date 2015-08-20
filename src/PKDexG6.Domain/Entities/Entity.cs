namespace PKDexG6.Domain.Entities
{
	public abstract class Entity<TPrimaryKey>
	{
		public TPrimaryKey ID { get; set; }
	}
}
