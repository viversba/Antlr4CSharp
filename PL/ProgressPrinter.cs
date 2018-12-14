using System;
using Antlr4.Runtime.Misc;

namespace PL {
    public class ProgressPrinter: CSharpParserBaseListener {


        public override void EnterUsing_directives([NotNull] CSharpParser.Using_directivesContext context) {
            base.EnterUsing_directives(context);
            string name = context.using_directive(0).GetText();
            Console.WriteLine(name);
        }
    }
}
