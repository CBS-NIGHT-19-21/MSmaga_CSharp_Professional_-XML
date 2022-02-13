using System.Xml;
using System.Xml.XPath;
using Task3_Create_XML;

class Program
{
    static void Main()
    {
        var xmlWriter = new XmlTextWriter("TelephoneBook.xml", null);
        xmlWriter.Formatting = Formatting.Indented;
        xmlWriter.IndentChar = '\t';
        xmlWriter.Indentation = 1;
        xmlWriter.QuoteChar = '\'';

        xmlWriter.WriteStartDocument();
        xmlWriter.WriteStartElement("MyContacts");
        xmlWriter.WriteStartElement("FriendOfMine1");
        xmlWriter.WriteStartElement("TelephoneNumber");
        xmlWriter.WriteString("131313");
        xmlWriter.WriteEndElement();
        xmlWriter.WriteEndElement();
        xmlWriter.WriteStartElement("FriendOfMine2");
        xmlWriter.WriteStartElement("TelephoneNumber");
        xmlWriter.WriteString("191919");
        xmlWriter.WriteEndElement();
        xmlWriter.WriteEndElement();
        xmlWriter.WriteEndElement();

        xmlWriter.Close();


        XMLData.ShowRootChild("TelephoneBook.xml");

        var document = new XPathDocument("TelephoneBook.xml");

        XPathNavigator navigator = document.CreateNavigator();

        XPathNodeIterator iterator1 = navigator.Select("MyContacts/FriendOfMine1/TelephoneNumber");
        foreach (var item in iterator1) Console.WriteLine(item);

        XPathExpression expr = navigator.Compile("MyContacts/FriendOfMine2/TelephoneNumber");

        XPathNodeIterator iterator2 = navigator.Select(expr);
        foreach (var item in iterator2) Console.WriteLine(item);
    }
}