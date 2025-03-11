using UnityEngine;

public class SpawnManager : MonoBehaviour
{
     public GameObject enemyPrefab;
    void SpawnEnemy()
    {
		Instantiate(enemyPrefab, transform.position , Quaternion.identity);
		float randtime = Random.Range(0.5f, 1.5f);
		Invoke("SpawnEnemy", randtime);
	}
	void Start()
    {
		SpawnEnemy();
	}

    // Update is called once per frame
    void Update()
    {

	}
}
