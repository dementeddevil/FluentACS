﻿using FluentACS.Specs.Rules.Chaining;

namespace FluentACS.Specs.Rules
{
	public class OutputClaimTypeSpec
	{
		private readonly RuleSpec owner;

		public OutputClaimTypeSpec(RuleSpec owner)
		{
			this.owner = owner;
		}

		public IAfterThenOutputClaimTypeRuleSpec ShouldPassthroughFirstInputClaimType()
		{
			this.owner.OutputClaimType(BaseSpec.Passthrough);
			return this.owner;
		}

		public IAfterThenOutputClaimTypeRuleSpec ShouldBe(string outputClaimType)
		{
			this.owner.OutputClaimType(outputClaimType);
			return this.owner;
		}
	}
}