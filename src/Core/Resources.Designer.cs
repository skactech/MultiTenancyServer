﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MultiTenancyServer {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MultiTenancyServer.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tenant {0} does not exist..
        /// </summary>
        internal static string CanonicalNameNotFoundFormat1 {
            get {
                return ResourceManager.GetString("CanonicalNameNotFoundFormat1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optimistic concurrency failure, object has been modified..
        /// </summary>
        internal static string ConcurrencyFailure {
            get {
                return ResourceManager.GetString("ConcurrencyFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unknown failure has occurred..
        /// </summary>
        internal static string DefaultError {
            get {
                return ResourceManager.GetString("DefaultError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Canonical name &apos;{0}&apos; is already taken..
        /// </summary>
        internal static string DuplicateCanonicalNameFormat1 {
            get {
                return ResourceManager.GetString("DuplicateCanonicalNameFormat1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Canonical name &apos;{0}&apos; is invalid, can only contain letters or digits..
        /// </summary>
        internal static string InvalidCanonicalNameFormat1 {
            get {
                return ResourceManager.GetString("InvalidCanonicalNameFormat1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type {0} must derive from {1}&lt;{2}&gt;..
        /// </summary>
        internal static string InvalidManagerTypeFormat3 {
            get {
                return ResourceManager.GetString("InvalidManagerTypeFormat3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AddMultiTenancy must be called on the service collection..
        /// </summary>
        internal static string MustCallAddMultiTenancy {
            get {
                return ResourceManager.GetString("MustCallAddMultiTenancy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Store does not implement IQueryableTenantStore&lt;TTenant&gt;..
        /// </summary>
        internal static string StoreNotIQueryableTenantStore {
            get {
                return ResourceManager.GetString("StoreNotIQueryableTenantStore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Store does not implement ITenantDomainStore&lt;TTenant&gt;..
        /// </summary>
        internal static string StoreNotITenantDomainStore {
            get {
                return ResourceManager.GetString("StoreNotITenantDomainStore", resourceCulture);
            }
        }
    }
}
