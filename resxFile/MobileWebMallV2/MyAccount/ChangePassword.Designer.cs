﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NineYi.WebStore.Resources.MobileWebMallV2.MyAccount {
    using System;
    
    
    /// <summary>
    ///   用於查詢當地語系化字串等的強類型資源類別。
    /// </summary>
    // 這個類別是自動產生的，是利用 StronglyTypedResourceBuilder
    // 類別透過 ResGen 或 Visual Studio 這類工具。
    // 若要加入或移除成員，請編輯您的 .ResX 檔，然後重新執行 ResGen
    // (利用 /str 選項)，或重建您的 VS 專案。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ChangePassword {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ChangePassword() {
        }
        
        /// <summary>
        ///   傳回這個類別使用的快取的 ResourceManager 執行個體。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NineYi.WebStore.Resources.MobileWebMallV2.MyAccount.ChangePassword", typeof(ChangePassword).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   覆寫目前執行緒的 CurrentUICulture 屬性，對象是所有
        ///   使用這個強類型資源類別的資源查閱。
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
        ///   查詢類似 Change password 的當地語系化字串。
        /// </summary>
        public static string Pages_ChangePassword_ModifyPassWord {
            get {
                return ResourceManager.GetString("Pages_ChangePassword_ModifyPassWord", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 New password 的當地語系化字串。
        /// </summary>
        public static string Pages_ChangePassword_NewPassWord {
            get {
                return ResourceManager.GetString("Pages_ChangePassword_NewPassWord", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 Old password 的當地語系化字串。
        /// </summary>
        public static string Pages_ChangePassword_OriginalPassWord {
            get {
                return ResourceManager.GetString("Pages_ChangePassword_OriginalPassWord", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 Passwords must be between 6-20 characters in length 的當地語系化字串。
        /// </summary>
        public static string Pages_ChangePassword_PleaseSetPassWord {
            get {
                return ResourceManager.GetString("Pages_ChangePassword_PleaseSetPassWord", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 To log in with Facebook account, please modify in Facebook 的當地語系化字串。
        /// </summary>
        public static string Pages_ChangePassword_UseFaceBookLogin {
            get {
                return ResourceManager.GetString("Pages_ChangePassword_UseFaceBookLogin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查詢類似 To log in with official website account, please contact customer service 的當地語系化字串。
        /// </summary>
        public static string Pages_ChangePassword_UseOfficialLogin {
            get {
                return ResourceManager.GetString("Pages_ChangePassword_UseOfficialLogin", resourceCulture);
            }
        }
    }
}