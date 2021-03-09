﻿using OpenQA.Selenium;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumFramework.Helpers
{
    public class HtmlTableHelpers
    {
        private static List<TableDataCollection> tableDataCollection;

        private static void Readtable(IWebElement table)
        {
            tableDataCollection = new List<TableDataCollection>();

            var columns = table.FindElements(By.TagName("th"));
            var rows = table.FindElements(By.TagName("tr"));

            int rowIndex = 0;
            foreach(var row in rows)
            {
                int colIndex = 0;
                var colDatas = row.FindElements(By.TagName("td"));


                if (colDatas.Count != 0)
                {
                    foreach(var colValue in colDatas)
                    {
                        tableDataCollection.Add(new TableDataCollection
                        {
                            RowNumber = rowIndex,
                            ColumnName = columns[colIndex].Text != "" ? columns[colIndex].Text : colIndex.ToString(),
                            ColumnValue = colValue.Text,
                            ColumnSpecialValues = GetControl(colValue)

                        });
                        colIndex++;
                    }
                    rowIndex++;
                }
            }
        }

        private static ColumnSpecialValue GetControl(IWebElement columnvalue)
        {
            ColumnSpecialValue columnSpecialValue = null;

            if (columnvalue.FindElements(By.TagName("a")).Count > 0)
            {
                columnSpecialValue = new ColumnSpecialValue
                {
                    ElementCollection = columnvalue.FindElements(By.TagName("a")),
                    ControlType = "hyperLink"
                };
            }

            if (columnvalue.FindElements(By.TagName("input")).Count > 0)
            {
                columnSpecialValue = new ColumnSpecialValue
                {
                    ElementCollection = columnvalue.FindElements(By.TagName("input")),
                    ControlType = "input"
                };
            }

            return columnSpecialValue;
        }

        public static void PerformActionOnCell(string columnIndex, string refColumnName, string refColumnValue, string controlToOperate =null)
        {

            foreach(int rowNumber in GetDynamicRowNumber(refColumnName, refColumnValue))
            {
                var cell = (from e in tableDataCollection
                            where e.ColumnName == columnIndex && e.RowNumber == rowNumber
                            select e.ColumnSpecialValues).SingleOrDefault();

                if(controlToOperate != null && cell != null)
                {

                    if(cell.ControlType == "hyperLink")
                    {
                        var returnedControl = (from c in cell.ElementCollection
                                             where c.Text == controlToOperate
                                             select c).SingleOrDefault();
                        returnedControl?.Click();
                    }

                    if (cell.ControlType == "input")
                    {
                        var returnedControl = (from c in cell.ElementCollection
                                               where c.GetAttribute("value") == controlToOperate
                                               select c).SingleOrDefault();
                        returnedControl?.Click();
                    }

                }
            }

        }

        private static IEnumerable GetDynamicRowNumber(string columnName, string columnValue)
        {
            foreach (var table in tableDataCollection)
            {
                if(table.ColumnName == columnName && table.ColumnValue == columnValue)
                {
                    yield return table.RowNumber;
                }
            }
        }

    }




    public class TableDataCollection
    {
        public int RowNumber { get; set; }

        public string ColumnName { get; set; }

        public string ColumnValue { get; set; }

        public ColumnSpecialValue ColumnSpecialValues { get; set; }
    }

    public class ColumnSpecialValue
    {
        public IEnumerable<IWebElement> ElementCollection { get; set; }

        public string ControlType { get; set; }
    }


}
