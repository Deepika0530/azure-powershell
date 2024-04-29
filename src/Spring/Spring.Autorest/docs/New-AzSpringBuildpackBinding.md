---
external help file:
Module Name: Az.SpringApps
online version: https://learn.microsoft.com/powershell/module/az.springapps/new-azspringbuildpackbinding
schema: 2.0.0
---

# New-AzSpringBuildpackBinding

## SYNOPSIS
Create a buildpack binding.

## SYNTAX

### CreateExpanded (Default)
```
New-AzSpringBuildpackBinding -BuilderName <String> -Name <String> -ResourceGroupName <String>
 -ServiceName <String> [-SubscriptionId <String>] [-BindingType <String>] [-LaunchProperty <Hashtable>]
 [-LaunchSecret <Hashtable>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentityBuilderExpanded
```
New-AzSpringBuildpackBinding -BuilderInputObject <ISpringAppsIdentity> -Name <String> [-BindingType <String>]
 [-LaunchProperty <Hashtable>] [-LaunchSecret <Hashtable>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityBuildServiceExpanded
```
New-AzSpringBuildpackBinding -BuilderName <String> -BuildServiceInputObject <ISpringAppsIdentity>
 -Name <String> [-BindingType <String>] [-LaunchProperty <Hashtable>] [-LaunchSecret <Hashtable>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-AzSpringBuildpackBinding -InputObject <ISpringAppsIdentity> [-BindingType <String>]
 [-LaunchProperty <Hashtable>] [-LaunchSecret <Hashtable>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentitySpringExpanded
```
New-AzSpringBuildpackBinding -BuilderName <String> -Name <String> -SpringInputObject <ISpringAppsIdentity>
 [-BindingType <String>] [-LaunchProperty <Hashtable>] [-LaunchSecret <Hashtable>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaJsonFilePath
```
New-AzSpringBuildpackBinding -BuilderName <String> -Name <String> -ResourceGroupName <String>
 -ServiceName <String> -JsonFilePath <String> [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-AsJob]
 [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaJsonString
```
New-AzSpringBuildpackBinding -BuilderName <String> -Name <String> -ResourceGroupName <String>
 -ServiceName <String> -JsonString <String> [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-AsJob]
 [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a buildpack binding.

## EXAMPLES

### Example 1: Create a buildpack binding.
```powershell
New-AzSpringBuildpackBinding -BuilderName azps-builder -Name azps -ResourceGroupName azps_test_group_spring -ServiceName azps-spring-01 -BindingType ApplicationInsights -LaunchProperty @{"abc"="def";"any-string"="any-string";"sampling-rate"="12.0"} -LaunchSecret @{"connection-string"="XXXXXXXXXXXXXXXXX=XXXXXXXXXXXXX-XXXXXXXXXXXXXXXXXXX;XXXXXXXXXXXXXXXXX=XXXXXXXXXXXXXXXXXXX"}
```

```output
BindingType                  : ApplicationInsights
Id                           : /subscriptions/9e223dbe-3399-4e19-88eb-0975f02ac87f/resourceGroups/azps_test_group_spring/providers/Microsoft.AppPlatform/Spring/azps-spring-01/buildServices/default/builders/az
                               ps-builder/buildpackBindings/azps
LaunchPropertyProperties     : {
                                 "abc": "def",
                                 "any-string": "any-string",
                                 "sampling-rate": "12.0"
                               }
LaunchPropertySecret         : {
                                 "connection-string": "*"
                               }
Name                         : azps
ProvisioningState            : Succeeded
ResourceGroupName            : azps_test_group_spring
SystemDataCreatedAt          : 2023-12-19 上午 03:57:38
SystemDataCreatedBy          : v-jinpel@microsoft.com
SystemDataCreatedByType      : User
SystemDataLastModifiedAt     : 2023-12-19 上午 03:57:38
SystemDataLastModifiedBy     : v-jinpel@microsoft.com
SystemDataLastModifiedByType : User
Type                         : Microsoft.AppPlatform/Spring/buildServices/builders/buildpackBindings
```

Create a buildpack binding.
The length of BuildServiceName + BuilderName + BuildpacksBindingName cannot be greater than 30.

## PARAMETERS

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BindingType
Buildpack Binding Type

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityBuilderExpanded, CreateViaIdentityBuildServiceExpanded, CreateViaIdentityExpanded, CreateViaIdentitySpringExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BuilderInputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.SpringApps.Models.ISpringAppsIdentity
Parameter Sets: CreateViaIdentityBuilderExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BuilderName
The name of the builder resource.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityBuildServiceExpanded, CreateViaIdentitySpringExpanded, CreateViaJsonFilePath, CreateViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BuildServiceInputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.SpringApps.Models.ISpringAppsIdentity
Parameter Sets: CreateViaIdentityBuildServiceExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.SpringApps.Models.ISpringAppsIdentity
Parameter Sets: CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -JsonFilePath
Path of Json file supplied to the Create operation

```yaml
Type: System.String
Parameter Sets: CreateViaJsonFilePath
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JsonString
Json string supplied to the Create operation

```yaml
Type: System.String
Parameter Sets: CreateViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LaunchProperty
Non-sensitive properties for launchProperties

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityBuilderExpanded, CreateViaIdentityBuildServiceExpanded, CreateViaIdentityExpanded, CreateViaIdentitySpringExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LaunchSecret
Sensitive properties for launchProperties

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityBuilderExpanded, CreateViaIdentityBuildServiceExpanded, CreateViaIdentityExpanded, CreateViaIdentitySpringExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The name of the Buildpack Binding Name

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityBuilderExpanded, CreateViaIdentityBuildServiceExpanded, CreateViaIdentitySpringExpanded, CreateViaJsonFilePath, CreateViaJsonString
Aliases: BuildpackBindingName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group that contains the resource.
You can obtain this value from the Azure Resource Manager API or the portal.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaJsonFilePath, CreateViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceName
The name of the Service resource.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaJsonFilePath, CreateViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SpringInputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.SpringApps.Models.ISpringAppsIdentity
Parameter Sets: CreateViaIdentitySpringExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SubscriptionId
Gets subscription ID which uniquely identify the Microsoft Azure subscription.
The subscription ID forms part of the URI for every service call.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaJsonFilePath, CreateViaJsonString
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.SpringApps.Models.ISpringAppsIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.SpringApps.Models.IBuildpackBindingResource

## NOTES

## RELATED LINKS

