/*
 * YtelAPIV3.Tests
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using YtelAPIV3.Standard;
using YtelAPIV3.Standard.Utilities; 
using YtelAPIV3.Standard.Http.Client;
using YtelAPIV3.Standard.Http.Response;
using YtelAPIV3.Tests.Helpers;
using NUnit.Framework;
using YtelAPIV3.Standard;
using YtelAPIV3.Standard.Controllers;
using YtelAPIV3.Standard.Exceptions;

namespace YtelAPIV3.Tests
{
    [TestFixture]
    public class SharedShortCodeControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static SharedShortCodeController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().SharedShortCode;
        }

        /// <summary>
        /// List All Inbound ShortCode 
        /// </summary>
        [Test]
        public async Task TestTestListInboundSMS() 
        {
            // Parameters for the API call
            string datecreated = null;
            int? page = null;
            int? pagesize = null;
            string mfrom = null;
            string shortcode = null;

            // Perform API call
            string result = null;

            try
            {
                result = await controller.CreateListInboundSMSAsync(datecreated, page, pagesize, mfrom, shortcode);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

        }

        /// <summary>
        /// List Shortcode Templates by Type 
        /// </summary>
        [Test]
        public async Task TestTestListTemplates() 
        {
            // Parameters for the API call
            string type = null;
            int? page = null;
            int? pagesize = null;
            string shortcode = null;

            // Perform API call
            string result = null;

            try
            {
                result = await controller.CreateListTemplatesAsync(type, page, pagesize, shortcode);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

        }

        /// <summary>
        /// Retrieve a list of keywords associated with your Ytel account. 
        /// </summary>
        [Test]
        public async Task TestTestListKeywords() 
        {
            // Parameters for the API call
            int? page = null;
            int? pagesize = null;
            string keyword = null;
            int? shortcode = null;

            // Perform API call
            string result = null;

            try
            {
                result = await controller.CreateListKeywordsAsync(page, pagesize, keyword, shortcode);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

        }

        /// <summary>
        /// Retrieve a list of shortcode assignment associated with your Ytel account. 
        /// </summary>
        [Test]
        public async Task TestTestListShortcodes() 
        {
            // Parameters for the API call
            string shortcode = null;
            int? page = null;
            int? pagesize = null;

            // Perform API call
            string result = null;

            try
            {
                result = await controller.CreateListShortcodesAsync(shortcode, page, pagesize);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

        }

    }
}