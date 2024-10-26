using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEvent : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;
       
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

        private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Cube_1")
        {
            mat.color = new Color(0, 1, 0);
        }
    }

    private void OncollisionStay(Collision collision)
    {

    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.name == "Cube_1")
        {
            mat.color = new Color(1, 1, 1);
        }
    }

    
    void Update()
    {
        
    }
}
