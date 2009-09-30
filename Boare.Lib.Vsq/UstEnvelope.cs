﻿/*
 * UstEnvelope.cs
 * Copyright (c) 2009 kbinani
 *
 * This file is part of Boare.Lib.Vsq.
 *
 * Boare.Lib.Vsq is free software; you can redistribute it and/or
 * modify it under the terms of the BSD License.
 *
 * Boare.Lib.Vsq is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 */
using System;

using bocoree;

namespace Boare.Lib.Vsq {

    [Serializable]
    public class UstEnvelope : ICloneable {
        public int p1 = 0;
        public int p2 = 5;
        public int p3 = 35;
        public int v1 = 0;
        public int v2 = 100;
        public int v3 = 100;
        public int v4 = 0;
        //public String Separator = "";
        public int p4 = 0;
        public int p5 = 0;
        public int v5 = 100;

        public UstEnvelope() {
        }

        public UstEnvelope( String line ) {
            if ( line.ToLower().StartsWith( "envelope=" ) ) {
                String[] spl = line.Split( '=' );
                spl = spl[1].Split( ',' );
                if ( spl.Length < 7 ) {
                    return;
                }
                //Separator = "";
                p1 = int.Parse( spl[0] );
                p2 = int.Parse( spl[1] );
                p3 = int.Parse( spl[2] );
                v1 = int.Parse( spl[3] );
                v2 = int.Parse( spl[4] );
                v3 = int.Parse( spl[5] );
                v4 = int.Parse( spl[6] );
                if ( spl.Length == 11 ) {
                    //Separator = "%";
                    p4 = int.Parse( spl[8] );
                    p5 = int.Parse( spl[9] );
                    v5 = int.Parse( spl[10] );
                }
            }
        }

        public object Clone() {
            return new UstEnvelope( ToString() );
        }

        public override String ToString() {
            String ret = "Envelope=" + p1 + "," + p2 + "," + p3 + "," + v1 + "," + v2 + "," + v3 + "," + v4;
            ret += ",%," + p4 + "," + p5 + "," + v5;
            return ret;
        }

        public int getCount() {
            //if ( Separator == "%" ) {
                return 5;
            //} else {
                //return 4;
            //}
        }
    }

}