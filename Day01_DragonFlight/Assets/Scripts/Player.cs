using UnityEngine;

public class Player : MonoBehaviour
{
	//�����̴� �ӵ��� ����
	public float moveSpeed = 5.0f;

	void Start()
    {
        
    }
    void Update()
    {
		moveControl();
	}

	void moveControl()
	{
		//������ Axis�� ���� Ű�� ������ �Ǵ��ϰ� �ӵ��� ������ ������ ���� �̵����� ���մϴ�.
		float distanceX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
		//�̵�����ŭ ������ �̵��� ���ִ� �Լ�
		transform.Translate(distanceX, 0, 0);
	}	
}
