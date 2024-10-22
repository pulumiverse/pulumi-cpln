// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

export interface CloudAccountAws {
    roleArn: string;
}

export interface CloudAccountAzure {
    secretLink: string;
}

export interface CloudAccountGcp {
    projectId: string;
}

export interface CloudAccountNgs {
    secretLink: string;
}

export interface DomainRouteHeaders {
    request?: outputs.DomainRouteHeadersRequest;
}

export interface DomainRouteHeadersRequest {
    set?: {[key: string]: string};
}

export interface DomainSpec {
    acceptAllHosts?: boolean;
    dnsMode?: string;
    gvcLink?: string;
    ports: outputs.DomainSpecPort[];
}

export interface DomainSpecPort {
    cors?: outputs.DomainSpecPortCors;
    number?: number;
    protocol?: string;
    tls: outputs.DomainSpecPortTls;
}

export interface DomainSpecPortCors {
    allowCredentials?: boolean;
    allowHeaders?: string[];
    allowMethods?: string[];
    allowOrigins?: outputs.DomainSpecPortCorsAllowOrigin[];
    exposeHeaders?: string[];
    maxAge?: string;
}

export interface DomainSpecPortCorsAllowOrigin {
    exact: string;
}

export interface DomainSpecPortTls {
    cipherSuites?: string[];
    clientCertificate?: outputs.DomainSpecPortTlsClientCertificate;
    minProtocolVersion?: string;
    serverCertificate?: outputs.DomainSpecPortTlsServerCertificate;
}

export interface DomainSpecPortTlsClientCertificate {
    secretLink?: string;
}

export interface DomainSpecPortTlsServerCertificate {
    secretLink?: string;
}

export interface DomainStatus {
    dnsConfigs?: outputs.DomainStatusDnsConfig[];
    endpoints?: outputs.DomainStatusEndpoint[];
    fingerprint?: string;
    locations?: outputs.DomainStatusLocation[];
    status?: string;
    warning?: string;
}

export interface DomainStatusDnsConfig {
    host?: string;
    ttl?: number;
    type?: string;
    value?: string;
}

export interface DomainStatusEndpoint {
    url?: string;
    workloadLink?: string;
}

export interface DomainStatusLocation {
    certificateStatus?: string;
    name?: string;
}

export interface GetGvcControlplaneTracing {
    customTags?: {[key: string]: string};
    sampling: number;
}

export interface GetGvcLightstepTracing {
    credentials?: string;
    customTags?: {[key: string]: string};
    endpoint: string;
    sampling: number;
}

export interface GetGvcLoadBalancer {
    dedicated: boolean;
    redirect?: outputs.GetGvcLoadBalancerRedirect;
    trustedProxies?: number;
}

export interface GetGvcLoadBalancerRedirect {
    class?: outputs.GetGvcLoadBalancerRedirectClass;
}

export interface GetGvcLoadBalancerRedirectClass {
    status5xx?: string;
}

export interface GetGvcOtelTracing {
    customTags?: {[key: string]: string};
    endpoint: string;
    sampling: number;
}

export interface GetGvcSidecar {
    envoy: string;
}

export interface GetImageManifest {
    configs: outputs.GetImageManifestConfig[];
    layers: outputs.GetImageManifestLayer[];
    mediaType: string;
    schemaVersion: number;
}

export interface GetImageManifestConfig {
    digest: string;
    mediaType: string;
    size: number;
}

export interface GetImageManifestLayer {
    digest: string;
    mediaType: string;
    size: number;
}

export interface GetImagesImage {
    cplnId: string;
    digest: string;
    manifests: outputs.GetImagesImageManifest[];
    name: string;
    repository: string;
    selfLink: string;
    tag: string;
    tags: {[key: string]: string};
}

export interface GetImagesImageManifest {
    configs: outputs.GetImagesImageManifestConfig[];
    layers: outputs.GetImagesImageManifestLayer[];
    mediaType: string;
    schemaVersion: number;
}

export interface GetImagesImageManifestConfig {
    digest: string;
    mediaType: string;
    size: number;
}

export interface GetImagesImageManifestLayer {
    digest: string;
    mediaType: string;
    size: number;
}

export interface GetImagesQuery {
    fetch?: string;
    spec?: outputs.GetImagesQuerySpec;
}

export interface GetImagesQuerySpec {
    match?: string;
    terms?: outputs.GetImagesQuerySpecTerm[];
}

export interface GetImagesQuerySpecTerm {
    op?: string;
    property?: string;
    rel?: string;
    tag?: string;
    value?: string;
}

export interface GetLocationGeo {
    city?: string;
    continent?: string;
    country?: string;
    lat?: number;
    lon?: number;
    state?: string;
}

export interface GetLocationsLocation {
    cloudProvider: string;
    cplnId: string;
    description: string;
    enabled: boolean;
    geos: outputs.GetLocationsLocationGeo[];
    ipRanges: string[];
    name: string;
    region: string;
    selfLink: string;
    tags: {[key: string]: string};
}

export interface GetLocationsLocationGeo {
    city?: string;
    continent?: string;
    country?: string;
    lat?: number;
    lon?: number;
    state?: string;
}

export interface GetSecretAws {
    accessKey: string;
    externalId?: string;
    roleArn?: string;
    secretKey: string;
}

export interface GetSecretAzureConnector {
    code: string;
    url: string;
}

export interface GetSecretEcr {
    accessKey: string;
    externalId?: string;
    repos: string[];
    roleArn?: string;
    secretKey: string;
}

export interface GetSecretKeypair {
    passphrase?: string;
    publicKey?: string;
    secretKey: string;
}

export interface GetSecretNatsAccount {
    accountId: string;
    privateKey: string;
}

export interface GetSecretOpaque {
    encoding?: string;
    payload: string;
}

export interface GetSecretTls {
    cert: string;
    chain?: string;
    key: string;
}

export interface GetSecretUserpass {
    encoding?: string;
    password: string;
    username: string;
}

export interface GroupIdentityMatcher {
    expression: string;
    language?: string;
}

export interface GroupMemberQuery {
    fetch?: string;
    spec?: outputs.GroupMemberQuerySpec;
}

export interface GroupMemberQuerySpec {
    match?: string;
    terms?: outputs.GroupMemberQuerySpecTerm[];
}

export interface GroupMemberQuerySpecTerm {
    op?: string;
    property?: string;
    rel?: string;
    tag?: string;
    value?: string;
}

export interface GvcControlplaneTracing {
    customTags?: {[key: string]: string};
    sampling: number;
}

export interface GvcLightstepTracing {
    credentials?: string;
    customTags?: {[key: string]: string};
    endpoint: string;
    sampling: number;
}

export interface GvcLoadBalancer {
    dedicated: boolean;
    redirect?: outputs.GvcLoadBalancerRedirect;
    trustedProxies?: number;
}

export interface GvcLoadBalancerRedirect {
    class?: outputs.GvcLoadBalancerRedirectClass;
}

export interface GvcLoadBalancerRedirectClass {
    status5xx?: string;
}

export interface GvcOtelTracing {
    customTags?: {[key: string]: string};
    endpoint: string;
    sampling: number;
}

export interface GvcSidecar {
    envoy: string;
}

export interface IdentityAwsAccessPolicy {
    cloudAccountLink: string;
    policyRefs?: string[];
    roleName?: string;
}

export interface IdentityAzureAccessPolicy {
    cloudAccountLink: string;
    roleAssignments?: outputs.IdentityAzureAccessPolicyRoleAssignment[];
}

export interface IdentityAzureAccessPolicyRoleAssignment {
    roles?: string[];
    scope?: string;
}

export interface IdentityGcpAccessPolicy {
    bindings?: outputs.IdentityGcpAccessPolicyBinding[];
    cloudAccountLink: string;
    scopes?: string;
    serviceAccount?: string;
}

export interface IdentityGcpAccessPolicyBinding {
    resource?: string;
    roles?: string[];
}

export interface IdentityNativeNetworkResource {
    awsPrivateLink?: outputs.IdentityNativeNetworkResourceAwsPrivateLink;
    fqdn: string;
    gcpServiceConnect?: outputs.IdentityNativeNetworkResourceGcpServiceConnect;
    name: string;
    ports: number[];
}

export interface IdentityNativeNetworkResourceAwsPrivateLink {
    endpointServiceName: string;
}

export interface IdentityNativeNetworkResourceGcpServiceConnect {
    targetService: string;
}

export interface IdentityNetworkResource {
    agentLink: string;
    fqdn?: string;
    ips?: string[];
    name: string;
    ports?: number[];
    resolverIp?: string;
}

export interface IdentityNgsAccessPolicy {
    cloudAccountLink: string;
    data?: number;
    payload?: number;
    pub?: outputs.IdentityNgsAccessPolicyPub;
    resp?: outputs.IdentityNgsAccessPolicyResp;
    sub?: outputs.IdentityNgsAccessPolicySub;
    subs?: number;
}

export interface IdentityNgsAccessPolicyPub {
    allows?: string[];
    denies?: string[];
}

export interface IdentityNgsAccessPolicyResp {
    max?: number;
    ttl?: string;
}

export interface IdentityNgsAccessPolicySub {
    allows?: string[];
    denies?: string[];
}

export interface IpSetLocation {
    name: string;
    retentionPolicy: string;
}

export interface IpSetStatus {
    error: string;
    ipAddresses: outputs.IpSetStatusIpAddress[];
}

export interface IpSetStatusIpAddress {
    created: string;
    id: string;
    ip: string;
    name: string;
    state: string;
}

export interface LocationGeo {
    city?: string;
    continent?: string;
    country?: string;
    lat?: number;
    lon?: number;
    state?: string;
}

export interface Mk8sAddOns {
    awsEcr?: outputs.Mk8sAddOnsAwsEcr;
    awsEfs?: outputs.Mk8sAddOnsAwsEfs;
    awsElb?: outputs.Mk8sAddOnsAwsElb;
    awsWorkloadIdentity?: boolean;
    azureAcr?: outputs.Mk8sAddOnsAzureAcr;
    azureWorkloadIdentity?: outputs.Mk8sAddOnsAzureWorkloadIdentity;
    dashboard?: boolean;
    localPathStorage?: boolean;
    logs?: outputs.Mk8sAddOnsLogs;
    metrics?: outputs.Mk8sAddOnsMetrics;
    nvidia?: outputs.Mk8sAddOnsNvidia;
    sysbox?: boolean;
}

export interface Mk8sAddOnsAwsEcr {
    _sentinel?: boolean;
    roleArn?: string;
}

export interface Mk8sAddOnsAwsEfs {
    _sentinel?: boolean;
    roleArn?: string;
}

export interface Mk8sAddOnsAwsElb {
    _sentinel?: boolean;
    roleArn?: string;
}

export interface Mk8sAddOnsAzureAcr {
    clientId: string;
}

export interface Mk8sAddOnsAzureWorkloadIdentity {
    _sentinel?: boolean;
    tenantId?: string;
}

export interface Mk8sAddOnsLogs {
    _sentinel?: boolean;
    auditEnabled?: boolean;
    excludeNamespaces?: string;
    includeNamespaces?: string;
}

export interface Mk8sAddOnsMetrics {
    _sentinel?: boolean;
    apiServer?: boolean;
    cadvisor?: boolean;
    coreDns?: boolean;
    kubeState?: boolean;
    kubelet?: boolean;
    nodeExporter?: boolean;
    scrapeAnnotated?: outputs.Mk8sAddOnsMetricsScrapeAnnotated;
}

export interface Mk8sAddOnsMetricsScrapeAnnotated {
    _sentinel?: boolean;
    excludeNamespaces?: string;
    includeNamespaces?: string;
    intervalSeconds?: number;
    retainLabels?: string;
}

export interface Mk8sAddOnsNvidia {
    _sentinel?: boolean;
    taintGpuNodes?: boolean;
}

export interface Mk8sAwsProvider {
    autoscaler?: outputs.Mk8sAwsProviderAutoscaler;
    awsTags?: {[key: string]: string};
    deployRoleArn: string;
    deployRoleChains?: outputs.Mk8sAwsProviderDeployRoleChain[];
    diskEncryptionKeyArn?: string;
    image: outputs.Mk8sAwsProviderImage;
    keyPair?: string;
    networking: outputs.Mk8sAwsProviderNetworking;
    nodePools?: outputs.Mk8sAwsProviderNodePool[];
    preInstallScript?: string;
    region: string;
    securityGroupIds?: string[];
    skipCreateRoles?: boolean;
    vpcId: string;
}

export interface Mk8sAwsProviderAutoscaler {
    expanders: string[];
    unneededTime?: string;
    unreadyTime?: string;
    utilizationThreshold?: number;
}

export interface Mk8sAwsProviderDeployRoleChain {
    externalId?: string;
    roleArn: string;
    sessionNamePrefix?: string;
}

export interface Mk8sAwsProviderImage {
    exact?: string;
    recommended?: string;
}

export interface Mk8sAwsProviderNetworking {
    podNetwork?: string;
    serviceNetwork?: string;
}

export interface Mk8sAwsProviderNodePool {
    bootDiskSize?: number;
    extraSecurityGroupIds?: string[];
    instanceTypes: string[];
    labels?: {[key: string]: string};
    maxSize?: number;
    minSize?: number;
    name: string;
    onDemandBaseCapacity?: number;
    onDemandPercentageAboveBaseCapacity?: number;
    overrideImage: outputs.Mk8sAwsProviderNodePoolOverrideImage;
    spotAllocationStrategy?: string;
    subnetIds: string[];
    taints?: outputs.Mk8sAwsProviderNodePoolTaint[];
}

export interface Mk8sAwsProviderNodePoolOverrideImage {
    exact?: string;
    recommended?: string;
}

export interface Mk8sAwsProviderNodePoolTaint {
    effect?: string;
    key?: string;
    value?: string;
}

export interface Mk8sDigitalOceanProvider {
    autoscaler?: outputs.Mk8sDigitalOceanProviderAutoscaler;
    digitalOceanTags?: string[];
    extraSshKeys?: string[];
    image: string;
    networking: outputs.Mk8sDigitalOceanProviderNetworking;
    nodePools?: outputs.Mk8sDigitalOceanProviderNodePool[];
    preInstallScript?: string;
    region: string;
    reservedIps?: string[];
    sshKeys: string[];
    tokenSecretLink: string;
    vpcId: string;
}

export interface Mk8sDigitalOceanProviderAutoscaler {
    expanders: string[];
    unneededTime?: string;
    unreadyTime?: string;
    utilizationThreshold?: number;
}

export interface Mk8sDigitalOceanProviderNetworking {
    podNetwork?: string;
    serviceNetwork?: string;
}

export interface Mk8sDigitalOceanProviderNodePool {
    dropletSize: string;
    labels?: {[key: string]: string};
    maxSize?: number;
    minSize?: number;
    name: string;
    overrideImage?: string;
    taints?: outputs.Mk8sDigitalOceanProviderNodePoolTaint[];
}

export interface Mk8sDigitalOceanProviderNodePoolTaint {
    effect?: string;
    key?: string;
    value?: string;
}

export interface Mk8sEphemeralProvider {
    location: string;
    nodePools?: outputs.Mk8sEphemeralProviderNodePool[];
}

export interface Mk8sEphemeralProviderNodePool {
    arch: string;
    count: number;
    cpu: string;
    flavor: string;
    labels?: {[key: string]: string};
    memory: string;
    name: string;
    taints?: outputs.Mk8sEphemeralProviderNodePoolTaint[];
}

export interface Mk8sEphemeralProviderNodePoolTaint {
    effect?: string;
    key?: string;
    value?: string;
}

export interface Mk8sFirewall {
    description?: string;
    sourceCidr: string;
}

export interface Mk8sGenericProvider {
    location: string;
    networking: outputs.Mk8sGenericProviderNetworking;
    nodePools?: outputs.Mk8sGenericProviderNodePool[];
}

export interface Mk8sGenericProviderNetworking {
    podNetwork?: string;
    serviceNetwork?: string;
}

export interface Mk8sGenericProviderNodePool {
    labels?: {[key: string]: string};
    name: string;
    taints?: outputs.Mk8sGenericProviderNodePoolTaint[];
}

export interface Mk8sGenericProviderNodePoolTaint {
    effect?: string;
    key?: string;
    value?: string;
}

export interface Mk8sHetznerProvider {
    autoscaler?: outputs.Mk8sHetznerProviderAutoscaler;
    dedicatedServerNodePools?: outputs.Mk8sHetznerProviderDedicatedServerNodePool[];
    firewallId?: string;
    floatingIpSelector?: {[key: string]: string};
    hetznerLabels?: {[key: string]: string};
    image?: string;
    networkId: string;
    networking: outputs.Mk8sHetznerProviderNetworking;
    nodePools?: outputs.Mk8sHetznerProviderNodePool[];
    preInstallScript?: string;
    region: string;
    sshKey?: string;
    tokenSecretLink: string;
}

export interface Mk8sHetznerProviderAutoscaler {
    expanders: string[];
    unneededTime?: string;
    unreadyTime?: string;
    utilizationThreshold?: number;
}

export interface Mk8sHetznerProviderDedicatedServerNodePool {
    labels?: {[key: string]: string};
    name: string;
    taints?: outputs.Mk8sHetznerProviderDedicatedServerNodePoolTaint[];
}

export interface Mk8sHetznerProviderDedicatedServerNodePoolTaint {
    effect?: string;
    key?: string;
    value?: string;
}

export interface Mk8sHetznerProviderNetworking {
    podNetwork?: string;
    serviceNetwork?: string;
}

export interface Mk8sHetznerProviderNodePool {
    labels?: {[key: string]: string};
    maxSize?: number;
    minSize?: number;
    name: string;
    overrideImage?: string;
    serverType: string;
    taints?: outputs.Mk8sHetznerProviderNodePoolTaint[];
}

export interface Mk8sHetznerProviderNodePoolTaint {
    effect?: string;
    key?: string;
    value?: string;
}

export interface Mk8sLambdalabsProvider {
    autoscaler?: outputs.Mk8sLambdalabsProviderAutoscaler;
    nodePools?: outputs.Mk8sLambdalabsProviderNodePool[];
    preInstallScript?: string;
    region: string;
    sshKey: string;
    tokenSecretLink: string;
    unmanagedNodePools?: outputs.Mk8sLambdalabsProviderUnmanagedNodePool[];
}

export interface Mk8sLambdalabsProviderAutoscaler {
    expanders: string[];
    unneededTime?: string;
    unreadyTime?: string;
    utilizationThreshold?: number;
}

export interface Mk8sLambdalabsProviderNodePool {
    instanceType: string;
    labels?: {[key: string]: string};
    maxSize?: number;
    minSize?: number;
    name: string;
    taints?: outputs.Mk8sLambdalabsProviderNodePoolTaint[];
}

export interface Mk8sLambdalabsProviderNodePoolTaint {
    effect?: string;
    key?: string;
    value?: string;
}

export interface Mk8sLambdalabsProviderUnmanagedNodePool {
    labels?: {[key: string]: string};
    name: string;
    taints?: outputs.Mk8sLambdalabsProviderUnmanagedNodePoolTaint[];
}

export interface Mk8sLambdalabsProviderUnmanagedNodePoolTaint {
    effect?: string;
    key?: string;
    value?: string;
}

export interface Mk8sLinodeProvider {
    authorizedKeys?: string[];
    authorizedUsers?: string[];
    autoscaler?: outputs.Mk8sLinodeProviderAutoscaler;
    firewallId?: string;
    image: string;
    networking: outputs.Mk8sLinodeProviderNetworking;
    nodePools?: outputs.Mk8sLinodeProviderNodePool[];
    preInstallScript?: string;
    region: string;
    tokenSecretLink: string;
    vpcId: string;
}

export interface Mk8sLinodeProviderAutoscaler {
    expanders: string[];
    unneededTime?: string;
    unreadyTime?: string;
    utilizationThreshold?: number;
}

export interface Mk8sLinodeProviderNetworking {
    podNetwork?: string;
    serviceNetwork?: string;
}

export interface Mk8sLinodeProviderNodePool {
    labels?: {[key: string]: string};
    maxSize?: number;
    minSize?: number;
    name: string;
    overrideImage?: string;
    serverType: string;
    subnetId: string;
    taints?: outputs.Mk8sLinodeProviderNodePoolTaint[];
}

export interface Mk8sLinodeProviderNodePoolTaint {
    effect?: string;
    key?: string;
    value?: string;
}

export interface Mk8sOblivusProvider {
    autoscaler?: outputs.Mk8sOblivusProviderAutoscaler;
    datacenter: string;
    nodePools?: outputs.Mk8sOblivusProviderNodePool[];
    preInstallScript?: string;
    sshKeys?: string[];
    tokenSecretLink: string;
    unmanagedNodePools?: outputs.Mk8sOblivusProviderUnmanagedNodePool[];
}

export interface Mk8sOblivusProviderAutoscaler {
    expanders: string[];
    unneededTime?: string;
    unreadyTime?: string;
    utilizationThreshold?: number;
}

export interface Mk8sOblivusProviderNodePool {
    flavor: string;
    labels?: {[key: string]: string};
    maxSize?: number;
    minSize?: number;
    name: string;
    taints?: outputs.Mk8sOblivusProviderNodePoolTaint[];
}

export interface Mk8sOblivusProviderNodePoolTaint {
    effect?: string;
    key?: string;
    value?: string;
}

export interface Mk8sOblivusProviderUnmanagedNodePool {
    labels?: {[key: string]: string};
    name: string;
    taints?: outputs.Mk8sOblivusProviderUnmanagedNodePoolTaint[];
}

export interface Mk8sOblivusProviderUnmanagedNodePoolTaint {
    effect?: string;
    key?: string;
    value?: string;
}

export interface Mk8sPaperspaceProvider {
    autoscaler?: outputs.Mk8sPaperspaceProviderAutoscaler;
    networkId: string;
    nodePools?: outputs.Mk8sPaperspaceProviderNodePool[];
    preInstallScript?: string;
    region: string;
    sharedDrives?: string[];
    tokenSecretLink: string;
    unmanagedNodePools?: outputs.Mk8sPaperspaceProviderUnmanagedNodePool[];
    userIds?: string[];
}

export interface Mk8sPaperspaceProviderAutoscaler {
    expanders: string[];
    unneededTime?: string;
    unreadyTime?: string;
    utilizationThreshold?: number;
}

export interface Mk8sPaperspaceProviderNodePool {
    bootDiskSize?: number;
    labels?: {[key: string]: string};
    machineType: string;
    maxSize?: number;
    minSize?: number;
    name: string;
    publicIpType: string;
    taints?: outputs.Mk8sPaperspaceProviderNodePoolTaint[];
}

export interface Mk8sPaperspaceProviderNodePoolTaint {
    effect?: string;
    key?: string;
    value?: string;
}

export interface Mk8sPaperspaceProviderUnmanagedNodePool {
    labels?: {[key: string]: string};
    name: string;
    taints?: outputs.Mk8sPaperspaceProviderUnmanagedNodePoolTaint[];
}

export interface Mk8sPaperspaceProviderUnmanagedNodePoolTaint {
    effect?: string;
    key?: string;
    value?: string;
}

export interface Mk8sStatus {
    addOns: outputs.Mk8sStatusAddOn[];
    homeLocation: string;
    oidcProviderUrl: string;
    serverUrl: string;
}

export interface Mk8sStatusAddOn {
    awsEcrs: outputs.Mk8sStatusAddOnAwsEcr[];
    awsEfs: outputs.Mk8sStatusAddOnAwsEf[];
    awsElbs: outputs.Mk8sStatusAddOnAwsElb[];
    awsWorkloadIdentities: outputs.Mk8sStatusAddOnAwsWorkloadIdentity[];
    dashboards: outputs.Mk8sStatusAddOnDashboard[];
    logs: outputs.Mk8sStatusAddOnLog[];
    metrics: outputs.Mk8sStatusAddOnMetric[];
}

export interface Mk8sStatusAddOnAwsEcr {
    trustPolicy: string;
}

export interface Mk8sStatusAddOnAwsEf {
    trustPolicy: string;
}

export interface Mk8sStatusAddOnAwsElb {
    trustPolicy: string;
}

export interface Mk8sStatusAddOnAwsWorkloadIdentity {
    oidcProviderConfigs: outputs.Mk8sStatusAddOnAwsWorkloadIdentityOidcProviderConfig[];
    trustPolicy: string;
}

export interface Mk8sStatusAddOnAwsWorkloadIdentityOidcProviderConfig {
    audience: string;
    providerUrl: string;
}

export interface Mk8sStatusAddOnDashboard {
    url: string;
}

export interface Mk8sStatusAddOnLog {
    lokiAddress: string;
}

export interface Mk8sStatusAddOnMetric {
    prometheusEndpoint: string;
    remoteWriteConfig: string;
}

export interface Mk8sTritonProvider {
    autoscaler?: outputs.Mk8sTritonProviderAutoscaler;
    connection: outputs.Mk8sTritonProviderConnection;
    firewallEnabled?: boolean;
    imageId: string;
    location: string;
    networking: outputs.Mk8sTritonProviderNetworking;
    nodePools?: outputs.Mk8sTritonProviderNodePool[];
    preInstallScript?: string;
    privateNetworkId: string;
    sshKeys?: string[];
}

export interface Mk8sTritonProviderAutoscaler {
    expanders: string[];
    unneededTime?: string;
    unreadyTime?: string;
    utilizationThreshold?: number;
}

export interface Mk8sTritonProviderConnection {
    account: string;
    privateKeySecretLink: string;
    url: string;
    user?: string;
}

export interface Mk8sTritonProviderNetworking {
    podNetwork?: string;
    serviceNetwork?: string;
}

export interface Mk8sTritonProviderNodePool {
    labels?: {[key: string]: string};
    maxSize?: number;
    minSize?: number;
    name: string;
    overrideImageId?: string;
    packageId: string;
    privateNetworkIds?: string[];
    publicNetworkId?: string;
    taints?: outputs.Mk8sTritonProviderNodePoolTaint[];
    tritonTags?: {[key: string]: string};
}

export interface Mk8sTritonProviderNodePoolTaint {
    effect?: string;
    key?: string;
    value?: string;
}

export interface OrgAuthConfig {
    domainAutoMembers: string[];
    samlOnly?: boolean;
}

export interface OrgLoggingCloudWatchLogging {
    credentials: string;
    extractFields?: {[key: string]: string};
    groupName: string;
    region: string;
    retentionDays?: number;
    streamName: string;
}

export interface OrgLoggingCoralogixLogging {
    app: string;
    cluster: string;
    credentials: string;
    subsystem: string;
}

export interface OrgLoggingDatadogLogging {
    credentials: string;
    host: string;
}

export interface OrgLoggingElasticLogging {
    aws?: outputs.OrgLoggingElasticLoggingAws;
    elasticCloud?: outputs.OrgLoggingElasticLoggingElasticCloud;
    generic?: outputs.OrgLoggingElasticLoggingGeneric;
}

export interface OrgLoggingElasticLoggingAws {
    credentials: string;
    host: string;
    index: string;
    port: number;
    region: string;
    type: string;
}

export interface OrgLoggingElasticLoggingElasticCloud {
    cloudId: string;
    credentials: string;
    index: string;
    type: string;
}

export interface OrgLoggingElasticLoggingGeneric {
    credentials: string;
    host: string;
    index: string;
    path: string;
    port: number;
    type: string;
}

export interface OrgLoggingFluentdLogging {
    host: string;
    port?: number;
}

export interface OrgLoggingLogzioLogging {
    credentials: string;
    listenerHost: string;
}

export interface OrgLoggingS3Logging {
    bucket: string;
    credentials: string;
    prefix?: string;
    region: string;
}

export interface OrgLoggingStackdriverLogging {
    credentials: string;
    location: string;
}

export interface OrgLoggingSyslogLogging {
    format?: string;
    host: string;
    mode?: string;
    port: number;
    severity?: number;
}

export interface OrgObservability {
    logsRetentionDays?: number;
    metricsRetentionDays?: number;
    tracesRetentionDays?: number;
}

export interface OrgSecurity {
    threatDetection?: outputs.OrgSecurityThreatDetection;
}

export interface OrgSecurityThreatDetection {
    enabled?: boolean;
    minimumSeverity?: string;
    syslog?: outputs.OrgSecurityThreatDetectionSyslog;
}

export interface OrgSecurityThreatDetectionSyslog {
    host?: string;
    port: number;
    transport?: string;
}

export interface OrgStatus {
    accountLink?: string;
    active?: boolean;
}

export interface OrgTracingControlplaneTracing {
    customTags?: {[key: string]: string};
    sampling: number;
}

export interface OrgTracingLightstepTracing {
    credentials?: string;
    customTags?: {[key: string]: string};
    endpoint: string;
    sampling: number;
}

export interface OrgTracingOtelTracing {
    customTags?: {[key: string]: string};
    endpoint: string;
    sampling: number;
}

export interface PolicyBinding {
    permissions: string[];
    principalLinks: string[];
}

export interface PolicyTargetQuery {
    fetch?: string;
    spec?: outputs.PolicyTargetQuerySpec;
}

export interface PolicyTargetQuerySpec {
    match?: string;
    terms?: outputs.PolicyTargetQuerySpecTerm[];
}

export interface PolicyTargetQuerySpecTerm {
    op?: string;
    property?: string;
    rel?: string;
    tag?: string;
    value?: string;
}

export interface SecretAws {
    accessKey: string;
    externalId?: string;
    roleArn?: string;
    secretKey: string;
}

export interface SecretAzureConnector {
    code: string;
    url: string;
}

export interface SecretEcr {
    accessKey: string;
    externalId?: string;
    repos: string[];
    roleArn?: string;
    secretKey: string;
}

export interface SecretKeypair {
    passphrase?: string;
    publicKey?: string;
    secretKey: string;
}

export interface SecretNatsAccount {
    accountId: string;
    privateKey: string;
}

export interface SecretOpaque {
    encoding?: string;
    payload: string;
}

export interface SecretTls {
    cert: string;
    chain?: string;
    key: string;
}

export interface SecretUserpass {
    encoding?: string;
    password: string;
    username: string;
}

export interface VolumeSetAutoscaling {
    maxCapacity: number;
    minFreePercentage: number;
    scalingFactor: number;
}

export interface VolumeSetSnapshots {
    createFinalSnapshot?: boolean;
    retentionDuration?: string;
    schedule?: string;
}

export interface VolumeSetStatus {
    bindingId: string;
    locations: string[];
    parentId: string;
    usedByWorkload: string;
}

export interface WorkloadContainer {
    args?: string[];
    command?: string;
    cpu?: string;
    env?: {[key: string]: string};
    gpuNvidia?: outputs.WorkloadContainerGpuNvidia;
    image: string;
    inheritEnv?: boolean;
    lifecycle?: outputs.WorkloadContainerLifecycle;
    livenessProbe?: outputs.WorkloadContainerLivenessProbe;
    memory?: string;
    metrics?: outputs.WorkloadContainerMetrics;
    minCpu?: string;
    minMemory?: string;
    name: string;
    /**
     * @deprecated The 'port' attribute will be deprecated in the next major version. Use the 'ports' attribute instead.
     */
    port?: number;
    ports?: outputs.WorkloadContainerPort[];
    readinessProbe?: outputs.WorkloadContainerReadinessProbe;
    volumes?: outputs.WorkloadContainerVolume[];
    workingDirectory?: string;
}

export interface WorkloadContainerGpuNvidia {
    model: string;
    quantity: number;
}

export interface WorkloadContainerLifecycle {
    postStart?: outputs.WorkloadContainerLifecyclePostStart;
    preStop?: outputs.WorkloadContainerLifecyclePreStop;
}

export interface WorkloadContainerLifecyclePostStart {
    exec: outputs.WorkloadContainerLifecyclePostStartExec;
}

export interface WorkloadContainerLifecyclePostStartExec {
    commands: string[];
}

export interface WorkloadContainerLifecyclePreStop {
    exec: outputs.WorkloadContainerLifecyclePreStopExec;
}

export interface WorkloadContainerLifecyclePreStopExec {
    commands: string[];
}

export interface WorkloadContainerLivenessProbe {
    exec?: outputs.WorkloadContainerLivenessProbeExec;
    failureThreshold?: number;
    grpc?: outputs.WorkloadContainerLivenessProbeGrpc;
    httpGet?: outputs.WorkloadContainerLivenessProbeHttpGet;
    initialDelaySeconds?: number;
    periodSeconds?: number;
    successThreshold?: number;
    tcpSocket?: outputs.WorkloadContainerLivenessProbeTcpSocket;
    timeoutSeconds?: number;
}

export interface WorkloadContainerLivenessProbeExec {
    commands: string[];
}

export interface WorkloadContainerLivenessProbeGrpc {
    port?: number;
}

export interface WorkloadContainerLivenessProbeHttpGet {
    httpHeaders?: {[key: string]: string};
    path?: string;
    port?: number;
    scheme?: string;
}

export interface WorkloadContainerLivenessProbeTcpSocket {
    port?: number;
}

export interface WorkloadContainerMetrics {
    path: string;
    port: number;
}

export interface WorkloadContainerPort {
    number: number;
    protocol?: string;
}

export interface WorkloadContainerReadinessProbe {
    exec?: outputs.WorkloadContainerReadinessProbeExec;
    failureThreshold?: number;
    grpc?: outputs.WorkloadContainerReadinessProbeGrpc;
    httpGet?: outputs.WorkloadContainerReadinessProbeHttpGet;
    initialDelaySeconds?: number;
    periodSeconds?: number;
    successThreshold?: number;
    tcpSocket?: outputs.WorkloadContainerReadinessProbeTcpSocket;
    timeoutSeconds?: number;
}

export interface WorkloadContainerReadinessProbeExec {
    commands: string[];
}

export interface WorkloadContainerReadinessProbeGrpc {
    port?: number;
}

export interface WorkloadContainerReadinessProbeHttpGet {
    httpHeaders?: {[key: string]: string};
    path?: string;
    port?: number;
    scheme?: string;
}

export interface WorkloadContainerReadinessProbeTcpSocket {
    port?: number;
}

export interface WorkloadContainerVolume {
    path: string;
    recoveryPolicy?: string;
    uri: string;
}

export interface WorkloadFirewallSpec {
    external?: outputs.WorkloadFirewallSpecExternal;
    internal?: outputs.WorkloadFirewallSpecInternal;
}

export interface WorkloadFirewallSpecExternal {
    inboundAllowCidrs?: string[];
    outboundAllowCidrs?: string[];
    outboundAllowHostnames?: string[];
    outboundAllowPorts?: outputs.WorkloadFirewallSpecExternalOutboundAllowPort[];
}

export interface WorkloadFirewallSpecExternalOutboundAllowPort {
    number: number;
    protocol: string;
}

export interface WorkloadFirewallSpecInternal {
    inboundAllowType?: string;
    inboundAllowWorkloads?: string[];
}

export interface WorkloadJob {
    activeDeadlineSeconds?: number;
    concurrencyPolicy?: string;
    historyLimit?: number;
    restartPolicy?: string;
    schedule: string;
}

export interface WorkloadLoadBalancer {
    direct?: outputs.WorkloadLoadBalancerDirect;
    geoLocation?: outputs.WorkloadLoadBalancerGeoLocation;
}

export interface WorkloadLoadBalancerDirect {
    enabled: boolean;
    ports?: outputs.WorkloadLoadBalancerDirectPort[];
}

export interface WorkloadLoadBalancerDirectPort {
    containerPort?: number;
    externalPort: number;
    protocol: string;
    scheme?: string;
}

export interface WorkloadLoadBalancerGeoLocation {
    enabled?: boolean;
    headers?: outputs.WorkloadLoadBalancerGeoLocationHeaders;
}

export interface WorkloadLoadBalancerGeoLocationHeaders {
    asn?: string;
    city?: string;
    country?: string;
    region?: string;
}

export interface WorkloadLocalOption {
    autoscaling?: outputs.WorkloadLocalOptionAutoscaling;
    capacityAi?: boolean;
    debug?: boolean;
    location: string;
    suspend?: boolean;
    timeoutSeconds?: number;
}

export interface WorkloadLocalOptionAutoscaling {
    maxConcurrency?: number;
    maxScale?: number;
    metric?: string;
    metricPercentile?: string;
    minScale?: number;
    scaleToZeroDelay?: number;
    target?: number;
}

export interface WorkloadOptions {
    autoscaling?: outputs.WorkloadOptionsAutoscaling;
    capacityAi?: boolean;
    debug?: boolean;
    suspend?: boolean;
    timeoutSeconds?: number;
}

export interface WorkloadOptionsAutoscaling {
    maxConcurrency?: number;
    maxScale?: number;
    metric?: string;
    metricPercentile?: string;
    minScale?: number;
    scaleToZeroDelay?: number;
    target?: number;
}

export interface WorkloadRolloutOptions {
    maxSurgeReplicas?: string;
    maxUnavailableReplicas?: string;
    minReadySeconds?: number;
    scalingPolicy?: string;
}

export interface WorkloadSecurityOptions {
    fileSystemGroupId?: number;
}

export interface WorkloadSidecar {
    envoy: string;
}

export interface WorkloadStatus {
    canonicalEndpoint?: string;
    currentReplicaCount?: number;
    endpoint?: string;
    healthChecks?: outputs.WorkloadStatusHealthCheck[];
    internalName?: string;
    loadBalancers?: outputs.WorkloadStatusLoadBalancer[];
    parentId?: string;
    resolvedImages?: outputs.WorkloadStatusResolvedImage[];
}

export interface WorkloadStatusHealthCheck {
    active: boolean;
    code?: number;
    failures?: number;
    lastChecked?: string;
    message?: string;
    success?: boolean;
    successes?: number;
}

export interface WorkloadStatusLoadBalancer {
    origin?: string;
    url?: string;
}

export interface WorkloadStatusResolvedImage {
    images?: outputs.WorkloadStatusResolvedImageImage[];
    resolvedAt?: string;
    resolvedForVersion?: number;
}

export interface WorkloadStatusResolvedImageImage {
    digest?: string;
    manifests?: outputs.WorkloadStatusResolvedImageImageManifest[];
}

export interface WorkloadStatusResolvedImageImageManifest {
    digest?: string;
    image?: string;
    mediaType?: string;
    platform?: {[key: string]: string};
}

