using JetBrains.Annotations;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;       //총알 프리팹

	void Start()
    {
        //InvokeRepeating(함수이름, 초기 지연시간, 지연할 시간)
        InvokeRepeating("Shoot", 0.5f, 0.5f);
	}
    void Shoot()
	{
		//총알 생성
		//Instantiate(생성할 오브젝트, 생성할 위치, 생성할 방향)
		SoundManager.instance.SoundBullet();
		Instantiate(bullet, transform.position, Quaternion.identity);
	}
	void Update()
    {
        
    }
}
