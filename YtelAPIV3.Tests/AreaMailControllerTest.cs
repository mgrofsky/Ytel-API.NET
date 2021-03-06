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
    public class AreaMailControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static AreaMailController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().AreaMail;
        }

        /// <summary>
        /// Retrieve a list of AreaMail objects. 
        /// </summary>
        [Test]
        public async Task TestTestListAreaMails() 
        {
            // Parameters for the API call
            int? page = null;
            int? pagesize = null;
            string areamailsid = null;
            string dateCreated = null;

            // Perform API call
            string result = null;

            try
            {
                result = await controller.CreateListAreaMailsAsync(page, pagesize, areamailsid, dateCreated);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

        }

    }
}