using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace VotacionesEstudiantiles.App.Pages
{
    public class AdministradorModel : PageModel
    {
        private readonly ILogger<AdministradorModel> _logger;

        public AdministradorModel(ILogger<AdministradorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
