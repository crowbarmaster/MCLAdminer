﻿using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace MCL_Adminer.Properties
{
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [DebuggerNonUserCode]
    [CompilerGenerated]
    internal class Resources
    {
        internal Resources()
        {
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                bool flag = Resources.resourceMan == null;
                if (flag)
                {
                    ResourceManager temp = new ResourceManager("MCL_Adminer.Properties.Resources", typeof(Resources).Assembly);
                    Resources.resourceMan = temp;
                }
                return Resources.resourceMan;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get
            {
                return Resources.resourceCulture;
            }
            set
            {
                Resources.resourceCulture = value;
            }
        }

        private static ResourceManager resourceMan;
        private static CultureInfo resourceCulture;
    }
}
