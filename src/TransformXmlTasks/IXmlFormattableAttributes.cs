namespace XmlTransformer
{
    internal interface IXmlFormattableAttributes
    {
        string AttributeIndent { get; }

        void FormatAttributes(XmlFormatter formatter);
    }
}
