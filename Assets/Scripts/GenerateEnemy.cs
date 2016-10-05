using UnityEngine;
using System.Collections;

public class GenerateEnemy : MonoBehaviour {

    public GameObject spawnObject;
    public float interval = 3.0f;

	// Use this for initialization
	void Start () {
        StartCoroutine("Spawn");
	}

    IEnumerator Spawn()
    {
        while (true)
        {
            Instantiate(spawnObject, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(interval);
        }
    }
}
