using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Manger : MonoBehaviour
{
    private Transform camerRef;
    private Camera mainCamera;
    private Player_Controller activePlayer;

    public void SwapPlayer()
    {
        camerRef = activePlayer.cameraRef;
        
    }
    

    // Start is called before the first frame update
    void Start()
    {
        
        mainCamera = Camera.main;
        
    }

    // Update is called once per frame
    void Update()
    {
        activePlayer = GameObject.Find("TurnManager").GetComponent<Turn_Manger>().activePlayer;
        SwapPlayer();
        mainCamera.transform.position = camerRef.position;
        mainCamera.transform.rotation = camerRef.rotation;
    }
}
