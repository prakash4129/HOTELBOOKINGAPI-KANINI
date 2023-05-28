﻿using Microsoft.AspNetCore.Mvc;
using HOTELBOOKINGAPI.Models;
using System.Threading.Tasks;

namespace HOTELBOOKINGAPI.Repository.users
{
    public interface IUser
    {
        public Task<User> PostUser(User user);
    }
}