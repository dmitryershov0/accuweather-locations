using NUnit.Framework;
using Accuweather.Locations;
using Accuweather.Core;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Accuweather.Core.Models;
using System.Net;

namespace Accuweather.Tests
{
	public class Locations
	{
		private ILocationsApi _api;

		[SetUp]
		public void Setup()
		{
			var apiKey = "YOUR_API_KEY";
			_api = new LocationsApi(apiKey, "ru-ru");
		}
		static object[] Offsets = {
			null,
			25
		};

		[Test, TestCaseSource("Offsets")]
		public async Task GetAreaList(int? offset)
		{
			var resultJson = await _api.GetAreaList("RU", offset);
			var result = JsonConvert.DeserializeObject<Response>(resultJson);
			Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);

		}
	}
}