namespace XMLparsers
{
    using System;
    using System.Xml.Linq;
    using System.Xml.Schema;

    internal class XSDSchema
    {
        private static void Main()
        {
            var schema = new XmlSchemaSet();
            schema.Add(string.Empty, "../../catalogue.xsd");

            XDocument doc = XDocument.Load("../../catalogue.xml");
            XDocument invalidDoc = XDocument.Load("../../catalogue-invalid.xml");

            PrintValidationResult(doc, schema, "catalogue.xml");
            PrintValidationResult(invalidDoc, schema, "invalidCatalogue.xml");
        }

        private static void PrintValidationResult(XDocument doc, XmlSchemaSet schema, string file)
        {
            doc.Validate(schema, (obj, ev) =>
            {
                Console.WriteLine("* {0} * {1}", file, ev.Message);
            });
        }
    }
}
