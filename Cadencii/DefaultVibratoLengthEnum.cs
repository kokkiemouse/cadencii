﻿/*
 * DefaultVibratoLength.cs
 * Copyright (c) 2008-2009 kbinani
 *
 * This file is part of Boare.Cadencii.
 *
 * Boare.Cadencii is free software; you can redistribute it and/or
 * modify it under the terms of the GPLv3 License.
 *
 * Boare.Cadencii is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 */
#if JAVA
package org.kbinani.cadencii;
#else
using System;

namespace org.kbinani.cadencii {
#endif

    public enum DefaultVibratoLengthEnum {
        L50,
        L66,
        L75,
        L100,
    }

#if !JAVA
}
#endif
