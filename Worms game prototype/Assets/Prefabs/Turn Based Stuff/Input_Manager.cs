using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Input_Manager : MonoBehaviour
{
    private Player_Controller activePlayer;

    public Vector2 moveInputDisplay;

    // Start is called before the first frame update
    void Update()
    {
        activePlayer = GameObject.Find("TurnManager").GetComponent<Turn_Manger>().activePlayer;

    }

    public void Move(InputAction.CallbackContext context)
    {
        activePlayer.OnMoveInput(context);

        
        moveInputDisplay = context.ReadValue<Vector2>();
    }

  //  public void upMove(InputAction.CallbackContext context)
    //{
      //  if (context.performed)
        //{
          //activePlayer.playerUp(context);

   //     }
 //   }
      
  //  public void downMove(InputAction.CallbackContext context)
    //{
      //  if (context.performed)
        //{
          //  activePlayer.playerDown(context);

        //}

    //}
    public void RotationMain(InputAction.CallbackContext context)
    {
        //if (context.performed)
       // {
            activePlayer.MainRotation(context);

        //}

    }

    public void ShootMain(InputAction.CallbackContext context)
    {
        activePlayer.OnShoot(context);

    }
    public void JumpMain(InputAction.CallbackContext context)
    {
        activePlayer.OnJump(context);
    }
}
