﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18213
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lw.ComponentModel.DataAnnotations {
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
    public class LwComponentModelDataAnnotationsMessagesResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LwComponentModelDataAnnotationsMessagesResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Lw.ComponentModel.DataAnnotations.LwComponentModelDataAnnotationsMessagesResource" +
                            "s", typeof(LwComponentModelDataAnnotationsMessagesResources).Assembly);
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
        ///   Looks up a localized string similar to &apos;{0}&apos;.
        /// </summary>
        public static string ErrorMessageMaximumLengthError {
            get {
                return ResourceManager.GetString("ErrorMessageMaximumLengthError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos;.
        /// </summary>
        public static string ErrorMessageMinimumLengthError {
            get {
                return ResourceManager.GetString("ErrorMessageMinimumLengthError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Properties are not equal. The validated property has value of &apos;{1}&apos;. Property &apos;{2}&apos; has value of &apos;{4}&apos;..
        /// </summary>
        public static string ErrorMessagePropertyCompareError {
            get {
                return ResourceManager.GetString("ErrorMessagePropertyCompareError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos;.
        /// </summary>
        public static string ErrorMessageValidationError {
            get {
                return ResourceManager.GetString("ErrorMessageValidationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The member&apos;s value must match pattern &apos;{0}&apos;. Yours is &apos;{1}&apos;..
        /// </summary>
        public static string ErrorMessageValueRangeError {
            get {
                return ResourceManager.GetString("ErrorMessageValueRangeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The member is required to have a value. Yours does not..
        /// </summary>
        public static string ErrorMessageValueRequiredError {
            get {
                return ResourceManager.GetString("ErrorMessageValueRequiredError", resourceCulture);
            }
        }
    }
}
