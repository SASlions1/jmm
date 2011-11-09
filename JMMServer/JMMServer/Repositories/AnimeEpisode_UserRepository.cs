﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JMMServer.Entities;
using NHibernate.Criterion;
using BinaryNorthwest;


namespace JMMServer.Repositories
{
	public class AnimeEpisode_UserRepository
	{
		public void Save(AnimeEpisode_User obj)
		{
			using (var session = JMMService.SessionFactory.OpenSession())
			{
				// populate the database
				using (var transaction = session.BeginTransaction())
				{
					session.SaveOrUpdate(obj);
					transaction.Commit();
				}
			}
		}

		public AnimeEpisode_User GetByID(int id)
		{
			using (var session = JMMService.SessionFactory.OpenSession())
			{
				return session.Get<AnimeEpisode_User>(id);
			}
		}

		public List<AnimeEpisode_User> GetBySeriesID(int seriesid)
		{
			using (var session = JMMService.SessionFactory.OpenSession())
			{
				var eps = session
					.CreateCriteria(typeof(AnimeEpisode_User))
					.Add(Restrictions.Eq("AnimeSeriesID", seriesid))
					.List<AnimeEpisode_User>();

				return new List<AnimeEpisode_User>(eps);
			}
		}

		public AnimeEpisode_User GetByUserIDAndEpisodeID(int userid, int epid)
		{
			using (var session = JMMService.SessionFactory.OpenSession())
			{
				AnimeEpisode_User obj = session
					.CreateCriteria(typeof(AnimeEpisode_User))
					.Add(Restrictions.Eq("JMMUserID", userid))
					.Add(Restrictions.Eq("AnimeEpisodeID", epid))
					.UniqueResult<AnimeEpisode_User>();

				return obj;
			}
		}

		public List<AnimeEpisode_User> GetByUserID(int userid)
		{
			using (var session = JMMService.SessionFactory.OpenSession())
			{
				var eps = session
					.CreateCriteria(typeof(AnimeEpisode_User))
					.Add(Restrictions.Eq("JMMUserID", userid))
					.List<AnimeEpisode_User>();

				return new List<AnimeEpisode_User>(eps);
			}
		}

		public List<AnimeEpisode_User> GetByEpisodeID(int epid)
		{
			using (var session = JMMService.SessionFactory.OpenSession())
			{
				var eps = session
					.CreateCriteria(typeof(AnimeEpisode_User))
					.Add(Restrictions.Eq("AnimeEpisodeID", epid))
					.List<AnimeEpisode_User>();

				return new List<AnimeEpisode_User>(eps);
			}
		}

		public List<AnimeEpisode_User> GetByUserIDAndSeriesID(int userid, int seriesid)
		{
			using (var session = JMMService.SessionFactory.OpenSession())
			{
				var eps = session
					.CreateCriteria(typeof(AnimeEpisode_User))
					.Add(Restrictions.Eq("JMMUserID", userid))
					.Add(Restrictions.Eq("AnimeSeriesID", seriesid))
					.List<AnimeEpisode_User>();

				return new List<AnimeEpisode_User>(eps);
			}
		}

		public void Delete(int id)
		{
			using (var session = JMMService.SessionFactory.OpenSession())
			{
				// populate the database
				using (var transaction = session.BeginTransaction())
				{
					AnimeEpisode_User cr = GetByID(id);
					if (cr != null)
					{
						session.Delete(cr);
						transaction.Commit();
					}
				}
			}
		}
	}
}