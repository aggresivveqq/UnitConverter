using Microsoft.AspNetCore.Mvc;
using UnitConverter.Models;
using UnitConverter.Services;

public class LengthController : Controller
{
    private readonly LengthConvertionService _lengthConvertionService;

    public LengthController()
    {
        _lengthConvertionService = new LengthConvertionService();
    }

    [HttpPost]
    public IActionResult ConvertLength(double value, LengthUnit from, LengthUnit to)
    {
        double result = _lengthConvertionService.ConvertLength(value, from, to);
        TempData["LengthResult"] = result.ToString(); 
        return RedirectToAction("Index", "Home");
    }
}
