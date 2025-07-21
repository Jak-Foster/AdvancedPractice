namespace AdvancedPractice.OperandCity
{
    public record BlockOffset(int RowOffset, int ColumnOffset)
    {
        public static implicit operator BlockOffset(Direction Direction)
        {
            return Direction switch
            {
                Direction.East  => new(0, 1),
                Direction.South => new(1, 0),
                Direction.West  => new(0, -1),
                Direction.North => new(-1, 0),
                _               => new(0, 0)
            };
        }
    }
}
