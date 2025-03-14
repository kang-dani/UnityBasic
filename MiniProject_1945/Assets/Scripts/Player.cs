using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{
	//���ǵ�
	public float moveSpeed = 5f;

	Animator ani; //�ִϸ����͸� ������ ����

	public GameObject[] bullet;  //�Ѿ� ���� 4�� �迭�� ���鿹��
	public Transform pos = null;

	//������
	public int power = 0;
	[SerializeField] private GameObject powerUP;		//private�ε� �ν����Ϳ��� �ٿ��� �� �ְ� �ϴ� ���
	
	//������

	void Start()
	{
		ani = GetComponent<Animator>();
	}

	void Update()
	{
		//����Ű������ ������
		float moveX = moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
		float moveY = moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");

		// -1   0   1
		if (Input.GetAxis("Horizontal") <= -0.5f)
			ani.SetBool("Left", true);
		else
			ani.SetBool("Left", false);


		if (Input.GetAxis("Horizontal") >= 0.5f)
			ani.SetBool("Right", true);
		else
			ani.SetBool("Right", false);


		if (Input.GetAxis("Vertical") >= 0.5f)
		{
			ani.SetBool("Up", true);
		}
		else
		{
			ani.SetBool("Up", false);
		}

		//�����̽�
		if (Input.GetKeyDown(KeyCode.Space))
		{
			//������ ��ġ ���� �ְ� ����
			Instantiate(bullet[power], pos.position, Quaternion.identity);
		}

		transform.Translate(moveX, moveY, 0);

		//ĳ������ ���� ��ǥ�� ����Ʈ ��ǥ��� ��ȯ���ش�.
		Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
		viewPos.x = Mathf.Clamp01(viewPos.x); //x���� 0�̻�, 1���Ϸ� �����Ѵ�.
		viewPos.y = Mathf.Clamp01(viewPos.y); //y���� 0�̻�, 1���Ϸ� �����Ѵ�.
		Vector3 worldPos = Camera.main.ViewportToWorldPoint(viewPos);//�ٽÿ�����ǥ�� ��ȯw
		transform.position = worldPos; //��ǥ�� �����Ѵ�.

	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.CompareTag("Item"))
		{
			power += 1;

			if (power >= 3) power = 3;
			else
			{
				//�Ŀ���
				GameObject go = Instantiate(powerUP, transform.position, Quaternion.identity);
				Destroy(go, 1);
			}

			//������ ���� ó��
			Destroy(collision.gameObject);
		}
	}

}