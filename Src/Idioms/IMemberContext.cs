﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ploeh.AutoFixture.Idioms
{
    public interface IMemberContext
    {
        void VerifyBoundaries(IBoundaryConvention convention);
    }
}