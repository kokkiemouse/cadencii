﻿#if JAVA
//INCLUDE ..\BuildJavaUI\src\org\kbinani\windows\forms\BFileChooser.java
#else
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace bocoree.windows.forms {

    public class BFileChooser : IDisposable {
        public const int APPROVE_OPTION = 0;
        public const int CANCEL_OPTION = 1;
        public const int ERROR_OPTION = -1;

        private string m_current_directory = "";
        private List<string> m_filters = new List<string>();
        private OpenFileDialog m_open = new OpenFileDialog();
        private SaveFileDialog m_save = new SaveFileDialog();
        private string m_current_filter = "";
        private string m_selected_file = "";

        public BFileChooser( String currentDirectoryPath ) {
            m_current_directory = currentDirectoryPath;
        }

        public void addFileFilter( String filter ) {
            m_filters.Add( filter );
        }

        public String getFileFilter() {
            return m_current_filter;
        }

        public void setFileFilter( String value ) {
            m_current_filter = value;
        }

        public void clearChoosableFileFilter() {
            m_filters.Clear();
        }

        public string[] getChoosableFileFilter() {
            return m_filters.ToArray();
        }

        public String getSelectedFile() {
            return m_selected_file;
        }

        public void setSelectedFile( String value ) {
            m_selected_file = value;
            m_open.FileName = m_selected_file;
            m_save.FileName = m_selected_file;
        }

        public void setInitialDirectory( string value ) {
            m_open.InitialDirectory = value;
            m_save.InitialDirectory = value;
        }

        public int showOpenDialog( Control parent ) {
            m_open.InitialDirectory = m_current_directory;
            string filter = "";
            int count = 0;
            int selected = -1;
            foreach ( string f in m_filters ) {
                filter += (count == 0 ? "" : "|") + f;
                if ( f == m_current_filter ) {
                    selected = count;
                }
                count++;
            }
            m_open.Filter = filter;
            if ( selected >= 0 ) {
                m_open.FilterIndex = selected;
            }
            DialogResult dr = m_open.ShowDialog();
            m_selected_file = m_open.FileName;
            int filter_index = m_open.FilterIndex;
            if ( 0 <= filter_index && filter_index < m_filters.Count ) {
                m_current_filter = m_filters[filter_index];
            }
            if ( m_selected_file != "" ) {
                m_current_directory = Path.GetDirectoryName( m_selected_file );
            }
            if ( dr == DialogResult.OK ) {
                return APPROVE_OPTION;
            } else if ( dr == DialogResult.Cancel ) {
                return CANCEL_OPTION;
            } else {
                return ERROR_OPTION;
            }
        }

        public int showSaveDialog( Control parent ) {
            m_save.InitialDirectory = m_current_directory;
            string filter = "";
            int count = 0;
            int selected = -1;
            foreach ( string f in m_filters ) {
                filter += (count == 0 ? "" : "|") + f;
                if ( f == m_current_filter ) {
                    selected = count;
                }
                count++;
            }
            m_save.Filter = filter;
            if ( selected >= 0 ) {
                m_save.FilterIndex = selected;
            }
            DialogResult dr = m_save.ShowDialog();
            m_selected_file = m_save.FileName;
            int filter_index = m_save.FilterIndex;
            if ( 0 <= filter_index && filter_index < m_filters.Count ) {
                m_current_filter = m_filters[filter_index];
            }
            if ( m_selected_file != "" ) {
                m_current_directory = Path.GetDirectoryName( m_selected_file );
            }
            if ( dr == DialogResult.OK ) {
                return APPROVE_OPTION;
            } else if ( dr == DialogResult.Cancel ) {
                return CANCEL_OPTION;
            } else {
                return ERROR_OPTION;
            }
        }

        public void setDialogTitle( String value ) {
            m_open.Title = value;
            m_save.Title = value;
        }

        public void Dispose() {
            if ( m_open == null ) {
                m_open.Dispose();
            }
            if ( m_save == null ) {
                m_save.Dispose();
            }
        }
    }

}
#endif