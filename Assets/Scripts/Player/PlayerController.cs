using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerForm currentForm;
    private Rigidbody _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Instantiate(currentForm.model, this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        //walk
        _rigidbody.velocity = currentForm.MoveSpeed * Input.GetAxis("Vertical") * Vector3.forward + currentForm.MoveSpeed * Input.GetAxis("Horizontal") * Vector3.right;
    }
}
