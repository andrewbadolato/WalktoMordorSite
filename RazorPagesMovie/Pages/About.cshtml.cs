﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WalktoMordor.Data;
using WalktoMordor.Models;

namespace WalktoMordor.Pages
{
    public class AboutModel : PageModel
    {
        public String Message;
 

        public void OnGet()
        {

            Message = "Your application description page.";

        }

    }

}