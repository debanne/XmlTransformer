using System.Xml;

namespace XmlTransformer
{
    public interface IXmlOriginalDocumentService
    {
        XmlNodeList SelectNodes(string path, XmlNamespaceManager nsmgr);
    }
}
