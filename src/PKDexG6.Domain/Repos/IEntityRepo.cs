using PKDexG6.Domain.Entities;
using System.Collections.Generic;

namespace PKDexG6.Domain.Repos
{
	public interface IEntityRepo<TPrimaryKey, TEntity> where TEntity : Entity<TPrimaryKey>
	{
		TEntity FindBy(TPrimaryKey ID);

		void Add(TEntity entity);

		void Update(TEntity entity);

		void Delete(TEntity entity);

		List<TEntity> List { get; }
	}
}
