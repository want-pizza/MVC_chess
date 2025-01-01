using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChessView:MonoBehaviour
{
    protected ChessPresenter presenter;
    public void Init(ChessPresenter _chessPresenter)
    {
        this.presenter = _chessPresenter;
    }
    public abstract void UpdateChessBoard(List<ChessPieceData> pieceDatas);
    public abstract void EndGame();
}
