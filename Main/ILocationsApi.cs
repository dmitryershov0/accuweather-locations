using System.Threading.Tasks;
using Accuweather.Locations.Enums;

namespace Accuweather.Locations
{
	/// <summary>
	/// The Locations API allows users to get a location key for their desired location.
	/// This location key will then be used in the other APIs to retrieve weather data.
	/// <para>Doc: https://developer.accuweather.com/accuweather-locations-api/apis</para>
	/// </summary>
	public interface ILocationsApi
	{
		#region List

		/// <summary>
		/// Returns basic information about administrative areas in the specified country.
		/// </summary>
		/// <param name="areaCode"></param>
		/// <param name="offset">Integer, along with the limit (25) that determines the first resource to be returned. If no offset is provided, the max number (100) of results will be returned.</param>
		/// <returns>JSON Object <seealso cref="Accuweather.Core.Models.Response"/></returns>
		Task<string> GetAreaList(string areaCode, int? offset = null);

		/// <summary>
		/// Returns basic information about all countries within a specified region.
		/// </summary>
		/// <param name="countryCode">Unique ID to search for a specific location.</param>
		/// <returns>JSON Object <seealso cref="Accuweather.Core.Models.Response"/></returns>
		Task<string> GetCountryList(string countryCode);

		/// <summary>
		/// Returns basic information about all regions.
		/// </summary>
		/// <returns>JSON Object <seealso cref="Accuweather.Core.Models.Response"/></returns>
		Task<string> GetRegionList();

		/// <summary>
		/// Returns information for the top 50, 100, or 150 cities, worldwide.
		/// </summary>
		/// <param name="group">Integer that indicates the number to return with the request. Current supported values are 50, 100 and 150.</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <returns>JSON Object <seealso cref="Accuweather.Core.Models.Response"/></returns>
		Task<string> GetTopCitiesList(int group, bool details = false);

		#endregion List

		#region  AutoComplete

		/// <summary>
		/// Returns basic information about locations matching an autocomplete of the search text.
		/// </summary>
		/// <param name="searchText">Text to use for Autocomplete search.</param>
		/// <returns>JSON Object <seealso cref="Accuweather.Core.Models.Response"/></returns>
		Task<string> AutoCompleteSearch(string searchText);

		#endregion  AutoComplete

		#region Location Key

		/// <summary>
		/// Returns information about a specific location, by location key. You must know the location key to perform this query.
		/// </summary>
		/// <param name="locationKey">Unique ID to search for a specific location.</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <returns>JSON Object <seealso cref="Accuweather.Core.Models.Response"/></returns>
		Task<string> SearchByLocationKey(string locationKey, bool details = false);

		/// <summary>
		/// Returns information about a specific location, by location key. You must know the location key to perform this query.
		/// </summary>
		/// <param name="locationKey">Unique ID to search for a specific location.</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <returns>JSON Object <seealso cref="Accuweather.Core.Models.Response"/></returns>
		Task<string> GetCityNeighbors(string locationKey, bool details = false);

		#endregion Location Key

		#region  TextSearch

		#region CitySearch
		/// <summary>
		/// Returns information for an array of cities that match the search text.
		/// </summary>
		/// <param name="searchText">Text to search for.</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <param name="offset">Integer, along with the limit (25) that determines the first resource to be returned. If no offset is provided, the max number (100) of results will be returned.</param>
		/// <param name="alias">Enumeration that specifies when alias locations should be included in the results. By default, an alias will only be returned if no official match for the search text was found. Enumeration values: Never or Always</param>
		/// <returns>JSON Object <seealso cref="Accuweather.Core.Models.Response"/></returns>
		Task<string> CitySearch(string searchText, bool details = false,
		   int? offset = null, string alias = null);

		/// <summary>
		/// Returns information for an array of cities that match the search text.
		/// </summary>
		/// <param name="countryCode">Unique ID to search for a specific location.</param>
		/// <param name="adminCode">Unique ID to search for a specific location.</param>
		/// <param name="searchText">Text to search for.</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <param name="offset">Integer, along with the limit (25) that determines the first resource to be returned. If no offset is provided, the max number (100) of results will be returned.</param>
		/// <param name="alias">Enumeration that specifies when alias locations should be included in the results. By default, an alias will only be returned if no official match for the search text was found. Enumeration values: Never or Always</param>
		/// <returns>JSON Object <seealso cref="Accuweather.Core.Models.Response"/></returns>
		Task<string> CitySearch(string countryCode, string adminCode,
		   string searchText, bool details = false, int? offset = null, string alias = null);

		/// <summary>
		/// Returns information for an array of cities that match the search text.
		/// </summary>
		/// <param name="countryCode">Unique ID to search for a specific location.</param>
		/// <param name="searchText">Text to search for.</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <param name="offset">Integer, along with the limit (25) that determines the first resource to be returned. If no offset is provided, the max number (100) of results will be returned.</param>
		/// <param name="alias">Enumeration that specifies when alias locations should be included in the results. By default, an alias will only be returned if no official match for the search text was found. Enumeration values: Never or Always</param>
		/// <returns>JSON Object <seealso cref="Accuweather.Core.Models.Response"/></returns>
		Task<string> CitySearch(string countryCode, string searchText, bool details = false,
		   int? offset = null, string alias = null);

		#endregion CitySearch

		#region POI Search

		/// <summary>
		/// Returns information for an array of Points of Interest that match the search text.
		/// </summary>
		/// <param name="searchText">Text to search for.</param>
		/// <param name="type">POI type ID</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <returns>JSON Object <seealso cref="Accuweather.Core.Models.Response"/></returns>
		Task<string> PointsOfInterestSearch(string searchText, POI? type = null, bool details = false);

		/// <summary>
		/// Returns information for an array of Points of Interest that match the search text.
		/// </summary>
		/// <param name="countryCode">Unique ID to search for a specific location.</param>
		/// <param name="adminCode">Unique ID to search for a specific location.</param>
		/// <param name="searchText">Text to search for.</param>
		/// <param name="type">POI type ID</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <returns>JSON Object <seealso cref="Accuweather.Core.Models.Response"/></returns>
		Task<string> PointsOfInterestSearch(string countryCode, string adminCode,
		   string searchText, POI? type = null, bool details = false);

		/// <summary>
		/// Returns information for an array of Points of Interest that match the search text.
		/// </summary>
		/// <param name="countryCode">Unique ID to search for a specific location.</param>
		/// <param name="searchText">Text to search for.</param>
		/// <param name="type">POI type ID</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <returns>JSON Object <seealso cref="Accuweather.Core.Models.Response"/></returns>
		Task<string> PointsOfInterestSearch(string countryCode, string searchText,
		   POI? type = null, bool details = false);

		#endregion POI Search

		#region Postal Code Search

		/// <summary>
		/// Returns information for an array of Postal Codes that match the search text.
		/// </summary>
		/// <param name="searchText">Text to search for.</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <returns>JSON Object <seealso cref="Accuweather.Core.Models.Response"/></returns>
		Task<string> PostalCodeSearch(string searchText, bool details = false);

		/// <summary>
		/// Returns information for an array of Postal Codes that match the search text.
		/// </summary>
		/// <param name="countryCode">Unique ID to search for a specific location.</param>
		/// <param name="searchText">Text to search for.</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <returns>JSON Object <seealso cref="Accuweather.Core.Models.Response"/></returns>
		Task<string> PostalCodeSearch(string countryCode, string searchText, bool details = false);

		#endregion Postal Code Search

		#region Text

		/// <summary>
		/// Returns information for an array of locations that match the search text.
		/// </summary>
		/// <param name="searchText">Text to search for.</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <param name="offset">Integer, along with the limit (25) that determines the first resource to be returned. If no offset is provided, the max number (100) of results will be returned.</param>
		/// <param name="alias">Enumeration that specifies when alias locations should be included in the results. By default, an alias will only be returned if no official match for the search text was found. Enumeration values: Never or Always</param>
		/// <returns>JSON Object <seealso cref="Accuweather.Core.Models.Response"/></returns>
		Task<string> TextSearch(string searchText, bool details = false,
		   int? offset = null, string alias = null);

		/// <summary>
		/// Returns information for an array of locations that match the search text. Results are narrowed by entering a countryCode in the path.
		/// </summary>
		/// <param name="countryCode">Unique ID to search for a specific location.</param>
		/// <param name="searchText">Text to search for.</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <param name="offset">Integer, along with the limit (25) that determines the first resource to be returned. If no offset is provided, the max number (100) of results will be returned.</param>
		/// <param name="alias">Enumeration that specifies when alias locations should be included in the results. By default, an alias will only be returned if no official match for the search text was found. Enumeration values: Never or Always</param>
		/// <returns>JSON Object <seealso cref="Accuweather.Core.Models.Response"/></returns>
		Task<string> TextSearch(string countryCode, string searchText, bool details = false,
		   int? offset = null, string alias = null);

		/// <summary>
		/// Returns information for an array of locations that match the search text. Results are narrowed by entering a countryCode and adminCode in the path.
		/// </summary>
		/// <param name="countryCode">Unique ID to search for a specific location.</param>
		/// <param name="adminCode">Unique ID to search for a specific location.</param>
		/// <param name="searchText">Text to search for.</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <param name="offset">Integer, along with the limit (25) that determines the first resource to be returned. If no offset is provided, the max number (100) of results will be returned.</param>
		/// <param name="alias">Enumeration that specifies when alias locations should be included in the results. By default, an alias will only be returned if no official match for the search text was found. Enumeration values: Never or Always</param>
		/// <returns>JSON Object <seealso cref="Accuweather.Core.Models.Response"/></returns>
		Task<string> TextSearch(string countryCode, string adminCode, string searchText,
		   bool details = false, int? offset = null, string alias = null);

		#endregion Text

		#endregion TextSearch

		#region GeoPosition

		/// <summary>
		/// Returns information about a specific location, by GeoPosition (Latitude and Longitude).
		/// </summary>
		/// <param name="lat">Latitude</param>
		/// <param name="lon">Longitude</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <param name="topLevel">
		/// When toplevel=true, the city with the highest rank will be returned.
		/// Large cities have higher rank than the neighborhoods within them, so toplevel=true delivers
		/// a more generic location result. (Example: 40.73,-74.00 returns Greenwich Village, NY when toplevel=false.
		/// If toplevel=true, the same lat/lon pair will return New York, NY.)
		///</param>
		/// <returns>JSON Object <seealso cref="Accuweather.Core.Models.Response"/></returns>
		Task<string> GeoPositionSearch(double lat, double lon,
		   bool details = false, bool topLevel = false);

		#endregion GeoPosition

		#region IP Address

		/// <summary>
		/// Returns information about a specific location, by IP Address.
		/// </summary>
		/// <param name="ipAddress">Text to search for. In this case, the text should be a valid ip address.</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <returns>JSON Object <seealso cref="Accuweather.Core.Models.Response"/></returns>
		Task<string> GeoPositionSearch(string ipAddress, bool details = false);
		#endregion IP Address
	}
}
