﻿/*
 * UtauVoiceDB.cs
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
using System;
using System.IO;
using System.Text;

using bocoree;

namespace Boare.Cadencii {

    public class UtauVoiceDB {
        private Vector<OtoArgs> m_configs = new Vector<OtoArgs>();

        public UtauVoiceDB( String oto_ini ) {
            if ( File.Exists( oto_ini ) ) {
                using ( StreamReader sr = new StreamReader( oto_ini, Encoding.GetEncoding( "Shift_JIS" ) ) ) {
                    String line;
                    while ( sr.Peek() >= 0 ) {
                        try {
                            line = sr.ReadLine();
                            String[] spl = line.Split( '=' );
                            String file_name = spl[0]; // あ.wav
                            String a2 = spl[1]; // ,0,36,64,0,0
                            String a1 = Path.GetFileNameWithoutExtension( file_name );
                            spl = a2.Split( ',' );
                            OtoArgs oa = new OtoArgs();
                            oa.fileName = file_name;
                            oa.Alias = spl[0];
                            oa.msOffset = int.Parse( spl[1] );
                            oa.msConsonant = int.Parse( spl[2] );
                            oa.msBlank = int.Parse( spl[3] );
                            oa.msPreUtterance = int.Parse( spl[4] );
                            oa.msOverlap = int.Parse( spl[5] );
                            m_configs.add( oa );
                        } catch {
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 指定した歌詞に合致する、エイリアスを考慮した原音設定を取得します
        /// </summary>
        /// <param name="lyric"></param>
        /// <returns></returns>
        public OtoArgs attachFileNameFromLyric( String lyric ) {
            int count = m_configs.size();
            for ( Iterator itr = m_configs.iterator(); itr.hasNext(); ) {
                OtoArgs item = (OtoArgs)itr.next();
                if ( Path.GetFileNameWithoutExtension( item.fileName ).Equals( lyric ) ) {
                    return item;
                }
                if ( item.Alias.Equals( lyric ) ) {
                    return item;
                }
            }
            return new OtoArgs();
        }
    }

}
