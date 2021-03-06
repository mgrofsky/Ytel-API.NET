/*
 * YtelAPIV3.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using YtelAPIV3.Standard;
using YtelAPIV3.Standard.Utilities;
using YtelAPIV3.Standard.Http.Request;
using YtelAPIV3.Standard.Http.Response;
using YtelAPIV3.Standard.Http.Client;
using YtelAPIV3.Standard.Exceptions;

namespace YtelAPIV3.Standard.Controllers
{
    public partial class AccountController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static AccountController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static AccountController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new AccountController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Retrieve information regarding your Ytel account by a specific date. The response object will contain data such as account status, balance, and account usage totals.
        /// </summary>
        /// <param name="date">Required parameter: Filter account information based on date.</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateViewAccount(string date)
        {
            Task<string> t = CreateViewAccountAsync(date);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve information regarding your Ytel account by a specific date. The response object will contain data such as account status, balance, and account usage totals.
        /// </summary>
        /// <param name="date">Required parameter: Filter account information based on date.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateViewAccountAsync(string date)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/accounts/viewaccount.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "Date", date )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 