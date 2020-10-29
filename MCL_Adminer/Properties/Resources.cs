using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace MCL_Adminer.Properties
{
    // Token: 0x02000010 RID: 16
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [DebuggerNonUserCode]
    [CompilerGenerated]
    internal class Resources
    {
        // Token: 0x06000051 RID: 81 RVA: 0x00006E74 File Offset: 0x00005074
        internal Resources()
        {
        }

        // Token: 0x17000004 RID: 4
        // (get) Token: 0x06000052 RID: 82 RVA: 0x00006E80 File Offset: 0x00005080
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

        // Token: 0x17000005 RID: 5
        // (get) Token: 0x06000053 RID: 83 RVA: 0x00006EC8 File Offset: 0x000050C8
        // (set) Token: 0x06000054 RID: 84 RVA: 0x00006EDF File Offset: 0x000050DF
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

        // Token: 0x04000072 RID: 114
        private static ResourceManager resourceMan;

        // Token: 0x04000073 RID: 115
        private static CultureInfo resourceCulture;
    }
}
