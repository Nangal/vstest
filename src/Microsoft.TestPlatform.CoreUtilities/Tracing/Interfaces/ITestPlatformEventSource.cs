﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.TestPlatform.CoreUtilities.Tracing.Interfaces
{
    /// <summary>
    /// TestPlatform Instrumentation events
    /// </summary>
    public interface ITestPlatformEventSource
    {
        /// <summary>
        /// The vs test console start.
        /// </summary>
        void VsTestConsoleStart();

        /// <summary>
        /// The vs test console stop.
        /// </summary>
        void VsTestConsoleStop();

        /// <summary>
        /// The discovery request start.
        /// </summary>
        void DiscoveryRequestStart();

        /// <summary>
        /// The discovery request stop.
        /// </summary>
        void DiscoveryRequestStop();

        /// <summary>
        /// The execution request start.
        /// </summary>
        void ExecutionRequestStart();

        /// <summary>
        /// The execution request stop.
        /// </summary>
        void ExecutionRequestStop();

        /// <summary>
        /// The test host start.
        /// </summary>
        void TestHostStart();

        /// <summary>
        /// The test host stop.
        /// </summary>
        void TestHostStop();

        /// <summary>
        /// The test host AppDomain Start.
        /// </summary>
        void TestHostAppDomainCreationStart();

        /// <summary>
        /// The test host AppDomain Stop.
        /// </summary>
        void TestHostAppDomainCreationStop();

        /// <summary>
        /// The adapter search start.
        /// </summary>
        void AdapterSearchStart();

        /// <summary>
        /// The adapter search stop.
        /// </summary>
        void AdapterSearchStop();

        /// <summary>
        /// The adapter execution start.
        /// </summary>
        /// <param name="executorUri">
        /// The executor uri.
        /// </param>
        void AdapterExecutionStart(string executorUri);

        /// <summary>
        /// The adapter execution stop.
        /// </summary>
        /// <param name="numberOfTests">
        /// The number of tests.
        /// </param>
        void AdapterExecutionStop(long numberOfTests);

        /// <summary>
        /// The adapter discovery start.
        /// </summary>
        /// <param name="executorUri">
        /// The executor uri.
        /// </param>
        void AdapterDiscoveryStart(string executorUri);

        /// <summary>
        /// The adapter discovery stop.
        /// </summary>
        /// <param name="numberOfTests">
        /// The number of tests.
        /// </param>
        void AdapterDiscoveryStop(long numberOfTests);

        /// <summary>
        /// The discovery start.
        /// </summary>
        void DiscoveryStart();

        /// <summary>
        /// The discovery stop.
        /// </summary>
        /// <param name="numberOfTests">
        /// The number of tests.
        /// </param>
        void DiscoveryStop(long numberOfTests);

        /// <summary>
        /// The execution start.
        /// </summary>
        void ExecutionStart();

        /// <summary>
        /// The execution stop.
        /// </summary>
        /// <param name="numberOfTests">
        /// The number of tests.
        /// </param>
        void ExecutionStop(long numberOfTests);

        /// <summary>
        /// The data collection start.
        /// </summary>
        /// <param name="dataCollectorUri">
        /// The data collector uri.
        /// </param>
        void DataCollectionStart(string dataCollectorUri);

        /// <summary>
        /// The data collection stop.
        /// </summary>
        void DataCollectionStop();
    }
}
