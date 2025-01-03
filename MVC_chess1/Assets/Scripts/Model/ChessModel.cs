using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public abstract class ChessModel
{
    protected ChessView view;
    public List<ChessPieceData> Pieces { get; private set; }
    public int BoardSize { get; private set; } = 8;
    protected bool isCheck;
    protected bool isEnd;

    public ChessModel(ChessView view)
    {
        this.view = view;
    }

    protected abstract void InitializeBoard();
    public void InitializeBoard(List<ChessPieceData> pieces) => Pieces = pieces;
    internal List<int[]> GetPiecePosibleMoves(int[] coordinateSelectedPiece)
    {
        ChessPieceData selectedPiece = Pieces.FirstOrDefault(piece =>
                                   piece.Position[0] == coordinateSelectedPiece[0] &&
                                   piece.Position[1] == coordinateSelectedPiece[1]);

        if (selectedPiece == null)
            return new List<int[]>();

        PieceType pieceType = selectedPiece.Type;

        switch (pieceType)
        {
            case PieceType.Pawn:
                return GetPawnPosibleMoves(selectedPiece);

            default:
                Debug.LogError($"Moves for {pieceType} are not defined yet.");
                return new List<int[]>();
        }
    }

    protected internal List<int[]> GetPawnPosibleMoves(ChessPieceData selectedPiece)
    {
        List<int[]> chessPositions = new List<int[]>();

        int direction = selectedPiece.Color == "White" ? 1 : -1;

        int oneStep = selectedPiece.Position[1] + direction;
        if (oneStep >= 0 && oneStep < BoardSize)
        {
            chessPositions.Add(new int[] { selectedPiece.Position[0], oneStep });
        }

        bool isInitialPosition = (selectedPiece.Color == "White" && selectedPiece.Position[1] == 1) ||
                                 (selectedPiece.Color == "Black" && selectedPiece.Position[1] == 6);

        if (isInitialPosition)
        {
            int twoSteps = selectedPiece.Position[1] + 2 * direction;
            if (twoSteps >= 0 && twoSteps < BoardSize)
            {
                chessPositions.Add(new int[] { selectedPiece.Position[0], twoSteps });
            }
        }

        return chessPositions;
    }
}

public class ChessPieceData
{
    public PieceType Type;
    public string Color;
    public int[] Position = { 2 };

    public ChessPieceData(PieceType type, string color, int hozPos, int verPos)
    {
        Type = type;
        Color = color;
        Position[0] = hozPos;
        Position[1] = verPos;
    }
}
