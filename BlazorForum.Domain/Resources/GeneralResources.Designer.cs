﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlazorForum.Domain.Resources {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class GeneralResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal GeneralResources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BlazorForum.Domain.Resources.GeneralResources", typeof(GeneralResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性
        ///   重写当前线程的 CurrentUICulture 属性。
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
        ///   查找类似 发表 的本地化字符串。
        /// </summary>
        public static string AddPostBtnText {
            get {
                return ResourceManager.GetString("AddPostBtnText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Posting... 的本地化字符串。
        /// </summary>
        public static string BtnPostingText {
            get {
                return ResourceManager.GetString("BtnPostingText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 取消 的本地化字符串。
        /// </summary>
        public static string CancelBtnText {
            get {
                return ResourceManager.GetString("CancelBtnText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 创建一个新话题 的本地化字符串。
        /// </summary>
        public static string CreateNewTopic {
            get {
                return ResourceManager.GetString("CreateNewTopic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Loading... 的本地化字符串。
        /// </summary>
        public static string Loading {
            get {
                return ResourceManager.GetString("Loading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Load More 的本地化字符串。
        /// </summary>
        public static string LoadMore {
            get {
                return ResourceManager.GetString("LoadMore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 你必须登录来创建新话题 的本地化字符串。
        /// </summary>
        public static string LoginToPostTopic {
            get {
                return ResourceManager.GetString("LoginToPostTopic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 你必须登录来发帖 的本地化字符串。
        /// </summary>
        public static string MustLoginToPost {
            get {
                return ResourceManager.GetString("MustLoginToPost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 没有子版块 的本地化字符串。
        /// </summary>
        public static string NoCategories {
            get {
                return ResourceManager.GetString("NoCategories", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 没有版面 的本地化字符串。
        /// </summary>
        public static string NoForumsFound {
            get {
                return ResourceManager.GetString("NoForumsFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 没有话题 的本地化字符串。
        /// </summary>
        public static string NoTopics {
            get {
                return ResourceManager.GetString("NoTopics", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 发表回复 的本地化字符串。
        /// </summary>
        public static string PostReply {
            get {
                return ResourceManager.GetString("PostReply", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 更新 的本地化字符串。
        /// </summary>
        public static string UpdateBtnText {
            get {
                return ResourceManager.GetString("UpdateBtnText", resourceCulture);
            }
        }
    }
}
