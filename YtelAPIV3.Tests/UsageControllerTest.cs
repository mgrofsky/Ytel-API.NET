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
    public class UsageControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static UsageController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().Usage;
        }

        /// <summary>
        /// Retrieve usage metrics regarding your Ytel account. The results includes inbound/outbound voice calls and inbound/outbound SMS messages as well as carrier lookup requests. 
        /// </summary>
        [Test]
        public async Task TestTestListUsage() 
        {
            // Parameters for the API call
            Standard.Models.ProductCodeEnum? productCode = null;
            string startDate = null;
            string endDate = null;
            string includeSubAccounts = null;

            // Perform API call
            string result = null;

            try
            {
                result = await controller.CreateListUsageAsync(productCode, startDate, endDate, includeSubAccounts);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

        }

    }
}