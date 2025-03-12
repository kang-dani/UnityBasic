using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private Vector2 minBounds;
	private Vector2 maxBounds;

	void Start()
	{
		// ȭ���� ��踦 ����
		Camera cam = Camera.main;
		Vector3 bottomLeft = cam.ViewportToWorldPoint(new Vector3(0, 0, 0));
		Vector3 topRight = cam.ViewportToWorldPoint(new Vector3(1, 1, 0));

		minBounds = new Vector2(bottomLeft.x, bottomLeft.y);
		maxBounds = new Vector2(topRight.x, topRight.y);
	}

	void Update()
	{

		Vector3 newPosition = transform.position;

		// ��踦 ����� �ʵ��� ��ġ ����
		newPosition.x = Mathf.Clamp(newPosition.x, minBounds.x, maxBounds.x);
		newPosition.y = Mathf.Clamp(newPosition.y, minBounds.y, maxBounds.y);

		transform.position = newPosition;
	}
}