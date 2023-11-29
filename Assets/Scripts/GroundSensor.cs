using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public static bool _isGrounded;

    void OnTriggerEnter2D (Collider other)
    {
        if(other.gameObject.layer == 3)
        {
            _isGrounded = true;
        }
    }

    void OnTriggerStay2D (Collider other)
    {
        if(other.gameObject.layer == 3)
        {
            _isGrounded = true;
        }
    }

    void OnTriggerExit2D (Collider other)
    {
        if(other.gameObject.layer == 3)
        {
            _isGrounded = false;
        }
    }
}
