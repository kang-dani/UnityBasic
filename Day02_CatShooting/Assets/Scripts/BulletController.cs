using UnityEngine;

public class BulletController : MonoBehaviour
{
	public float moveSpeed = 10f;
	private int direction;
	void Start()
	{

	}
	private void OnBecameInvisible()
	{
		Destroy(gameObject);
	}

	void Update()
	{
		transform.position += new Vector3(moveSpeed * Time.deltaTime * direction, 0, 0);
	}
	public void SetDirection(bool _direction)
	{
		direction = _direction ? 1 : -1;
	}

}
