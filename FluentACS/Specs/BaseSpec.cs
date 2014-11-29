using FluentACS.Commands;
using System.Collections.Generic;

namespace FluentACS.Specs
{

    public class BaseSpec
    {
        internal const string Any = "_ANY";

        internal const string Passthrough = "_PASSTHROUGH";

        internal const string Acs = "LOCAL AUTHORITY";

        public BaseSpec(List<ICommand> commands)
        {
            this.Commands = commands;
        }

        protected List<ICommand> Commands { get; private set; }
    }
}