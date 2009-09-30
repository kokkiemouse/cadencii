﻿/*
 * FormMidiImExport.Designer.cs
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

namespace Boare.Cadencii {

    using boolean = System.Boolean;
    
    partial class FormMidiImExport {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose( boolean disposing ) {
            if ( disposing && (components != null) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.ListTrack = new System.Windows.Forms.ListView();
            this.columnTrack = new System.Windows.Forms.ColumnHeader();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.columnNumNotes = new System.Windows.Forms.ColumnHeader();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.btnUnckeckAll = new System.Windows.Forms.Button();
            this.chkBeat = new System.Windows.Forms.CheckBox();
            this.chkTempo = new System.Windows.Forms.CheckBox();
            this.chkNote = new System.Windows.Forms.CheckBox();
            this.chkLyric = new System.Windows.Forms.CheckBox();
            this.groupCommonOption = new System.Windows.Forms.GroupBox();
            this.chkMetaText = new System.Windows.Forms.CheckBox();
            this.chkPreMeasure = new System.Windows.Forms.CheckBox();
            this.chkExportVocaloidNrpn = new System.Windows.Forms.CheckBox();
            this.groupCommonOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point( 261, 423 );
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size( 75, 23 );
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point( 180, 423 );
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size( 75, 23 );
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // ListTrack
            // 
            this.ListTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ListTrack.CheckBoxes = true;
            this.ListTrack.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.columnTrack,
            this.columnName,
            this.columnNumNotes} );
            this.ListTrack.FullRowSelect = true;
            this.ListTrack.Location = new System.Drawing.Point( 12, 41 );
            this.ListTrack.Name = "ListTrack";
            this.ListTrack.Size = new System.Drawing.Size( 324, 282 );
            this.ListTrack.TabIndex = 6;
            this.ListTrack.UseCompatibleStateImageBehavior = false;
            this.ListTrack.View = System.Windows.Forms.View.Details;
            // 
            // columnTrack
            // 
            this.columnTrack.Text = "track";
            this.columnTrack.Width = 54;
            // 
            // columnName
            // 
            this.columnName.Text = "name";
            this.columnName.Width = 122;
            // 
            // columnNumNotes
            // 
            this.columnNumNotes.Text = "notes";
            this.columnNumNotes.Width = 126;
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.AutoSize = true;
            this.btnCheckAll.Location = new System.Drawing.Point( 12, 12 );
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size( 75, 23 );
            this.btnCheckAll.TabIndex = 7;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler( this.btnCheckAll_Click );
            // 
            // btnUnckeckAll
            // 
            this.btnUnckeckAll.AutoSize = true;
            this.btnUnckeckAll.Location = new System.Drawing.Point( 93, 12 );
            this.btnUnckeckAll.Name = "btnUnckeckAll";
            this.btnUnckeckAll.Size = new System.Drawing.Size( 77, 23 );
            this.btnUnckeckAll.TabIndex = 8;
            this.btnUnckeckAll.Text = "Uncheck All";
            this.btnUnckeckAll.UseVisualStyleBackColor = true;
            this.btnUnckeckAll.Click += new System.EventHandler( this.btnUnckeckAll_Click );
            // 
            // chkBeat
            // 
            this.chkBeat.AutoSize = true;
            this.chkBeat.Checked = true;
            this.chkBeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBeat.Location = new System.Drawing.Point( 81, 18 );
            this.chkBeat.Name = "chkBeat";
            this.chkBeat.Padding = new System.Windows.Forms.Padding( 5, 0, 5, 0 );
            this.chkBeat.Size = new System.Drawing.Size( 58, 16 );
            this.chkBeat.TabIndex = 9;
            this.chkBeat.Text = "Beat";
            this.chkBeat.UseVisualStyleBackColor = true;
            // 
            // chkTempo
            // 
            this.chkTempo.AutoSize = true;
            this.chkTempo.Checked = true;
            this.chkTempo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTempo.Location = new System.Drawing.Point( 10, 18 );
            this.chkTempo.Name = "chkTempo";
            this.chkTempo.Padding = new System.Windows.Forms.Padding( 5, 0, 5, 0 );
            this.chkTempo.Size = new System.Drawing.Size( 68, 16 );
            this.chkTempo.TabIndex = 10;
            this.chkTempo.Text = "Tempo";
            this.chkTempo.UseVisualStyleBackColor = true;
            // 
            // chkNote
            // 
            this.chkNote.AutoSize = true;
            this.chkNote.Checked = true;
            this.chkNote.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNote.Location = new System.Drawing.Point( 10, 40 );
            this.chkNote.Name = "chkNote";
            this.chkNote.Padding = new System.Windows.Forms.Padding( 5, 0, 5, 0 );
            this.chkNote.Size = new System.Drawing.Size( 58, 16 );
            this.chkNote.TabIndex = 11;
            this.chkNote.Text = "Note";
            this.chkNote.UseVisualStyleBackColor = true;
            this.chkNote.CheckedChanged += new System.EventHandler( this.chkNote_CheckedChanged );
            // 
            // chkLyric
            // 
            this.chkLyric.AutoSize = true;
            this.chkLyric.Checked = true;
            this.chkLyric.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLyric.Location = new System.Drawing.Point( 145, 18 );
            this.chkLyric.Name = "chkLyric";
            this.chkLyric.Padding = new System.Windows.Forms.Padding( 5, 0, 5, 0 );
            this.chkLyric.Size = new System.Drawing.Size( 65, 16 );
            this.chkLyric.TabIndex = 12;
            this.chkLyric.Text = "Lyrics";
            this.chkLyric.UseVisualStyleBackColor = true;
            // 
            // groupCommonOption
            // 
            this.groupCommonOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupCommonOption.Controls.Add( this.chkMetaText );
            this.groupCommonOption.Controls.Add( this.chkPreMeasure );
            this.groupCommonOption.Controls.Add( this.chkExportVocaloidNrpn );
            this.groupCommonOption.Controls.Add( this.chkLyric );
            this.groupCommonOption.Controls.Add( this.chkNote );
            this.groupCommonOption.Controls.Add( this.chkBeat );
            this.groupCommonOption.Controls.Add( this.chkTempo );
            this.groupCommonOption.Location = new System.Drawing.Point( 12, 329 );
            this.groupCommonOption.Name = "groupCommonOption";
            this.groupCommonOption.Size = new System.Drawing.Size( 324, 88 );
            this.groupCommonOption.TabIndex = 13;
            this.groupCommonOption.TabStop = false;
            this.groupCommonOption.Text = "Option";
            // 
            // chkMetaText
            // 
            this.chkMetaText.AutoSize = true;
            this.chkMetaText.Checked = true;
            this.chkMetaText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMetaText.Location = new System.Drawing.Point( 74, 40 );
            this.chkMetaText.Name = "chkMetaText";
            this.chkMetaText.Padding = new System.Windows.Forms.Padding( 5, 0, 5, 0 );
            this.chkMetaText.Size = new System.Drawing.Size( 131, 16 );
            this.chkMetaText.TabIndex = 16;
            this.chkMetaText.Text = "vocaloid meta-text";
            this.chkMetaText.UseVisualStyleBackColor = true;
            this.chkMetaText.Click += new System.EventHandler( this.chkMetaText_Click );
            // 
            // chkPreMeasure
            // 
            this.chkPreMeasure.AutoSize = true;
            this.chkPreMeasure.Checked = true;
            this.chkPreMeasure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPreMeasure.Location = new System.Drawing.Point( 127, 62 );
            this.chkPreMeasure.Name = "chkPreMeasure";
            this.chkPreMeasure.Padding = new System.Windows.Forms.Padding( 5, 0, 5, 0 );
            this.chkPreMeasure.Size = new System.Drawing.Size( 160, 16 );
            this.chkPreMeasure.TabIndex = 15;
            this.chkPreMeasure.Text = "Export pre-measure part";
            this.chkPreMeasure.UseVisualStyleBackColor = true;
            // 
            // chkExportVocaloidNrpn
            // 
            this.chkExportVocaloidNrpn.AutoSize = true;
            this.chkExportVocaloidNrpn.Checked = true;
            this.chkExportVocaloidNrpn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExportVocaloidNrpn.Location = new System.Drawing.Point( 10, 62 );
            this.chkExportVocaloidNrpn.Name = "chkExportVocaloidNrpn";
            this.chkExportVocaloidNrpn.Padding = new System.Windows.Forms.Padding( 5, 0, 5, 0 );
            this.chkExportVocaloidNrpn.Size = new System.Drawing.Size( 111, 16 );
            this.chkExportVocaloidNrpn.TabIndex = 14;
            this.chkExportVocaloidNrpn.Text = "vocaloid NRPN";
            this.chkExportVocaloidNrpn.UseVisualStyleBackColor = true;
            this.chkExportVocaloidNrpn.CheckedChanged += new System.EventHandler( this.chkExportVocaloidNrpn_CheckedChanged );
            // 
            // FormMidiImExport
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 12F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size( 348, 458 );
            this.Controls.Add( this.groupCommonOption );
            this.Controls.Add( this.btnUnckeckAll );
            this.Controls.Add( this.btnCheckAll );
            this.Controls.Add( this.ListTrack );
            this.Controls.Add( this.btnCancel );
            this.Controls.Add( this.btnOK );
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMidiImExport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormMidiInExport";
            this.groupCommonOption.ResumeLayout( false );
            this.groupCommonOption.PerformLayout();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ColumnHeader columnTrack;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnNumNotes;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button btnUnckeckAll;
        private System.Windows.Forms.CheckBox chkBeat;
        private System.Windows.Forms.CheckBox chkTempo;
        private System.Windows.Forms.CheckBox chkNote;
        private System.Windows.Forms.CheckBox chkLyric;
        private System.Windows.Forms.GroupBox groupCommonOption;
        private System.Windows.Forms.CheckBox chkExportVocaloidNrpn;
        public System.Windows.Forms.ListView ListTrack;
        private System.Windows.Forms.CheckBox chkPreMeasure;
        private System.Windows.Forms.CheckBox chkMetaText;

    }
}