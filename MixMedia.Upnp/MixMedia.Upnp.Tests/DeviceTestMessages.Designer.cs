﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MixMedia.Upnp.Tests {
    using System;
    
    
    /// <summary>
    ///   Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    /// </summary>
    // Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    // -Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    // Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    // mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class DeviceTestMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DeviceTestMessages() {
        }
        
        /// <summary>
        ///   Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MixMedia.Upnp.Tests.DeviceTestMessages", typeof(DeviceTestMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        ///   Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die &lt;?xml version=&quot;1.0&quot;?&gt;&lt;root xmlns=&quot;urn:schemas-upnp-org:device-1-0&quot;&gt;   &lt;specVersion&gt;     &lt;major&gt;1&lt;/major&gt;     &lt;minor&gt;0&lt;/minor&gt;   &lt;/specVersion&gt;   &lt;URLBase&gt;base URL for all relative URLs&lt;/URLBase&gt;   &lt;device&gt;     &lt;deviceType&gt;urn:schemas-upnp-org:device:Basic:1&lt;/deviceType&gt;     &lt;friendlyName&gt;short user-friendly title&lt;/friendlyName&gt;     &lt;manufacturer&gt;manufacturer name&lt;/manufacturer&gt;     &lt;manufacturerURL&gt;URL to manufacturer site&lt;/manufacturerURL&gt;     &lt;modelDescription&gt;long user-friendly title&lt;/modelDescription&gt;   [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        internal static string BasicDevice {
            get {
                return ResourceManager.GetString("BasicDevice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die &lt;device&gt;&lt;/device&gt; ähnelt.
        /// </summary>
        internal static string EmptyDevice {
            get {
                return ResourceManager.GetString("EmptyDevice", resourceCulture);
            }
        }
    }
}