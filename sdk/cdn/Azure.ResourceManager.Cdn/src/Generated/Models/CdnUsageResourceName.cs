// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The usage names. </summary>
    public partial class CdnUsageResourceName
    {
        /// <summary> Initializes a new instance of CdnUsageResourceName. </summary>
        internal CdnUsageResourceName()
        {
        }

        /// <summary> Initializes a new instance of CdnUsageResourceName. </summary>
        /// <param name="value"> A string describing the resource name. </param>
        /// <param name="localizedValue"> A localized string describing the resource name. </param>
        internal CdnUsageResourceName(string value, string localizedValue)
        {
            Value = value;
            LocalizedValue = localizedValue;
        }

        /// <summary> A string describing the resource name. </summary>
        public string Value { get; }
        /// <summary> A localized string describing the resource name. </summary>
        public string LocalizedValue { get; }
    }
}
