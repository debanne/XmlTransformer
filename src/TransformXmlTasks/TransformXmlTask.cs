using System;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace XmlTransformer
{
    public class TransformXmlTask : Task
    {
        private string _source;
        private string _transform;
        private string _destination;

        [Required]
        public string Source
        {
            get { return _source; }
            set { _source = value; }
        }

        [Required]
        public string Transform
        {
            get { return _transform; }
            set { _transform = value; }
        }

        [Required]
        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public override bool Execute()
        {
            try
            {
                XmlTransformer.TransformXml(_source, _transform, _destination);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured during Xml transformation: {0}", e.Message);
                return false;
            }
            return true;
        }
    }
}
