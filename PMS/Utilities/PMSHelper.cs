using Microsoft.AspNetCore.Http;
using PMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PMS.Utilities
{
    public class PMSHelper
    {
        ApplicationDbContext dbContext;

        public PMSHelper(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public string GetCurrentDate()
        {
            var longtimestr = DateTime.Now.ToString();
            return longtimestr.ToString();
        }
        public string GetCurrentUserId()
        {
            HttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            return httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
        public string GetUserName(string UserId)
        {
            return dbContext.Users.FirstOrDefault(x => x.Id == UserId).FullName;
        }
    }
}
