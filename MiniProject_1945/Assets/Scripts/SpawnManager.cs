using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float ss = -2;       //몬스터 생성 x값 시작 좌표
    public float es = 2;        //몬스터 생성 x값 끝 좌표
    public float StartTime = 1;
    public float SpawnTime = 10;
    public GameObject monster;
    public GameObject monster2;
	public GameObject Boss;

    bool swi = true;
	bool swi2 = true;

	[SerializeField]
	GameObject textBossWarning;

	private void Awake()
	{
		textBossWarning.SetActive(false);
		PoolManager.Instance.CreatePool(monster, 10);

	}

	void Start()
    {
        StartCoroutine(RandomSpawn());
        Invoke("Stop", SpawnTime);
	}

    //코루틴으로 랜덤하게 생성하기
    IEnumerator RandomSpawn()
    {
        while(swi)
		{
            
			yield return new WaitForSeconds(StartTime);                          //1초마다
			float x = Random.Range(ss, es);                                      //x값 랜덤
            Vector2 r = new Vector2(x, transform.position.y);                    //x값을 r에 저장
																				 //Instantiate(monster, r, Quaternion.identity);
			GameObject enemy = PoolManager.Instance.Get(monster);
			enemy.transform.position = r;
		}   
	}
	IEnumerator RandomSpawn2()
	{
		while (swi2)
		{

			yield return new WaitForSeconds(StartTime + 2);                      //1초마다
			float x = Random.Range(ss, es);                                      //x값 랜덤
			Vector2 r = new Vector2(x, transform.position.y);                    //x값을 r에 저장
			Instantiate(monster2, r, Quaternion.identity);
		}
	}

	void Stop()
    {
		swi = false;
		//두번째 몬스터 코루틴
		StopCoroutine(RandomSpawn());
		StartCoroutine(RandomSpawn2());

		//30초 뒤에 두번째 몬스터 호출 멈추기
		Invoke("Stop2", SpawnTime);
	}
	void Stop2()
	{
		swi2 = false;
		//두번째 몬스터 코루틴
		StopCoroutine(RandomSpawn2());
		StartCoroutine(Shake());

		//보스
		textBossWarning.SetActive(true);
		Vector3 pos = new Vector3(0, 3.0f, 0);
		Instantiate(Boss, pos, Quaternion.identity);
	}

	IEnumerator Shake()
	{
		for (int i = 0; i < 3; i++)
		{
			yield return new WaitForSeconds(0.2f);
			CameraShake.instance.CameraShakeShow();
		}
	}
}
