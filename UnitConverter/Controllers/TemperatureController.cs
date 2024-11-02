using Microsoft.AspNetCore.Mvc;
using UnitConverter.Models;
using UnitConverter.Services;

public class TemperatureController : Controller
{
    private readonly TempretureConversionService _temperatureConversionService;

    public TemperatureController()
    {
        _temperatureConversionService = new TempretureConversionService();
    }

    [HttpPost]
    public IActionResult ConvertTemperature(double value, TemperatureUnit from, TemperatureUnit to)
    {
        double result = _temperatureConversionService.ConvertTemperature(value, from, to);
        TempData["TemperatureResult"] = result.ToString(); 
        return RedirectToAction("Index", "Home");
    }
}
