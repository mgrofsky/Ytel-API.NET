/*
 * YtelAPIV3.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Linq;
using System.Collections.Generic;
using YtelAPIV3.Standard;
using YtelAPIV3.Standard.Utilities;

namespace YtelAPIV3.Standard.Models
{
    public enum MergeNumberEnum
    {
        ENUM_0 = 0, //TODO: Write general description for this method
        ENUM_1 = 1, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type MergeNumberEnum
    /// </summary>
    public static class MergeNumberEnumHelper
    {
        /// <summary>
        /// Convert a list of MergeNumberEnum values to a list of integers
        /// </summary>
        /// <param name="enumValues">The list of MergeNumberEnum values to convert</param>
        /// <returns>The list of representative integer values</returns>
        public static List<int> ToValue(List<MergeNumberEnum> enumValues)
        {
            if (null == enumValues)
                return null;
            
            return enumValues.Select(eVal => (int)eVal).ToList();
        }
    }
} 