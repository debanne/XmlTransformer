using System;

namespace XmlTransformer
{
    public sealed class XPath : Locator
    {
        protected override string ParentPath
        {
            get
            {
                return this.ConstructPath();
            }
        }

        protected override string ConstructPath()
        {
            this.EnsureArguments(1, 1);
            string str = this.Arguments[0];
            if (!str.StartsWith("/", StringComparison.Ordinal))
                str = this.AppendStep(this.AppendStep(base.ParentPath, this.NextStepNodeTest), this.Arguments[0]).Replace("/./", "/");
            return str;
        }
    }
}
