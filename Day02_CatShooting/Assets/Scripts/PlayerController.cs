using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private Animator walkAnimator;
	public float moveSpeed = 3.0f;
	public bool trans;
	public GameObject bullets;
	public Transform firePoint;
	void Start()
	{
		walkAnimator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		walkAnimator.SetBool("isWalk", false);
		if (Input.GetKey(KeyCode.D))
		{
			walkAnimator.SetBool("isWalk", true);
			transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, 0);
			walkAnimator.SetBool("transition", false);
			trans = false;
		}
		if (Input.GetKey(KeyCode.A))
		{
			walkAnimator.SetBool("isWalk", true);
			transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0, 0);
			walkAnimator.SetBool("transition", true);
			trans = true;
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			Shoot();
		}
	}

	void Shoot()
	{
		GameObject bullet = Instantiate(bullets, firePoint.position, Quaternion.identity);
		BulletController bulletController = bullet.GetComponent<BulletController>();
		bulletController.SetDirection(!trans); // 발사 순간의 방향을 총알에 전달
	}
}
