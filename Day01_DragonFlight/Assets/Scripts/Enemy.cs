using UnityEngine;

public class Enemy : MonoBehaviour
{
	//�����̴� �ӵ��� ����
	public float moveSpeed = 2f;

	void Start()
    {
        
	}

    // Update is called once per frame
    void Update()
    {
        //������ �Ÿ��� ���
        float distanceY = moveSpeed * Time.deltaTime;

        //�������� �ݿ�
        transform.Translate(0, -distanceY, 0);
	}

	//ȭ�� ������ ���� ī�޶󿡼� ������ ������ ȣ��Ǵ� �Լ�
	private void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
}
