﻿using System;
using System.Reflection;
using NHibernate;
using Streamus.Backend.Domain;
using Streamus.Backend.Domain.Interfaces;
using log4net;

namespace Streamus.Backend.Dao
{
    public class UserDao : AbstractNHibernateDao<User>, IUserDao
    {
        private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public User Get(Guid id)
        {
            User user;

            try
            {
                user = (User)NHibernateSession.Load(typeof(User), id);
            }
            catch (ObjectNotFoundException exception)
            {
                Logger.Error(exception);
                throw;
            }

            return user;
        }
    }
}