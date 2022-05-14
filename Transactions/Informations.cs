using GMap.NET;
using System.Collections.Generic;

namespace GMap_Tutorial.Transactions
{
    public static class Informations
    {
        public static int Count { get; set; } = 0;
        public static string[,] TotalArray { get; set; } = new string[100, 100];
        public static int NumberOfElement { get; set; } = 0;
        public static List<PointLatLng> GlobalPoints { get; set; } = new List<PointLatLng>();
        public static int Index { get; set; } = 0;

    }
}
