using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    public float MovementSpeed;
    public float JumpPower;

    private Rigidbody2D _ridigbody;

    private void Start()
    {
        _ridigbody = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {




        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;


        if (!Mathf.Approximately(0, movement))
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_ridigbody.velocity.y) < 0.001)
        {
            _ridigbody.AddForce(new Vector2(0, JumpPower), ForceMode2D.Impulse);
        }

    }
 




}