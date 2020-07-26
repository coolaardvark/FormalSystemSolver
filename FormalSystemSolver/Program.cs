using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FormalSystemSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            var startString = "MU";
            var targetString = "MI";

            // Build, or load, rules
            var allRules = new List<Rule>();
            // For the moment, I'll just hard code these for the MU system
            // Dam I can't 'do' the I rule with just a regex, not sure how
            // do this now
            allRules.Add(new Rule(@"I\^", @"I\^"));
            // I can't do this rule either, need a completely new approch
            // here, I need a mini-language to descript the result string
            // it will likely invovle regex meta characters, but needs more
            // power than I can get from regex's alone
            allRules.Add(new Rule(@"M[M,U,I]*", "M([M,U,I]*)"));
            allRules.Add(new Rule(@"III", @"U"));
            allRules.Add(new Rule(@"UU", @""));
            // Maybe the second parameter in our rule is a reference
            // to a little function (in line) that returns the result?
            // Is this doable in CSharp and is it the right way to do it?

            // Indentify cadidates for rule application
            var applicableRules = findApplicableRules(allRules, startString);

            bool targetFound = false;
            while (!targetFound)
            {
                // Iterate through all candidates applying rules
                var workingString = "";

                // Store child strings

                // Do we have any matches for our target string
                // if so print results and exit
                if (workingString == targetString)
                {
                    Console.WriteLine("Found solution!");
                    targetFound = true;
                }
            }
        }

        static List<Rule> findApplicableRules(List<Rule> ruleSet, string source)
        {
            var applicableRules = new List<Rule>();


            return applicableRules;
        }

        static string applyRule(Rule rule, string source)
        {
            string result = "";

            return result;
        }
    }
}
