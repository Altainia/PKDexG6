﻿using PKDexG6.Domain.Entities;
using PKDexG6.Domain.Repos;

namespace PKDexG6.Data.EF.Repos
{
	public class PKGameRepo : EntityRepo<int, PKGame>, IPKGameRepo
	{
	}
}
