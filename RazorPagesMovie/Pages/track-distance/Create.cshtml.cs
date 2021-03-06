using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WalktoMordor.Data;
using WalktoMordor.Models;

namespace WalktoMordor.Pages.track_distance
{
    public class CreateModel : PageModel
    {
        private readonly WalktoMordor.Models.TrackerContext _context;

        public CreateModel(WalktoMordor.Models.TrackerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {

            Tracker = new Tracker
            {
                Date = (DateTime.Today),
            };

            return Page();
        }

        [BindProperty]
        public Tracker Tracker { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ClaimsPrincipal currentUser = this.User;
            var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;

            Tracker.OwnerID = currentUserID;


            _context.Tracker.Add(Tracker);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}