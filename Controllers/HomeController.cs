using ASPNETCORE_WEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Services;
using System.Diagnostics;

namespace ASPNETCORE_WEB.Controllers
{
    public class HomeController : Controller
    {

        // DI : 

        private readonly AtcgsaWithoutAspnetauthContext _atcgsaWithoutAspnetauthContext;
        private readonly ILogger<HomeController> _logger;

        private readonly ITransient _iTransientServic1;
        private readonly ITransient _iTransientServic2;

        private readonly IScoped _iIScopedServic1;
        private readonly IScoped _iIScopedServic2;


        private readonly ISingleton _iSingletonServic1;
        private readonly ISingleton _iSingletonServic2;

        // Constuctor dependancy
        public HomeController(ILogger<HomeController> logger, AtcgsaWithoutAspnetauthContext atcgsaWithoutAspnetauthContext, ITransient transientservice1, ITransient transientService2, IScoped iIScopedServic1, IScoped iIScopedServic2, ISingleton iSingletonServic1, ISingleton iSingletonServic2)
        {
            _logger = logger;
            _atcgsaWithoutAspnetauthContext = atcgsaWithoutAspnetauthContext;
            _iTransientServic1 = transientservice1;
            _iTransientServic2 = transientService2;

            _iIScopedServic1 = iIScopedServic1;
            _iIScopedServic2 = iIScopedServic2;

            _iSingletonServic1 = iSingletonServic1;
            _iSingletonServic2 = iSingletonServic2;

        }

        public IActionResult Index()
        {

            ViewBag.transient1 = _iTransientServic1.GetData().ToString();
            ViewBag.transient2 = _iTransientServic2.GetData().ToString();


            ViewBag.scoped1 = _iIScopedServic1.GetData().ToString();
            ViewBag.scoped2 = _iIScopedServic2.GetData().ToString();

            ViewBag.singleton1 = _iSingletonServic1.GetData().ToString();
            ViewBag.singleton2 = _iSingletonServic2.GetData().ToString();


            //var sql = "Insert into TblRole VALUES('HR')";
            //_atcgsaWithoutAspnetauthContext.Database.ExecuteSqlRaw("exec sp_table @roleid = {0}, @roleName", 1, "RoleName");

            //var getData = _atcgsaWithoutAspnetauthContext.TblRoles.FromSqlRaw("Select * from TblRole").ToList();

            ////var getData = _atcgsaWithoutAspnetauthContext.TblRoles.FromSqlRaw("exec sp_table").ToList();


            //using (var transation = _atcgsaWithoutAspnetauthContext.Database.BeginTransaction())
            //{
            //    try
            //    {
            //        TblUser tblUsers = new TblUser();
            //        tblUsers.UserName = "fds";
            //        tblUsers.Gender = 1;

            //        _atcgsaWithoutAspnetauthContext.TblUsers.Add(tblUsers);
            //        _atcgsaWithoutAspnetauthContext.SaveChanges();

            //        TblUser tblUsers1 = new TblUser();
            //        tblUsers1.UserName = "fdsfdsfs";
            //        tblUsers1.Gender = 2;

            //        _atcgsaWithoutAspnetauthContext.TblUsers.Add(tblUsers1);
            //        _atcgsaWithoutAspnetauthContext.SaveChanges();

            //        transation.Commit();
            //    }
            //    catch (Exception)
            //    {

            //        transation.Rollback();
            //    }


            //}

            //Eager loading

            //var getData = _atcgsaWithoutAspnetauthContext.TblUsers.Include(x => x.TblUserRoles).ToList(); // Every data ma mane TblUserRoles.


            //var getData11 = _atcgsaWithoutAspnetauthContext.TblUsers.Where(x => x.UserId == 1).FirstOrDefault();

            //// Lazy loading
            //_atcgsaWithoutAspnetauthContext.Entry(getData11).Collection(c => c.TblUserRoles).Load();


            //getData.UserName = "jigar12";

            //_atcgsaWithoutAspnetauthContext.SaveChanges();



            //TblUser tblUsers = new TblUser();
            //tblUsers.UserName = "fds";
            //tblUsers.Gender = 1;

            //_atcgsaWithoutAspnetauthContext.TblUsers.Add(tblUsers);

            //DisplayStates(_atcgsaWithoutAspnetauthContext.ChangeTracker.Entries());


            //var a = _atcgsaWithoutAspnetauthContext.TblUsers.ToList();



            return View();
        }

        static void DisplayStates(IEnumerable<EntityEntry> entries)
        {
            foreach (var entry in entries)
            {
                Console.WriteLine($"Entity: {entry.Entity.GetType().Name}, State: {entry.State.ToString()} ");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}