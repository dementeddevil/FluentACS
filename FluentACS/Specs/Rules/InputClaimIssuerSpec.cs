using FluentACS.Specs.Rules.Chaining;

namespace FluentACS.Specs.Rules
{
	public class InputClaimIssuerSpec
	{
		private readonly RuleSpec owner;

		public InputClaimIssuerSpec(RuleSpec owner)
		{
			this.owner = owner;
		}

		public IAfterIfInputClaimIssuerRuleSpec Is(string inputClaimIssuer)
		{
			this.owner.IdentityProvider(inputClaimIssuer);
			return this.owner;
		}

		public IAfterIfInputClaimIssuerRuleSpec IsAcs()
		{
			this.owner.IdentityProvider(BaseSpec.Acs);
			return this.owner;
		}
	}
}