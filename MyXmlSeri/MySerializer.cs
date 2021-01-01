using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyXmlSeri
{
    class MySerializer
    {
        string Xmlitem;
        string item;
        string Propertyitem;
        string name;
        string piItem;
        public MySerializer()
        {
            StreamReader Templatereader = new StreamReader(@"C:/Users/sarah/source/repos/MyXmlSeri/MyXmlSeri/XmlTemplate.txt");
            Xmlitem = Templatereader.ReadToEnd();

            StreamReader Itemreader = new StreamReader(@"C:/Users/sarah/source/repos/MyXmlSeri/MyXmlSeri/ItemTemplate.txt");
            item = Itemreader.ReadToEnd();

            StreamReader Propertyreader = new StreamReader(@"C:/Users/sarah/source/repos/MyXmlSeri/MyXmlSeri/PropertyTemplate.txt");
            Propertyitem = Propertyreader.ReadToEnd();
        }

        public bool Serilestirme<T>(List<T> dizi, string path)
        {

            StringBuilder sb = new StringBuilder();

            item = item.Replace("#ClassName#", typeof(T).Name);


            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (T deger in dizi)
            {


                StringBuilder attribu = new StringBuilder();

                StringBuilder prop = new StringBuilder();


                foreach (PropertyInfo Propertyler in properties)
                {

                    MyAttribute attribute = (MyAttribute)Propertyler.GetCustomAttribute(typeof(MyAttribute));

                    if (attribute != null)
                    {

                        name = attribute.Name;

                        if (attribute.isAttribute)
                        {
                            attribu.Append(name);
                            attribu.Append(" = ");
                            attribu.Append("\" ");
                            attribu.Append(Propertyler.GetValue(deger).ToString());
                            attribu.Append("\" ");
                            continue; 
                        }
                    }
                    else

                        name = Propertyler.Name;

                    piItem = Propertyitem.Replace("#PropertyName#", name).Replace("#Value#", Propertyler.GetValue(deger).ToString()) + "\n";
                    prop.Append(piItem);
                }
              
                sb.Append(item.Replace("#Attribute#", attribu.ToString()).Replace("#PropertyList#", prop.ToString()));

            }

            Xmlitem = Xmlitem.Replace("#Items#", sb.ToString());

            StreamWriter writer = new StreamWriter(path); 
            writer.Write(Xmlitem); 
            writer.Close(); 

            return true;
        }


    }
}
