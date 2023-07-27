using System;
using UnityEngine;

public class MeshCreator : MonoBehaviour
{
    public Vector3[] vertices;
    public Vector2[] uv;
    public int[] triangles;

    private void Start()
    {
        Mesh mesh = new Mesh();
        mesh.vertices = vertices;
        mesh.uv = uv;
        mesh.triangles = triangles;
        GetComponent<MeshFilter>().mesh = mesh;
    }
}
