﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Topology.Geometries
{
    public interface IMultiLineString : IMultiCurve
    {
        IMultiLineString Reverse();
    }
}
