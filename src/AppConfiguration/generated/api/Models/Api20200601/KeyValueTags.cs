// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;

    /// <summary>
    /// A dictionary of tags that can help identify what a key-value may be applicable for.
    /// </summary>
    public partial class KeyValueTags :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200601.IKeyValueTags,
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20200601.IKeyValueTagsInternal
    {

        /// <summary>Creates an new <see cref="KeyValueTags" /> instance.</summary>
        public KeyValueTags()
        {

        }
    }
    /// A dictionary of tags that can help identify what a key-value may be applicable for.
    public partial interface IKeyValueTags :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IAssociativeArray<string>
    {

    }
    /// A dictionary of tags that can help identify what a key-value may be applicable for.
    internal partial interface IKeyValueTagsInternal

    {

    }
}