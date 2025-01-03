using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    //[SerializeField] private SlotMachine3DView _3dView;
    [SerializeField] private ChessView2D _uiView;
    [SerializeField] private bool is3D;
    [SerializeField] private bool isThreeCheckGame;
    [SerializeField] private GameObject UICellPrefab;
    [SerializeField] private Transform UIBoardParrent;
    public void StartGame(GameObject startButton)
    {
        startButton.SetActive(false);
        //ChessView viewPrefab = is3D ? _3dView : _uiView;
        ChessView viewPrefab = _uiView;

        ChessView view = GameObject.Instantiate(viewPrefab, UIBoardParrent);
        var model = new DefChessModel(view);
        ChessPresenter presenter = !isThreeCheckGame ?
            new DefChessPresenter(model) : null; // added presenter for 3 checks chess

        Debug.Log("Start Init");
        view.Init(presenter, GetComponent<ChessFactory>(), UICellPrefab);
    }
}
