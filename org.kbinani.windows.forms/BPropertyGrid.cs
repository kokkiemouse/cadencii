/* -京-
 * BPropertyGrid.cs
 * Copyright © 2011 kbinani
 *
 *
 * This file is part of org.kbinani.windows.forms.
 *
 * org.kbinani.windows.forms is free software; you can redistribute it and/or
 * modify it under the terms of the BSD License.
 *
 * org.kbinani.windows.forms is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 */
#if JAVA
//INCLUDE ./BPropertyGrid.java
#else
using System;
using System.Windows.Forms;

namespace cadencii.windows.forms {

    public class BPropertyGrid : PropertyGrid  {
        public object[] getSelectedObjects() {
            return base.SelectedObjects;
        }

        public void setSelectedObjects( object[] value ) {
            base.SelectedObjects = value;
        }
    }

}
#endif
