using System;
using System.Text.RegularExpressions;

namespace FormalSystemSolver
{
    public class Rule
    {
        public Regex Target { get; private set; }
        public Regex Result { get; private set; }

        public Rule(string target, string result)
        {
            Target = new Regex(target);
            Result = new Regex(result);
        }
    }
}
