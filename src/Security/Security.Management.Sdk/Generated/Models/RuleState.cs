// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Security.Models
{

    /// <summary>
    /// Defines values for RuleState.
    /// </summary>


    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RuleState
    {
        [System.Runtime.Serialization.EnumMember(Value = "Enabled")]
        Enabled,
        [System.Runtime.Serialization.EnumMember(Value = "Disabled")]
        Disabled,
        [System.Runtime.Serialization.EnumMember(Value = "Expired")]
        Expired
    }
    internal static class RuleStateEnumExtension
    {
        internal static string ToSerializedValue(this RuleState? value)
        {
            return value == null ? null : ((RuleState)value).ToSerializedValue();
        }
        internal static string ToSerializedValue(this RuleState value)
        {
            switch( value )
            {
                case RuleState.Enabled:
                    return "Enabled";
                case RuleState.Disabled:
                    return "Disabled";
                case RuleState.Expired:
                    return "Expired";
            }
            return null;
        }
        internal static RuleState? ParseRuleState(this string value)
        {
            switch( value )
            {
                case "Enabled":
                    return RuleState.Enabled;
                case "Disabled":
                    return RuleState.Disabled;
                case "Expired":
                    return RuleState.Expired;
            }
            return null;
        }
    }
}