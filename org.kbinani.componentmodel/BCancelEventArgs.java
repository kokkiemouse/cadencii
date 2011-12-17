﻿package com.github.cadencii.componentmodel;

import org.kbinani.BEventArgs;

public class BCancelEventArgs extends BEventArgs{
    public boolean Cancel = false;

    public BCancelEventArgs( boolean value ){
        Cancel = value;
    }

    public BCancelEventArgs(){
        this( false );
    }
}