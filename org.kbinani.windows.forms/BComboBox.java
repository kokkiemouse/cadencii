﻿package com.github.cadencii.windows.forms;

import java.awt.event.ItemEvent;
import java.awt.event.ItemListener;
import javax.swing.JComboBox;
import org.kbinani.BEvent;
import org.kbinani.BEventArgs;
import org.kbinani.BEventHandler;

public class BComboBox extends JComboBox implements ItemListener{
    private static final long serialVersionUID = -7617550549292777417L;
    public final BEvent<BEventHandler> selectedIndexChangedEvent = new BEvent<BEventHandler>();

    public BComboBox()
    {
        super();
        addItemListener( this );
    }
    
    public void itemStateChanged( ItemEvent e )
    {
        try{
            selectedIndexChangedEvent.raise( this, new BEventArgs() );
        }catch( Exception ex ){
            System.err.println( "BComboBox#itemStateChanged; ex=" + ex );
        }
    }
}