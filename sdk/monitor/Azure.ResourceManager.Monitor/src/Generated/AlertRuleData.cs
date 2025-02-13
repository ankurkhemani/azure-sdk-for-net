// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class representing the AlertRule data model. </summary>
    public partial class AlertRuleData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of AlertRuleData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="namePropertiesName"> the name of the alert rule. </param>
        /// <param name="isEnabled"> the flag that indicates whether the alert rule is enabled. </param>
        /// <param name="condition">
        /// the condition that results in the alert rule being activated.
        /// Please note <see cref="RuleCondition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LocationThresholdRuleCondition"/>, <see cref="ManagementEventRuleCondition"/> and <see cref="ThresholdRuleCondition"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="namePropertiesName"/> or <paramref name="condition"/> is null. </exception>
        public AlertRuleData(AzureLocation location, string namePropertiesName, bool isEnabled, RuleCondition condition) : base(location)
        {
            if (namePropertiesName == null)
            {
                throw new ArgumentNullException(nameof(namePropertiesName));
            }
            if (condition == null)
            {
                throw new ArgumentNullException(nameof(condition));
            }

            NamePropertiesName = namePropertiesName;
            IsEnabled = isEnabled;
            Condition = condition;
            Actions = new ChangeTrackingList<RuleAction>();
        }

        /// <summary> Initializes a new instance of AlertRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="namePropertiesName"> the name of the alert rule. </param>
        /// <param name="description"> the description of the alert rule that will be included in the alert email. </param>
        /// <param name="provisioningState"> the provisioning state. </param>
        /// <param name="isEnabled"> the flag that indicates whether the alert rule is enabled. </param>
        /// <param name="condition">
        /// the condition that results in the alert rule being activated.
        /// Please note <see cref="RuleCondition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LocationThresholdRuleCondition"/>, <see cref="ManagementEventRuleCondition"/> and <see cref="ThresholdRuleCondition"/>.
        /// </param>
        /// <param name="action">
        /// action that is performed when the alert rule becomes active, and when an alert condition is resolved.
        /// Please note <see cref="RuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RuleEmailAction"/> and <see cref="RuleWebhookAction"/>.
        /// </param>
        /// <param name="actions">
        /// the array of actions that are performed when the alert rule becomes active, and when an alert condition is resolved.
        /// Please note <see cref="RuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RuleEmailAction"/> and <see cref="RuleWebhookAction"/>.
        /// </param>
        /// <param name="lastUpdatedOn"> Last time the rule was updated in ISO8601 format. </param>
        internal AlertRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string namePropertiesName, string description, string provisioningState, bool isEnabled, RuleCondition condition, RuleAction action, IList<RuleAction> actions, DateTimeOffset? lastUpdatedOn) : base(id, name, resourceType, systemData, tags, location)
        {
            NamePropertiesName = namePropertiesName;
            Description = description;
            ProvisioningState = provisioningState;
            IsEnabled = isEnabled;
            Condition = condition;
            Action = action;
            Actions = actions;
            LastUpdatedOn = lastUpdatedOn;
        }

        /// <summary> the name of the alert rule. </summary>
        public string NamePropertiesName { get; set; }
        /// <summary> the description of the alert rule that will be included in the alert email. </summary>
        public string Description { get; set; }
        /// <summary> the provisioning state. </summary>
        public string ProvisioningState { get; set; }
        /// <summary> the flag that indicates whether the alert rule is enabled. </summary>
        public bool IsEnabled { get; set; }
        /// <summary>
        /// the condition that results in the alert rule being activated.
        /// Please note <see cref="RuleCondition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LocationThresholdRuleCondition"/>, <see cref="ManagementEventRuleCondition"/> and <see cref="ThresholdRuleCondition"/>.
        /// </summary>
        public RuleCondition Condition { get; set; }
        /// <summary>
        /// action that is performed when the alert rule becomes active, and when an alert condition is resolved.
        /// Please note <see cref="RuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RuleEmailAction"/> and <see cref="RuleWebhookAction"/>.
        /// </summary>
        public RuleAction Action { get; set; }
        /// <summary>
        /// the array of actions that are performed when the alert rule becomes active, and when an alert condition is resolved.
        /// Please note <see cref="RuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RuleEmailAction"/> and <see cref="RuleWebhookAction"/>.
        /// </summary>
        public IList<RuleAction> Actions { get; }
        /// <summary> Last time the rule was updated in ISO8601 format. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
    }
}
