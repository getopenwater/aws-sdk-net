/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the cognito-sync-2014-06-30.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.CognitoSync.Model;
using Amazon.CognitoSync.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoSync
{
    /// <summary>
    /// Implementation for accessing CognitoSync
    ///
    /// Amazon Cognito Sync 
    /// <para>
    /// Amazon Cognito Sync provides an AWS service and client library that enable cross-device
    /// syncing of application-related user data. High-level client libraries are available
    /// for both iOS and Android. You can use these libraries to persist data locally so that
    /// it's available even if the device is offline. Developer credentials don't need to
    /// be stored on the mobile device to access the service. You can use Amazon Cognito to
    /// obtain a normalized user ID and credentials. User data is persisted in a dataset that
    /// can store up to 1 MB of key-value pairs, and you can have up to 20 datasets per user
    /// identity.
    /// </para>
    ///  
    /// <para>
    /// With Amazon Cognito Sync, the data stored for each identity is accessible only to
    /// credentials assigned to that identity. In order to use the Cognito Sync service, you
    /// need to make API calls using credentials retrieved with <a href="http://docs.aws.amazon.com/cognitoidentity/latest/APIReference/Welcome.html">Amazon
    /// Cognito Identity service</a>.
    /// </para>
    ///  
    /// <para>
    /// If you want to use Cognito Sync in an Android or iOS application, you will probably
    /// want to make API calls via the AWS Mobile SDK. To learn more, see the <a href="http://docs.aws.amazon.com/mobile/sdkforandroid/developerguide/cognito-sync.html">Developer
    /// Guide for Android</a> and the <a href="http://docs.aws.amazon.com/mobile/sdkforios/developerguide/cognito-sync.html">Developer
    /// Guide for iOS</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCognitoSyncClient : AmazonServiceClient, IAmazonCognitoSync
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCognitoSyncClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCognitoSyncConfig()) { }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoSyncClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCognitoSyncConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonCognitoSyncClient Configuration Object</param>
        public AmazonCognitoSyncClient(AmazonCognitoSyncConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCognitoSyncClient(AWSCredentials credentials)
            : this(credentials, new AmazonCognitoSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoSyncClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCognitoSyncConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Credentials and an
        /// AmazonCognitoSyncClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCognitoSyncClient Configuration Object</param>
        public AmazonCognitoSyncClient(AWSCredentials credentials, AmazonCognitoSyncConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCognitoSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCognitoSyncConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCognitoSyncClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCognitoSyncClient Configuration Object</param>
        public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCognitoSyncConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCognitoSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCognitoSyncConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCognitoSyncClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCognitoSyncClient Configuration Object</param>
        public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCognitoSyncConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.CredentialsRetriever>();
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.CognitoSync.Internal.CognitoCredentialsRetriever(this.Credentials));
        }    

        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  BulkPublish

        /// <summary>
        /// Initiates a bulk publish of all existing datasets for an Identity Pool to the configured
        /// stream. Customers are limited to one successful bulk publish per 24 hours. Bulk publish
        /// is an asynchronous request, customers can see the status of the request via the GetBulkPublishDetails
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BulkPublish service method.</param>
        /// 
        /// <returns>The response from the BulkPublish service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.AlreadyStreamedException">
        /// An exception thrown when a bulk publish operation is requested less than 24 hours
        /// after a previous bulk publish operation completed successfully.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.DuplicateRequestException">
        /// An exception thrown when there is an <code>IN_PROGRESS</code> bulk publish operation
        /// for the given identity pool.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        public BulkPublishResponse BulkPublish(BulkPublishRequest request)
        {
            var marshaller = new BulkPublishRequestMarshaller();
            var unmarshaller = BulkPublishResponseUnmarshaller.Instance;

            return Invoke<BulkPublishRequest,BulkPublishResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BulkPublish operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BulkPublish operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBulkPublish
        ///         operation.</returns>
        public IAsyncResult BeginBulkPublish(BulkPublishRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new BulkPublishRequestMarshaller();
            var unmarshaller = BulkPublishResponseUnmarshaller.Instance;

            return BeginInvoke<BulkPublishRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BulkPublish operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBulkPublish.</param>
        /// 
        /// <returns>Returns a  BulkPublishResult from CognitoSync.</returns>
        public  BulkPublishResponse EndBulkPublish(IAsyncResult asyncResult)
        {
            return EndInvoke<BulkPublishResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataset

        /// <summary>
        /// Deletes the specific dataset. The dataset will be deleted permanently, and the action
        /// can't be undone. Datasets that this dataset was merged with will no longer report
        /// the merge. Any subsequent operation on this dataset will result in a <code>ResourceNotFoundException</code>.
        /// 
        ///  
        /// <para>
        /// <code>DeleteDataset</code> can be called with temporary user credentials provided
        /// by Cognito Identity or with developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        public DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request)
        {
            var marshaller = new DeleteDatasetRequestMarshaller();
            var unmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetRequest,DeleteDatasetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataset
        ///         operation.</returns>
        public IAsyncResult BeginDeleteDataset(DeleteDatasetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteDatasetRequestMarshaller();
            var unmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDatasetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataset.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetResult from CognitoSync.</returns>
        public  DeleteDatasetResponse EndDeleteDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDataset

        /// <summary>
        /// Gets meta data about a dataset by identity and dataset name. With Amazon Cognito Sync,
        /// each identity has access only to its own data. Thus, the credentials used to make
        /// this API call need to have access to the identity data.
        /// 
        ///  
        /// <para>
        /// <code>DescribeDataset</code> can be called with temporary user credentials provided
        /// by Cognito Identity or with developer credentials. You should use Cognito Identity
        /// credentials to make this API call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
        /// 
        /// <returns>The response from the DescribeDataset service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        public DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request)
        {
            var marshaller = new DescribeDatasetRequestMarshaller();
            var unmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetRequest,DescribeDatasetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataset
        ///         operation.</returns>
        public IAsyncResult BeginDescribeDataset(DescribeDatasetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeDatasetRequestMarshaller();
            var unmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDatasetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataset.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetResult from CognitoSync.</returns>
        public  DescribeDatasetResponse EndDescribeDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeIdentityPoolUsage

        /// <summary>
        /// Gets usage details (for example, data storage) about a particular identity pool.
        /// 
        ///  
        /// <para>
        /// <code>DescribeIdentityPoolUsage</code> can only be called with developer credentials.
        /// You cannot make this API call with the temporary user credentials provided by Cognito
        /// Identity.
        /// </para>
        /// </summary>
        /// <param name="identityPoolId">A name-spaced GUID (for example, us-east-1:23EC4050-6AEA-7089-A2DD-08002EXAMPLE) created by Amazon Cognito. GUID generation is unique within a region.</param>
        /// 
        /// <returns>The response from the DescribeIdentityPoolUsage service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        public DescribeIdentityPoolUsageResponse DescribeIdentityPoolUsage(string identityPoolId)
        {
            var request = new DescribeIdentityPoolUsageRequest();
            request.IdentityPoolId = identityPoolId;
            return DescribeIdentityPoolUsage(request);
        }

        /// <summary>
        /// Gets usage details (for example, data storage) about a particular identity pool.
        /// 
        ///  
        /// <para>
        /// <code>DescribeIdentityPoolUsage</code> can only be called with developer credentials.
        /// You cannot make this API call with the temporary user credentials provided by Cognito
        /// Identity.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityPoolUsage service method.</param>
        /// 
        /// <returns>The response from the DescribeIdentityPoolUsage service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        public DescribeIdentityPoolUsageResponse DescribeIdentityPoolUsage(DescribeIdentityPoolUsageRequest request)
        {
            var marshaller = new DescribeIdentityPoolUsageRequestMarshaller();
            var unmarshaller = DescribeIdentityPoolUsageResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityPoolUsageRequest,DescribeIdentityPoolUsageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityPoolUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityPoolUsage operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIdentityPoolUsage
        ///         operation.</returns>
        public IAsyncResult BeginDescribeIdentityPoolUsage(DescribeIdentityPoolUsageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeIdentityPoolUsageRequestMarshaller();
            var unmarshaller = DescribeIdentityPoolUsageResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeIdentityPoolUsageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIdentityPoolUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIdentityPoolUsage.</param>
        /// 
        /// <returns>Returns a  DescribeIdentityPoolUsageResult from CognitoSync.</returns>
        public  DescribeIdentityPoolUsageResponse EndDescribeIdentityPoolUsage(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeIdentityPoolUsageResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeIdentityUsage

        /// <summary>
        /// Gets usage information for an identity, including number of datasets and data usage.
        /// 
        ///  
        /// <para>
        /// <code>DescribeIdentityUsage</code> can be called with temporary user credentials provided
        /// by Cognito Identity or with developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityUsage service method.</param>
        /// 
        /// <returns>The response from the DescribeIdentityUsage service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        public DescribeIdentityUsageResponse DescribeIdentityUsage(DescribeIdentityUsageRequest request)
        {
            var marshaller = new DescribeIdentityUsageRequestMarshaller();
            var unmarshaller = DescribeIdentityUsageResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityUsageRequest,DescribeIdentityUsageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityUsage operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIdentityUsage
        ///         operation.</returns>
        public IAsyncResult BeginDescribeIdentityUsage(DescribeIdentityUsageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeIdentityUsageRequestMarshaller();
            var unmarshaller = DescribeIdentityUsageResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeIdentityUsageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIdentityUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIdentityUsage.</param>
        /// 
        /// <returns>Returns a  DescribeIdentityUsageResult from CognitoSync.</returns>
        public  DescribeIdentityUsageResponse EndDescribeIdentityUsage(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeIdentityUsageResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBulkPublishDetails

        /// <summary>
        /// Get the status of the last BulkPublish operation for an identity pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBulkPublishDetails service method.</param>
        /// 
        /// <returns>The response from the GetBulkPublishDetails service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        public GetBulkPublishDetailsResponse GetBulkPublishDetails(GetBulkPublishDetailsRequest request)
        {
            var marshaller = new GetBulkPublishDetailsRequestMarshaller();
            var unmarshaller = GetBulkPublishDetailsResponseUnmarshaller.Instance;

            return Invoke<GetBulkPublishDetailsRequest,GetBulkPublishDetailsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBulkPublishDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBulkPublishDetails operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBulkPublishDetails
        ///         operation.</returns>
        public IAsyncResult BeginGetBulkPublishDetails(GetBulkPublishDetailsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetBulkPublishDetailsRequestMarshaller();
            var unmarshaller = GetBulkPublishDetailsResponseUnmarshaller.Instance;

            return BeginInvoke<GetBulkPublishDetailsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBulkPublishDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBulkPublishDetails.</param>
        /// 
        /// <returns>Returns a  GetBulkPublishDetailsResult from CognitoSync.</returns>
        public  GetBulkPublishDetailsResponse EndGetBulkPublishDetails(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBulkPublishDetailsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIdentityPoolConfiguration

        /// <summary>
        /// Gets the configuration settings of an identity pool.
        /// </summary>
        /// <param name="identityPoolId">A name-spaced GUID (for example, us-east-1:23EC4050-6AEA-7089-A2DD-08002EXAMPLE) created by Amazon Cognito. This is the ID of the pool for which to return a configuration.</param>
        /// 
        /// <returns>The response from the GetIdentityPoolConfiguration service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        public GetIdentityPoolConfigurationResponse GetIdentityPoolConfiguration(string identityPoolId)
        {
            var request = new GetIdentityPoolConfigurationRequest();
            request.IdentityPoolId = identityPoolId;
            return GetIdentityPoolConfiguration(request);
        }

        /// <summary>
        /// Gets the configuration settings of an identity pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityPoolConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetIdentityPoolConfiguration service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        public GetIdentityPoolConfigurationResponse GetIdentityPoolConfiguration(GetIdentityPoolConfigurationRequest request)
        {
            var marshaller = new GetIdentityPoolConfigurationRequestMarshaller();
            var unmarshaller = GetIdentityPoolConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetIdentityPoolConfigurationRequest,GetIdentityPoolConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityPoolConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityPoolConfiguration operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdentityPoolConfiguration
        ///         operation.</returns>
        public IAsyncResult BeginGetIdentityPoolConfiguration(GetIdentityPoolConfigurationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetIdentityPoolConfigurationRequestMarshaller();
            var unmarshaller = GetIdentityPoolConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke<GetIdentityPoolConfigurationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdentityPoolConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdentityPoolConfiguration.</param>
        /// 
        /// <returns>Returns a  GetIdentityPoolConfigurationResult from CognitoSync.</returns>
        public  GetIdentityPoolConfigurationResponse EndGetIdentityPoolConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIdentityPoolConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDatasets

        /// <summary>
        /// Lists datasets for an identity. With Amazon Cognito Sync, each identity has access
        /// only to its own data. Thus, the credentials used to make this API call need to have
        /// access to the identity data.
        /// 
        ///  
        /// <para>
        /// <code>ListDatasets</code> can be called with temporary user credentials provided by
        /// Cognito Identity or with developer credentials. You should use the Cognito Identity
        /// credentials to make this API call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        public ListDatasetsResponse ListDatasets(ListDatasetsRequest request)
        {
            var marshaller = new ListDatasetsRequestMarshaller();
            var unmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetsRequest,ListDatasetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasets
        ///         operation.</returns>
        public IAsyncResult BeginListDatasets(ListDatasetsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListDatasetsRequestMarshaller();
            var unmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return BeginInvoke<ListDatasetsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasets.</param>
        /// 
        /// <returns>Returns a  ListDatasetsResult from CognitoSync.</returns>
        public  ListDatasetsResponse EndListDatasets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDatasetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIdentityPoolUsage

        /// <summary>
        /// Gets a list of identity pools registered with Cognito.
        /// 
        ///  
        /// <para>
        /// <code>ListIdentityPoolUsage</code> can only be called with developer credentials.
        /// You cannot make this API call with the temporary user credentials provided by Cognito
        /// Identity.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPoolUsage service method.</param>
        /// 
        /// <returns>The response from the ListIdentityPoolUsage service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        public ListIdentityPoolUsageResponse ListIdentityPoolUsage(ListIdentityPoolUsageRequest request)
        {
            var marshaller = new ListIdentityPoolUsageRequestMarshaller();
            var unmarshaller = ListIdentityPoolUsageResponseUnmarshaller.Instance;

            return Invoke<ListIdentityPoolUsageRequest,ListIdentityPoolUsageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentityPoolUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPoolUsage operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdentityPoolUsage
        ///         operation.</returns>
        public IAsyncResult BeginListIdentityPoolUsage(ListIdentityPoolUsageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListIdentityPoolUsageRequestMarshaller();
            var unmarshaller = ListIdentityPoolUsageResponseUnmarshaller.Instance;

            return BeginInvoke<ListIdentityPoolUsageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdentityPoolUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdentityPoolUsage.</param>
        /// 
        /// <returns>Returns a  ListIdentityPoolUsageResult from CognitoSync.</returns>
        public  ListIdentityPoolUsageResponse EndListIdentityPoolUsage(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIdentityPoolUsageResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRecords

        /// <summary>
        /// Gets paginated records, optionally changed after a particular sync count for a dataset
        /// and identity. With Amazon Cognito Sync, each identity has access only to its own data.
        /// Thus, the credentials used to make this API call need to have access to the identity
        /// data.
        /// 
        ///  
        /// <para>
        /// <code>ListRecords</code> can be called with temporary user credentials provided by
        /// Cognito Identity or with developer credentials. You should use Cognito Identity credentials
        /// to make this API call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecords service method.</param>
        /// 
        /// <returns>The response from the ListRecords service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        public ListRecordsResponse ListRecords(ListRecordsRequest request)
        {
            var marshaller = new ListRecordsRequestMarshaller();
            var unmarshaller = ListRecordsResponseUnmarshaller.Instance;

            return Invoke<ListRecordsRequest,ListRecordsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecords operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecords
        ///         operation.</returns>
        public IAsyncResult BeginListRecords(ListRecordsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListRecordsRequestMarshaller();
            var unmarshaller = ListRecordsResponseUnmarshaller.Instance;

            return BeginInvoke<ListRecordsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecords operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecords.</param>
        /// 
        /// <returns>Returns a  ListRecordsResult from CognitoSync.</returns>
        public  ListRecordsResponse EndListRecords(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRecordsResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterDevice

        /// <summary>
        /// Registers a device to receive push sync notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDevice service method.</param>
        /// 
        /// <returns>The response from the RegisterDevice service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidConfigurationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        public RegisterDeviceResponse RegisterDevice(RegisterDeviceRequest request)
        {
            var marshaller = new RegisterDeviceRequestMarshaller();
            var unmarshaller = RegisterDeviceResponseUnmarshaller.Instance;

            return Invoke<RegisterDeviceRequest,RegisterDeviceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterDevice operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterDevice
        ///         operation.</returns>
        public IAsyncResult BeginRegisterDevice(RegisterDeviceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RegisterDeviceRequestMarshaller();
            var unmarshaller = RegisterDeviceResponseUnmarshaller.Instance;

            return BeginInvoke<RegisterDeviceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterDevice.</param>
        /// 
        /// <returns>Returns a  RegisterDeviceResult from CognitoSync.</returns>
        public  RegisterDeviceResponse EndRegisterDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  SetIdentityPoolConfiguration

        /// <summary>
        /// Sets the necessary configuration for push sync.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityPoolConfiguration service method.</param>
        /// 
        /// <returns>The response from the SetIdentityPoolConfiguration service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        public SetIdentityPoolConfigurationResponse SetIdentityPoolConfiguration(SetIdentityPoolConfigurationRequest request)
        {
            var marshaller = new SetIdentityPoolConfigurationRequestMarshaller();
            var unmarshaller = SetIdentityPoolConfigurationResponseUnmarshaller.Instance;

            return Invoke<SetIdentityPoolConfigurationRequest,SetIdentityPoolConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityPoolConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityPoolConfiguration operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetIdentityPoolConfiguration
        ///         operation.</returns>
        public IAsyncResult BeginSetIdentityPoolConfiguration(SetIdentityPoolConfigurationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SetIdentityPoolConfigurationRequestMarshaller();
            var unmarshaller = SetIdentityPoolConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke<SetIdentityPoolConfigurationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetIdentityPoolConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetIdentityPoolConfiguration.</param>
        /// 
        /// <returns>Returns a  SetIdentityPoolConfigurationResult from CognitoSync.</returns>
        public  SetIdentityPoolConfigurationResponse EndSetIdentityPoolConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<SetIdentityPoolConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  SubscribeToDataset

        /// <summary>
        /// Subscribes to receive notifications when a dataset is modified by another device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubscribeToDataset service method.</param>
        /// 
        /// <returns>The response from the SubscribeToDataset service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidConfigurationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        public SubscribeToDatasetResponse SubscribeToDataset(SubscribeToDatasetRequest request)
        {
            var marshaller = new SubscribeToDatasetRequestMarshaller();
            var unmarshaller = SubscribeToDatasetResponseUnmarshaller.Instance;

            return Invoke<SubscribeToDatasetRequest,SubscribeToDatasetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SubscribeToDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SubscribeToDataset operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSubscribeToDataset
        ///         operation.</returns>
        public IAsyncResult BeginSubscribeToDataset(SubscribeToDatasetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SubscribeToDatasetRequestMarshaller();
            var unmarshaller = SubscribeToDatasetResponseUnmarshaller.Instance;

            return BeginInvoke<SubscribeToDatasetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SubscribeToDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSubscribeToDataset.</param>
        /// 
        /// <returns>Returns a  SubscribeToDatasetResult from CognitoSync.</returns>
        public  SubscribeToDatasetResponse EndSubscribeToDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<SubscribeToDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  UnsubscribeFromDataset

        /// <summary>
        /// Unsubscribes from receiving notifications when a dataset is modified by another device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnsubscribeFromDataset service method.</param>
        /// 
        /// <returns>The response from the UnsubscribeFromDataset service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidConfigurationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        public UnsubscribeFromDatasetResponse UnsubscribeFromDataset(UnsubscribeFromDatasetRequest request)
        {
            var marshaller = new UnsubscribeFromDatasetRequestMarshaller();
            var unmarshaller = UnsubscribeFromDatasetResponseUnmarshaller.Instance;

            return Invoke<UnsubscribeFromDatasetRequest,UnsubscribeFromDatasetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UnsubscribeFromDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnsubscribeFromDataset operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnsubscribeFromDataset
        ///         operation.</returns>
        public IAsyncResult BeginUnsubscribeFromDataset(UnsubscribeFromDatasetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UnsubscribeFromDatasetRequestMarshaller();
            var unmarshaller = UnsubscribeFromDatasetResponseUnmarshaller.Instance;

            return BeginInvoke<UnsubscribeFromDatasetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UnsubscribeFromDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnsubscribeFromDataset.</param>
        /// 
        /// <returns>Returns a  UnsubscribeFromDatasetResult from CognitoSync.</returns>
        public  UnsubscribeFromDatasetResponse EndUnsubscribeFromDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<UnsubscribeFromDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRecords

        /// <summary>
        /// Posts updates to records and adds and deletes records for a dataset and user.
        /// 
        ///  
        /// <para>
        /// <code>UpdateRecords</code> can only be called with temporary user credentials provided
        /// by Cognito Identity. You cannot make this API call with developer credentials.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecords service method.</param>
        /// 
        /// <returns>The response from the UpdateRecords service method, as returned by CognitoSync.</returns>
        /// <exception cref="Amazon.CognitoSync.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.InvalidParameterException">
        /// Thrown when a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.LimitExceededException">
        /// Thrown when the limit on the number of objects or operations has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceConflictException">
        /// Thrown if an update can't be applied because the resource was changed by another call
        /// and this would result in a conflict.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.ResourceNotFoundException">
        /// Thrown if the resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoSync.Model.TooManyRequestsException">
        /// Thrown if the request is throttled.
        /// </exception>
        public UpdateRecordsResponse UpdateRecords(UpdateRecordsRequest request)
        {
            var marshaller = new UpdateRecordsRequestMarshaller();
            var unmarshaller = UpdateRecordsResponseUnmarshaller.Instance;

            return Invoke<UpdateRecordsRequest,UpdateRecordsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecords operation on AmazonCognitoSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRecords
        ///         operation.</returns>
        public IAsyncResult BeginUpdateRecords(UpdateRecordsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateRecordsRequestMarshaller();
            var unmarshaller = UpdateRecordsResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateRecordsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRecords operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRecords.</param>
        /// 
        /// <returns>Returns a  UpdateRecordsResult from CognitoSync.</returns>
        public  UpdateRecordsResponse EndUpdateRecords(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRecordsResponse>(asyncResult);
        }

        #endregion
        
    }
}