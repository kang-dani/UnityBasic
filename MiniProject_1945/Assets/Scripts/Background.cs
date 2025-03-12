using UnityEngine;

public class Background : MonoBehaviour
{
    public float scrollSpeed = 0.01f;
	Material material;
	void Start()
    {
		material = GetComponent<Renderer>().material;
	}

    // Update is called once per frame
    void Update()
    {
        float newOffsetY = material.mainTextureOffset.y + scrollSpeed * Time.deltaTime;
		Vector2 newOffset = new Vector2(0, newOffsetY);
		material.mainTextureOffset = newOffset;
	}
}
