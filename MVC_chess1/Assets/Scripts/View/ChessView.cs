using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChessView:MonoBehaviour
{
    protected ChessPresenter presenter;
    public abstract void Init(ChessPresenter _chessPresenter, ChessFactory factory, GameObject piecePrefab);
    public abstract void UpdateChessBoard(List<ChessPieceData> pieceDatas);
    public abstract void EndGame();
}
