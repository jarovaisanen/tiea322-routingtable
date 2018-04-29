using System;

namespace RoutingTable
{
    public class RoutingTableRow
    {
        public string SubNetAddress { get; set; }
        public string NextHopAddress { get; set; }

        public RoutingTableRow(string line)
        {
            SubNetAddress = GetSubNetAddress(line);
            NextHopAddress = GetNextHopAddress(line);
        }

        private string GetNextHopAddress(string line)
        {
            return line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)[1];
        }

        private string GetSubNetAddress(string line)
        {
            return line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)[0];
        }
    }
}