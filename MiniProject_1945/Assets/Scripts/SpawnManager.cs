using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float ss = -2;       //���� ���� x�� ���� ��ǥ
    public float es = 2;        //���� ���� x�� �� ��ǥ
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

    //�ڷ�ƾ���� �����ϰ� �����ϱ�
    IEnumerator RandomSpawn()
    {
        while(swi)
		{
            
			yield return new WaitForSeconds(StartTime);                          //1�ʸ���
			float x = Random.Range(ss, es);                                      //x�� ����
            Vector2 r = new Vector2(x, transform.position.y);                    //x���� r�� ����
																				 //Instantiate(monster, r, Quaternion.identity);
			GameObject enemy = PoolManager.Instance.Get(monster);
			enemy.transform.position = r;
		}   
	}
	IEnumerator RandomSpawn2()
	{
		while (swi2)
		{

			yield return new WaitForSeconds(StartTime + 2);                      //1�ʸ���
			float x = Random.Range(ss, es);                                      //x�� ����
			Vector2 r = new Vector2(x, transform.position.y);                    //x���� r�� ����
			Instantiate(monster2, r, Quaternion.identity);
		}
	}

	void Stop()
    {
		swi = false;
		//�ι�° ���� �ڷ�ƾ
		StopCoroutine(RandomSpawn());
		StartCoroutine(RandomSpawn2());

		//30�� �ڿ� �ι�° ���� ȣ�� ���߱�
		Invoke("Stop2", SpawnTime);
	}
	void Stop2()
	{
		swi2 = false;
		//�ι�° ���� �ڷ�ƾ
		StopCoroutine(RandomSpawn2());
		StartCoroutine(Shake());

		//����
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
