﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Common.Data.Properties {
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
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Common.Data.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Có Lỗi Xảy ra, vui lòng kiểm tra lại.
        /// </summary>
        public static string ErrorException {
            get {
                return ResourceManager.GetString("ErrorException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mã Khách Hàng không được trùng hoặc trống.
        /// </summary>
        public static string ErrorService_CustomerDupplicate {
            get {
                return ResourceManager.GetString("ErrorService_CustomerDupplicate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tên không được để trống.
        /// </summary>
        public static string ErrorService_CustomerName {
            get {
                return ResourceManager.GetString("ErrorService_CustomerName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Số điện thoại không được phép trống.
        /// </summary>
        public static string ErrorService_CustomerPhoneNumber {
            get {
                return ResourceManager.GetString("ErrorService_CustomerPhoneNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mã Khách Hàng Không Được Phép Trùng.
        /// </summary>
        public static string ErrorService_EmployeeDupplicate {
            get {
                return ResourceManager.GetString("ErrorService_EmployeeDupplicate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mã khách hàng bị trùng.
        /// </summary>
        public static string ErrService_DuplicatedCustomerCode {
            get {
                return ResourceManager.GetString("ErrService_DuplicatedCustomerCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Số điện thoại bị trùng.
        /// </summary>
        public static string ErrService_DuplicatedPhoneNumber {
            get {
                return ResourceManager.GetString("ErrService_DuplicatedPhoneNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mã Không tồn tại.
        /// </summary>
        public static string ErrService_ExistCustomerCode {
            get {
                return ResourceManager.GetString("ErrService_ExistCustomerCode", resourceCulture);
            }
        }
    }
}