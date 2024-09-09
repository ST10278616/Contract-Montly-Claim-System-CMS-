using Contract_Montly_Claim_System__CMS_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace Contract_Montly_Claim_System__CMS_.Controllers
{
    public class ClaimsController : Controller
    {

        public IActionResult SubmitClaim()
        {
            return View();
        }

        public IActionResult TrackStatus()
        {
            return View();
        }

        public IActionResult UploadDocument()
        {
            return View();
        }

        public IActionResult VerifyClaim()
        {
            return View();
        }
    }
}