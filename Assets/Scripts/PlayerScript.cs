using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] PaddleScript leftPaddle;
    [SerializeField] PaddleScript rightPaddle;
    [SerializeField] PlungerScript plunger;

    [SerializeField] InputAction useLeft;
    [SerializeField] InputAction useRight;
    [SerializeField] InputAction pullPlunger;
    // Update is called once per frame
    void Update()
    {
        leftPaddle.Flip(useLeft.IsPressed());
        //leftPaddle.Flip(useLeft.IsPressed(Mouse.current.IsPressed()))
        rightPaddle.Flip(useRight.IsPressed());
        plunger.Pull(pullPlunger.ReadValue<float>());
        
    }
    private void OnEnable()
    {
        useLeft.Enable();
        useRight.Enable();
        pullPlunger.Enable();
    }

    private void OnDisable()
    {
        useLeft.Disable();
        useRight.Disable();
        pullPlunger.Disable();
    }
}
