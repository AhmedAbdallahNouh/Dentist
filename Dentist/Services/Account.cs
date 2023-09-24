using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dentist.Services
{
    public class Account
    {
        private readonly UserManager<IdentityUser> userManager;
        //private readonly IEmailSender _emailSender;

        public Account(UserManager<IdentityUser> userManager/*, IEmailSender emailSender*/)
        {
            this.userManager = userManager;
            //this._emailSender = emailSender;
        }

        public async Task<List<IdentityUser>> getAllUsers()
        {
            List<IdentityUser> users = await userManager.Users.ToListAsync();
            return users;
            
        }
    }
}
