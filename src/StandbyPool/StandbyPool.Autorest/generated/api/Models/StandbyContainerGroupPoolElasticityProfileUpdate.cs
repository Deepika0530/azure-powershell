// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>Specifies the elasticity profile of the standby container group pools.</summary>
    public partial class StandbyContainerGroupPoolElasticityProfileUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolElasticityProfileUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolElasticityProfileUpdateInternal
    {

        /// <summary>Backing field for <see cref="MaxReadyCapacity" /> property.</summary>
        private long? _maxReadyCapacity;

        /// <summary>Specifies maximum number of standby container groups in the standby pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public long? MaxReadyCapacity { get => this._maxReadyCapacity; set => this._maxReadyCapacity = value; }

        /// <summary>Backing field for <see cref="RefillPolicy" /> property.</summary>
        private string _refillPolicy;

        /// <summary>Specifies refill policy of the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string RefillPolicy { get => this._refillPolicy; set => this._refillPolicy = value; }

        /// <summary>
        /// Creates an new <see cref="StandbyContainerGroupPoolElasticityProfileUpdate" /> instance.
        /// </summary>
        public StandbyContainerGroupPoolElasticityProfileUpdate()
        {

        }
    }
    /// Specifies the elasticity profile of the standby container group pools.
    public partial interface IStandbyContainerGroupPoolElasticityProfileUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IJsonSerializable
    {
        /// <summary>Specifies maximum number of standby container groups in the standby pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies maximum number of standby container groups in the standby pool.",
        SerializedName = @"maxReadyCapacity",
        PossibleTypes = new [] { typeof(long) })]
        long? MaxReadyCapacity { get; set; }
        /// <summary>Specifies refill policy of the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies refill policy of the pool.",
        SerializedName = @"refillPolicy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("always")]
        string RefillPolicy { get; set; }

    }
    /// Specifies the elasticity profile of the standby container group pools.
    internal partial interface IStandbyContainerGroupPoolElasticityProfileUpdateInternal

    {
        /// <summary>Specifies maximum number of standby container groups in the standby pool.</summary>
        long? MaxReadyCapacity { get; set; }
        /// <summary>Specifies refill policy of the pool.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("always")]
        string RefillPolicy { get; set; }

    }
}