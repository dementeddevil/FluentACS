﻿using FluentACS.Specs.Rules.Chaining;

namespace FluentACS.Specs.Rules
{
    public class InputClaimTypeSpec
    {
        private readonly RuleSpec owner;

        public InputClaimTypeSpec(RuleSpec owner)
        {
            this.owner = owner;
        }

        public IAfterAndInputClaimTypeRuleSpec IsAny()
        {
            this.owner.InputClaimType(BaseSpec.Any);
            return this.owner;
        }

        public IAfterAndInputClaimTypeRuleSpec IsOfType(string inputClaimType)
        {
            this.owner.InputClaimType(inputClaimType);
            return this.owner;
        }
    }
}