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
    public enum Fileformat37Enum
    {
        MP3, //mp3 file
        WAV, //wav file
    }

    /// <summary>
    /// Helper for the enum type Fileformat37Enum
    /// </summary>
    public static class Fileformat37EnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "mp3", "wav" };

        /// <summary>
        /// Converts a Fileformat37Enum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Fileformat37Enum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Fileformat37Enum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Fileformat37Enum.MP3:
                case Fileformat37Enum.WAV:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Fileformat37Enum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Fileformat37Enum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Fileformat37Enum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into Fileformat37Enum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Fileformat37Enum value</returns>
        public static Fileformat37Enum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type Fileformat37Enum", value));

            return (Fileformat37Enum) index;
        }
    }
} 