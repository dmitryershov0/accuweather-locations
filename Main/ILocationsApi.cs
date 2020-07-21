using System.Threading.Tasks;

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
		/// 
		/// </summary>
		/// <param name="areaCode"></param>
		/// <param name="offset"></param>
		/// <returns></returns>
		Task<string> GetAreaList(string areaCode, int? offset = null);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="countryCode"></param>
		/// <returns></returns>
		Task<string> GetCountryList(string countryCode);

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		Task<string> GetRegionList();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="group"></param>
		/// <param name="details"></param>
		/// <returns></returns>
		Task<string> GetTopCitiesList(int group, bool details = false);

		#endregion List

		#region  AutoComplete

		/// <summary>
		/// 
		/// </summary>
		/// <param name="searchText"></param>
		/// <returns></returns>
		Task<string> AutoCompleteSearch(string searchText);

		#endregion  AutoComplete

		#region Location Key

		/// <summary>
		/// 
		/// </summary>
		/// <param name="locationKey"></param>
		/// <param name="details"></param>
		/// <returns></returns>
		Task<string> GetCityNeighbors(string locationKey, bool details = false);

		#endregion Location Key

		#region  TextSearch

		#region CitySearch
		/// <summary>
		/// 
		/// </summary>
		/// <param name="searchText"></param>
		/// <param name="details"></param>
		/// <param name="offset"></param>
		/// <param name="alias"></param>
		/// <returns></returns>
		Task<string> CitySearch(string searchText, bool details = false,
		   int? offset = null, string alias = null);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="countryCode"></param>
		/// <param name="adminCode"></param>
		/// <param name="searchText"></param>
		/// <param name="details"></param>
		/// <param name="offset"></param>
		/// <param name="alias"></param>
		/// <returns></returns>
		Task<string> CitySearch(string countryCode, string adminCode,
		   string searchText, bool details = false, int? offset = null, string alias = null);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="countryCode"></param>
		/// <param name="searchText"></param>
		/// <param name="details"></param>
		/// <param name="offset"></param>
		/// <param name="alias"></param>
		/// <returns></returns>
		Task<string> CitySearch(string countryCode, string searchText, bool details = false,
		   int? offset = null, string alias = null);

		#endregion CitySearch

		#region POI Search

		/// <summary>
		/// 
		/// </summary>
		/// <param name="serachText"></param>
		/// <param name="type"></param>
		/// <param name="details"></param>
		/// <returns></returns>
		Task<string> PointsOfInterestSerach(string serachText, string type = null, bool details = false);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="countryCode"></param>
		/// <param name="adminCode"></param>
		/// <param name="serachText"></param>
		/// <param name="type"></param>
		/// <param name="details"></param>
		/// <returns></returns>
		Task<string> PointsOfInterestSerach(string countryCode, string adminCode,
		   string serachText, string type = null, bool details = false);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="countryCode"></param>
		/// <param name="serachText"></param>
		/// <param name="type"></param>
		/// <param name="details"></param>
		/// <returns></returns>
		Task<string> PointsOfInterestSerach(string countryCode, string serachText,
		   string type = null, bool details = false);

		#endregion POI Search

		#region Postal Code Search

		/// <summary>
		/// 
		/// </summary>
		/// <param name="searchText"></param>
		/// <param name="details"></param>
		/// <returns></returns>
		Task<string> PostalCodeSearch(string searchText, bool details = false);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="countryCode"></param>
		/// <param name="searchText"></param>
		/// <param name="details"></param>
		/// <returns></returns>
		Task<string> PostalCodeSearch(string countryCode, string searchText, bool details = false);

		#endregion Postal Code Search

		#region Text

		/// <summary>
		/// 
		/// </summary>
		/// <param name="searchText"></param>
		/// <param name="details"></param>
		/// <param name="offset"></param>
		/// <param name="alias"></param>
		/// <returns></returns>
		Task<string> TextSearch(string searchText, bool details = false,
		   int? offset = null, string alias = null);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="countryCode"></param>
		/// <param name="searchText"></param>
		/// <param name="details"></param>
		/// <param name="offset"></param>
		/// <param name="alias"></param>
		/// <returns></returns>
		Task<string> TextSearch(string countryCode, string searchText, bool details = false,
		   int? offset = null, string alias = null);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="countryCode"></param>
		/// <param name="adminCode"></param>
		/// <param name="searchText"></param>
		/// <param name="details"></param>
		/// <param name="offset"></param>
		/// <param name="alias"></param>
		/// <returns></returns>
		Task<string> TextSearch(string countryCode, string adminCode, string searchText,
		   bool details = false, int? offset = null, string alias = null);

		#endregion Text

		#endregion TextSearch

		#region GeoPosition

		/// <summary>
		/// 
		/// </summary>
		/// <param name="lat"></param>
		/// <param name="lon"></param>
		/// <param name="details"></param>
		/// <param name="topLevel"></param>
		/// <returns></returns>
		Task<string> GeoPositionSearch(double lat, double lon,
		   bool details = false, bool topLevel = false);

		#endregion GeoPosition

		#region IP Address

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ipAddress"></param>
		/// <param name="details"></param>
		/// <returns></returns>
		Task<string> GeoPositionSearch(string ipAddress, bool details = false);
		#endregion IP Address
	}
}
