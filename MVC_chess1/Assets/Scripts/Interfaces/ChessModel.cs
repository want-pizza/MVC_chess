using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChessModel
{
    protected ChessView view;
    public List<ChessPieceData> Pieces { get; private set; }
    public int BoardSize { get; private set; }
    protected bool isEnd;

    public ChessModel(ChessView view)
    {
        this.view = view;
    }

    protected abstract void InitializeBoard();
    protected void InitializeBoard(List<ChessPieceData> pieces) => Pieces = pieces;
    public int GetBoardSize()
    {
        return BoardSize;
    }
}

public class ChessPieceData
{
    public string Type;
    public string Color;
    public string Position;

    public ChessPieceData(string type, string color, string position)
    {
        Type = type;
        Color = color;
        Position = position;
    }
}
