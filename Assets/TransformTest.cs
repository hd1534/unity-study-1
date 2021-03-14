using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal") * 0.1f,
            Input.GetAxis("Vertical") * 0.1f,
            0
        );

        transform.Translate(vec);
    }
}
