﻿// -----------------------------------------------------------------------
// <copyright file="IStreamGeometryImpl.cs" company="Steven Kirk">
// Copyright 2014 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

namespace Perspex.Media
{
    public interface IStreamGeometryImpl : IGeometryImpl
    {
        IStreamGeometryContextImpl Open();
    }
}
