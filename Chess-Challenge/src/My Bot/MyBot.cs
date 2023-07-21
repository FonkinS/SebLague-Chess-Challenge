using ChessChallenge.API;

// This super simple sample bot by SebLague simply returns the first possible move it can think of
public class MyBot : IChessBot
{
    public Move Think(Board board, Timer timer)
    {
        Move[] moves = board.GetLegalMoves();
        return moves[0];
    }
}
