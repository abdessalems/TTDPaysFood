using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class PaysController : ControllerBase
{
    private List<Pay> _payData = new List<Pay>
    {
        new Pay { Id = 1, Name = "Italy" },
        new Pay { Id = 2, Name = "Japan" },
        // Add other pays
    };

    private List<TraditionalFood> _foodData = new List<TraditionalFood>
    {
        new TraditionalFood { Id = 1, Name = "Pizza", PayId = 1 },
        new TraditionalFood { Id = 2, Name = "Pasta", PayId = 1 },
        new TraditionalFood { Id = 3, Name = "Sushi", PayId = 2 },
        new TraditionalFood { Id = 4, Name = "Tempura", PayId = 2 },
        // Add other real food data
    };

}
