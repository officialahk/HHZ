using HHZ.Data;
using HHZ.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HHZ.Startup))]
namespace HHZ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
           // CreateRolesandUsers();

        }


        // In this method we will create default User roles and Admin user for login   
        //private void CreateRolesandUsers()
        //{
        //    ApplicationDbContext context = new ApplicationDbContext();
        //    
        //    var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
        //    var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
        //    
        //    
        //    // In Startup iam creating first Admin Role and creating a default Admin User    
        //        if (!roleManager.RoleExists("Admin"))
        //        {
        //    
        //             //first we create Admin rool   
        //            var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
        //            role.Name = "Admin";
        //            roleManager.Create(role);
        //    
        //    //        //Here we create a Admin super user who will maintain the website                  
        //    
        //            var user = new ApplicationUser();
        //            user.FirstName = "Nisar";
        //            user.LastName = "Ahmed";
        //            user.UserName = "Rao";
        //            user.Email = "M.Nisar@live.com";
        //            string userPWD = "123456789";
        //    
        //            var chkUser = userManager.Create(user, userPWD);
        //    
        //            //Add default User to Role Admin   
        //            if (chkUser.Succeeded)
        //            {
        //                var result1 = userManager.AddToRole(user.Id, "Admin");
        //    
        //            }
        //        }
        //    
        //        // creating Creating Manager role    
        //        if (!roleManager.RoleExists("Doctor"))
        //        {
        //            var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
        //            role.Name = "Doctor";
        //            roleManager.Create(role);
        //    
        //        }
        //    
        //        // creating Creating Employee role    
        //        if (!roleManager.RoleExists("Patient"))
        //        {
        //            var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
        //            role.Name = "Patient";
        //            roleManager.Create(role);
        //    
        //        }
        //    }
        }
}
