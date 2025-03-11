using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 2f;
	public GameObject explosion;  //���� ����Ʈ �������� ���� ����
	void Start()
    {

	}

    // Update is called once per frame
    void Update()
    {
        //Y �� �̵�
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
	}
	private void OnBecameInvisible()
	{
		Destroy(gameObject);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		//�ҷ��� �� �浹��
		if (collision.tag == "Enemy")
		{
			GameManager.instance.Add(10);
			SoundManager.instance.SoundDie();
			//���� ����Ʈ ����
			Instantiate(explosion, transform.position, Quaternion.identity);
			//�� �����
			Destroy(collision.gameObject);
			//�Ѿ� ����� �ڱ��ڽ�
			Destroy(gameObject);
		}
	}
}
