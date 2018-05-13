using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FisrstLevelGenerate : MonoBehaviour {

	public GameObject locked;
	public float posX;
	public float posY;

	// Use this for initialization
	void Start () {

		MapGenerator(locked);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void MapGenerator(GameObject stop)
	{
		
		int[,] MapGenerator = new int[12, 9];
		for (int i = 0; i < 12; i ++)
			for (int j = 0; j < 9; j ++)
				MapGenerator[i, j] = 0;

		for (int i = 0;i<12;i++)
		{
			MapGenerator[i, 0] = 1;
			MapGenerator[i, 8] = 1;
		}
		for (int j = 0; j < 9; j++)
		{
			MapGenerator[0, j] = 1;
			MapGenerator[11, j] = 1;
		}
		for (int i = 1; i < 10; i = i + 2)
			for (int j = 1; j < 8; j = j + 2)
			{
				MapGenerator[i, j] = 1;
			}


		for (int i = 0; i < 12; i++)
			for (int j = 0; j < 9; j++)
				if (MapGenerator[i, j] != 0)
				{
					Instantiate(stop, new Vector3(posX+(0.6f*j), posY+(0.6f*i), -2.08f), Quaternion.identity);
				}
	}
}
