// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Communication.Models;
using Azure.ResourceManager.TestFramework;
using System.Collections.Generic;

namespace Azure.ResourceManager.Communication.Tests
{
    [RunFrequency(RunTestFrequency.Manually)]
    public abstract class CommunicationManagementClientLiveTestBase : ManagementRecordedTestBase<CommunicationManagementTestEnvironment>
    {
        public string ResourceGroupPrefix { get; private set; }
        public string ResourceLocation { get; private set; }
        public string ResourceDataLocation { get; private set; }

        public ArmClient ArmClient { get; set; }

        protected CommunicationManagementClientLiveTestBase(bool isAsync)
            : base(isAsync)
        {
            Init();
        }

        private void Init()
        {
            ResourceGroupPrefix = "Communication-RG-";
            ResourceLocation = "global";
            ResourceDataLocation = "UnitedStates";
            //Sanitizer = new CommunicationManagementRecordedTestSanitizer();
        }

        protected CommunicationManagementClientLiveTestBase(bool isAsync, RecordedTestMode mode)
            : base(isAsync, mode)
        {
            Init();
        }

        internal async Task<CommunicationServiceResource> CreateDefaultCommunicationServices(string communicationServiceName, ResourceGroupResource _resourceGroup)
        {
            CommunicationServiceResourceData data = new CommunicationServiceResourceData(ResourceLocation)
            {
                DataLocation = ResourceDataLocation,
            };
            var communicationServiceLro = await _resourceGroup.GetCommunicationServiceResources().CreateOrUpdateAsync(WaitUntil.Completed, communicationServiceName, data);
            return communicationServiceLro.Value;
        }

        internal async Task<EmailServiceResource> CreateDefaultEmailServices(string emailServiceName, ResourceGroupResource _resourceGroup)
        {
            EmailServiceResourceData data = new EmailServiceResourceData(ResourceLocation)
            {
                DataLocation = ResourceDataLocation,
            };
            var emailServiceLro = await _resourceGroup.GetEmailServiceResources().CreateOrUpdateAsync(WaitUntil.Completed, emailServiceName, data);
            return emailServiceLro.Value;
        }

        internal async Task<CommunicationDomainResource> CreateDefaultDomain(string domainName, EmailServiceResource emailService)
        {
            CommunicationDomainResourceData data = new CommunicationDomainResourceData(ResourceLocation)
            {
                DomainManagement = DomainManagement.CustomerManaged,
                ValidSenderUsernames = { {"username", "displayName" } }
            };
            var domainLro = await emailService.GetCommunicationDomainResources().CreateOrUpdateAsync(WaitUntil.Completed, domainName, data);
            return domainLro.Value;
        }
    }
}
