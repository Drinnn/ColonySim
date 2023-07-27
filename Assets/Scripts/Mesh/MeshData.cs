using System.Collections.Generic;
using UnityEngine;

public class MeshData
{
    public readonly List<Vector3> Vertices = new();
    public readonly List<int> Triangles = new();
    public readonly List<Vector2> UV = new();

    public void AddVertices(List<Vector3> verticesToAdd)
    {
        Vertices.AddRange(verticesToAdd);
    }

    public void AddTriangles(List<int> trianglesToAdd)
    {
        Triangles.AddRange(trianglesToAdd);
    }

    public void AddUvs(List<Vector2> uvToAdd)
    {
        UV.AddRange(uvToAdd);
    }
}
