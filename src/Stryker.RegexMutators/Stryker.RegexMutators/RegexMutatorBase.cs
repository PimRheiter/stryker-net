﻿using RegexParser.Nodes;
using System.Collections.Generic;

namespace Stryker.RegexMutators
{
    /// <summary>
    /// Mutators can implement this class to check the type of the node and cast the node to the expected type.
    /// Implementing this class is not obligatory for mutators.
    /// </summary>
    /// <typeparam name="T">The type of RegexNode to cast to</typeparam>
    public abstract class RegexMutatorBase <T>
        where T : RegexNode
    {
        /// <summary>
        /// Apply the given mutations to a single RegexNode
        /// </summary>
        /// <param name="node">The node to mutate</param>
        /// <returns>One or more mutations</returns>
        public abstract IEnumerable<string> ApplyMutations(T node);
    }
}
