using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    Animator ani;                        //애니메이터를 가져올 변수
	void Start()
    {
        ani = GetComponent<Animator>();  //애니메이터를 가져옴
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
