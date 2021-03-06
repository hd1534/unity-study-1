using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyBall : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;

    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "myBall")
            mat.color = new Color(0, 0, 0);
    }

    private void OnCollisionExit(Collision other) {
        if (other.gameObject.name == "myBall")
            mat.color = new Color(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
