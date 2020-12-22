﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using Uplift.Models;

namespace Uplift.DataAccess.Data.Repository.IRepository
{
    public interface IUserRepository : IRepository<ApplicationUser>
    {
        void Lockuser(string userId);
        void UnLockuser(string userId);


    }
}
