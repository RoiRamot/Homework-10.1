using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel
{
    class FileReader
    {
        public  List<string> Reader(string path)
        {
            if (path != null && File.Exists(path))
            {
                StreamReader reader = new StreamReader(path);
                List<string> list = new List<string>();
                string name;
                while ((name = reader.ReadLine()) != null)
                {
                    if (name != "")
                    {
                        list.Add(name);
                    }

                }
                reader.Close();
                return list;
            }
            return null;
        }
    }
}
