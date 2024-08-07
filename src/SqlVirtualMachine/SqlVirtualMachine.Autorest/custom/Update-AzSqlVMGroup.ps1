
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Updates SQL virtual machine group.
.Description
Updates SQL virtual machine group.
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.ISqlVirtualMachineIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlVirtualMachineGroup
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <ISqlVirtualMachineIdentity>: Identity Parameter
  [AvailabilityGroupListenerName <String>]: Name of the availability group listener.
  [Id <String>]: Resource identity path
  [ResourceGroupName <String>]: Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
  [SqlVirtualMachineGroupName <String>]: Name of the SQL virtual machine group.
  [SqlVirtualMachineName <String>]: Name of the SQL virtual machine.
  [SubscriptionId <String>]: Subscription ID that identifies an Azure subscription.

.Link
https://learn.microsoft.com/powershell/module/az.sqlvirtualmachine/update-azsqlvmgroup
#>
function Update-AzSqlVMGroup {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlVirtualMachineGroup])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Alias('SqlVirtualMachineGroupName', 'SqlVMGroupName')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Path')]
    [System.String]
    # Name of the SQL virtual machine group.
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Path')]
    [System.String]
    # Name of the resource group that contains the resource.
    # You can obtain this value from the Azure Resource Manager API or the portal.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription ID that identifies an Azure subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.ISqlVirtualMachineIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # Account name used for creating cluster (at minimum needs permissions to 'Create Computer Objects' in domain).
    ${ClusterBootstrapAccount},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # Account name used for operating cluster i.e.
    # will be part of administrators group on all the participating virtual machines in the cluster.
    ${ClusterOperatorAccount},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.ClusterSubnetType])]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.ClusterSubnetType]
    # Cluster subnet type.
    ${ClusterSubnetType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # Fully qualified name of the domain.
    ${DomainFqdn},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # Optional path for fileshare witness.
    ${FileShareWitnessPath},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # Organizational Unit path in which the nodes and cluster will be present.
    ${OuPath},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # Account name under which SQL service will run on all participating SQL virtual machines in the cluster.
    ${SqlServiceAccount},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.Security.SecureString]
    # Primary key of the witness storage account.
    ${StorageAccountPrimaryKey},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [System.String]
    # Fully qualified ARM resource id of the witness storage account.
    ${StorageAccountUrl},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlVirtualMachineGroupUpdateTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

process {
    try {
        $hasInputObject = $PSBoundParameters.Remove('InputObject')

        $hasClusterBootstrapAccount = $PSBoundParameters.Remove('ClusterBootstrapAccount')
        $hasClusterOperatorAccount = $PSBoundParameters.Remove('ClusterOperatorAccount')
        $hasClusterSubnetType = $PSBoundParameters.Remove('ClusterSubnetType')
        $hasDomainFqdn = $PSBoundParameters.Remove('DomainFqdn')
        $hasFileShareWitnessPath = $PSBoundParameters.Remove('FileShareWitnessPath')
        $hasOuPath = $PSBoundParameters.Remove('OuPath')
        $hasSqlServiceAccount = $PSBoundParameters.Remove('SqlServiceAccount')
        $hasStorageAccountPrimaryKey = $PSBoundParameters.Remove('StorageAccountPrimaryKey')
        $hasStorageAccountUrl = $PSBoundParameters.Remove('StorageAccountUrl')
        $hasTag = $PSBoundParameters.Remove('Tag')
		
        $hasAsJob = $PSBoundParameters.Remove('AsJob')
        $null = $PSBoundParameters.Remove('WhatIf')
        $null = $PSBoundParameters.Remove('Confirm')

        if($hasInputObject){
            $sqlvmgroup = Get-AzSqlVMGroup -InputObject $InputObject @PSBoundParameters
        }else{
		    $sqlvmgroup = Get-AzSqlVMGroup @PSBoundParameters
        }

        $null = $PSBoundParameters.Remove('ResourceGroupName')
        $null = $PSBoundParameters.Remove('Name')
        $null = $PSBoundParameters.Remove('SubscriptionId')
		
        if ($hasClusterBootstrapAccount) {
            $sqlvmgroup.WsfcDomainProfileClusterBootstrapAccount = $ClusterBootstrapAccount
        }
        if ($hasClusterOperatorAccount) {
            $sqlvmgroup.WsfcDomainProfileClusterOperatorAccount = $ClusterOperatorAccount
        }
        if ($hasClusterSubnetType) {
            $sqlvmgroup.WsfcDomainProfileClusterSubnetType = $ClusterSubnetType
        }
        if ($hasDomainFqdn) {
            $sqlvmgroup.WsfcDomainProfileDomainFqdn = $DomainFqdn
        }
        if ($hasFileShareWitnessPath) {
            $sqlvmgroup.WsfcDomainProfileFileShareWitnessPath = $FileShareWitnessPath
        }
        if ($hasOuPath) {
            $sqlvmgroup.WsfcDomainProfileOuPath = $OuPath
        }
        if ($hasSqlServiceAccount) {
            $sqlvmgroup.WsfcDomainProfileSqlServiceAccount = $SqlServiceAccount
        }
        if ($hasStorageAccountPrimaryKey) {
            $sqlvmgroup.WsfcDomainProfileStorageAccountPrimaryKey = $StorageAccountPrimaryKey
        }
        if ($hasStorageAccountUrl) {
            $sqlvmgroup.WsfcDomainProfileStorageAccountUrl = $StorageAccountUrl
        }
        if ($hasTag) {
            $sqlvmgroup.Tag = $Tag
        }

        if ($hasAsJob) {
            $PSBoundParameters.Add('AsJob', $true)
        }
		
        if ($PSCmdlet.ShouldProcess("SQL virtual machine group $($sqlvmgroup.Name)", "Update")) {
            New-AzSqlVMGroup -InputObject $sqlvmgroup -Parameter $sqlvmgroup @PSBoundParameters
        }
        
    } catch {
        throw
    }

}

}
