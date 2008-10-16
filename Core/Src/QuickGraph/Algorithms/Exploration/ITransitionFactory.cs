﻿using System;
using System.Collections.Generic;

namespace Topology.Graph.Algorithms.Exploration
{
    public interface ITransitionFactory<TVertex,TEdge>
        where TVertex : ICloneable
        where TEdge : IEdge<TVertex>
    {
        bool IsValid(TVertex v);
        IEnumerable<TEdge> Apply(TVertex source);
    }
}