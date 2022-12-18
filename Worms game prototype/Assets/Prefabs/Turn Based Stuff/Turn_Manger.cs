using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_Manger : MonoBehaviour
{
    public float Timer;
    public Player_Controller Player1;
    public Player_Controller Player2;
    public Player_Controller activePlayer;

    // Start is called before the first frame update
    void Awake()
    {
        activePlayer = Player1;
        InvokeRepeating("SwapTimer", Timer, Timer);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SwapTimer()
    {
        if(activePlayer == Player1)
        {
            activePlayer = Player2;
        }
        else
        {
            activePlayer = Player1;
        }

    }
}
