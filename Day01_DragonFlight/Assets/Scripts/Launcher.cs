using JetBrains.Annotations;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;       //�Ѿ� ������

	void Start()
    {
        //InvokeRepeating(�Լ��̸�, �ʱ� �����ð�, ������ �ð�)
        InvokeRepeating("Shoot", 0.5f, 0.5f);
	}
    void Shoot()
	{
		//�Ѿ� ����
		//Instantiate(������ ������Ʈ, ������ ��ġ, ������ ����)
		SoundManager.instance.SoundBullet();
		Instantiate(bullet, transform.position, Quaternion.identity);
	}
	void Update()
    {
        
    }
}
