using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetStage.Config
{
    public class NhibernateSession
    {
        public static ISession OpenSessionElearning()
        {
            var configuration = new Configuration();
            var configurationPath = HttpContext.Current.Server.MapPath(@"~\Config\Nhibernate\Nhibernate.cfg.xml");
            configuration.Configure(configurationPath);
            var MyAppConfigurationFile = HttpContext.Current.Server.MapPath(@"~\Config\Nhibernate\mapFile.hbm.xml");
            configuration.AddFile(MyAppConfigurationFile);
            ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
        public static ISession OpenSessionPortailDas()
        {
            var configuration = new Configuration();
            var configurationPath = HttpContext.Current.Server.MapPath(@"~\Config\Nhibernate\NhibernatePortailDas.cfg.xml");
            configuration.Configure(configurationPath);
            var MyAppConfigurationFile = HttpContext.Current.Server.MapPath(@"~\Config\Nhibernate\mapFilePortailDas.hbm.xml");
            configuration.AddFile(MyAppConfigurationFile);
            ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}