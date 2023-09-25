using Dentist.DTO;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Dentist.Services
{
    public class Account 
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;


        //private readonly IEmailSender _emailSender;

        public Account(UserManager<AppUser> _userManager, RoleManager<IdentityRole> _roleManager , SignInManager<AppUser> _signInManager)
        {
            this._userManager = _userManager;
            this._roleManager = _roleManager;
            this._signInManager = _signInManager;
            //this._emailSender = emailSender;
        }

        public async Task<List<AppUser>> getAllUsers()
        {
            List<AppUser> users = await _userManager.Users.ToListAsync();
            return users;
            
        }

        public async Task<bool> Registration(RegistrationDTO registrationDTO)
        {                
               AppUser user = new()
                {
                   firstName = registrationDTO.FirstName,
                   LastName = registrationDTO.LastName,
                   UserName = registrationDTO.UserName,
                   Email = registrationDTO.Email,
                   PhoneNumber = registrationDTO.PhoneNumber,
                   Address = registrationDTO.Address
                   
               };
                IdentityResult addUserResult = await _userManager.CreateAsync(user, registrationDTO.Password);
                IdentityResult addRoleToUserResult = await _userManager.AddToRoleAsync(user, "Patient");
       
                if (addUserResult.Succeeded && addRoleToUserResult.Succeeded)
                {
                    return true;
                }
                else return false;                       
        }


        public async Task<bool> Login(LoginDTO loginDTO)
        {
            try
            {
                AppUser? user = await _userManager.FindByEmailAsync(loginDTO.Email);
                if (user != null)
                {
                    await _signInManager.SignInAsync(user, loginDTO.presisted);

                    bool valid = await _userManager.CheckPasswordAsync(user, loginDTO.Password);
                    if (valid)
                    {


                        var claims = new List<Claim>();
                        claims.Add(new Claim(ClaimTypes.Name, user.UserName));
                        claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id));


                        //Get Role
                        var userRoles = await _userManager.GetRolesAsync(user);
                        foreach (var userRole in userRoles)
                        {
                            claims.Add(new Claim(ClaimTypes.Role, userRole));
                        }



                        return true;
                    }
                    else return false;
                }
                return false;

            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it)
                return false;
            }
            
        }

    }


}
