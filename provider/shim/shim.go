package shim

import (
	provider "github.com/controlplane-com/terraform-provider-cpln/internal/provider"

	"github.com/hashicorp/terraform-plugin-sdk/v2/helper/schema"
)

func NewProvider() *schema.Provider {
	return provider.Provider()
}
