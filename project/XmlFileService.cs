using System;
using System.Xml;
using System.Collections.Generic;
namespace conproj
{
    /// <summary>
    /// Class for workimg with XmlDocuments
    /// </summary>
    public class XmlFileService:IFileSystem<File>
    {
        /// <summary>
        /// Import method returns List with files from destfile
        /// </summary>
        /// <param name="destFilePath"></param>
        /// <returns></returns>
        public  List<File> Import(string destFilePath)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(destFilePath);
            XmlElement xRoot = xDoc.DocumentElement;
            File fil = new File();
            List<File> strx = new List<File>();
            foreach (XmlElement xnode in xRoot)
            {

                XmlNode attr = xnode.Attributes.GetNamedItem("id");
                if (attr != null)
                {
                    int id;
                    if (!Int32.TryParse(attr.Value, out id)) { throw new ArgumentException("invalid entry form"); }
                    fil.id = id;

                }

                foreach (XmlNode childnode in xnode.ChildNodes)
                {

                    {
                        string name;
                        name = childnode.InnerText;
                        fil.name = name;
                    }
                    if (childnode.Name == "lastname")
                    {
                        string lastname;
                        lastname = childnode.InnerText;
                        fil.lastname = lastname;
                    }
                    if (childnode.Name == "date")
                    {
                        string date;
                        date = childnode.InnerText;
                        Data d = Data.Unstring(date);
                        fil.date = d;
                    }

                }
                strx.Add(fil);

            }
            return strx;
        }
        /// <summary>
        /// Exportmethod saves our collection to destfile 
        /// </summary>
        /// <param name="destfile"></param>
        /// <param name="store"></param>
        public void Export(string destfile,List<File> store)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(destfile);
            XmlElement xRoot = xDoc.DocumentElement;
            XmlElement userElem = xDoc.CreateElement("file");
            XmlAttribute idAttr = xDoc.CreateAttribute("id");
            // создаем элементы company и age
            XmlElement nameElem = xDoc.CreateElement("name");
            XmlElement lastnameElem = xDoc.CreateElement("lastname");
            XmlElement dateElem = xDoc.CreateElement("date");
            // создаем текстовые значения для элементов и атрибута
            foreach (File f in store)
            {
                string strid = f.id.ToString();
                string d = f.date.ToString();

                XmlText idText = xDoc.CreateTextNode(strid);
                XmlText nameText = xDoc.CreateTextNode(f.name);
                XmlText lastnameText = xDoc.CreateTextNode(f.lastname);
                XmlText DateText = xDoc.CreateTextNode(d);

                //добавляем узлы
                idAttr.AppendChild(idText);
                nameElem.AppendChild(nameText);
                lastnameElem.AppendChild(lastnameText);
                userElem.Attributes.Append(idAttr);
                userElem.AppendChild(nameElem);
                userElem.AppendChild(lastnameElem);
                userElem.AppendChild(dateElem);
            }
            xRoot.AppendChild(userElem);
            xDoc.Save(destfile);
        }

    }
}
