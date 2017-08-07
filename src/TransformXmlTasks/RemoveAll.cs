namespace XmlTransformer
{
    internal class RemoveAll : Remove
    {
        public RemoveAll()
        {
            this.ApplyTransformToAllTargetNodes = true;
        }

        protected override void Apply()
        {
            this.RemoveNode();
        }
    }
}
