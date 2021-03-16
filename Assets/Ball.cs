using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.AddTorque(Vector3.up);  // 토크
        rigid.velocity = Vector3.right;  // 속도
    }

    // Update is called once per frame
    void FixedUpdate()
    {        
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Jump"),
            Input.GetAxis("Vertical")
        );

        rigid.AddForce(vec, ForceMode.Impulse);  // 힘주기

    }

    private void OnTriggerStay(Collider other) {
        if(other.name == "JumpArea")
            rigid.AddForce(Vector3.up, ForceMode.Impulse);
    }

    public void set() {
        transform.position = new Vector3(-2.75999999f,0.437168121f,-0.600000143f);
    }
}
