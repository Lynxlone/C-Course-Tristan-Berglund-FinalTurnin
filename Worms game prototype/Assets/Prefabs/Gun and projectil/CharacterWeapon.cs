using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterWeapon : MonoBehaviour

{
    //[SerializeField] private activePlayer playerTurn;
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform shootingStartPosition;

    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Shoot!");
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
    }
}


/*
if Shoot_Input(InputAction.CallbackContext context)
{
    bool IsPlayerTurn = playerTurn.IsPlayerTurn();
    if (IsPlayerTurn)
    {
        Vector3 force = transform.forward * 700f + transform.up * 300f;

        Turn_Manger.GetInstance().TriggerChangeTurn();
        GameObject newProjectile = Instantiate(projectilePrefab);
        newProjectile.transform.position = shootingStartPosition.position;
        newProjectile.GetComponent<Projectile>().Initialize(force);
    }
}
*/