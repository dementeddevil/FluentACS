using FluentACS.Specs.Rules.Chaining;

namespace FluentACS.Specs.Rules
{
	public class InputClaimValueSpec
	{
		private readonly RuleSpec owner;

		public InputClaimValueSpec(RuleSpec owner)
		{
			this.owner = owner;
		}

		public IAfterAndInputClaimValueRuleSpec IsAny()
		{
			this.owner.InputClaimValue(BaseSpec.Any);
			return this.owner;
		}

		public IAfterAndInputClaimValueRuleSpec Is(string inputClaimValue)
		{
			this.owner.InputClaimValue(inputClaimValue);
			return this.owner;
		}
	}
}