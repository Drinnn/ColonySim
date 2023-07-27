using System.Linq;
using UnityEngine;

public static class MeshUtilities
{
    public static void FaceUp(MeshData meshData, Vector3 originPoint)
    {
        var vertices = new Vector3[4];
        vertices[0] = new Vector3(originPoint.x - .5f, originPoint.y + .5f, originPoint.z + .5f);
        vertices[1] = new Vector3(originPoint.x + .5f, originPoint.y + .5f, originPoint.z + .5f);
        vertices[2] = new Vector3(originPoint.x + .5f, originPoint.y + .5f, originPoint.z - .5f);
        vertices[3] = new Vector3(originPoint.x - .5f, originPoint.y + .5f, originPoint.z - .5f);
        meshData.AddVertices(vertices.ToList());

        var triangles = new int[6];
        triangles[0] = meshData.Vertices.Count - 4; // First element
        triangles[1] = meshData.Vertices.Count - 3; // Second element
        triangles[2] = meshData.Vertices.Count - 2; // Third element
        triangles[3] = meshData.Vertices.Count - 4;
        triangles[4] = meshData.Vertices.Count - 2;
        triangles[5] = meshData.Vertices.Count - 1;
        meshData.AddTriangles(triangles.ToList());        
        
    }   
}
