﻿using Bookify.GuestRepositary;
using Bookify.Models;
using Bookify.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Bookify.Controllers
{
    public class GuestController : Controller
    {
        public IGuestRepo GuestRepo { get; }
        public GuestController(IGuestRepo guestRepo)
        {
            GuestRepo = guestRepo;
        }

       

        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> Index()
        {
            List<ApplicationUser> customers = await GuestRepo.GetAllCustomers();
            return View(customers);
        }
        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> Delete(string id)
        {
            await GuestRepo.removeUser(id);
            return View("Index");
        }
    }
}
