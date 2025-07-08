package shim

import (
	cpln "github.com/controlplane-com/terraform-provider-cpln/internal/provider"
	"github.com/hashicorp/terraform-plugin-framework/provider"
)

func NewProvider(version string) provider.Provider {
	return cpln.New(version)()
}
