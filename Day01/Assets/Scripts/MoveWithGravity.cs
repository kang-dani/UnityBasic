using UnityEngine;

public class MoveWithGravity : MonoBehaviour
{
	public Rigidbody rb;
    public float jumpForce = 5.0f;
	void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
		{
			//Rigidbody : ���� ȿ���� �߰��� �߷��� �����մϴ�
			//AddForce : ���� ���մϴ�
			//ForceMode : ���� ���ϴ� ����� �����մϴ�
			//Impulse : �������� ���� ���մϴ�
			rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
		}
	}
}
