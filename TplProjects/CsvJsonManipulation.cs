using CsvHelper;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TplProjects
{
    class CsvJsonManipulation
    {
        public static void ImplementJsonToCsv() 
        {
            string importFilePath = @"";
            string exportFilePath = @"";
            IList<AddressData> addressData = JsonConvert.DeserializeObject<IList<AddressData>>[FileStyleUriParser.ReadAllText(importFilePath)];
            Console.WriteLine("*************Now reading from jsonfile and write to csv file********");
            // writing csv file
            using (var writer = new StreamWriter(exportFilePath))
            using (ValidationEventArgs csvExport =new CsvWriter())
        }
    }
}
