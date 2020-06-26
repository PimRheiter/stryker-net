﻿using RegexParser.Nodes;
using RegexParser.Nodes.AnchorNodes;
using System.Collections.Generic;

namespace Stryker.RegexMutators.Mutators
{
    public class AnchorRemovalMutator : RegexMutatorBase<AnchorNode>, IRegexMutator
    {
        public AnchorRemovalMutator(RegexNode root)
            : base(root)
        {
        }

        public override IEnumerable<RegexMutation> ApplyMutations(AnchorNode node)
        {
            yield return AnchorRemoval(node);
        }

        private RegexMutation AnchorRemoval(AnchorNode node)
        {
            var span = node.GetSpan();
            return new RegexMutation
            {
                OriginalNode = node,
                DisplayName = "Regex anchor removal mutation",
                Description = $"Anchor \"{Root.ToString().Substring(span.Start, span.Length)}\" was removed at offset {span.Start}.",
                ReplacementPattern = Root.RemoveNode(node).ToString()
            };
        }
    }
}
