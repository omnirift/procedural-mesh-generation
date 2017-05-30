using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshGenerator : MonoBehaviour {

    public Material mat;

    float width = 1;
    float height = 1;

    // Use this for initialization
    void Start()
    {
        Mesh mesh = new Mesh();

        Vector3[] vertices = new Vector3[4];

        vertices[0] = new Vector3(-width, -height);
        vertices[1] = new Vector3(-width, height);
        vertices[2] = new Vector3(width, height);
        vertices[3] = new Vector3(width, -height);

        mesh.vertices = vertices;

        mesh.triangles = new int[] { 0, 1, 2, 0, 2, 3 };

        GetComponent<MeshRenderer>().material = mat;

        GetComponent<MeshFilter>().mesh = mesh;
    }
}
