using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace VotacionesEstudiantiles.App.Pages
{
    public class VotanteModel : PageModel
    {
        private readonly ILogger<VotanteModel> _logger;

        public VotanteModel(ILogger<VotanteModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
