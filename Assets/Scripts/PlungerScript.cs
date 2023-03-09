using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlungerScript : MonoBehaviour
{
    [SerializeField] SpringJoint2D joint;
    public void Pull(float amount)
    {
        joint.distance = amount * -12f;
        joint.attachedRigidbody.AddForce(Vector2.down * amount * 16);
    }
}
