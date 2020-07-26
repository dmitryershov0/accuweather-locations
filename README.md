# Accuweather Locations Api client

https://developer.accuweather.com/accuweather-locations-api/apis


## Download

Accuweather Locations Api client is available on [NuGet](https://www.nuget.org/packages/Accuweather.Locations/).


## Usage

```csharp
using Accuweather.Locations;


public class Startup
{

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<ILocationsApi>(l => new LocationApi("YOUR_API_KEY", "en-us");
    }
}

```
```csharp
using Accuweather.Locations;


public class SampleController : Controller
{
    private readonly ILocationsApi _locations;
    
    public void SampleController(ILocationsApi locations)
    {
        _locations = locations;
    }
    
    public async Tasnk<ActionResult> GetRegionList() 
    {
        var regionList = await _locations.GetRegionList();
        return Json(regionList , JsonRequestBehavior.AllowGet);
    }
}

```
