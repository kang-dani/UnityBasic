using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //몬스터 가지고 오기
    public GameObject Enemy;

    void SpawnEnemy()
	{
		//랜덤한 위치에 몬스터 생성
		float randomX = Random.Range(-2f, 2f);
		Instantiate(Enemy, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
	}
	void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 0.5f);
	}

    void Update()
    {
        
    }
}
