using System;
using System.IO;
using System.Collections.Generic;
namespace conproj
{
    public class CsvFileService:IFileSystem<File>
    {
        public CsvFileService()
        {
        }
        public void Export(string destFilePath,List<File> store)
        {
            StreamWriter sw = null;
            string fileContent = null;
            foreach (File f in store)
            {
                fileContent += File.StringRow(f) + "\n";
            }

            sw = new StreamWriter(new FileStream(destFilePath, FileMode.Create, FileAccess.Write));
            sw.Write(fileContent);

            sw.Flush();
            sw.Dispose();
            sw.Close();


        }

        public  List<File> Import(string srcFilePath)
        {
            // Initilization  
            List<File> datatable = new List<File>();
            StreamReader sr = null;
            // Creating data table without header.  
            using (sr = new StreamReader(new FileStream(srcFilePath, FileMode.Open, FileAccess.Read)))
            {
                // Initialization.  
                string line = string.Empty;
                string[] headers = sr.ReadLine().Split('\n');
                // Preparing header.  
                for (int i = 0; i < headers.Length; i++)
                {
                    // Setting.  
                    datatable.Add(File.Unstring(headers[i]));
                }
                // Closing.  
                sr.Dispose();
                sr.Close();


                // Info.  
                return datatable;
            }

        }
    }
}
