using System.Globalization;
using System.Threading.Tasks;
using Accuweather.Core;
using Accuweather.Core.Helpers;
using Accuweather.Locations.Enums;

namespace Accuweather.Locations
{
	public class LocationsApi : AccuweatherApiCore, ILocationsApi
	{
		#region Pivate

		private const string _url = "http://dataservice.accuweather.com/locations/v1";
		private object GetLanguageObject
		{
			get
			{
				return new { language = _language };
			}
		}
		private object GetLanguageDetailsObject(bool details)
		{

			return new { language = _language, details };
		}

		#endregion

		#region Public
		public LocationsApi(string apiKey, string language = "") : base(apiKey, language)
		{
		}

		#region List

		public async Task<string> GetAreaList(string areaCode, int? offset = null)
		{
			var obj = new
			{
				language = _language,
				offset
			};
			var url = $"{_url}/adminareas/{areaCode}?apikey={_apiKey}&";
			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}

		public async Task<string> GetCountryList(string countryCode)
		{
			var url = $"{_url}/countries/{countryCode}?apikey={_apiKey}&";
			return await SendGetRequest(UrlEncodeHelper.UrlEncode(GetLanguageObject, url));
		}

		public async Task<string> GetRegionList()
		{
			var url = $"{_url}/regions?apikey={_apiKey}&";
			return await SendGetRequest(UrlEncodeHelper.UrlEncode(GetLanguageObject, url));
		}

		public async Task<string> GetTopCitiesList(int group, bool details = false)
		{
			var url = $"{_url}/topcities/{group}?apikey={_apiKey}&";
			return await SendGetRequest(UrlEncodeHelper.UrlEncode(GetLanguageDetailsObject(details), url));
		}


		#endregion List

		#region  AutoComplete

		public async Task<string> AutoCompleteSearch(string searchText)
		{
			var obj = new
			{
				q = searchText,
				language = _language
			};
			var url = $"{_url}/cities/autocomplete?apikey={_apiKey}&";
			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}

		#endregion  AutoComplete

		#region Location Key

		public async Task<string> SearchByLocationKey(string locationKey, bool details = false)
		{
			var url = $"{_url}/{locationKey}?apikey={_apiKey}&";
			return await SendGetRequest(UrlEncodeHelper.UrlEncode(GetLanguageDetailsObject(details), url));
		}

		public async Task<string> GetCityNeighbors(string locationKey, bool details = false)
		{
			var url = $"{_url}/cities/neighbors/{locationKey}?apikey={_apiKey}&";
			return await SendGetRequest(UrlEncodeHelper.UrlEncode(GetLanguageDetailsObject(details), url));
		}

		#endregion Location Key

		#region  TextSearch

		#region CitySearch

		public async Task<string> CitySearch(string searchText, bool details = false,
			int? offset = null, string alias = null)
		{
			var obj = new
			{
				q = searchText,
				language = _language,
				details,
				offset,
				alias
			};
			var url = $"{_url}/cities/search?apikey={_apiKey}&";
			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}

		public async Task<string> CitySearch(string countryCode, string adminCode,
			string searchText, bool details = false, int? offset = null, string alias = null)
		{
			var obj = new
			{
				q = searchText,
				language = _language,
				details,
				offset,
				alias
			};
			var url = $"{_url}/countries/{countryCode}/{adminCode}/search?apikey={_apiKey}&";
			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}

		public async Task<string> CitySearch(string countryCode, string searchText, bool details = false,
			int? offset = null, string alias = null)
		{
			var obj = new
			{
				q = searchText,
				language = _language,
				details,
				offset,
				alias
			};
			var url = $"{_url}/cities/{countryCode}/search?apikey={_apiKey}&";
			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}

		#endregion CitySearch

		#region POI Search
		public async Task<string> PointsOfInterestSearch(string searchText, POI? type = null, bool details = false)
		{
			var obj = new
			{
				q = searchText,
				language = _language,
				type = (int?)type.Value,
				details
			};
			var url = $"{_url}/poi/search?apikey={_apiKey}&";
			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}

		public async Task<string> PointsOfInterestSearch(string countryCode, string adminCode,
			string searchText, POI? type = null, bool details = false)
		{
			var obj = new
			{
				q = searchText,
				language = _language,
				type = (int?)type.Value,
				details
			};
			var url = $"{_url}/poi/{countryCode}/{adminCode}/search?apikey={_apiKey}&";
			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}

		public async Task<string> PointsOfInterestSearch(string countryCode, string searchText,
			POI? type = null, bool details = false)
		{
			var obj = new
			{
				q = searchText,
				language = _language,
				type = (int?)type.Value,
				details
			};
			var url = $"{_url}/poi/{countryCode}/search?apikey={_apiKey}&";
			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}

		#endregion POI Search

		#region Postal Code Search

		public async Task<string> PostalCodeSearch(string searchText, bool details = false)
		{
			var obj = new
			{
				q = searchText,
				language = _language,
				details
			};
			var url = $"{_url}/postalcodes/search?apikey={_apiKey}&";
			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}
		public async Task<string> PostalCodeSearch(string countryCode, string searchText, bool details = false)
		{
			var obj = new
			{
				q = searchText,
				language = _language,
				details
			};
			var url = $"{_url}/postalcodes/{countryCode}/search?apikey={_apiKey}&";
			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}

		#endregion Postal Code Search

		#region Text

		public async Task<string> TextSearch(string searchText, bool details = false,
			int? offset = null, string alias = null)
		{
			var obj = new
			{
				q = searchText,
				language = _language,
				details,
				offset,
				alias
			};
			var url = $"{_url}/search?apikey={_apiKey}&";
			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}

		public async Task<string> TextSearch(string countryCode, string searchText, bool details = false,
			int? offset = null, string alias = null)
		{
			var obj = new
			{
				q = searchText,
				language = _language,
				details,
				offset,
				alias
			};
			var url = $"{_url}/{countryCode}/search?apikey={_apiKey}&";
			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}

		public async Task<string> TextSearch(string countryCode, string adminCode, string searchText,
			bool details = false, int? offset = null, string alias = null)
		{
			var obj = new
			{
				q = searchText,
				language = _language,
				details,
				offset,
				alias
			};
			var url = $"{_url}/{countryCode}/{adminCode}/search?apikey={_apiKey}&";
			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}

		#endregion Text

		#endregion TextSearch

		#region GeoPosition

		public async Task<string> GeoPositionSearch(double lat, double lon,
			bool details = false, bool topLevel = false)
		{
			var q = lat.ToString(CultureInfo.InvariantCulture) +
				$",{lon.ToString(CultureInfo.InvariantCulture)}";

			var obj = new
			{
				q,
				language = _language,
				details,
				topLevel
			};

			var url = $"{_url}/cities/geoposition/search?apikey={_apiKey}&";

			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}

		#endregion GeoPosition

		#region IP Address
		public async Task<string> IpAddressSearch(string ipAddress, bool details = false)
		{
			var obj = new
			{
				q = ipAddress,
				language = _language,
				details
			};
			var url = $"{_url}/cities/ipaddress?apikey={_apiKey}&";
			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}
		#endregion IP Address

		#endregion Public
	}
}
