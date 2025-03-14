using UnityEngine;

public class Homing : MonoBehaviour
{
    public GameObject target;       //�÷��̾ ã�� ����
    public float Speed = 3f;
    Vector2 dir;
    Vector2 dirNo;

	void Start()
    {
        // �÷��̾ ã�Ƽ� target�� ����
        target = GameObject.FindGameObjectWithTag("Player");        //�±׷θ� ã�Ƽ� �޸� ȿ�� �� ���� ����
		dir = target.transform.position - transform.position;       //A - B = B���� A�� ���� ����
		dirNo = dir.normalized;                                     //���� ���͸� ���ϱ�
	}

	void Update()
    {
        transform.Translate(dirNo * Speed * Time.deltaTime);       //���� ���ͷ� �̵�    
                                                  // �� ��ġ                   ��ǥ ����               �̵� �ӵ�
        //transform.position = Vector2.MoveTowards(transform.position, target.transform.position, Speed * Time.deltaTime);       //��ǥ�������� �̵�
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
