using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    //Camera mainCamera;

    //private InputMasterControls inputActionControls;
    //public LayerMask movementMask;

    void Awake()
    {
        //inputActionControls.Player.Movement.performed += movement_performed => OnMovement(movement_performed.ReadValue<Vector2>());
        //inputActionControls.Player.Movement.canceled += movement_canceled => Canceled();
    }
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMovement(Vector2 direction)
    {
        Debug.Log("Player is moving " + direction);
    }

    void OnEnable()
    {
        //inputActionControls.Player.Movement.Enable();
    }

    void OnDisable()
    {
        //inputActionControls.Player.Movement.Disable();
    }
}
