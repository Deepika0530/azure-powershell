// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Resources.Models
{
    using System.Linq;

    public partial class AliasPathMetadata
    {
        /// <summary>
        /// Initializes a new instance of the AliasPathMetadata class.
        /// </summary>
        public AliasPathMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AliasPathMetadata class.
        /// </summary>

        /// <param name="type">The type of the token that the alias path is referring to.
        /// Possible values include: &#39;NotSpecified&#39;, &#39;Any&#39;, &#39;String&#39;, &#39;Object&#39;,
        /// &#39;Array&#39;, &#39;Integer&#39;, &#39;Number&#39;, &#39;Boolean&#39;</param>

        /// <param name="attributes">The attributes of the token that the alias path is referring to.
        /// Possible values include: &#39;None&#39;, &#39;Modifiable&#39;</param>
        public AliasPathMetadata(string type = default(string), string attributes = default(string))

        {
            this.Type = type;
            this.Attributes = attributes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the type of the token that the alias path is referring to. Possible values include: &#39;NotSpecified&#39;, &#39;Any&#39;, &#39;String&#39;, &#39;Object&#39;, &#39;Array&#39;, &#39;Integer&#39;, &#39;Number&#39;, &#39;Boolean&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type {get; private set; }

        /// <summary>
        /// Gets the attributes of the token that the alias path is referring to. Possible values include: &#39;None&#39;, &#39;Modifiable&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "attributes")]
        public string Attributes {get; private set; }
    }
}