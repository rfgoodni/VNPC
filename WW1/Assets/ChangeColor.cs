using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {
    private MeshRenderer render;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Cube1")
        {
            transform.Translate(1000, 1, 10, Space.World);
            transform.Rotate(0, 180, 0);
            render = col.gameObject.GetComponent<MeshRenderer>();
            render.material.color = Color.green;
        } else if (col.gameObject.name == "Cube2")
        {
            transform.Translate(-1000, 1, 10, Space.World);
            transform.Rotate(0, 180, 0);
            render = col.gameObject.GetComponent<MeshRenderer>();
            render.material.color = Color.red;
        }
    }
}
