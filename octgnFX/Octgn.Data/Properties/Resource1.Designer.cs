﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Octgn.Data.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Octgn.Data.Properties.Resource1", typeof(Resource1).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parse error in binaryparser: .
        /// </summary>
        public static string BinaryParser_Parse_Parse_error_in_binaryparser__ {
            get {
                return ResourceManager.GetString("BinaryParser_Parse_Parse_error_in_binaryparser__", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client Disconnected..
        /// </summary>
        public static string Connection_Disconnect_Client_Disconnected_ {
            get {
                return ResourceManager.GetString("Connection_Disconnect_Client_Disconnected_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to begin transaction;
        ///
        ///CREATE TABLE [dbinfo] (
        ///  [version] INTEGER NOT NULL
        ///);
        ///
        ///INSERT INTO dbinfo([version]) VALUES(3);
        ///
        ///CREATE TABLE [games] (
        ///  [real_id] INTEGER PRIMARY KEY AUTOINCREMENT, 
        ///  [id] TEXT UNIQUE NOT NULL, 
        ///  [name] TEXT NOT NULL,
        ///  [filename] TEXT NOT NULL, 
        ///  [version] TEXT NOT NULL, 
        ///  [card_width] INTEGER, 
        ///  [card_height] INTEGER, 
        ///  [card_back] TEXT, 
        ///  [deck_sections] TEXT, 
        ///  [shared_deck_sections] TEXT,
        ///  [file_hash] TEXT);
        ///
        ///CREATE TABLE [sets] (
        ///  [real_id] INTEG [rest of string was truncated]&quot;;.
        /// </summary>
        public static string MakeDatabase {
            get {
                return ResourceManager.GetString("MakeDatabase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;updates&gt;
        ///  &lt;update from=&quot;1&quot; to=&quot;2&quot;&gt;
        ///    &lt;transaction&gt;
        ///      &lt;![CDATA[
        ///        UPDATE dbinfo SET version=2;
        ///      ]]&gt;
        ///    &lt;/transaction&gt;
        ///  &lt;/update&gt;
        ///  &lt;update from=&quot;2&quot; to=&quot;3&quot;&gt;
        ///    &lt;transaction&gt;
        ///      &lt;![CDATA[
        ///        ALTER TABLE cards ADD alternate TEXT DEFAULT &apos;00000000-0000-0000-0000-000000000000&apos;;
        ///        ALTER TABLE cards ADD dependent TEXT;
        ///        UPDATE dbinfo SET version=3;
        ///      ]]&gt;
        ///    &lt;/transaction&gt;
        ///  &lt;/update&gt;
        ///&lt;/updates&gt;.
        /// </summary>
        public static string UpdataDatabaseQueries {
            get {
                return ResourceManager.GetString("UpdataDatabaseQueries", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parse error in xmlparser: .
        /// </summary>
        public static string XmlParser_Parse_Parse_error_in_xmlparser__ {
            get {
                return ResourceManager.GetString("XmlParser_Parse_Parse_error_in_xmlparser__", resourceCulture);
            }
        }
    }
}
