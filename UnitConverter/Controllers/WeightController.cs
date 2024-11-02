using Microsoft.AspNetCore.Mvc;
using UnitConverter.Models;
using UnitConverter.Services;

public class WeightController : Controller
{
    private readonly WeightConversionService _weightConversionService;

    public WeightController()
    {
        _weightConversionService = new WeightConversionService();
    }

    [HttpPost]
    public IActionResult ConvertWeight(double value, WeightUnit from, WeightUnit to)
    {
        double result = _weightConversionService.ConvertWeight(value, from, to);
        TempData["WeightResult"] = result.ToString(); 
        return RedirectToAction("Index", "Home");
    }
}
