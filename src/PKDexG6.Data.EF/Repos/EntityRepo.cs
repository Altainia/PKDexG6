using PKDexG6.Domain.Entities;
using PKDexG6.Domain.Repos;
using System.Collections.Generic;
using System.Linq;

namespace PKDexG6.Data.EF.Repos
{
	public abstract class EntityRepo<TPrimaryKey, TEntity>
		: IEntityRepo<TPrimaryKey, TEntity> where TEntity
		: Entity<TPrimaryKey>
	{
		protected readonly PKDexContext m_context;

		public EntityRepo()
		{
			m_context = new PKDexContext();
		}

		public TEntity FindBy(TPrimaryKey ID)
		{
			return m_context.Set<TEntity>().Find(ID);
		}

		public void Add(TEntity entity)
		{
			m_context.Set<TEntity>().Add(entity);
			m_context.SaveChanges();
		}

		public void Update(TEntity entity)
		{
			m_context.Entry<TEntity>(entity).State = EntityState.Modified;
			m_context.SaveChanges();
		}

		public void Delete(TEntity entity)
		{
			m_context.Set<TEntity>().Remove(entity);
			m_context.SaveChanges();
		}

		public List<TEntity> List
		{
			get
			{
				return m_context.Set<TEntity>().ToList();
			}
		}
	}
}
