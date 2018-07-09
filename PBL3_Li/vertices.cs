using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vertices : MonoBehaviour {
	//顶点数组
	public Vector3[] Vertexes;
	//网格过滤器
	private MeshFilter _meshFilter;
	//网格
	private Mesh _mesh;

	// Use this for initialization
	void Start () {
		Vertexes = new Vector3[] { Vector3.zero, new Vector3(-1, 1, 0), new Vector3(1, 2, 0), new Vector3(2, -1, 0) };

		_mesh = GetComponent<MeshFilter> ().mesh;
		_mesh.Clear ();
		//得到三角形的数量
		int trianglesCount = Vertexes.Length - 2;

		//三角形顶点ID数组
		int[] triangles = new int[trianglesCount * 3];

		//绘制三角形
		_mesh.vertices = Vertexes;

		//三角形顶点索引,确保按照顺时针方向设置三角形顶点
		for (int i = 0; i < trianglesCount; i++)
		{
			for (int j = 0; j < 3; ++j)
			{
				triangles[i * 3 + j] = j == 0 ? 0 : i + j;
			}
		}
		_mesh.triangles = triangles;
//		_meshFilter.mesh = _mesh;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
