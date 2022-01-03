using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Home1Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult Index()
        {

            
            LoginModel obj = new LoginModel();
            return Ok(obj);


        }


        [HttpPost]
        public ActionResult Index(LoginModel objuserlogin)
        {
           
            var display = Userloginvalues().Where(m => m.UserName == objuserlogin.UserName && m.UserPassword == objuserlogin.UserPassword).FirstOrDefault();
            if (display != null)
            {
                /*ViewBag.Status = "CORRECT UserNAme and Password";*/
                return Ok("correct");
            }
            else
            {
                /*ViewBag.Status = "INCORRECT UserName or Password";*/
                return Ok("incorrect");
            }
           /* return View(objuserlogin);*/
        }
        public List<LoginModel> Userloginvalues()
        {
            List<LoginModel> objModel = new List<LoginModel>();
            objModel.Add(new LoginModel { UserName = "user1", UserPassword = "password1" });
            objModel.Add(new LoginModel { UserName = "user2", UserPassword = "password2" });
            objModel.Add(new LoginModel { UserName = "user3", UserPassword = "password3" });
            objModel.Add(new LoginModel { UserName = "user4", UserPassword = "password4" });
            objModel.Add(new LoginModel { UserName = "user5", UserPassword = "password5" });
            return objModel;
        }

    }
}
