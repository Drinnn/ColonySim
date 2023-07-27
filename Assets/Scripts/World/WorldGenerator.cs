using System;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    [SerializeField] private int maxX = 16;
    [SerializeField] private int maxZ = 16;
    
    private MeshFilter _meshFilter;
    
    private void Awake()
    {
        _meshFilter = GetComponent<MeshFilter>();
    }

    private void Start()
    {
        var worldMesh = CreateWorld();

        LoadMeshData(worldMesh);
    }

    private MeshData CreateWorld()
    {
        MeshData meshData = new MeshData();
        for (int x = 0; x < maxX; x++)
        {
            for (int z = 0; z < maxZ; z++)
            {
                Vector3 targetPosition = Vector3.zero;
                targetPosition.x = x * 1;
                targetPosition.z = z * 1;
                
                MeshUtilities.FaceUp(meshData, targetPosition);
            }
        }

        return meshData;
    }

    private void LoadMeshData(MeshData meshData)
    {
        Mesh mesh = new Mesh()
        {
            vertices = meshData.Vertices.ToArray(),
            uv = meshData.UV.ToArray(),
            triangles = meshData.Triangles.ToArray(),
        };

        _meshFilter.mesh = mesh;
    }
}
