﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.DotnetCore.Test.Mocks
{
    using Moq;
    using System.Net.Http;
    using System.Threading.Tasks;
    public class MockHttpProvider : Mock<IHttpProvider>
    {
        public MockHttpProvider(HttpResponseMessage httpResponseMessage, ISerializer serializer = null)
            : base(MockBehavior.Strict)
        {
            this.SetupAllProperties();

            this.Setup(
                provider => provider.SendAsync(It.IsAny<HttpRequestMessage>()))
                .Returns(Task.FromResult(httpResponseMessage));

            this.SetupGet(provider => provider.Serializer).Returns(serializer);
        }
    }
}
