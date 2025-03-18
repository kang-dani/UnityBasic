using UnityEngine;

public class Monster : MonoBehaviour
{
	public int Hp = 100;
	public float Speed = 3;
	public float Delay = 1f;
	public Transform ms1;
	public Transform ms2;
	public GameObject bullet;

	//������ ��������
	public GameObject Item = null;

	void Start()
	{
		Invoke("CreateBullet", Delay);
	}

	void CreateBullet()
	{
		Instantiate(bullet, ms1.position, Quaternion.identity);
		Instantiate(bullet, ms2.position, Quaternion.identity);
		Invoke("CreateBullet", Delay);		//��� ȣ��
	}


	void Update()
	{
		//�Ʒ� �������� ��������
		transform.Translate(Vector2.down * Speed * Time.deltaTime);
	}

	private void OnBecameInvisible()
	{
		//PoolManager.Instance.Return(gameObject);
		Destroy(gameObject);
	}

	//�̻��Ͽ� ���� ������ �Դ� �Լ�
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
		//������ ����
		Instantiate(Item, transform.position, Quaternion.identity);
	}
}
