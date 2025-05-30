// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    internal partial class WorkflowsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of WorkflowsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public WorkflowsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-06-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListByStorageSyncServiceRequestUri(string subscriptionId, string resourceGroupName, string storageSyncServiceName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.StorageSync/storageSyncServices/", false);
            uri.AppendPath(storageSyncServiceName, true);
            uri.AppendPath("/workflows", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListByStorageSyncServiceRequest(string subscriptionId, string resourceGroupName, string storageSyncServiceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.StorageSync/storageSyncServices/", false);
            uri.AppendPath(storageSyncServiceName, true);
            uri.AppendPath("/workflows", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a Workflow List. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="storageSyncServiceName"> Name of Storage Sync Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="storageSyncServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="storageSyncServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<WorkflowArray>> ListByStorageSyncServiceAsync(string subscriptionId, string resourceGroupName, string storageSyncServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(storageSyncServiceName, nameof(storageSyncServiceName));

            using var message = CreateListByStorageSyncServiceRequest(subscriptionId, resourceGroupName, storageSyncServiceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WorkflowArray value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = WorkflowArray.DeserializeWorkflowArray(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a Workflow List. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="storageSyncServiceName"> Name of Storage Sync Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="storageSyncServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="storageSyncServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<WorkflowArray> ListByStorageSyncService(string subscriptionId, string resourceGroupName, string storageSyncServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(storageSyncServiceName, nameof(storageSyncServiceName));

            using var message = CreateListByStorageSyncServiceRequest(subscriptionId, resourceGroupName, storageSyncServiceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WorkflowArray value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = WorkflowArray.DeserializeWorkflowArray(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string storageSyncServiceName, string workflowId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.StorageSync/storageSyncServices/", false);
            uri.AppendPath(storageSyncServiceName, true);
            uri.AppendPath("/workflows/", false);
            uri.AppendPath(workflowId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string storageSyncServiceName, string workflowId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.StorageSync/storageSyncServices/", false);
            uri.AppendPath(storageSyncServiceName, true);
            uri.AppendPath("/workflows/", false);
            uri.AppendPath(workflowId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get Workflows resource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="storageSyncServiceName"> Name of Storage Sync Service resource. </param>
        /// <param name="workflowId"> workflow Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="storageSyncServiceName"/> or <paramref name="workflowId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="storageSyncServiceName"/> or <paramref name="workflowId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<StorageSyncWorkflowData>> GetAsync(string subscriptionId, string resourceGroupName, string storageSyncServiceName, string workflowId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(storageSyncServiceName, nameof(storageSyncServiceName));
            Argument.AssertNotNullOrEmpty(workflowId, nameof(workflowId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, storageSyncServiceName, workflowId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        StorageSyncWorkflowData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = StorageSyncWorkflowData.DeserializeStorageSyncWorkflowData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((StorageSyncWorkflowData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get Workflows resource. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="storageSyncServiceName"> Name of Storage Sync Service resource. </param>
        /// <param name="workflowId"> workflow Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="storageSyncServiceName"/> or <paramref name="workflowId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="storageSyncServiceName"/> or <paramref name="workflowId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<StorageSyncWorkflowData> Get(string subscriptionId, string resourceGroupName, string storageSyncServiceName, string workflowId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(storageSyncServiceName, nameof(storageSyncServiceName));
            Argument.AssertNotNullOrEmpty(workflowId, nameof(workflowId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, storageSyncServiceName, workflowId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        StorageSyncWorkflowData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = StorageSyncWorkflowData.DeserializeStorageSyncWorkflowData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((StorageSyncWorkflowData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateAbortRequestUri(string subscriptionId, string resourceGroupName, string storageSyncServiceName, string workflowId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.StorageSync/storageSyncServices/", false);
            uri.AppendPath(storageSyncServiceName, true);
            uri.AppendPath("/workflows/", false);
            uri.AppendPath(workflowId, true);
            uri.AppendPath("/abort", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateAbortRequest(string subscriptionId, string resourceGroupName, string storageSyncServiceName, string workflowId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.StorageSync/storageSyncServices/", false);
            uri.AppendPath(storageSyncServiceName, true);
            uri.AppendPath("/workflows/", false);
            uri.AppendPath(workflowId, true);
            uri.AppendPath("/abort", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Abort the given workflow. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="storageSyncServiceName"> Name of Storage Sync Service resource. </param>
        /// <param name="workflowId"> workflow Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="storageSyncServiceName"/> or <paramref name="workflowId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="storageSyncServiceName"/> or <paramref name="workflowId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> AbortAsync(string subscriptionId, string resourceGroupName, string storageSyncServiceName, string workflowId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(storageSyncServiceName, nameof(storageSyncServiceName));
            Argument.AssertNotNullOrEmpty(workflowId, nameof(workflowId));

            using var message = CreateAbortRequest(subscriptionId, resourceGroupName, storageSyncServiceName, workflowId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Abort the given workflow. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="storageSyncServiceName"> Name of Storage Sync Service resource. </param>
        /// <param name="workflowId"> workflow Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="storageSyncServiceName"/> or <paramref name="workflowId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="storageSyncServiceName"/> or <paramref name="workflowId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Abort(string subscriptionId, string resourceGroupName, string storageSyncServiceName, string workflowId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(storageSyncServiceName, nameof(storageSyncServiceName));
            Argument.AssertNotNullOrEmpty(workflowId, nameof(workflowId));

            using var message = CreateAbortRequest(subscriptionId, resourceGroupName, storageSyncServiceName, workflowId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
