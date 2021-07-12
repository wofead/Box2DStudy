using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshRendererAndFilter : MonoBehaviour
{
    private MeshFilter filter;
    private Mesh filterMesh;
    private MeshRenderer renderer;

    //绘制三角形顶点坐标
    private Vector3[] vertices;
    //绘制三角形所需顶点ID顺序
    private int[] triangles;
    //顶点数
    private int count;
    //记录所有点的坐标
    private List<Vector3> list;

    void Awake()
    {
        filter = gameObject.GetComponent<MeshFilter>();
        filterMesh = filter.mesh;
        renderer = gameObject.GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        list = new List<Vector3>();
        renderer.material.color = Color.green;
        renderer.material.shader = Shader.Find("Transparent/Diffuse");
        // 清空所有点，用于初始化
        filterMesh.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            count++;
            list.Add(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.8f)));

            if (count >=3)
            {
                //绘制的三角形的index
                triangles = new int[3 * (count - 2)];
                //顶点个数
                vertices = new Vector3[count];
                for (int i = 0; i < count; i++)
                {
                    vertices[i] = list[i];
                }

                int trianglesCount = count - 2;
                for (int i = 0; i < trianglesCount; i++)
                {
                    triangles[3 * i] = 0;
                    triangles[3 * i + 1] = i + 2;
                    triangles[3 * i + 2] = i + 1;
                }

                filterMesh.vertices = vertices;
                filterMesh.triangles = triangles;
            }
        }
    }
}
