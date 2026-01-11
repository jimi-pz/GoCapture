using System;
using System.Collections.Generic;
using System.Linq;

namespace GoCapture
{
    public class Map
    {
        public List<MapPoint> FilledPoints { get; }
        public int XSize { get; set; }
        public int YSize { get; set; }

        public Map(int xSize, int ySize)
        {
            XSize = xSize;
            YSize = ySize;

            FilledPoints = [];
            for (var i = 1; i <= XSize; i++)
            {
                FilledPoints.Add(new MapPoint(i, 0, CellStatus.Border));
                FilledPoints.Add(new MapPoint(i, YSize + 1, CellStatus.Border));
            }
            for (var i = 1; i <= YSize; i++)
            {
                FilledPoints.Add(new MapPoint(0, i, CellStatus.Border));
                FilledPoints.Add(new MapPoint(XSize + 1, i, CellStatus.Border));
            }
        }

        public void SetBorderPointStatus (CellStatus pointStatus)
        {
            for (var i = 1; i <= XSize; i++)
            {
                SetPoint(new MapPoint(i, 0, pointStatus));
                SetPoint(new MapPoint(i, YSize + 1, pointStatus));
            }
            for (var i = 1; i <= YSize; i++)
            {
                SetPoint(new MapPoint(0, i, pointStatus));
                SetPoint(new MapPoint(XSize + 1, i, pointStatus));
            }
        }

        public MapPoint GetPoint(int x, int y)
        {
            return FilledPoints.FirstOrDefault(point => point.X == x && point.Y == y);
        }

        public MapPoint GetPoint(int x, int y, Direction direction)
        {
            return direction switch
            {
                Direction.North => GetPoint(x, y + 1),
                Direction.South => GetPoint(x, y - 1),
                Direction.East => GetPoint(x + 1, y),
                Direction.West => GetPoint(x - 1, y),
                _ => GetPoint(x, y),
            };
        }

        public void DeletePoint(int x, int y)
        {
            var existingPoint = GetPoint(x, y);

            if (existingPoint != null)
            {
                FilledPoints.Remove(existingPoint);
            }
        }

        public void SetPoint(MapPoint point)
        {
            var existingPoint = GetPoint(point.X, point.Y);

            if (existingPoint != null)
            {
                FilledPoints.Remove(existingPoint);
            }
            FilledPoints.Add(point);
        }

        public void Print()
        {
            foreach (var point in FilledPoints.Where(point => point.CellStatus != CellStatus.Border))
            {
                Console.WriteLine($"X:{point.X} Y:{point.Y} Status:{point.CellStatus}");
            }
        }
    }
}
