using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace workshop01.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private Random _rnd;

        private readonly string[] quotes = {
            "Logic will get you from A to B. Imagination will take you everywhere",
            "There are 10 kinds of people. Those who know binary and those who don't.",
            "There are two ways of constructing a software design. One way is to make it so simple that there are obviously no deficiencies and the other is to make it so complicated that there are no obvious deficiencies.",
            "It's not that I'm so smart, it's just that I stay with problems longer.",
            "It is pitch dark. You are likely to be eaten by a grue."
        };

        public string Repo { get; private set; } = "https://github.com/CornCobs/cfdsa-precourse";

        public string RandomQuote() {
            return quotes[_rnd.Next(quotes.Length)];
        }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _rnd = new System.Random();
        }

        public void OnGet()
        {

        }
    }
}
