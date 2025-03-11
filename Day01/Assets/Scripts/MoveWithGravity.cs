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
			//Rigidbody : 물리 효과를 추가해 중력을 적용합니다
			//AddForce : 힘을 가합니다
			//ForceMode : 힘을 가하는 방식을 설정합니다
			//Impulse : 순간적인 힘을 가합니다
			rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
		}
	}
}
