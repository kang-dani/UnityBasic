using System.Security.Cryptography;
using UnityEngine;

public class PBullet : MonoBehaviour
{
	public float speed = 4.0f;
	//공격력
	//이펙트
	public GameObject effect;

	void Update()
	{
		//총알이 위로 이동
		//윗 방향 * speed * Time.deltaTime
		transform.Translate(Vector2.up * speed * Time.deltaTime);
	}

	//화면 밖으로 나갈 경우
	private void OnBecameInvisible()
	{
		//총알 제거
		Destroy(gameObject);
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Monster")
		{
			GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
			Destroy(go, 1f);

			collision.gameObject.GetComponent<Monster>().Damage(1);

			//미사일 삭제
			Destroy(gameObject);
		}
		if (collision.gameObject.tag == "Boss")
		{
			GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
			Destroy(go, 1f);

			//미사일 삭제
			Destroy(gameObject);
		}

	}

}
