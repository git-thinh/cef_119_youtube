﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CefSharp.Example.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CefSharp.Example.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;!DOCTYPE HTML PUBLIC &quot;-//W3C//DTD HTML 4.0 Transitional//EN&quot;&gt;
        ///&lt;html&gt;
        ///	&lt;head&gt;
        ///		&lt;title&gt;Binding Test&lt;/title&gt;
        ///	&lt;/head&gt;
        ///	&lt;body&gt;
        ///	    &lt;p&gt;
        ///	    Result of calling bound.Repeat(&quot;hi &quot;, 5) =
        ///	    &lt;script type=&quot;text/javascript&quot;&gt;
        ///	        var result = bound.Repeat(&quot;hi &quot;, 5);
        ///	        document.write(&apos;&quot;&apos; + result + &apos;&quot;&apos;);
        ///	        if(result == &quot;hi hi hi hi hi &quot;)
        ///	        {
        ///	            document.write(&quot; SUCCESS&quot;);
        ///	        }
        ///	        else
        ///	        {
        ///	            document.write(&quot; FAIL!&quot;);
        ///	        }
        ///	    &lt;/script&gt;
        ///	    &lt;/p [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string BindingTest {
            get {
                return ResourceManager.GetString("BindingTest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE HTML PUBLIC &quot;-//W3C//DTD HTML 4.0 Transitional//EN&quot;&gt;
        ///&lt;html&gt;
        ///	&lt;head&gt;
        ///		&lt;title&gt;Popup Test&lt;/title&gt;
        ///	&lt;/head&gt;
        ///	&lt;body&gt;
        ///        &lt;a href=&quot;https://github.com/ataranto/CefSharp&quot; target=&quot;_blank&quot;&gt;target=_blank&lt;/a&gt;
        ///        &lt;br /&gt;
        ///        &lt;a href=&quot;#&quot; onclick=&quot;window.open(&apos;https://github.com/ataranto/CefSharp&apos;)&quot;&gt;window.open()&lt;/a&gt;
        ///	&lt;/body&gt;
        ///&lt;/html&gt;
        ///.
        /// </summary>
        internal static string PopupTest {
            get {
                return ResourceManager.GetString("PopupTest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE HTML PUBLIC &quot;-//W3C//DTD HTML 4.0 Transitional//EN&quot;&gt;
        ///&lt;html&gt;
        ///	&lt;head&gt;
        ///		&lt;title&gt;Scheme Handler Test&lt;/title&gt;
        ///	&lt;/head&gt;
        ///	&lt;body&gt;
        ///	&lt;h1&gt;Success&lt;/h1&gt;
        ///	&lt;p&gt;Scheme Handler Functioned Correctly&lt;/p&gt;
        ///	&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string SchemeTest {
            get {
                return ResourceManager.GetString("SchemeTest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE HTML PUBLIC &quot;-//W3C//DTD HTML 4.0 Transitional//EN&quot;&gt;
        ///&lt;html&gt;
        ///	&lt;head&gt;
        ///		&lt;title&gt;Scheme Handler Test&lt;/title&gt;
        ///	&lt;/head&gt;
        ///	&lt;body&gt;
        ///        &lt;form&gt;
        ///            &lt;input type=&quot;text&quot; size=25 title=&quot;This is the first tooltip&quot;&gt;
        ///            &lt;br /&gt;
        ///            &lt;input type=&quot;text&quot; size=25 title=&quot;This is the second tooltip&quot;&gt;
        ///            &lt;br /&gt;
        ///            &lt;select&gt;
        ///                &lt;option selected&gt;test&lt;/option&gt;
        ///                &lt;option&gt;one&lt;/option&gt;
        ///                &lt;option&gt;two&lt;/option&gt;
        ///            &lt;/select&gt;
        ///        &lt;/form [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TooltipTest {
            get {
                return ResourceManager.GetString("TooltipTest", resourceCulture);
            }
        }
    }
}
