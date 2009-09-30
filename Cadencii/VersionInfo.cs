﻿/*
 * VersionInfo.cs
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
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using Boare.Lib.AppUtil;

namespace Boare.Cadencii {

    using boolean = System.Boolean;

    public partial class VersionInfo : Form {
        DateTime m_scroll_started;
        private AuthorListEntry[] m_credit;
        const float m_speed = 35f;
        String m_version;
        boolean m_credit_mode = false;
        float m_last_t = 0f;
        float m_last_speed = 0f;
        float m_shift = 0f;
        int m_button_width_about = 75;
        int m_button_width_credit = 75;
        Bitmap m_scroll;
        const int m_height = 380;
        readonly Color m_background = Color.White;
        private String m_app_name = "";
        private Color m_app_name_color = Color.Black;
        private Color m_version_color = Color.FromArgb( 105, 105, 105 );
        private boolean m_shadow_enablde = false;

        public VersionInfo( String app_name, String version ) {
            m_version = version;
            m_app_name = app_name;
            InitializeComponent();
            ApplyLanguage();

            this.SetStyle( ControlStyles.DoubleBuffer, true );
            this.SetStyle( ControlStyles.UserPaint, true );
            this.SetStyle( ControlStyles.AllPaintingInWmPaint, true );

            m_credit = new AuthorListEntry[] { };
            btnSaveAuthorList.Visible = false;
            lblVstLogo.ForeColor = m_version_color;
            lblStraightAcknowledgement.ForeColor = m_version_color;
#if DEBUG
            GenerateAuthorList();
            btnSaveAuthorList.Visible = true;
            btnSaveAuthorList.Click += new EventHandler( btnSaveAuthorList_Click );
#endif
        }

        public void ApplyLanguage() {
            String about = String.Format( _( "About {0}" ), m_app_name );
            String credit = _( "Credit" );
            Size size1 = Misc.MeasureString( about, btnFlip.Font );
            Size size2 = Misc.MeasureString( credit, btnFlip.Font );
            m_button_width_about = Math.Max( 75, (int)(size1.Width * 1.3) );
            m_button_width_credit = Math.Max( 75, (int)(size2.Width * 1.3) );
            if ( m_credit_mode ) {
                btnFlip.Width = m_button_width_about;
                btnFlip.Text = about;
            } else {
                btnFlip.Width = m_button_width_credit;
                btnFlip.Text = credit;
            }
            this.Text = about;
        }

        public boolean SaveAuthorListVisible {
            set {
                btnSaveAuthorList.Visible = value;
            }
        }

        public static String _( String s ) {
            return Messaging.GetMessage( s );
        }

        /// <summary>
        /// バージョン番号表示の文字色を取得または設定します
        /// </summary>
        public Color VersionColor {
            get {
                return m_version_color;
            }
            set {
                m_version_color = value;
                lblVstLogo.ForeColor = value;
                lblStraightAcknowledgement.ForeColor = value;
            }
        }
        
        /// <summary>
        /// アプリケーション名表示の文字色を取得または設定します
        /// </summary>
        public Color AppNameColor {
            get {
                return m_app_name_color;
            }
            set {
                m_app_name_color = value;
            }
        }

        public Bitmap Credit {
            set {
                m_scroll = value;
            }
        }

        public String AppName {
            get {
                return m_app_name;
            }
            set {
                m_app_name = value;
            }
        }

        public AuthorListEntry[] AuthorList {
            set {
                m_credit = value;
#if DEBUG
                GenerateAuthorList();
#endif
            }
        }

        private void GenerateAuthorList() {
            const float shadow_shift = 2f;
            const String font_name = "Arial";
            const int font_size = 10;
            Font font = new Font( font_name, font_size );
            Size size = Boare.Lib.AppUtil.Misc.MeasureString( "the quick brown fox jumped over the lazy dogs. THE QUICK BROWN FOX JUMPED OVER THE LAZY DOGS. 0123456789", font );
            float width = this.Width;
            float height = size.Height;
            StringFormat sf = new StringFormat();
            m_scroll = new Bitmap( (int)width, (int)(40f + m_credit.Length * height * 1.1f) );
            using ( Graphics g = Graphics.FromImage( m_scroll ) ) {
                sf.Alignment = StringAlignment.Center;
                if ( m_shadow_enablde ) {
                    g.DrawString( m_app_name,
                                  new Font( font_name, (int)(font_size * 1.1f), FontStyle.Bold ),
                                  new SolidBrush( Color.FromArgb( 40, Color.Black ) ),
                                  new RectangleF( shadow_shift, shadow_shift, width, height ),
                                  sf );
                }
                g.DrawString( m_app_name,
                              new Font( font_name, (int)(font_size * 1.1f), FontStyle.Bold ),
                              Brushes.Black,
                              new RectangleF( 0f, 0f, width, height ),
                              sf );
                for ( int i = 0; i < m_credit.Length; i++ ) {
                    if ( m_shadow_enablde ) {
                        g.DrawString( m_credit[i].Name,
                                      new Font( font_name, font_size, m_credit[i].Style ),
                                      new SolidBrush( Color.FromArgb( 40, Color.Black ) ),
                                      new RectangleF( 0f + shadow_shift, 40f + i * height * 1.1f + shadow_shift, width, height ),
                                      sf );
                    }
                    g.DrawString( m_credit[i].Name,
                                  new Font( font_name, font_size, m_credit[i].Style ),
                                  Brushes.Black,
                                  new RectangleF( 0f, 40f + i * height * 1.1f, width, height ),
                                  sf );
                }
            }
        }

        void btnSaveAuthorList_Click( object sender, EventArgs e ) {
#if DEBUG
            using ( SaveFileDialog dlg = new SaveFileDialog() ){
                if( dlg.ShowDialog() == DialogResult.OK ){
                    m_scroll.Save( dlg.FileName, System.Drawing.Imaging.ImageFormat.Png );
                }
            }
#endif
        }

        private void btnOK_Click( object sender, EventArgs e ) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        
        private void btnFlip_Click( object sender, EventArgs e ) {
            m_credit_mode = !m_credit_mode;
            if ( m_credit_mode ) {
                btnFlip.Width = m_button_width_about;
                btnFlip.Text = String.Format( _( "About {0}" ), m_app_name );
                m_scroll_started = DateTime.Now;
                m_last_speed = 0f;
                m_last_t = 0f;
                m_shift = 0f;
                pictVstLogo.Visible = false;
                lblVstLogo.Visible = false;
                lblStraightAcknowledgement.Visible = false;
                timer.Enabled = true;
            } else {
                timer.Enabled = false;
                btnFlip.Width = m_button_width_credit;
                btnFlip.Text = _( "Credit" );
                pictVstLogo.Visible = true;
                lblVstLogo.Visible = true;
                lblStraightAcknowledgement.Visible = true;
            }
            this.Invalidate();
        }

        private void timer_Tick( object sender, EventArgs e ) {
            this.Invalidate();
        }
        
        private void VersionInfoEx_Paint( object sender, PaintEventArgs e ) {
            try {
                Graphics g = e.Graphics;
                g.Clip = new Region( new Rectangle( 0, 0, this.Width, m_height ) );
                g.Clear( m_background );
                if ( m_credit_mode ) {
                    float times = (float)(((DateTime.Now).Subtract( m_scroll_started )).TotalSeconds) - 3f;
                    float speed = (float)((2.0 - bocoree.math.erfcc( times * 0.8 )) / 2.0) * m_speed;
                    float dt = times - m_last_t;
                    m_shift += (speed + m_last_speed) * dt / 2f;
                    m_last_t = times;
                    m_last_speed = speed;
                    float dx = (this.Width - m_scroll.Width) * 0.5f;
                    if ( m_scroll != null ) {
                        g.DrawImage( m_scroll,
                                     dx, 90f - m_shift,
                                     m_scroll.Width, m_scroll.Height );
                        if ( 90f - m_shift + m_scroll.Height < 0 ) {
                            m_shift = -m_height * 1.5f;
                        }
                    }
                    int grad_height = 60;
                    Rectangle top = new Rectangle( 0, 0, this.Width, grad_height );
                    using ( LinearGradientBrush lgb = new LinearGradientBrush( top, Color.White, Color.Transparent, LinearGradientMode.Vertical ) ) {
                        g.FillRectangle( lgb, top );
                    }
                    Rectangle bottom = new Rectangle( 0, m_height - grad_height, this.Width, grad_height );
                    g.Clip = new Region( new Rectangle( 0, m_height - grad_height + 1, this.Width, grad_height - 1 ) );
                    using ( LinearGradientBrush lgb = new LinearGradientBrush( bottom, Color.Transparent, Color.White, LinearGradientMode.Vertical ) ) {
                        g.FillRectangle( lgb, bottom );
                    }
                    g.ResetClip();
                } else {
                    StringFormat sf = new StringFormat();
                    Size size = this.ClientSize;
                    g.DrawString(
                        m_app_name,
                        new Font( "Century Gorhic", 24, FontStyle.Bold ),
                        new SolidBrush( m_app_name_color ),
                        new RectangleF( 20, 60, size.Width - 20, size.Height ),
                        sf );
                    g.DrawString(
                        "version " + m_version,
                        new Font( "Arial", 10 ),
                        new SolidBrush( m_version_color ),
                        new RectangleF( 25, 100,size.Width - 25, size.Height ),
                        sf );
                }
            } catch ( Exception ex ) {
#if DEBUG
                Console.WriteLine( "VersionInfoEx_Paint" );
                Console.WriteLine( ex.StackTrace );
#endif
            }
        }

        private void VersionInfoEx_KeyDown( object sender, KeyEventArgs e ) {
            if ( (e.KeyCode & Keys.Escape) == Keys.Escape ) {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void VersionInfoEx_FontChanged( object sender, EventArgs e ) {
            Font font = this.Font;
            for ( int i = 0; i < this.Controls.Count; i++ ) {
                Misc.ApplyFontRecurse( this.Controls[i], font );
            }
        }
    }

}
