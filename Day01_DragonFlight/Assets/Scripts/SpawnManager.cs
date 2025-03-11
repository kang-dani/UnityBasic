using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //���� ������ ����
    public GameObject Enemy;

    void SpawnEnemy()
	{
		//������ ��ġ�� ���� ����
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
