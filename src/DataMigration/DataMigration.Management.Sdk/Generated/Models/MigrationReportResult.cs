// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using System.Linq;

    /// <summary>
    /// Migration validation report result, contains the url for downloading the
    /// generated report.
    /// </summary>
    public partial class MigrationReportResult
    {
        /// <summary>
        /// Initializes a new instance of the MigrationReportResult class.
        /// </summary>
        public MigrationReportResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MigrationReportResult class.
        /// </summary>

        /// <param name="id">Migration validation result identifier
        /// </param>

        /// <param name="reportUrl">The url of the report.
        /// </param>
        public MigrationReportResult(string id = default(string), string reportUrl = default(string))

        {
            this.Id = id;
            this.ReportUrl = reportUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets migration validation result identifier
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id {get; set; }

        /// <summary>
        /// Gets or sets the url of the report.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "reportUrl")]
        public string ReportUrl {get; set; }
    }
}