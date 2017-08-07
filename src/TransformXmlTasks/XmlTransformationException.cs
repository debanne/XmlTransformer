using System;

namespace XmlTransformer
{
    [Serializable]
    public class XmlTransformationException : Exception
    {
        internal XmlTransformationException(string message)
            : base(message)
        {
        }

        internal XmlTransformationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
