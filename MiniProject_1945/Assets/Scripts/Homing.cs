using UnityEngine;

public class Homing : MonoBehaviour
{
    public GameObject target;       //플레이어를 찾을 것임
    public float Speed = 3f;
    Vector2 dir;
    Vector2 dirNo;

	void Start()
    {
        // 플레이어를 찾아서 target에 저장
        target = GameObject.FindGameObjectWithTag("Player");        //태그로만 찾아서 메모리 효율 및 성능 높임
		dir = target.transform.position - transform.position;       //A - B = B에서 A로 가는 벡터
		dirNo = dir.normalized;                                     //방향 벡터만 구하기
	}

	void Update()
    {
        transform.Translate(dirNo * Speed * Time.deltaTime);       //방향 벡터로 이동    
                                                  // 내 위치                   목표 지점               이동 속도
        //transform.position = Vector2.MoveTowards(transform.position, target.transform.position, Speed * Time.deltaTime);       //목표지점까지 이동
	}
	private void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Player")
		{
			//Destroy(collision.gameObject);
			Destroy(gameObject);
		}
	}
}
