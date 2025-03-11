using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float rotationSpeed = 15f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

        transform.Rotate(-vertical * rotationSpeed * Time.deltaTime, 0, horizontal * rotationSpeed * Time.deltaTime);
	}
}
