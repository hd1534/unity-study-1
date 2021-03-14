using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTest : MonoBehaviour
{
    Vector3 target =  new Vector3(8, 1.5f, 0);
    Vector3 velocity = Vector3.zero;


    // Start is called before the first frame update
    void Start()
    {
        // Lerp
        transform.position = Vector3.Lerp(
            transform.position, target, 0.1f
        );
    }

    // Update is called once per frame
    void Update()
    {
        /* Translate
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal") * 0.1f,
            Input.GetAxis("Vertical") * 0.1f,
            0
        );

        transform.Translate(vec);
        */

        /* MoveTowards
        transform.position = Vector3.MoveTowards(
            transform.position, target, 1f
        );
        */

        /* SmoothDamp
        transform.position = Vector3.SmoothDamp(
            transform.position, target, ref velocity, 1f
        );
        */

        // Slerp
        transform.position = Vector3.Slerp(
            transform.position, target, 0.005f
        );
    }
}
