using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace SeleniumFramework.Helpers
{
    public class ExcelHelpers
    {
        private static List<DataCollection> dataCol = new List<DataCollection>();

        /// <summary>
        /// To read all the data from the excel sheet
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static DataTable ExcelToDataTable(string fileName)
        {
            using (var stream = File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (data) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });

                    //Get all the Tables
                    DataTableCollection table = result.Tables;
                    //Store it in DataTable
                    DataTable resultTable = table["Sheet1"];
                    //return
                    return resultTable;
                }
            }
        }

        /// <summary>
        /// Populate the data in collection
        /// </summary>
        /// <param name="fileName"></param>
        public static void PopulateInCollection(string fileName)
        {
            DataTable table = ExcelToDataTable(fileName);

            //Iterate through the rows and columns of the Table
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    DataCollection dtTable = new DataCollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName.ToString(),
                        colValue = table.Rows[row - 1][col].ToString()
                    };
                    //Add all the details for each row
                    dataCol.Add(dtTable);
                }
            }

        }

        public static string ReadData(int rowNumber, string colName)
        {
            try
            {
                string data = (from colData in dataCol
                               where colData.colName == colName && colData.rowNumber == rowNumber
                               select colData.colValue).SingleOrDefault();
                return data.ToString();
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public class DataCollection
        {
            public int rowNumber { get; set; }

            public string colName { get; set; }

            public string colValue { get; set; }
        }

    }
}
