using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;
using System;
using System.IO;
using System.Collections.Generic;
using PL;

class Program{

    public static void Main(string[] args){
    
        try {

            string[] files = Directory.GetFiles(".", "*.cs");
            foreach(string file in files) {

                Console.WriteLine(file);
                var result = new List<CSharpTokenValue>();
                //Read the file
                string text = File.ReadAllText(file);

                //Create the lexer
                ICharStream inputStream = new AntlrInputStream(text);
                CSharpLexer lexer = new CSharpLexer(inputStream);

                //Create the token stream
                CommonTokenStream tokens = new CommonTokenStream(lexer);
                CSharpParser parser = new CSharpParser(tokens);
                IParseTree tree = parser.compilation_unit();

                //Walk the tree
                ParseTreeWalker walker = new ParseTreeWalker();
                walker.Walk(new ProgressPrinter(), tree);
            }

        }
        catch(Exception e) {
            Console.WriteLine("Error (Program.cs): " + e.ToString());
        }
    }
}