using System;
using System.Collections.Generic;

namespace GoCapture
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // // SAMPLE 1: Result should be true
            //var map = new Map(10,10);
            //map.SetPoint(new MapPoint(4, 6, PointStatus.White));
            //map.SetPoint(new MapPoint(4, 7, PointStatus.White));
            //map.SetPoint(new MapPoint(4, 5, PointStatus.Black));
            //map.SetPoint(new MapPoint(3, 6, PointStatus.Black));
            //map.SetPoint(new MapPoint(5, 6, PointStatus.Black));
            //map.SetPoint(new MapPoint(4, 8, PointStatus.Black));
            //map.SetPoint(new MapPoint(3, 7, PointStatus.Black));
            //map.SetPoint(new MapPoint(5, 7, PointStatus.Black));
            //var checkedCoordinate = new Coordinate(4, 6);

            // // SAMPLE 2: Result should be true
            //var map = new Map(10,10);
            //map.SetPoint(new MapPoint(4, 6, PointStatus.White));
            //map.SetPoint(new MapPoint(4, 7, PointStatus.White));
            //map.SetPoint(new MapPoint(4, 5, PointStatus.White));
            //map.SetPoint(new MapPoint(3, 6, PointStatus.White));
            //map.SetPoint(new MapPoint(5, 6, PointStatus.White));
            //map.SetPoint(new MapPoint(4, 8, PointStatus.Black));
            //map.SetPoint(new MapPoint(3, 7, PointStatus.Black));
            //map.SetPoint(new MapPoint(5, 7, PointStatus.Black));
            //map.SetPoint(new MapPoint(6, 6, PointStatus.Black));
            //map.SetPoint(new MapPoint(5, 5, PointStatus.Black));
            //map.SetPoint(new MapPoint(4, 4, PointStatus.Black));
            //map.SetPoint(new MapPoint(3, 5, PointStatus.Black));
            //map.SetPoint(new MapPoint(2, 6, PointStatus.Black));
            //var checkedCoordinate = new Coordinate(4, 6);

            // // SAMPLE 3: Result should be false
            //var map = new Map(10,10);
            //map.SetPoint(new MapPoint(4, 6, PointStatus.White));
            //map.SetPoint(new MapPoint(5, 6, PointStatus.White));
            //map.SetPoint(new MapPoint(5, 7, PointStatus.White));
            //map.SetPoint(new MapPoint(5, 8, PointStatus.White));
            //map.SetPoint(new MapPoint(4, 7, PointStatus.White));
            //map.SetPoint(new MapPoint(4, 8, PointStatus.Black));
            //map.SetPoint(new MapPoint(3, 6, PointStatus.Black));
            //map.SetPoint(new MapPoint(3, 7, PointStatus.Black));
            //map.SetPoint(new MapPoint(4, 5, PointStatus.Black));
            //map.SetPoint(new MapPoint(5, 5, PointStatus.Black));
            //map.SetPoint(new MapPoint(6, 6, PointStatus.Black));
            //map.SetPoint(new MapPoint(6, 7, PointStatus.Black));
            //var checkedCoordinate = new Coordinate(4, 6);

            // // SAMPLE 4: Result should be false
            //var map = new Map(10,10);
            //map.SetPoint(new MapPoint(4, 6, PointStatus.White));
            //map.SetPoint(new MapPoint(5, 6, PointStatus.White));
            //map.SetPoint(new MapPoint(5, 7, PointStatus.White));
            //map.SetPoint(new MapPoint(4, 7, PointStatus.White));
            //var checkedCoordinate = new Coordinate(4, 6);

            // // SAMPLE 5: Result should be false
            //var map = new Map(10,10);
            //map.SetPoint(new MapPoint(4, 6, PointStatus.White));
            //map.SetPoint(new MapPoint(4, 7, PointStatus.White));
            //map.SetPoint(new MapPoint(3, 6, PointStatus.Black));
            //map.SetPoint(new MapPoint(4, 5, PointStatus.Black));
            //var checkedCoordinate = new Coordinate(4, 6);

            // // SAMPLE 6: Result should be false
            //var map = new Map(10,10);
            //map.SetPoint(new MapPoint(4, 6, PointStatus.White));
            //map.SetPoint(new MapPoint(5, 6, PointStatus.White));
            //map.SetPoint(new MapPoint(5, 7, PointStatus.White));
            //map.SetPoint(new MapPoint(5, 8, PointStatus.White));
            //map.SetPoint(new MapPoint(4, 7, PointStatus.White));
            //map.SetPoint(new MapPoint(4, 8, PointStatus.Black));
            //map.SetPoint(new MapPoint(3, 6, PointStatus.Black));
            //map.SetPoint(new MapPoint(3, 7, PointStatus.Black));
            //map.SetPoint(new MapPoint(4, 5, PointStatus.Black));
            //map.SetPoint(new MapPoint(5, 5, PointStatus.Black));
            //map.SetPoint(new MapPoint(6, 6, PointStatus.Black));
            //map.SetPoint(new MapPoint(6, 7, PointStatus.Black));
            //map.SetPoint(new MapPoint(6, 8, PointStatus.White));
            //map.SetPoint(new MapPoint(6, 9, PointStatus.White));
            //var checkedCoordinate = new Coordinate(4, 6);

            // // SAMPLE 7: Result should be false
            //var map = new Map(10,10);
            //map.SetPoint(new MapPoint(4, 6, PointStatus.White));
            //map.SetPoint(new MapPoint(4, 7, PointStatus.White));
            //map.SetPoint(new MapPoint(4, 5, PointStatus.White));
            //map.SetPoint(new MapPoint(5, 5, PointStatus.White));
            //map.SetPoint(new MapPoint(5, 6, PointStatus.Black));
            //map.SetPoint(new MapPoint(5, 7, PointStatus.White));
            //map.SetPoint(new MapPoint(6, 5, PointStatus.White));
            //map.SetPoint(new MapPoint(6, 6, PointStatus.White));
            //map.SetPoint(new MapPoint(6, 6, PointStatus.White));
            //var checkedCoordinate = new Coordinate(4, 6);

            // // SAMPLE 8: Result should be true
            //var map = new Map(10,10);
            //map.SetPoint(new MapPoint(4, 6, PointStatus.White));
            //map.SetPoint(new MapPoint(4, 7, PointStatus.White));
            //map.SetPoint(new MapPoint(5, 6, PointStatus.White));
            //map.SetPoint(new MapPoint(5, 7, PointStatus.White));
            //map.SetPoint(new MapPoint(3, 6, PointStatus.Black));
            //map.SetPoint(new MapPoint(3, 7, PointStatus.Black));
            //map.SetPoint(new MapPoint(6, 6, PointStatus.Black));
            //map.SetPoint(new MapPoint(6, 7, PointStatus.Black));
            //map.SetPoint(new MapPoint(4, 8, PointStatus.Black));
            //map.SetPoint(new MapPoint(5, 8, PointStatus.Black));
            //map.SetPoint(new MapPoint(4, 5, PointStatus.Black));
            //map.SetPoint(new MapPoint(5, 5, PointStatus.Black));
            //var checkedCoordinate = new Coordinate(4, 6);

            // // SAMPLE 9: Result should be true
            var map = new Map(10,10);
            map.SetPoint(new MapPoint(10, 10, CellStatus.White));
            map.SetPoint(new MapPoint(9, 10, CellStatus.Black));
            map.SetPoint(new MapPoint(9, 9, CellStatus.Black));
            map.SetPoint(new MapPoint(10, 9, CellStatus.Black));
            var checkedCoordinate = new Coordinate(10, 10);
            
            map.Print();            

            var result = Run(map, checkedCoordinate);

            Console.WriteLine($"Checking for coordinates X: {checkedCoordinate.X} Y: {checkedCoordinate.Y} Result is={result}");

            Console.ReadLine();
        }

        private static bool Run(Map originalMap, Coordinate coordinate)
        {
            // Create a copy
            var map = new Map(originalMap.XSize, originalMap.YSize);
            foreach (var point in originalMap.FilledPoints)
            {
                map.SetPoint(point);
            }

            var checkedPoint = map.GetPoint(coordinate.X, coordinate.Y);

            if (checkedPoint == null)
            {
                Console.WriteLine("Checked coordinates is empty!");
                return false;
            }

            var enemyPointStatus = checkedPoint.CellStatus == CellStatus.White ? CellStatus.Black : CellStatus.White;
            map.SetBorderPointStatus(enemyPointStatus);
            return IsPointLost(map, checkedPoint, enemyPointStatus);
        }

        private static bool IsPointLost(Map map, MapPoint point, CellStatus enemyPointStatus)
        {
            var neighbours = new List<MapPoint>
            {
                map.GetPoint(point.X, point.Y, Direction.North),
                map.GetPoint(point.X, point.Y, Direction.South),
                map.GetPoint(point.X, point.Y, Direction.East),
                map.GetPoint(point.X, point.Y, Direction.West)
            };

            foreach (var neighbour in neighbours)
            {
                if (neighbour == null)
                {
                    return false;
                }

                if (neighbour.CellStatus == enemyPointStatus) continue;
                point.CellStatus = enemyPointStatus;
                if (!IsPointLost(map, neighbour, enemyPointStatus))
                {
                    return false;
                }
            }

            return true;
        }        
    }
}
