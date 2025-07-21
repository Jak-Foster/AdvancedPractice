
namespace AdvancedPractice.OperandCity
{
    public record BlockCoordinate(int Row, int Column)
    {
        public static BlockCoordinate operator +(BlockCoordinate Location, BlockOffset Offset) => new(Location.Row + Offset.RowOffset, Location.Column + Offset.ColumnOffset);

        public static BlockCoordinate operator +(BlockCoordinate Location, Direction Direction)
        {
            if (Direction == Direction.East) return new(Location.Row, Location.Column + 1);
            if (Direction == Direction.South) return new(Location.Row + 1, Location.Column);
            if (Direction == Direction.West) return new(Location.Row, Location.Column - 1);
            if (Direction == Direction.North) return new(Location.Row - 1, Location.Column);
            return Location;
        }

        public int this[int Index]
        {
            get {
                if (Index == 0) return Row;
                else return Column;
            }
        }
    }
}
