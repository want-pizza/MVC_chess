using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessView2D : ChessView
{
    DefChessPresenter chessPresenter;

    public override void EndGame()
    {
        throw new System.NotImplementedException();
    }

    public void OnPlayButtonClicked()
    {

    }

    public override void UpdateChessBoard(List<ChessPieceData> pieceDatas)
    {
        throw new System.NotImplementedException();
    }
}
