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
            string position = $"{file}2";
            Pieces.Add(new ChessPieceData("Pawn", "White", position));
        }

        Pieces.Add(new ChessPieceData("Rook", "White", "a1"));
        Pieces.Add(new ChessPieceData("Knight", "White", "b1"));
        Pieces.Add(new ChessPieceData("Bishop", "White", "c1"));
        Pieces.Add(new ChessPieceData("Queen", "White", "d1"));
        Pieces.Add(new ChessPieceData("King", "White", "e1"));
        Pieces.Add(new ChessPieceData("Bishop", "White", "f1"));
        Pieces.Add(new ChessPieceData("Knight", "White", "g1"));
        Pieces.Add(new ChessPieceData("Rook", "White", "h1"));

        for (int i = 0; i < BoardSize; i++)
        {
            char file = (char)('a' + i);
            string position = $"{file}7";
            Pieces.Add(new ChessPieceData("Pawn", "Black", position));
        }

        Pieces.Add(new ChessPieceData("Rook", "Black", "a8"));
        Pieces.Add(new ChessPieceData("Knight", "Black", "b8"));
        Pieces.Add(new ChessPieceData("Bishop", "Black", "c8"));
        Pieces.Add(new ChessPieceData("Queen", "Black", "d8"));
        Pieces.Add(new ChessPieceData("King", "Black", "e8"));
        Pieces.Add(new ChessPieceData("Bishop", "Black", "f8"));
        Pieces.Add(new ChessPieceData("Knight", "Black", "g8"));
        Pieces.Add(new ChessPieceData("Rook", "Black", "h8"));

    }
}
