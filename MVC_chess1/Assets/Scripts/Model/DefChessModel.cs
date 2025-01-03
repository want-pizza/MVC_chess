using JetBrains.Annotations;
using System.Collections.Generic;

public class DefChessModel : ChessModel
{
    public DefChessModel(ChessView view) : base(view)
    {
    }

    protected override void InitializeBoard()
    {
        for (int i = 0; i < BoardSize; i++)
        {
            char file = (char)('a' + i);
            Pieces.Add(new ChessPieceData(PieceType.Pawn, "White", i, 1));
        }

        Pieces.Add(new ChessPieceData(PieceType.Rook, "White", 0, 0));
        Pieces.Add(new ChessPieceData(PieceType.Knight, "White", 1, 0));
        Pieces.Add(new ChessPieceData(PieceType.Bishop, "White", 2, 0));
        Pieces.Add(new ChessPieceData(PieceType.Queen, "White", 3, 0));
        Pieces.Add(new ChessPieceData(PieceType.King, "White", 4, 0));
        Pieces.Add(new ChessPieceData(PieceType.Bishop, "White", 5, 0));
        Pieces.Add(new ChessPieceData(PieceType.Knight, "White", 6, 0));
        Pieces.Add(new ChessPieceData(PieceType.Rook, "White", 7, 0));

        for (int i = 0; i < BoardSize; i++)
        {
            Pieces.Add(new ChessPieceData(PieceType.Pawn, "White", i, 6));
        }

        Pieces.Add(new ChessPieceData(PieceType.Rook, "Black", 0, 7));
        Pieces.Add(new ChessPieceData(PieceType.Knight, "Black", 1, 7));
        Pieces.Add(new ChessPieceData(PieceType.Bishop, "Black", 2, 7));
        Pieces.Add(new ChessPieceData(PieceType.Queen, "Black", 3, 7));
        Pieces.Add(new ChessPieceData(PieceType.King, "Black", 4, 7));
        Pieces.Add(new ChessPieceData(PieceType.Bishop, "Black", 5, 7));
        Pieces.Add(new ChessPieceData(PieceType.Knight, "Black", 6, 7));
        Pieces.Add(new ChessPieceData(PieceType.Rook, "Black", 7, 7));
    }
}
