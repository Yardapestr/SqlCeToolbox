﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ErikEJ.SqlCeToolbox.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.13.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DropTargetTables {
            get {
                return ((bool)(this["DropTargetTables"]));
            }
            set {
                this["DropTargetTables"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowBinaryValuesInResult {
            get {
                return ((bool)(this["ShowBinaryValuesInResult"]));
            }
            set {
                this["ShowBinaryValuesInResult"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowResultInGrid {
            get {
                return ((bool)(this["ShowResultInGrid"]));
            }
            set {
                this["ShowResultInGrid"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisplayDescriptionTable {
            get {
                return ((bool)(this["DisplayDescriptionTable"]));
            }
            set {
                this["DisplayDescriptionTable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IncludeSystemTablesInDocumentation {
            get {
                return ((bool)(this["IncludeSystemTablesInDocumentation"]));
            }
            set {
                this["IncludeSystemTablesInDocumentation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("200")]
        public int MaxRowsToEdit {
            get {
                return ((int)(this["MaxRowsToEdit"]));
            }
            set {
                this["MaxRowsToEdit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int MaxColumnWidth {
            get {
                return ((int)(this["MaxColumnWidth"]));
            }
            set {
                this["MaxColumnWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IgnoreIdentityInInsertScript {
            get {
                return ((bool)(this["IgnoreIdentityInInsertScript"]));
            }
            set {
                this["IgnoreIdentityInInsertScript"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool KeepServerSchemaNames {
            get {
                return ((bool)(this["KeepServerSchemaNames"]));
            }
            set {
                this["KeepServerSchemaNames"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MultiLineTextEntry {
            get {
                return ((bool)(this["MultiLineTextEntry"]));
            }
            set {
                this["MultiLineTextEntry"] = value;
            }
        }
    }
}
