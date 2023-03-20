using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    [SerializeField] HingeJoint2D joint;

    public void Flip(bool isPressed)
    {  
        joint.useMotor = isPressed;
    }
}
