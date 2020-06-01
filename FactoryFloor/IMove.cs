using System.Collections.Generic;

namespace FactoryFloor
{
    public interface IMove
    {
        string MoveBlocks(string moveSeq);
        void RightMove(string visited, List<string> visitedBlocks);
        string[] DetermineMoves(string moveSeq);
    }
}
