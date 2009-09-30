﻿/*
 * RgbColor.cs
 * Copyright (c) 2009 kbinani
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
using System.Drawing;

namespace Boare.Cadencii {

    public struct RgbColor {
        public int R;
        public int G;
        public int B;

        public RgbColor( int r, int g, int b ) {
            R = r;
            G = g;
            B = b;
        }

        public Color Color {
            get {
                return Color.FromArgb( R, G, B );
            }
        }
    }

}
