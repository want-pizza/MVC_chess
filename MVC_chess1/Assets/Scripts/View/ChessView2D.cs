using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ChessView2D : ChessView
{
    List<Transform> boardPieces = new List<Transform>(); 

    public override void Init(ChessPresenter _chessPresenter, ChessFactory factory, GameObject piecePrefab)
    {
        boardPieces.Clear();
        this.presenter = _chessPresenter;
        int size = presenter.GetBoardSize();
        Debug.Log($"size = {size}");

        float cellSize = piecePrefab.GetComponent<RectTransform>().rect.width;
        float offsetX = -(size * cellSize) / 2f + cellSize / 2f;
        float offsetY = -(size * cellSize) / 2f + cellSize / 2f;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Debug.Log("instantiating");
                Transform newCell = factory.InstantiateBoard2D(piecePrefab, this.transform).transform;

                float xPos = i * cellSize + offsetX;
                float yPos = j * cellSize + offsetY;

                newCell.localPosition = new Vector3(xPos, yPos, 0f);

                boardPieces.Add(newCell);
            }
        }

    }
    public override void UpdateChessBoard(List<ChessPieceData> pieceDatas)
    {
        throw new System.NotImplementedException();
    }
    public override void EndGame()
    {
        throw new System.NotImplementedException();
    }
}
