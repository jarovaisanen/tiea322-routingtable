using System;
using System.IO;

namespace RoutingTable
{
    public class MainEntry
    {
        public static void Main(string[] args)
        {
            try
            {
                var routingTable = new RoutingTable("routingtable.txt");
                var ipAddresses = File.ReadAllLines("iposoitelista.txt");
                Console.WriteLine(ipAddresses[0]);
                PrintRoutingTable(routingTable);
            }
            catch (Exception e)
            {
                Console.WriteLine("File not found! Ex: " + e);
            }
        }

        private static void PrintRoutingTable(RoutingTable routingTable)
        {
            foreach (var row in routingTable.RoutingTableRows)
            {
                Console.Write($"Sub net address: {row.SubNetAddress} ");
                Console.WriteLine($"Next hop address: {row.NextHopAddress}");
            }
        }
    }
}
