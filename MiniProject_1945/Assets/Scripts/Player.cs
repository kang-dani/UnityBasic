using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    Animator ani;                        //�ִϸ����͸� ������ ����
	void Start()
    {
        ani = GetComponent<Animator>();  //�ִϸ����͸� ������
	}

    // Update is called once per frame
    void Update()
    {
        float moveX = moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float moveY = moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");

        if(Input.GetAxis("Horizontal") <= -0.5f)
            ani.SetBool("Left", true);
        else ani.SetBool("Left", false);

		if (Input.GetAxis("Horizontal") >= 0.5f)
			ani.SetBool("Right", true);
		else ani.SetBool("Right", false);
        if(Input.GetAxis("Vertical") >= 0.5f)
			ani.SetBool("Up", true);
		else ani.SetBool("Up", false);

		transform.Translate(moveX, moveY, 0);
	}
}
