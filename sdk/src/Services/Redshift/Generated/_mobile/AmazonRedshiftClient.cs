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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Redshift.Model;
using Amazon.Redshift.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Redshift
{
    /// <summary>
    /// Implementation for accessing Redshift
    ///
    /// Amazon Redshift <b>Overview</b> 
    /// <para>
    ///  This is an interface reference for Amazon Redshift. It contains documentation for
    /// one of the programming or command line interfaces you can use to manage Amazon Redshift
    /// clusters. Note that Amazon Redshift is asynchronous, which means that some interfaces
    /// may require techniques, such as polling or asynchronous callback handlers, to determine
    /// when a command has been applied. In this reference, the parameter descriptions indicate
    /// whether a change is applied immediately, on the next instance reboot, or during the
    /// next maintenance window. For a summary of the Amazon Redshift cluster management interfaces,
    /// go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/using-aws-sdk.html">Using
    /// the Amazon Redshift Management Interfaces </a>.
    /// </para>
    ///  
    /// <para>
    ///  Amazon Redshift manages all the work of setting up, operating, and scaling a data
    /// warehouse: provisioning capacity, monitoring and backing up the cluster, and applying
    /// patches and upgrades to the Amazon Redshift engine. You can focus on using your data
    /// to acquire new insights for your business and customers. 
    /// </para>
    ///  
    /// <para>
    /// If you are a first-time user of Amazon Redshift, we recommend that you begin by reading
    /// the The <a href="http://docs.aws.amazon.com/redshift/latest/gsg/getting-started.html">Amazon
    /// Redshift Getting Started Guide</a>
    /// </para>
    ///  
    /// <para>
    /// If you are a database developer, the <a href="http://docs.aws.amazon.com/redshift/latest/dg/welcome.html">Amazon
    /// Redshift Database Developer Guide</a> explains how to design, build, query, and maintain
    /// the databases that make up your data warehouse. 
    /// </para>
    /// </summary>
    public partial class AmazonRedshiftClient : AmazonServiceClient, IAmazonRedshift
    {
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRedshiftClient(AWSCredentials credentials)
            : this(credentials, new AmazonRedshiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRedshiftConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Credentials and an
        /// AmazonRedshiftClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRedshiftClient Configuration Object</param>
        public AmazonRedshiftClient(AWSCredentials credentials, AmazonRedshiftConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRedshiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRedshiftConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRedshiftClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRedshiftClient Configuration Object</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRedshiftConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRedshiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRedshiftConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRedshiftClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRedshiftClient Configuration Object</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRedshiftConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 


        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  AuthorizeClusterSecurityGroupIngress

        internal AuthorizeClusterSecurityGroupIngressResponse AuthorizeClusterSecurityGroupIngress(AuthorizeClusterSecurityGroupIngressRequest request)
        {
            var marshaller = new AuthorizeClusterSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeClusterSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeClusterSecurityGroupIngressRequest,AuthorizeClusterSecurityGroupIngressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeClusterSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeClusterSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AuthorizeClusterSecurityGroupIngressResponse> AuthorizeClusterSecurityGroupIngressAsync(AuthorizeClusterSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AuthorizeClusterSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeClusterSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeClusterSecurityGroupIngressRequest,AuthorizeClusterSecurityGroupIngressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeSnapshotAccess

        internal AuthorizeSnapshotAccessResponse AuthorizeSnapshotAccess(AuthorizeSnapshotAccessRequest request)
        {
            var marshaller = new AuthorizeSnapshotAccessRequestMarshaller();
            var unmarshaller = AuthorizeSnapshotAccessResponseUnmarshaller.Instance;

            return Invoke<AuthorizeSnapshotAccessRequest,AuthorizeSnapshotAccessResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSnapshotAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSnapshotAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AuthorizeSnapshotAccessResponse> AuthorizeSnapshotAccessAsync(AuthorizeSnapshotAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AuthorizeSnapshotAccessRequestMarshaller();
            var unmarshaller = AuthorizeSnapshotAccessResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeSnapshotAccessRequest,AuthorizeSnapshotAccessResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopyClusterSnapshot

        internal CopyClusterSnapshotResponse CopyClusterSnapshot(CopyClusterSnapshotRequest request)
        {
            var marshaller = new CopyClusterSnapshotRequestMarshaller();
            var unmarshaller = CopyClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CopyClusterSnapshotRequest,CopyClusterSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CopyClusterSnapshotResponse> CopyClusterSnapshotAsync(CopyClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopyClusterSnapshotRequestMarshaller();
            var unmarshaller = CopyClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CopyClusterSnapshotRequest,CopyClusterSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateCluster

        internal CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var marshaller = new CreateClusterRequestMarshaller();
            var unmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterRequest,CreateClusterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateClusterRequestMarshaller();
            var unmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterRequest,CreateClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateClusterParameterGroup

        internal CreateClusterParameterGroupResponse CreateClusterParameterGroup(CreateClusterParameterGroupRequest request)
        {
            var marshaller = new CreateClusterParameterGroupRequestMarshaller();
            var unmarshaller = CreateClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateClusterParameterGroupRequest,CreateClusterParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateClusterParameterGroupResponse> CreateClusterParameterGroupAsync(CreateClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateClusterParameterGroupRequestMarshaller();
            var unmarshaller = CreateClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterParameterGroupRequest,CreateClusterParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateClusterSecurityGroup

        internal CreateClusterSecurityGroupResponse CreateClusterSecurityGroup(CreateClusterSecurityGroupRequest request)
        {
            var marshaller = new CreateClusterSecurityGroupRequestMarshaller();
            var unmarshaller = CreateClusterSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<CreateClusterSecurityGroupRequest,CreateClusterSecurityGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateClusterSecurityGroupResponse> CreateClusterSecurityGroupAsync(CreateClusterSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateClusterSecurityGroupRequestMarshaller();
            var unmarshaller = CreateClusterSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterSecurityGroupRequest,CreateClusterSecurityGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateClusterSnapshot

        internal CreateClusterSnapshotResponse CreateClusterSnapshot(CreateClusterSnapshotRequest request)
        {
            var marshaller = new CreateClusterSnapshotRequestMarshaller();
            var unmarshaller = CreateClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateClusterSnapshotRequest,CreateClusterSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateClusterSnapshotResponse> CreateClusterSnapshotAsync(CreateClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateClusterSnapshotRequestMarshaller();
            var unmarshaller = CreateClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterSnapshotRequest,CreateClusterSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateClusterSubnetGroup

        internal CreateClusterSubnetGroupResponse CreateClusterSubnetGroup(CreateClusterSubnetGroupRequest request)
        {
            var marshaller = new CreateClusterSubnetGroupRequestMarshaller();
            var unmarshaller = CreateClusterSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateClusterSubnetGroupRequest,CreateClusterSubnetGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateClusterSubnetGroupResponse> CreateClusterSubnetGroupAsync(CreateClusterSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateClusterSubnetGroupRequestMarshaller();
            var unmarshaller = CreateClusterSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterSubnetGroupRequest,CreateClusterSubnetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateEventSubscription

        internal CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request)
        {
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var unmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateEventSubscriptionRequest,CreateEventSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var unmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEventSubscriptionRequest,CreateEventSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateHsmClientCertificate

        internal CreateHsmClientCertificateResponse CreateHsmClientCertificate(CreateHsmClientCertificateRequest request)
        {
            var marshaller = new CreateHsmClientCertificateRequestMarshaller();
            var unmarshaller = CreateHsmClientCertificateResponseUnmarshaller.Instance;

            return Invoke<CreateHsmClientCertificateRequest,CreateHsmClientCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsmClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateHsmClientCertificateResponse> CreateHsmClientCertificateAsync(CreateHsmClientCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateHsmClientCertificateRequestMarshaller();
            var unmarshaller = CreateHsmClientCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHsmClientCertificateRequest,CreateHsmClientCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateHsmConfiguration

        internal CreateHsmConfigurationResponse CreateHsmConfiguration(CreateHsmConfigurationRequest request)
        {
            var marshaller = new CreateHsmConfigurationRequestMarshaller();
            var unmarshaller = CreateHsmConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateHsmConfigurationRequest,CreateHsmConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsmConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateHsmConfigurationResponse> CreateHsmConfigurationAsync(CreateHsmConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateHsmConfigurationRequestMarshaller();
            var unmarshaller = CreateHsmConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHsmConfigurationRequest,CreateHsmConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSnapshotCopyGrant

        internal CreateSnapshotCopyGrantResponse CreateSnapshotCopyGrant(CreateSnapshotCopyGrantRequest request)
        {
            var marshaller = new CreateSnapshotCopyGrantRequestMarshaller();
            var unmarshaller = CreateSnapshotCopyGrantResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotCopyGrantRequest,CreateSnapshotCopyGrantResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshotCopyGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotCopyGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateSnapshotCopyGrantResponse> CreateSnapshotCopyGrantAsync(CreateSnapshotCopyGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSnapshotCopyGrantRequestMarshaller();
            var unmarshaller = CreateSnapshotCopyGrantResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotCopyGrantRequest,CreateSnapshotCopyGrantResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTags

        internal CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var marshaller = new CreateTagsRequestMarshaller();
            var unmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateTagsRequest,CreateTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTagsRequestMarshaller();
            var unmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTagsRequest,CreateTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCluster

        internal DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var marshaller = new DeleteClusterRequestMarshaller();
            var unmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterRequest,DeleteClusterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteClusterRequestMarshaller();
            var unmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterRequest,DeleteClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteClusterParameterGroup

        internal DeleteClusterParameterGroupResponse DeleteClusterParameterGroup(DeleteClusterParameterGroupRequest request)
        {
            var marshaller = new DeleteClusterParameterGroupRequestMarshaller();
            var unmarshaller = DeleteClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterParameterGroupRequest,DeleteClusterParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteClusterParameterGroupResponse> DeleteClusterParameterGroupAsync(DeleteClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteClusterParameterGroupRequestMarshaller();
            var unmarshaller = DeleteClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterParameterGroupRequest,DeleteClusterParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteClusterSecurityGroup

        internal DeleteClusterSecurityGroupResponse DeleteClusterSecurityGroup(DeleteClusterSecurityGroupRequest request)
        {
            var marshaller = new DeleteClusterSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteClusterSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterSecurityGroupRequest,DeleteClusterSecurityGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteClusterSecurityGroupResponse> DeleteClusterSecurityGroupAsync(DeleteClusterSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteClusterSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteClusterSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterSecurityGroupRequest,DeleteClusterSecurityGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteClusterSnapshot

        internal DeleteClusterSnapshotResponse DeleteClusterSnapshot(DeleteClusterSnapshotRequest request)
        {
            var marshaller = new DeleteClusterSnapshotRequestMarshaller();
            var unmarshaller = DeleteClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterSnapshotRequest,DeleteClusterSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteClusterSnapshotResponse> DeleteClusterSnapshotAsync(DeleteClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteClusterSnapshotRequestMarshaller();
            var unmarshaller = DeleteClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterSnapshotRequest,DeleteClusterSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteClusterSubnetGroup

        internal DeleteClusterSubnetGroupResponse DeleteClusterSubnetGroup(DeleteClusterSubnetGroupRequest request)
        {
            var marshaller = new DeleteClusterSubnetGroupRequestMarshaller();
            var unmarshaller = DeleteClusterSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterSubnetGroupRequest,DeleteClusterSubnetGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteClusterSubnetGroupResponse> DeleteClusterSubnetGroupAsync(DeleteClusterSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteClusterSubnetGroupRequestMarshaller();
            var unmarshaller = DeleteClusterSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterSubnetGroupRequest,DeleteClusterSubnetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteEventSubscription

        internal DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request)
        {
            var marshaller = new DeleteEventSubscriptionRequestMarshaller();
            var unmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteEventSubscriptionRequest,DeleteEventSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteEventSubscriptionRequestMarshaller();
            var unmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEventSubscriptionRequest,DeleteEventSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteHsmClientCertificate

        internal DeleteHsmClientCertificateResponse DeleteHsmClientCertificate(DeleteHsmClientCertificateRequest request)
        {
            var marshaller = new DeleteHsmClientCertificateRequestMarshaller();
            var unmarshaller = DeleteHsmClientCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteHsmClientCertificateRequest,DeleteHsmClientCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsmClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteHsmClientCertificateResponse> DeleteHsmClientCertificateAsync(DeleteHsmClientCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteHsmClientCertificateRequestMarshaller();
            var unmarshaller = DeleteHsmClientCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHsmClientCertificateRequest,DeleteHsmClientCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteHsmConfiguration

        internal DeleteHsmConfigurationResponse DeleteHsmConfiguration(DeleteHsmConfigurationRequest request)
        {
            var marshaller = new DeleteHsmConfigurationRequestMarshaller();
            var unmarshaller = DeleteHsmConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteHsmConfigurationRequest,DeleteHsmConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsmConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteHsmConfigurationResponse> DeleteHsmConfigurationAsync(DeleteHsmConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteHsmConfigurationRequestMarshaller();
            var unmarshaller = DeleteHsmConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHsmConfigurationRequest,DeleteHsmConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSnapshotCopyGrant

        internal DeleteSnapshotCopyGrantResponse DeleteSnapshotCopyGrant(DeleteSnapshotCopyGrantRequest request)
        {
            var marshaller = new DeleteSnapshotCopyGrantRequestMarshaller();
            var unmarshaller = DeleteSnapshotCopyGrantResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotCopyGrantRequest,DeleteSnapshotCopyGrantResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshotCopyGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotCopyGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteSnapshotCopyGrantResponse> DeleteSnapshotCopyGrantAsync(DeleteSnapshotCopyGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSnapshotCopyGrantRequestMarshaller();
            var unmarshaller = DeleteSnapshotCopyGrantResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotCopyGrantRequest,DeleteSnapshotCopyGrantResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTags

        internal DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusterParameterGroups

        internal DescribeClusterParameterGroupsResponse DescribeClusterParameterGroups()
        {
            return DescribeClusterParameterGroups(new DescribeClusterParameterGroupsRequest());
        }
        internal DescribeClusterParameterGroupsResponse DescribeClusterParameterGroups(DescribeClusterParameterGroupsRequest request)
        {
            var marshaller = new DescribeClusterParameterGroupsRequestMarshaller();
            var unmarshaller = DescribeClusterParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterParameterGroupsRequest,DescribeClusterParameterGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameterGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeClusterParameterGroupsResponse> DescribeClusterParameterGroupsAsync(DescribeClusterParameterGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterParameterGroupsRequestMarshaller();
            var unmarshaller = DescribeClusterParameterGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterParameterGroupsRequest,DescribeClusterParameterGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusterParameters

        internal DescribeClusterParametersResponse DescribeClusterParameters(DescribeClusterParametersRequest request)
        {
            var marshaller = new DescribeClusterParametersRequestMarshaller();
            var unmarshaller = DescribeClusterParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterParametersRequest,DescribeClusterParametersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeClusterParametersResponse> DescribeClusterParametersAsync(DescribeClusterParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterParametersRequestMarshaller();
            var unmarshaller = DescribeClusterParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterParametersRequest,DescribeClusterParametersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusters

        internal DescribeClustersResponse DescribeClusters()
        {
            return DescribeClusters(new DescribeClustersRequest());
        }
        internal DescribeClustersResponse DescribeClusters(DescribeClustersRequest request)
        {
            var marshaller = new DescribeClustersRequestMarshaller();
            var unmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeClustersRequest,DescribeClustersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClustersRequestMarshaller();
            var unmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClustersRequest,DescribeClustersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusterSecurityGroups

        internal DescribeClusterSecurityGroupsResponse DescribeClusterSecurityGroups()
        {
            return DescribeClusterSecurityGroups(new DescribeClusterSecurityGroupsRequest());
        }
        internal DescribeClusterSecurityGroupsResponse DescribeClusterSecurityGroups(DescribeClusterSecurityGroupsRequest request)
        {
            var marshaller = new DescribeClusterSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeClusterSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterSecurityGroupsRequest,DescribeClusterSecurityGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeClusterSecurityGroupsResponse> DescribeClusterSecurityGroupsAsync(DescribeClusterSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeClusterSecurityGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterSecurityGroupsRequest,DescribeClusterSecurityGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusterSnapshots

        internal DescribeClusterSnapshotsResponse DescribeClusterSnapshots()
        {
            return DescribeClusterSnapshots(new DescribeClusterSnapshotsRequest());
        }
        internal DescribeClusterSnapshotsResponse DescribeClusterSnapshots(DescribeClusterSnapshotsRequest request)
        {
            var marshaller = new DescribeClusterSnapshotsRequestMarshaller();
            var unmarshaller = DescribeClusterSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterSnapshotsRequest,DescribeClusterSnapshotsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeClusterSnapshotsResponse> DescribeClusterSnapshotsAsync(DescribeClusterSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterSnapshotsRequestMarshaller();
            var unmarshaller = DescribeClusterSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterSnapshotsRequest,DescribeClusterSnapshotsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusterSubnetGroups

        internal DescribeClusterSubnetGroupsResponse DescribeClusterSubnetGroups()
        {
            return DescribeClusterSubnetGroups(new DescribeClusterSubnetGroupsRequest());
        }
        internal DescribeClusterSubnetGroupsResponse DescribeClusterSubnetGroups(DescribeClusterSubnetGroupsRequest request)
        {
            var marshaller = new DescribeClusterSubnetGroupsRequestMarshaller();
            var unmarshaller = DescribeClusterSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterSubnetGroupsRequest,DescribeClusterSubnetGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSubnetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeClusterSubnetGroupsResponse> DescribeClusterSubnetGroupsAsync(DescribeClusterSubnetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterSubnetGroupsRequestMarshaller();
            var unmarshaller = DescribeClusterSubnetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterSubnetGroupsRequest,DescribeClusterSubnetGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusterVersions

        internal DescribeClusterVersionsResponse DescribeClusterVersions()
        {
            return DescribeClusterVersions(new DescribeClusterVersionsRequest());
        }
        internal DescribeClusterVersionsResponse DescribeClusterVersions(DescribeClusterVersionsRequest request)
        {
            var marshaller = new DescribeClusterVersionsRequestMarshaller();
            var unmarshaller = DescribeClusterVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterVersionsRequest,DescribeClusterVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeClusterVersionsResponse> DescribeClusterVersionsAsync(DescribeClusterVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterVersionsRequestMarshaller();
            var unmarshaller = DescribeClusterVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterVersionsRequest,DescribeClusterVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDefaultClusterParameters

        internal DescribeDefaultClusterParametersResponse DescribeDefaultClusterParameters(DescribeDefaultClusterParametersRequest request)
        {
            var marshaller = new DescribeDefaultClusterParametersRequestMarshaller();
            var unmarshaller = DescribeDefaultClusterParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeDefaultClusterParametersRequest,DescribeDefaultClusterParametersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDefaultClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultClusterParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDefaultClusterParametersResponse> DescribeDefaultClusterParametersAsync(DescribeDefaultClusterParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDefaultClusterParametersRequestMarshaller();
            var unmarshaller = DescribeDefaultClusterParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDefaultClusterParametersRequest,DescribeDefaultClusterParametersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventCategories

        internal DescribeEventCategoriesResponse DescribeEventCategories()
        {
            return DescribeEventCategories(new DescribeEventCategoriesRequest());
        }
        internal DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request)
        {
            var marshaller = new DescribeEventCategoriesRequestMarshaller();
            var unmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeEventCategoriesRequest,DescribeEventCategoriesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventCategoriesRequestMarshaller();
            var unmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventCategoriesRequest,DescribeEventCategoriesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEvents

        internal DescribeEventsResponse DescribeEvents()
        {
            return DescribeEvents(new DescribeEventsRequest());
        }
        internal DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var marshaller = new DescribeEventsRequestMarshaller();
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsRequest,DescribeEventsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventsRequestMarshaller();
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventsRequest,DescribeEventsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventSubscriptions

        internal DescribeEventSubscriptionsResponse DescribeEventSubscriptions()
        {
            return DescribeEventSubscriptions(new DescribeEventSubscriptionsRequest());
        }
        internal DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request)
        {
            var marshaller = new DescribeEventSubscriptionsRequestMarshaller();
            var unmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventSubscriptionsRequest,DescribeEventSubscriptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventSubscriptionsRequestMarshaller();
            var unmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventSubscriptionsRequest,DescribeEventSubscriptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeHsmClientCertificates

        internal DescribeHsmClientCertificatesResponse DescribeHsmClientCertificates()
        {
            return DescribeHsmClientCertificates(new DescribeHsmClientCertificatesRequest());
        }
        internal DescribeHsmClientCertificatesResponse DescribeHsmClientCertificates(DescribeHsmClientCertificatesRequest request)
        {
            var marshaller = new DescribeHsmClientCertificatesRequestMarshaller();
            var unmarshaller = DescribeHsmClientCertificatesResponseUnmarshaller.Instance;

            return Invoke<DescribeHsmClientCertificatesRequest,DescribeHsmClientCertificatesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsmClientCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmClientCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeHsmClientCertificatesResponse> DescribeHsmClientCertificatesAsync(DescribeHsmClientCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeHsmClientCertificatesRequestMarshaller();
            var unmarshaller = DescribeHsmClientCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHsmClientCertificatesRequest,DescribeHsmClientCertificatesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeHsmConfigurations

        internal DescribeHsmConfigurationsResponse DescribeHsmConfigurations()
        {
            return DescribeHsmConfigurations(new DescribeHsmConfigurationsRequest());
        }
        internal DescribeHsmConfigurationsResponse DescribeHsmConfigurations(DescribeHsmConfigurationsRequest request)
        {
            var marshaller = new DescribeHsmConfigurationsRequestMarshaller();
            var unmarshaller = DescribeHsmConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeHsmConfigurationsRequest,DescribeHsmConfigurationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsmConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeHsmConfigurationsResponse> DescribeHsmConfigurationsAsync(DescribeHsmConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeHsmConfigurationsRequestMarshaller();
            var unmarshaller = DescribeHsmConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHsmConfigurationsRequest,DescribeHsmConfigurationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoggingStatus

        internal DescribeLoggingStatusResponse DescribeLoggingStatus(DescribeLoggingStatusRequest request)
        {
            var marshaller = new DescribeLoggingStatusRequestMarshaller();
            var unmarshaller = DescribeLoggingStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeLoggingStatusRequest,DescribeLoggingStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoggingStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeLoggingStatusResponse> DescribeLoggingStatusAsync(DescribeLoggingStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLoggingStatusRequestMarshaller();
            var unmarshaller = DescribeLoggingStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoggingStatusRequest,DescribeLoggingStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeOrderableClusterOptions

        internal DescribeOrderableClusterOptionsResponse DescribeOrderableClusterOptions()
        {
            return DescribeOrderableClusterOptions(new DescribeOrderableClusterOptionsRequest());
        }
        internal DescribeOrderableClusterOptionsResponse DescribeOrderableClusterOptions(DescribeOrderableClusterOptionsRequest request)
        {
            var marshaller = new DescribeOrderableClusterOptionsRequestMarshaller();
            var unmarshaller = DescribeOrderableClusterOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeOrderableClusterOptionsRequest,DescribeOrderableClusterOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableClusterOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableClusterOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeOrderableClusterOptionsResponse> DescribeOrderableClusterOptionsAsync(DescribeOrderableClusterOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeOrderableClusterOptionsRequestMarshaller();
            var unmarshaller = DescribeOrderableClusterOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOrderableClusterOptionsRequest,DescribeOrderableClusterOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedNodeOfferings

        internal DescribeReservedNodeOfferingsResponse DescribeReservedNodeOfferings()
        {
            return DescribeReservedNodeOfferings(new DescribeReservedNodeOfferingsRequest());
        }
        internal DescribeReservedNodeOfferingsResponse DescribeReservedNodeOfferings(DescribeReservedNodeOfferingsRequest request)
        {
            var marshaller = new DescribeReservedNodeOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedNodeOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedNodeOfferingsRequest,DescribeReservedNodeOfferingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedNodeOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodeOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeReservedNodeOfferingsResponse> DescribeReservedNodeOfferingsAsync(DescribeReservedNodeOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedNodeOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedNodeOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedNodeOfferingsRequest,DescribeReservedNodeOfferingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedNodes

        internal DescribeReservedNodesResponse DescribeReservedNodes()
        {
            return DescribeReservedNodes(new DescribeReservedNodesRequest());
        }
        internal DescribeReservedNodesResponse DescribeReservedNodes(DescribeReservedNodesRequest request)
        {
            var marshaller = new DescribeReservedNodesRequestMarshaller();
            var unmarshaller = DescribeReservedNodesResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedNodesRequest,DescribeReservedNodesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeReservedNodesResponse> DescribeReservedNodesAsync(DescribeReservedNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedNodesRequestMarshaller();
            var unmarshaller = DescribeReservedNodesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedNodesRequest,DescribeReservedNodesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeResize

        internal DescribeResizeResponse DescribeResize(DescribeResizeRequest request)
        {
            var marshaller = new DescribeResizeRequestMarshaller();
            var unmarshaller = DescribeResizeResponseUnmarshaller.Instance;

            return Invoke<DescribeResizeRequest,DescribeResizeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResize operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResize operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeResizeResponse> DescribeResizeAsync(DescribeResizeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeResizeRequestMarshaller();
            var unmarshaller = DescribeResizeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeResizeRequest,DescribeResizeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSnapshotCopyGrants

        internal DescribeSnapshotCopyGrantsResponse DescribeSnapshotCopyGrants(DescribeSnapshotCopyGrantsRequest request)
        {
            var marshaller = new DescribeSnapshotCopyGrantsRequestMarshaller();
            var unmarshaller = DescribeSnapshotCopyGrantsResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotCopyGrantsRequest,DescribeSnapshotCopyGrantsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotCopyGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotCopyGrants operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeSnapshotCopyGrantsResponse> DescribeSnapshotCopyGrantsAsync(DescribeSnapshotCopyGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSnapshotCopyGrantsRequestMarshaller();
            var unmarshaller = DescribeSnapshotCopyGrantsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotCopyGrantsRequest,DescribeSnapshotCopyGrantsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags

        internal DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableLogging

        internal DisableLoggingResponse DisableLogging(DisableLoggingRequest request)
        {
            var marshaller = new DisableLoggingRequestMarshaller();
            var unmarshaller = DisableLoggingResponseUnmarshaller.Instance;

            return Invoke<DisableLoggingRequest,DisableLoggingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DisableLoggingResponse> DisableLoggingAsync(DisableLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableLoggingRequestMarshaller();
            var unmarshaller = DisableLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<DisableLoggingRequest,DisableLoggingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableSnapshotCopy

        internal DisableSnapshotCopyResponse DisableSnapshotCopy(DisableSnapshotCopyRequest request)
        {
            var marshaller = new DisableSnapshotCopyRequestMarshaller();
            var unmarshaller = DisableSnapshotCopyResponseUnmarshaller.Instance;

            return Invoke<DisableSnapshotCopyRequest,DisableSnapshotCopyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableSnapshotCopy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableSnapshotCopy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DisableSnapshotCopyResponse> DisableSnapshotCopyAsync(DisableSnapshotCopyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableSnapshotCopyRequestMarshaller();
            var unmarshaller = DisableSnapshotCopyResponseUnmarshaller.Instance;

            return InvokeAsync<DisableSnapshotCopyRequest,DisableSnapshotCopyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableLogging

        internal EnableLoggingResponse EnableLogging(EnableLoggingRequest request)
        {
            var marshaller = new EnableLoggingRequestMarshaller();
            var unmarshaller = EnableLoggingResponseUnmarshaller.Instance;

            return Invoke<EnableLoggingRequest,EnableLoggingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<EnableLoggingResponse> EnableLoggingAsync(EnableLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableLoggingRequestMarshaller();
            var unmarshaller = EnableLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<EnableLoggingRequest,EnableLoggingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableSnapshotCopy

        internal EnableSnapshotCopyResponse EnableSnapshotCopy(EnableSnapshotCopyRequest request)
        {
            var marshaller = new EnableSnapshotCopyRequestMarshaller();
            var unmarshaller = EnableSnapshotCopyResponseUnmarshaller.Instance;

            return Invoke<EnableSnapshotCopyRequest,EnableSnapshotCopyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableSnapshotCopy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableSnapshotCopy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<EnableSnapshotCopyResponse> EnableSnapshotCopyAsync(EnableSnapshotCopyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableSnapshotCopyRequestMarshaller();
            var unmarshaller = EnableSnapshotCopyResponseUnmarshaller.Instance;

            return InvokeAsync<EnableSnapshotCopyRequest,EnableSnapshotCopyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyCluster

        internal ModifyClusterResponse ModifyCluster(ModifyClusterRequest request)
        {
            var marshaller = new ModifyClusterRequestMarshaller();
            var unmarshaller = ModifyClusterResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterRequest,ModifyClusterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyClusterResponse> ModifyClusterAsync(ModifyClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyClusterRequestMarshaller();
            var unmarshaller = ModifyClusterResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClusterRequest,ModifyClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyClusterParameterGroup

        internal ModifyClusterParameterGroupResponse ModifyClusterParameterGroup(ModifyClusterParameterGroupRequest request)
        {
            var marshaller = new ModifyClusterParameterGroupRequestMarshaller();
            var unmarshaller = ModifyClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterParameterGroupRequest,ModifyClusterParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyClusterParameterGroupResponse> ModifyClusterParameterGroupAsync(ModifyClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyClusterParameterGroupRequestMarshaller();
            var unmarshaller = ModifyClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClusterParameterGroupRequest,ModifyClusterParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyClusterSubnetGroup

        internal ModifyClusterSubnetGroupResponse ModifyClusterSubnetGroup(ModifyClusterSubnetGroupRequest request)
        {
            var marshaller = new ModifyClusterSubnetGroupRequestMarshaller();
            var unmarshaller = ModifyClusterSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterSubnetGroupRequest,ModifyClusterSubnetGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyClusterSubnetGroupResponse> ModifyClusterSubnetGroupAsync(ModifyClusterSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyClusterSubnetGroupRequestMarshaller();
            var unmarshaller = ModifyClusterSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClusterSubnetGroupRequest,ModifyClusterSubnetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyEventSubscription

        internal ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request)
        {
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var unmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<ModifyEventSubscriptionRequest,ModifyEventSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var unmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyEventSubscriptionRequest,ModifyEventSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifySnapshotCopyRetentionPeriod

        internal ModifySnapshotCopyRetentionPeriodResponse ModifySnapshotCopyRetentionPeriod(ModifySnapshotCopyRetentionPeriodRequest request)
        {
            var marshaller = new ModifySnapshotCopyRetentionPeriodRequestMarshaller();
            var unmarshaller = ModifySnapshotCopyRetentionPeriodResponseUnmarshaller.Instance;

            return Invoke<ModifySnapshotCopyRetentionPeriodRequest,ModifySnapshotCopyRetentionPeriodResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifySnapshotCopyRetentionPeriod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotCopyRetentionPeriod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifySnapshotCopyRetentionPeriodResponse> ModifySnapshotCopyRetentionPeriodAsync(ModifySnapshotCopyRetentionPeriodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifySnapshotCopyRetentionPeriodRequestMarshaller();
            var unmarshaller = ModifySnapshotCopyRetentionPeriodResponseUnmarshaller.Instance;

            return InvokeAsync<ModifySnapshotCopyRetentionPeriodRequest,ModifySnapshotCopyRetentionPeriodResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PurchaseReservedNodeOffering

        internal PurchaseReservedNodeOfferingResponse PurchaseReservedNodeOffering(PurchaseReservedNodeOfferingRequest request)
        {
            var marshaller = new PurchaseReservedNodeOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedNodeOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedNodeOfferingRequest,PurchaseReservedNodeOfferingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedNodeOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedNodeOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PurchaseReservedNodeOfferingResponse> PurchaseReservedNodeOfferingAsync(PurchaseReservedNodeOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PurchaseReservedNodeOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedNodeOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseReservedNodeOfferingRequest,PurchaseReservedNodeOfferingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RebootCluster

        internal RebootClusterResponse RebootCluster(RebootClusterRequest request)
        {
            var marshaller = new RebootClusterRequestMarshaller();
            var unmarshaller = RebootClusterResponseUnmarshaller.Instance;

            return Invoke<RebootClusterRequest,RebootClusterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RebootClusterResponse> RebootClusterAsync(RebootClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RebootClusterRequestMarshaller();
            var unmarshaller = RebootClusterResponseUnmarshaller.Instance;

            return InvokeAsync<RebootClusterRequest,RebootClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetClusterParameterGroup

        internal ResetClusterParameterGroupResponse ResetClusterParameterGroup(ResetClusterParameterGroupRequest request)
        {
            var marshaller = new ResetClusterParameterGroupRequestMarshaller();
            var unmarshaller = ResetClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ResetClusterParameterGroupRequest,ResetClusterParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ResetClusterParameterGroupResponse> ResetClusterParameterGroupAsync(ResetClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetClusterParameterGroupRequestMarshaller();
            var unmarshaller = ResetClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ResetClusterParameterGroupRequest,ResetClusterParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RestoreFromClusterSnapshot

        internal RestoreFromClusterSnapshotResponse RestoreFromClusterSnapshot(RestoreFromClusterSnapshotRequest request)
        {
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var unmarshaller = RestoreFromClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreFromClusterSnapshotRequest,RestoreFromClusterSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreFromClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RestoreFromClusterSnapshotResponse> RestoreFromClusterSnapshotAsync(RestoreFromClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var unmarshaller = RestoreFromClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreFromClusterSnapshotRequest,RestoreFromClusterSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RevokeClusterSecurityGroupIngress

        internal RevokeClusterSecurityGroupIngressResponse RevokeClusterSecurityGroupIngress(RevokeClusterSecurityGroupIngressRequest request)
        {
            var marshaller = new RevokeClusterSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeClusterSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<RevokeClusterSecurityGroupIngressRequest,RevokeClusterSecurityGroupIngressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeClusterSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeClusterSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RevokeClusterSecurityGroupIngressResponse> RevokeClusterSecurityGroupIngressAsync(RevokeClusterSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeClusterSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeClusterSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeClusterSecurityGroupIngressRequest,RevokeClusterSecurityGroupIngressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RevokeSnapshotAccess

        internal RevokeSnapshotAccessResponse RevokeSnapshotAccess(RevokeSnapshotAccessRequest request)
        {
            var marshaller = new RevokeSnapshotAccessRequestMarshaller();
            var unmarshaller = RevokeSnapshotAccessResponseUnmarshaller.Instance;

            return Invoke<RevokeSnapshotAccessRequest,RevokeSnapshotAccessResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSnapshotAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSnapshotAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RevokeSnapshotAccessResponse> RevokeSnapshotAccessAsync(RevokeSnapshotAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeSnapshotAccessRequestMarshaller();
            var unmarshaller = RevokeSnapshotAccessResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeSnapshotAccessRequest,RevokeSnapshotAccessResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RotateEncryptionKey

        internal RotateEncryptionKeyResponse RotateEncryptionKey(RotateEncryptionKeyRequest request)
        {
            var marshaller = new RotateEncryptionKeyRequestMarshaller();
            var unmarshaller = RotateEncryptionKeyResponseUnmarshaller.Instance;

            return Invoke<RotateEncryptionKeyRequest,RotateEncryptionKeyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RotateEncryptionKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RotateEncryptionKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RotateEncryptionKeyResponse> RotateEncryptionKeyAsync(RotateEncryptionKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RotateEncryptionKeyRequestMarshaller();
            var unmarshaller = RotateEncryptionKeyResponseUnmarshaller.Instance;

            return InvokeAsync<RotateEncryptionKeyRequest,RotateEncryptionKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}