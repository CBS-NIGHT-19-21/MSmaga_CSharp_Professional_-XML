using System.Xml;

namespace Task3_Create_XML
{
    internal class XMLData
    {
        internal static void ShowAllData(string filePath)
        {
            ShowText(filePath);
            ShowXML(filePath);
            ShowRootLocalName(filePath);
            ShowRootChild(filePath);
            ShowChildNodes(filePath);
            ShowTags(filePath);
            ShowAttributes(filePath);
        }
        internal static void ShowTags(string filePath)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Open);
            XmlTextReader xmlReader = new XmlTextReader(fileStream);
            while (xmlReader.Read())
            {
                Console.WriteLine("{0,15} {1,15} {2,15}",
                    xmlReader.NodeType,
                    xmlReader.Name,
                    xmlReader.Value);
            }
            xmlReader.Close();
            fileStream.Close();
        }
        internal static void ShowText(string filePath)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);
            Console.WriteLine(xmlDoc.InnerText + "n");
        }
        internal static void ShowXML(string filePath)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);
            Console.WriteLine(xmlDoc.InnerXml + "n");
        }
        internal static void ShowRootLocalName(string filePath)
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(filePath);
            XmlNode root = xmlDocument.DocumentElement!;

            Console.WriteLine("Root.LocalName = {0}\n", root.LocalName);
        }
        internal static void ShowRootChild(string filePath)
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(filePath);
            XmlNode root = xmlDocument.DocumentElement!;

            foreach (XmlNode books in root.ChildNodes)
            {
                Console.WriteLine(books.Name + " : " + books.InnerText);
            }
        }
        internal static void ShowChildNodes(string filePath)
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(filePath);
            XmlNode root = xmlDocument.DocumentElement!;

            foreach (XmlNode books in root.ChildNodes)
            {
                foreach (XmlNode book in books.ChildNodes)
                {
                    Console.WriteLine(book.Name + " : " + book.InnerText);
                }
            }
        }
        internal static void ShowAttributes(string filePath)
        {
            var reader = new XmlTextReader(filePath);
            while(reader.Read())
            {
                if(reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name.Equals("Title"))
                    {
                        Console.WriteLine("<{0}>", reader.GetAttribute("FontSize"));
                    }
                }
            }
        }
    }
}
