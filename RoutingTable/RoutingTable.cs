using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RoutingTable
{
    public class RoutingTable
    {
        public List<RoutingTableRow> RoutingTableRows { get; set; }

        public RoutingTable(string file)
        {
            RoutingTableRows = new List<RoutingTableRow>();
            PopulateRoutingTable(File.ReadAllLines(file));
        }
        
        private void PopulateRoutingTable(string[] routingTable)
        {
            for (int i = 0; i < routingTable.Length; i++)
            {
                var row = new RoutingTableRow(routingTable[i]);
                RoutingTableRows.Add(row);
            }
        }
    }
}
