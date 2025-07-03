package shim

import (
	cpln "github.com/controlplane-com/terraform-provider-cpln/internal/provider"
	"github.com/hashicorp/terraform-plugin-framework/provider"
)

func NewProvider() provider.Provider {
	version := "1.2.0"
	return cpln.New(version)()
}
