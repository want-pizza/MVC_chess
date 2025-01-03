using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChessPresenter
{
    private ChessModel model;
    public ChessPresenter(ChessModel model)
    {
        this.model = model;
    }
    internal int GetBoardSize()
    {
        return model.BoardSize;
    }
    internal List<ChessPieceData> GetChessPieceData()
    {
        return model.Pieces;
    }
    internal List<int[]> GetPiecePosibleMoves(int[] coordinateSelectedPiece)
    {
        return model.GetPiecePosibleMoves(coordinateSelectedPiece);
    }
}
