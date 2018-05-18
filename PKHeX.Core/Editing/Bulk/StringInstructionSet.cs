﻿using System.Collections.Generic;
using System.Linq;

namespace PKHeX.Core
{

    // Utility Methods

    public class StringInstructionSet
    {
        public IList<StringInstruction> Filters { get; private set; }
        public IList<StringInstruction> Instructions { get; private set; }

        private const string SetSeparator = ";";
        public static IEnumerable<StringInstructionSet> GetBatchSets(string[] lines)
        {
            int start = 0;
            while (start < lines.Length)
            {
                var list = lines.Skip(start).TakeWhile(_ => !lines[start++].StartsWith(SetSeparator)).ToList();
                yield return GetBatchSet(list);
            }
        }

        private static StringInstructionSet GetBatchSet(IList<string> set)
        {
            return new StringInstructionSet
            {
                Filters = StringInstruction.GetFilters(set).ToList(),
                Instructions = StringInstruction.GetInstructions(set).ToList(),
            };
        }
    }
}
