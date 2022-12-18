using Cinemachine.Utility;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;

public class Player_Controller : MonoBehaviour
{
    Vector2 input;
    public Transform cameraRef;
    private float heading = 0;
    private Vector3 moveInput;
    private Rigidbody rb;
    private Vector2 rotateInput; 
    private Vector3 moveDirection;
    [SerializeField] public GameObject Shootobj;
    [SerializeField] private float Health;
    [SerializeField] float sensetivity;
    [SerializeField] float speed;

    private bool hasDied = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        
        moveInput = context.ReadValue<Vector3>();
        //moveDirection = new Vector3(moveInput.x,0, moveInput.y);
        
    }

   // public void playerUp(InputAction.CallbackContext context) 
    //{
      //  Debug.Log("jump");
        //rb.velocity = new Vector3(0,100,0);
        
    //}

    // Update is called once per frame
    void Update()
    {
        //Camera.main.transform.position
        Debug.Log("player: " + this.name + " health is: " + Health);

        //moveInput.x* transform.right;
        //moveInput.y* transform.forward;
        moveDirection = cameraRef.forward * moveInput.z + cameraRef.right * moveInput.x + cameraRef.up * moveInput.y;

        if (Health < 0 && hasDied == false)
        {
            hasDied = true;
            SceneManager.LoadScene("Victory");
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("Victory"));
        }

    }
    private void FixedUpdate()
    {

        //transform.position = transform.position + (new Vector3(moveInput.x, 0f, moveInput.y) * Time.deltaTime * 50f);


       
        rb.AddForce(moveDirection * speed * Time.fixedDeltaTime);

        var newAngles = new Vector3(rotateInput.y, rotateInput.x, 0f);
        transform.Rotate(newAngles, Space.Self);

        Debug.Log(rotateInput);
        
    }
   // public void playerDown(InputAction.CallbackContext context)
    //{
      //  Debug.Log("down!");
       // rb.velocity = new Vector3(0, -100, 0);
    //}
    public void MainRotation(InputAction.CallbackContext context)
    {
       
       
            rotateInput = context.ReadValue<Vector2>();
        rotateInput = new Vector2(rotateInput.x * Time.fixedDeltaTime * sensetivity, rotateInput.y * Time.fixedDeltaTime * sensetivity);
        /*
        if (context.canceled)
        {
            Debug.Log("stop");
            rotateInput = new Vector2(0, 0);
            rb.angularVelocity = Vector3.zero;
        }
        */
    }
   
    public void OnShoot(InputAction.CallbackContext context)
    {
        GetComponentInChildren<CharacterWeapon>().OnShoot(context);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Bullet")
        {
            Health -= 1;
            
        }
        Debug.Log(Health);
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        rb.AddForce(moveDirection * speed * 0.6f);
    }
}
