using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessFactory:MonoBehaviour
{
    public static ChessFactory Instance = new ChessFactory();
    public GameObject InstancePiece3D()
    {
        return null;
    }
    public GameObject InstantiateBoard2D(GameObject boardCellPrefab, Transform parent = null) {
        if (parent == null)
            return Instantiate(boardCellPrefab, Vector3.zero, Quaternion.identity);
        return Instantiate(boardCellPrefab, Vector3.zero, Quaternion.identity, parent);
    }
}
