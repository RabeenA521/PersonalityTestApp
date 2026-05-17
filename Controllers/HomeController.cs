using Microsoft.AspNetCore.Mvc;

namespace PersonalityTestApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(string selectedImage)
        {
            string personality = selectedImage switch
            {
                "image1" => "🌿 Nature Lover — You are calm, peaceful, and love the outdoors. You value simplicity and find joy in natural beauty.",
                "image2" => "🏙️ City Explorer — You are ambitious, energetic, and love excitement. You thrive in fast-paced environments.",
                "image3" => "🌊 Free Spirit — You are creative, emotional, and go with the flow. You love freedom and new experiences.",
                "image4" => "⛰️ Adventurer — You are brave, determined, and love challenges. You always aim for the top.",
                "image5" => "🎨 Creative Soul — You are artistic, imaginative, and think outside the box.",
                "image6" => "📚 Deep Thinker — You are analytical, wise, and love learning new things.",
                _ => "Unknown personality"
            };

            ViewBag.Personality = personality;
            ViewBag.SelectedImage = selectedImage;
            return View();
        }
    }
}
