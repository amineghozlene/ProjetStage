using NHibernate;
using NHibernate.Linq;
using ProjetStage.Config;
using ProjetStage.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace ProjetStage.Controllers
{
    public class AccountController : Controller
    {
        ISession session = NhibernateSession.OpenSessionElearning();
        // GET: Account
        public ActionResult Index()
        {
            var personnes = session.Query<User>().ToList();
            foreach(User personne in personnes)
            {
                University u = personne.University;
                var univ = session.Get<University>(u.Id);
            }
            session.Close();
            return View(personnes);   
        }
        // Login
        public ActionResult Login()
        {
            session.Close();
            return View();
        }
        // la partie sécurité manquante
        [HttpPost]
        public ActionResult Login(User user)
        {
            var personne = session.Get<User>(user.Iduser);
            if (!personne.Password.Equals(user.Password)) { throw new NullReferenceException(); }
            Session["user"] = personne;
            Session.Timeout = 10;
            session.Save(personne);
            session.Close();
            return RedirectToAction("Index");
        }
        // Logout
        public ActionResult Logout()
        {
            session.Clear();
            session.Close();
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login");
        }
        // sign up
        public ActionResult SignUp()
        {
            return View();
        }
        // la partie vérification manquante
        [HttpPost]
        public ActionResult SignUp(User user)
        {
            ITransaction transaction = session.BeginTransaction();
            var univ = session.Get<University>(user.University.Id);
            user.University = univ;
            session.Save(user);
            transaction.Commit();
            return RedirectToAction("Login");
        }
        // Edit account
        public ActionResult Edit()
        {
            session.Close();
            return View();
        }
        // la partie vérification manquante
        [HttpPost]
        public ActionResult Edit(User user)
        {
            User UsertoUpdate = (User) Session["user"];
            if (user.FirstName != null)
                UsertoUpdate.FirstName = user.FirstName;
            if (user.LastName != null)
                UsertoUpdate.LastName = user.LastName;
            if (user.Age > 17)
                UsertoUpdate.Age = user.Age;
            if (user.Adress != null)
                UsertoUpdate.Adress = user.Adress;
            if (user.Email != null)
                UsertoUpdate.Email = user.Email;
            if (user.Iduser != null)
                UsertoUpdate.Iduser = user.Iduser;
            if (user.Password != null)
                UsertoUpdate.Password = user.Password;
            if (user.NumTel != null)
                UsertoUpdate.NumTel = user.NumTel;
            Session["user"] = UsertoUpdate;
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(UsertoUpdate);
                transaction.Commit();
            }
            session.Close();
            return RedirectToAction("Index");
        }
    }
}