using UnityEngine;

public class Monster : MonoBehaviour
{
	public int Hp = 100;
	public float Speed = 3;
	public float Delay = 1f;
	public Transform ms1;
	public Transform ms2;
	public GameObject bullet;

	//아이템 가져오기
	public GameObject Item = null;

	void Start()
	{
		Invoke("CreateBullet", Delay);
	}

	void CreateBullet()
	{
		Instantiate(bullet, ms1.position, Quaternion.identity);
		Instantiate(bullet, ms2.position, Quaternion.identity);
		Invoke("CreateBullet", Delay);		//재귀 호출
	}


	void Update()
	{
		//아래 방향으로 움직여라
		transform.Translate(Vector2.down * Speed * Time.deltaTime);
	}

	private void OnBecameInvisible()
	{
		//PoolManager.Instance.Return(gameObject);
		Destroy(gameObject);
	}

	//미사일에 따른 데미지 입는 함수
	public void Damage(int attack)
	{
		Hp -= attack;
		if(Hp <= 0)
		{
			ItemDrop();
			//PoolManager.Instance.Return(gameObject);
			Destroy(gameObject);
		}
	}

	public void ItemDrop()
	{
		//아이템 생성
		Instantiate(Item, transform.position, Quaternion.identity);
	}
}
