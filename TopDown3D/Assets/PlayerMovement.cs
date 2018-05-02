using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    public float movementspeed = 3f;
    private Vector3 move;
    private Rigidbody rb;
    // Use this for initialization
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
       move = new Vector3(-Input.GetAxis("Horizontal"), 0.0f, -Input.GetAxis("Vertical"));
     //(move * Time.deltaTime * movementspeed);
       rb.velocity= move * movementspeed;
    }
}
