namespace GoCapture
{
    public class MapPoint(int x, int y, CellStatus cellStatus)
    {
        public int X { get; set; } = x;
        public int Y { get; set; } = y;
        public CellStatus CellStatus { get; set; } = cellStatus;
    }
}
