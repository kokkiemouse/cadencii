﻿/*
 * SelectedTimesigEntry.cs
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
using Boare.Lib.Vsq;

namespace Boare.Cadencii {

    public class SelectedTimesigEntry {
        public TimeSigTableEntry original;
        public TimeSigTableEntry editing;

        public SelectedTimesigEntry( TimeSigTableEntry original_, TimeSigTableEntry editing_ ) {
            original = original_;
            editing = editing_;
        }
    }

}