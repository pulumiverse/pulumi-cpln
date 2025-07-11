// Copyright 2016-2018, Pulumi Corporation.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

package cpln

import (
	"fmt"
	"path/filepath"

	// embed is used to embed the schema files in the provider
	_ "embed"

	providerShim "github.com/controlplane-com/terraform-provider-cpln/shim"

	pf "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/pf/tfbridge"
	"github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfbridge"
	"github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfbridge/tokens"
	shim "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfshim"
	"github.com/pulumi/pulumi/sdk/v3/go/common/resource"
	"github.com/pulumiverse/pulumi-cpln/provider/pkg/version"
)

// all of the token components used below.
const (
	// This variable controls the default name of the package in the package
	// registries for nodejs and python:
	mainPkg = "cpln"
	// modules:
	mainMod = "index" // the cpln module
)

//go:embed cmd/pulumi-resource-cpln/bridge-metadata.json
var metadata []byte

// preConfigureCallback is called before the providerConfigure function of the underlying provider.
// It should validate that the provider can be configured, and provide actionable errors in the case
// it cannot be. Configuration variables can be read from `vars` using the `stringValue` function -
// for example `stringValue(vars, "accessKey")`.
func preConfigureCallback(_ resource.PropertyMap, _ shim.ResourceConfig) error {
	return nil
}

// Provider returns additional overlaid schema and metadata associated with the provider..
func Provider() tfbridge.ProviderInfo {
	// Instantiate the Terraform provider
	p := pf.ShimProvider(providerShim.NewProvider())

	// Create a Pulumi provider mapping
	prov := tfbridge.ProviderInfo{
		P:    p,
		Name: "cpln",
		// DisplayName is a way to be able to change the casing of the provider
		// name when being displayed on the Pulumi registry
		DisplayName: "Control Plane",
		// The default publisher for all packages is Pulumi.
		// Change this to your personal name (or a company name) that you
		// would like to be shown in the Pulumi Registry if this package is published
		// there.
		Publisher: "pulumiverse",
		// LogoURL is optional but useful to help identify your package in the Pulumi Registry
		// if this package is published there.
		//
		// You may host a logo on a domain you control or add an SVG logo for your package
		// in your repository and use the raw content URL for that file as your logo URL.
		LogoURL: "https://raw.githubusercontent.com/pulumiverse/pulumi-cpln/main/docs/logo.png",
		// PluginDownloadURL is an optional URL used to download the Provider
		// for use in Pulumi programs
		// e.g https://github.com/org/pulumi-provider-name/releases/
		PluginDownloadURL: "github://api.github.com/pulumiverse",
		Description:       "A Pulumi package for creating and managing Control Plane (cpln) resources.",
		// category/cloud tag helps with categorizing the package in the Pulumi Registry.
		// For all available categories, see `Keywords` in
		// https://www.pulumi.com/docs/guides/pulumi-packages/schema/#package.
		Keywords:   []string{"pulumi", "cpln", "category/infrastructure"},
		License:    "Apache-2.0",
		Homepage:   "https://www.controlplane.com",
		Repository: "https://github.com/pulumiverse/pulumi-cpln",
		// The GitHub Org for the provider - defaults to `terraform-providers`. Note that this
		// should match the TF provider module's require directive, not any replace directives.
		GitHubOrg: "controlplane-com",
		Config:    map[string]*tfbridge.SchemaInfo{
			// Add any required configuration here, or remove the example below if
			// no additional points are required.
			// "region": {
			// 	Type: tfbridge.MakeType("region", "Region"),
			// 	Default: &tfbridge.DefaultInfo{
			// 		EnvVars: []string{"AWS_REGION", "AWS_DEFAULT_REGION"},
			// 	},
			// },
		},
		Version:              version.Version,
		PreConfigureCallback: preConfigureCallback,
		MetadataInfo:         tfbridge.NewProviderMetadata(metadata),
		Resources: map[string]*tfbridge.ResourceInfo{
			"cpln_agent":           {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Agent")},
			"cpln_audit_context":   {Tok: tfbridge.MakeResource(mainPkg, mainMod, "AuditContext")},
			"cpln_cloud_account":   {Tok: tfbridge.MakeResource(mainPkg, mainMod, "CloudAccount")},
			"cpln_custom_location": {Tok: tfbridge.MakeResource(mainPkg, mainMod, "CustomLocation")},
			"cpln_domain_route":    {Tok: tfbridge.MakeResource(mainPkg, mainMod, "DomainRoute")},
			"cpln_domain":          {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Domain")},
			"cpln_group":           {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Group")},
			"cpln_gvc":             {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Gvc")},
			"cpln_identity":        {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Identity")},
			"cpln_ipset":           {Tok: tfbridge.MakeResource(mainPkg, mainMod, "IpSet")},
			"cpln_location":        {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Location")},
			"cpln_mk8s":            {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Mk8s")},
			"cpln_mk8s_kubeconfig": {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Mk8sKubeconfig")},
			"cpln_org_logging":     {Tok: tfbridge.MakeResource(mainPkg, mainMod, "OrgLogging")},
			"cpln_org_tracing":     {Tok: tfbridge.MakeResource(mainPkg, mainMod, "OrgTracing")},
			"cpln_org":             {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Org")},
			"cpln_policy":          {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Policy")},
			"cpln_secret":          {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Secret")},
			"cpln_service_account": {Tok: tfbridge.MakeResource(mainPkg, mainMod, "ServiceAccount")},
			"cpln_service_account_key": {
				Tok: tfbridge.MakeResource(mainPkg, mainMod, "ServiceAccountKey"),
				ComputeID: tfbridge.DelegateIDField(
					resource.PropertyKey("name"),
					mainPkg, "https://github.com/pulumiverse/pulumi-cpln"),
			},
			"cpln_volume_set": {Tok: tfbridge.MakeResource(mainPkg, mainMod, "VolumeSet")},
			"cpln_workload":   {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Workload")},
		},
		DataSources: map[string]*tfbridge.DataSourceInfo{
			"cpln_cloud_account": {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getCloudAccount")},
			"cpln_gvc":           {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getGvc")},
			"cpln_image":         {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getImage")},
			"cpln_images":        {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getImages")},
			"cpln_location":      {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getLocation")},
			"cpln_locations":     {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getLocations")},
			"cpln_org":           {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getOrg")},
			"cpln_secret":        {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getSecret")},
		},
		JavaScript: &tfbridge.JavaScriptInfo{
			PackageName: "@pulumiverse/cpln",
			// List any npm dependencies and their versions
			Dependencies: map[string]string{
				"@pulumi/pulumi": "^3.0.0",
			},
			DevDependencies: map[string]string{
				"@types/node": "^10.0.0", // so we can access strongly typed node definitions.
				"@types/mime": "^2.0.0",
			},
			RespectSchemaVersion: true,
		},
		Python: &tfbridge.PythonInfo{
			PackageName: "pulumiverse_cpln",
			// List any Python dependencies and their version ranges
			Requires: map[string]string{
				"pulumi": ">=3.0.0,<4.0.0",
			},
			PyProject:            struct{ Enabled bool }{true},
			RespectSchemaVersion: true,
		},
		Golang: &tfbridge.GolangInfo{
			ImportBasePath: filepath.Join(
				fmt.Sprintf("github.com/pulumiverse/pulumi-%[1]s/sdk/", mainPkg),
				tfbridge.GetModuleMajorVersion(version.Version),
				"go",
				mainPkg,
			),
			GenerateResourceContainerTypes: true,
			RespectSchemaVersion:           true,
		},
		CSharp: &tfbridge.CSharpInfo{
			RootNamespace: "Pulumiverse",
			PackageReferences: map[string]string{
				"Pulumi": "3.*",
			},
			RespectSchemaVersion: true,
		},
	}

	// MustComputeTokens maps all resources and datasources from the upstream provider into Pulumi.
	//
	// tokens.SingleModule puts every upstream item into your provider's main module.
	//
	// You shouldn't need to override anything, but if you do, use the [tfbridge.ProviderInfo.Resources]
	// and [tfbridge.ProviderInfo.DataSources].
	prov.MustComputeTokens(tokens.SingleModule("cpln_", mainMod,
		tokens.MakeStandard(mainPkg)))

	prov.MustApplyAutoAliases()
	prov.SetAutonaming(255, "-")

	return prov
}
