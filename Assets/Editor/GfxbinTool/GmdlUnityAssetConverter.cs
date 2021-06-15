using SQEX.Luminous.Renderer;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace GfxbinTool
{
    public class GmdlUnityAssetConverter : MonoBehaviour
    {
        public static void Convert(ModelResourceNode gmdl, string inputPath, string outputPath)
        {
            // Create a game object and helper objects to recreate the mesh
            // from the source file. Get file name without .gmdl.gfxbin
            // extension.
            GameObject mainObject = new GameObject((Path.GetFileNameWithoutExtension(inputPath)).Split('.')[0]);
            GameObject meshObject = new GameObject("Mesh");
            meshObject.transform.parent = mainObject.transform;
            GameObject parts_Base = new GameObject("Parts_Base");
            parts_Base.transform.parent = meshObject.transform;
            foreach (MeshContainer meshContainer in gmdl.MeshContainers)
            {
                // I'm pretty sure the Count variable is optimized such that
                // this won't damage performance, but if the script becomes
                // slow try storing count in a variable before entering the
                // loop.
                foreach (SQEX.Luminous.Renderer.Mesh luminMesh in meshContainer.Meshes)
                {
                    GameObject gameObject = new GameObject(luminMesh.Name);
                    gameObject.transform.parent = parts_Base.transform;
                    UnityEngine.Mesh mesh = new UnityEngine.Mesh();
                    UnityEngine.SkinnedMeshRenderer smr =  gameObject.AddComponent<SkinnedMeshRenderer>();
                    List<Vector3> luminVertices = new List<Vector3>();
                    List<Vector3> normalsList = new List<Vector3>();
                    Vector3[] normalsArray;
                    List<Vector4> tangentList = new List<Vector4>();
                    List<int> triangles = new List<int>();

                    // Read the vertex information from the input file and 
                    // convert the list (vertex information) at each position
                    // to an array of doubles
                    List<float> positions = luminMesh.VertexElementArrays["POSITION0"] as List<float>;
                    float[] floatPositions = (from Position in positions
                                                select Position).ToArray();

                    int[] indices = (from index in luminMesh.GmdlGeometry.IdxBuffer
                                        select (int)index).ToArray();

                    // Convert triangles to proper order for unity normals
                    for (var j = 0; j < indices.Length; j += 3)
                    {
                        var a = indices[j];

                        indices[j] = indices[j + 2];
                        indices[j + 2] = a;
                    }

                    // Load the vertices into a vector3 list
                    for (uint j = 0; j < luminMesh.VertexCount * 3; j += 3)
                    {
                        luminVertices.Add(new Vector3(floatPositions[j],
                                                        floatPositions[j + 1],
                                                        floatPositions[j + 2]));
                    }

                    foreach (int triangle in indices) { triangles.Add(triangle); }

                    // TODO: Figure out why I am passing the mesh to these
                    // functions. It doesn't look like I'm using them.
                    if (luminMesh.VertexElementArrays.ContainsKey("NORMAL0"))
                    {
                        AddLayerNormal(luminMesh.VertexElementArrays["NORMAL0"], ref normalsList, mesh);
                        normalsArray = normalsList.ToArray();
                    }

                    if (luminMesh.VertexElementArrays.ContainsKey("TANGENT0"))
                    {
                        AddLayerTangent(luminMesh.VertexElementArrays["TANGENT0"], ref tangentList, normalsList.ToArray());
                    }

                    // Set mesh parts
                    mesh.vertices = luminVertices.ToArray();
                    mesh.normals = normalsList.ToArray();
                    mesh.triangles = triangles.ToArray();
                    mesh.tangents = tangentList.ToArray();

                    smr.sharedMesh = mesh;

                    // This temp hack causes the script to only write the 
                    // first mesh which reduces the amount of time each test
                    // takes.
                    // break;
                }
            }
        }
        
        private static void AddLayerNormal(IList rawNormals, ref List<Vector3> normalsList, UnityEngine.Mesh mesh)
        {
            float[] normalsConverted = ConvertToFloatArray(rawNormals);
            for (int i = 0; i < normalsConverted.Length; i += 4)
            {
                normalsList.Add(new Vector3(/*-*/normalsConverted[i],
                                            normalsConverted[i + 1],
                                            /*-*/normalsConverted[i + 2]));
            }
        }

        private static void AddLayerTangent(IList rawTangents, ref List<Vector4> tangentList, Vector3[] normals)
        {
            float[] tangentsConverted = ConvertToFloatArray(rawTangents);
            for (int i = 0; i < tangentsConverted.Length; i += 4)
            {
                Vector4 vector4 = new Vector4(-tangentsConverted[i],
                                              tangentsConverted[i + 1],
                                              -tangentsConverted[i + 2],
                                              tangentsConverted[i + 3]);
                tangentList.Add(vector4);
            }
        }

        private static float[] ConvertToFloatArray(IList list)
        {
            float[] result = new float[list.Count];
            for(int i = 0; i < list.Count; i++)
            {

                if (list[i] is float fl)
                {
                    result[i] = fl;
                }
                else if (list[i] is sbyte sb)
                {
                    result[i] = (float) sb / sbyte.MaxValue;
                }
            }
            return result;
        }
    }
}

