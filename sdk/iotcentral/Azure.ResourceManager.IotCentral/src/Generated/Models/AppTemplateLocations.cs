// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.IotCentral.Models
{
    /// <summary> IoT Central Application Template Locations. </summary>
    public partial class AppTemplateLocations
    {
        /// <summary> Initializes a new instance of AppTemplateLocations. </summary>
        internal AppTemplateLocations()
        {
        }

        /// <summary> Initializes a new instance of AppTemplateLocations. </summary>
        /// <param name="id"> The ID of the location. </param>
        /// <param name="displayName"> The display name of the location. </param>
        internal AppTemplateLocations(string id, string displayName)
        {
            Id = id;
            DisplayName = displayName;
        }

        /// <summary> The ID of the location. </summary>
        public string Id { get; }
        /// <summary> The display name of the location. </summary>
        public string DisplayName { get; }
    }
}
