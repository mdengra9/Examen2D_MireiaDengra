using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public static bool _isGrounded;
    //[SerializeField] private Animator _animator;

    // Start is called before the first frame update
    /*void Start()
    {
        _animator = GetComponent<Animator>();
    }*/

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.layer == 3)
        {
            _isGrounded = true;
           // _animator.SetBool("IsJumping", false);
        }
    }

    void OnTriggerStay2D (Collider2D other)
    {
        if(other.gameObject.layer == 3)
        {
            _isGrounded = true;
           // _animator.SetBool("IsJumping", false);
        }
    }

    void OnTriggerExit2D (Collider2D other)
    {
        if(other.gameObject.layer == 3)
        {
            _isGrounded = false;
           // _animator.SetBool("IsJumping", true);
        }
    }
}
