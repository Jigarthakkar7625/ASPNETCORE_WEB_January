using ASPNETCORE_WEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Diagnostics;

namespace ASPNETCORE_WEB.Controllers
{
    public class HomeController : Controller
    {

        private readonly AtcgsaWithoutAspnetauthContext _atcgsaWithoutAspnetauthContext;
        private readonly ILogger<HomeController> _logger;

        // Constuctor dependancy
        public HomeController(ILogger<HomeController> logger, AtcgsaWithoutAspnetauthContext atcgsaWithoutAspnetauthContext)
        {
            _logger = logger;
            _atcgsaWithoutAspnetauthContext = atcgsaWithoutAspnetauthContext;
        }

        public IActionResult Index()
        {


            var sql = "Insert into TblRole VALUES('HR')";
            _atcgsaWithoutAspnetauthContext.Database.ExecuteSqlRaw("exec sp_table @roleid = {0}, @roleName", 1, "RoleName");

            var getData = _atcgsaWithoutAspnetauthContext.TblRoles.FromSqlRaw("Select * from TblRole").ToList();

            var getData = _atcgsaWithoutAspnetauthContext.TblRoles.FromSqlRaw("exec sp_table").ToList();


            using (var transation = _atcgsaWithoutAspnetauthContext.Database.BeginTransaction())
            {
                try
                {
                    TblUser tblUsers = new TblUser();
                    tblUsers.UserName = "fds";
                    tblUsers.Gender = 1;

                    _atcgsaWithoutAspnetauthContext.TblUsers.Add(tblUsers);
                    _atcgsaWithoutAspnetauthContext.SaveChanges();

                    TblUser tblUsers1 = new TblUser();
                    tblUsers1.UserName = "fdsfdsfs";
                    tblUsers1.Gender = 2;

                    _atcgsaWithoutAspnetauthContext.TblUsers.Add(tblUsers1);
                    _atcgsaWithoutAspnetauthContext.SaveChanges();

                    transation.Commit();
                }
                catch (Exception)
                {

                    transation.Rollback();
                }


            }

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