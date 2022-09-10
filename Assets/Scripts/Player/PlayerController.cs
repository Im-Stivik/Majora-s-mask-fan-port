using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerForm currentForm;
    private Rigidbody _rigidbody;
    private Camera _camera;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Instantiate(currentForm.model, this.transform);
        _camera = Camera.main;
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move(){
        //rotate the player away from the camera in y axis
        transform.rotation = Quaternion.Euler(0, _camera.transform.rotation.eulerAngles.y, 0);
        //get the input
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        //move the player forward with max speed
        _rigidbody.velocity = (transform.forward * vertical + transform.right * horizontal) * currentForm.MoveSpeed;
    }
}
