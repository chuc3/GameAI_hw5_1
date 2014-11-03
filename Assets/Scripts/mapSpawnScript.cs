using UnityEngine;
using System.Collections;

public class mapSpawnScript : MonoBehaviour {

	public Transform tile;
	public TextAsset map;


	void Awake() {
		// subdivide map by newline chars
		string [] lines = map.text.Split ('\n'); int i, j,d; i=j=d=0;

		foreach (string l in lines)
		{
			foreach (char c in l)
			{
				if(c=='.' && d==0)
				{
					d=3;
				}
				else if(c == '.' && d>0)
				{
					d--;
				}
				else
				{
					Vector3 v = new Vector3(i,j,0f);
					GameObject g = new GameObject();
					g = Instantiate(tile,v, Quaternion.identity) as GameObject;
					if(c=='.')
						tile.renderer.material.color = Color.blue;
					else
						tile.renderer.material.color = Color.red;
					i++;
				}

			}
			i=0;j++;
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
