/*
 * YtelAPIV3.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YtelAPIV3.Standard;
using YtelAPIV3.Standard.Utilities;

namespace YtelAPIV3.Standard.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum Status25Enum
    {
        INPROGRESS, //TODO: Write general description for this method
        SUCCESS, //TODO: Write general description for this method
        FAILURE, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type Status25Enum
    /// </summary>
    public static class Status25EnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "inprogress", "success", "failure" };

        /// <summary>
        /// Converts a Status25Enum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Status25Enum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Status25Enum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Status25Enum.INPROGRESS:
                case Status25Enum.SUCCESS:
                case Status25Enum.FAILURE:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Status25Enum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Status25Enum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Status25Enum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into Status25Enum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Status25Enum value</returns>
        public static Status25Enum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type Status25Enum", value));

            return (Status25Enum) index;
        }
    }
} 