// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support
{

    public partial struct ListCustomizationGroupsIncludeProperty :
        System.IEquatable<ListCustomizationGroupsIncludeProperty>
    {
        /// <summary>Include list of tasks in the response.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.ListCustomizationGroupsIncludeProperty Tasks = @"tasks";

        /// <summary>
        /// the value for an instance of the <see cref="ListCustomizationGroupsIncludeProperty" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ListCustomizationGroupsIncludeProperty</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ListCustomizationGroupsIncludeProperty" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ListCustomizationGroupsIncludeProperty(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ListCustomizationGroupsIncludeProperty</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.ListCustomizationGroupsIncludeProperty e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type ListCustomizationGroupsIncludeProperty (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ListCustomizationGroupsIncludeProperty && Equals((ListCustomizationGroupsIncludeProperty)obj);
        }

        /// <summary>Returns hashCode for enum ListCustomizationGroupsIncludeProperty</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// Creates an instance of the <see cref="ListCustomizationGroupsIncludeProperty"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ListCustomizationGroupsIncludeProperty(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ListCustomizationGroupsIncludeProperty</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ListCustomizationGroupsIncludeProperty</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ListCustomizationGroupsIncludeProperty" />.</param>

        public static implicit operator ListCustomizationGroupsIncludeProperty(string value)
        {
            return new ListCustomizationGroupsIncludeProperty(value);
        }

        /// <summary>Implicit operator to convert ListCustomizationGroupsIncludeProperty to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ListCustomizationGroupsIncludeProperty" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.ListCustomizationGroupsIncludeProperty e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ListCustomizationGroupsIncludeProperty</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.ListCustomizationGroupsIncludeProperty e1, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.ListCustomizationGroupsIncludeProperty e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ListCustomizationGroupsIncludeProperty</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.ListCustomizationGroupsIncludeProperty e1, Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.ListCustomizationGroupsIncludeProperty e2)
        {
            return e2.Equals(e1);
        }
    }
}