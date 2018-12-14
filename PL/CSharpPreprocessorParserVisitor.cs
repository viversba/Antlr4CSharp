//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from CSharpPreprocessorParser.g4 by ANTLR 4.7.1

// Unreachable code detected
//#pragma warning disable 0162
//// The variable '...' is assigned but its value is never used
//#pragma warning disable 0219
//// Missing XML comment for publicly visible type or member '...'
//#pragma warning disable 1591
//// Ambiguous reference in cref attribute
//#pragma warning disable 419

using System.Linq; 
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using PL;
using System.Collections.Generic;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="CSharpPreprocessorParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public interface ICSharpPreprocessorParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>preprocessorDeclaration</c>
	/// labeled alternative in <see cref="CSharpPreprocessorParser.preprocessor_directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPreprocessorDeclaration([NotNull] CSharpPreprocessorParser.PreprocessorDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>preprocessorConditional</c>
	/// labeled alternative in <see cref="CSharpPreprocessorParser.preprocessor_directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPreprocessorConditional([NotNull] CSharpPreprocessorParser.PreprocessorConditionalContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>preprocessorLine</c>
	/// labeled alternative in <see cref="CSharpPreprocessorParser.preprocessor_directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPreprocessorLine([NotNull] CSharpPreprocessorParser.PreprocessorLineContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>preprocessorDiagnostic</c>
	/// labeled alternative in <see cref="CSharpPreprocessorParser.preprocessor_directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPreprocessorDiagnostic([NotNull] CSharpPreprocessorParser.PreprocessorDiagnosticContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>preprocessorRegion</c>
	/// labeled alternative in <see cref="CSharpPreprocessorParser.preprocessor_directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPreprocessorRegion([NotNull] CSharpPreprocessorParser.PreprocessorRegionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>preprocessorPragma</c>
	/// labeled alternative in <see cref="CSharpPreprocessorParser.preprocessor_directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPreprocessorPragma([NotNull] CSharpPreprocessorParser.PreprocessorPragmaContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CSharpPreprocessorParser.directive_new_line_or_sharp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDirective_new_line_or_sharp([NotNull] CSharpPreprocessorParser.Directive_new_line_or_sharpContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="CSharpPreprocessorParser.preprocessor_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPreprocessor_expression([NotNull] CSharpPreprocessorParser.Preprocessor_expressionContext context);
}

public class CSharpPreprocessorParserVisitor : CSharpPreprocessorParserBaseVisitor<object> {
    public List<CSharpTokenValue> csharpValues = new List<CSharpTokenValue>();


    public override object VisitDirective_new_line_or_sharp(CSharpPreprocessorParser.Directive_new_line_or_sharpContext context) {

        var tokens = context.GetTokens(103).ToList();

        List<string> data = new List<string>();
        foreach (var token in tokens) {
            var stopIndex = token.Symbol.StopIndex;
            var outputText = string.Empty;

            for (int i = stopIndex + 1; i <= token.Symbol.InputStream.Size; i++) {
                if (token.Symbol.InputStream.GetText(new Interval(i, i)) == ";")
                    break;
                else
                    outputText += token.Symbol.InputStream.GetText(new Interval(i, i));
            }

            data.Add(outputText);
        }

        csharpValues.Add(new CSharpTokenValue { Token = tokens[0].GetText(), Value = new List<string>(data) });

        return csharpValues;
    }
}