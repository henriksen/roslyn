﻿using System;
using System.Composition;
using System.Linq;
using Microsoft.CodeAnalysis.CodeRefactorings;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using Microsoft.CodeAnalysis.Editing;

namespace Microsoft.CodeAnalysis.CSharp.CodeRefactorings.ConvertToInterpolatedString
{
    [ExportCodeRefactoringProvider(LanguageNames.CSharp, Name = PredefinedCodeRefactoringProviderNames.ConvertToInterpolatedString), Shared]
    internal partial class ConvertToInterpolatedStringRefactoringProvider :
        AbstractConvertToInterpolatedStringRefactoringProvider <InvocationExpressionSyntax, ExpressionSyntax, ArgumentSyntax, LiteralExpressionSyntax>
    {
        protected override SyntaxNode GetInterpolatedString(string text) =>
            ParseExpression("$" + text) as InterpolatedStringExpressionSyntax;
    }
}
