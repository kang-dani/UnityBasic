using System.Security.Cryptography;
using UnityEngine;

public class PBullet : MonoBehaviour
{
	public float speed = 4.0f;
	//���ݷ�
	public int Attack = 10;
	//����Ʈ
	public GameObject effect;

	void Update()
	{
		//�Ѿ��� ���� �̵�
		//�� ���� * speed * Time.deltaTime
		transform.Translate(Vector2.up * speed * Time.deltaTime);
	}

	//ȭ�� ������ ���� ���
	private void OnBecameInvisible()
	{
		//�Ѿ� ����
		Destroy(gameObject);
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Monster")
		{
			GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
			Destroy(go, 1f);

			//collision.gameObject.GetComponent<Monster>().Damage(Attack);
			PoolManager.Instance.Return(collision.gameObject);

			//�̻��� ����
			Destroy(gameObject);
		}
		if (collision.gameObject.tag == "Boss")
		{
			GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
			Destroy(go, 1f);

			//�̻��� ����
			Destroy(gameObject);
		}

	}

}
