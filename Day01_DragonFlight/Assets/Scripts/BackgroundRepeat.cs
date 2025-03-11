using UnityEngine;

public class BackgroundRepeat : MonoBehaviour
{
    //��ũ���� �ӵ��� ����� �������ݴϴ�.
    public float scrollSpeed = 1.2f;
    //������ ���͸��� �����͸� �޾ƿ� ��ü�� �����մϴ�.
    private Material thisMaterial;
	void Start()
    {
		//���� ��ü�� Component�� Renderer���� Material �����͸� �޾ƿɴϴ�.
        thisMaterial = GetComponent<Renderer>().material;
	}

	// Update is called once per frame
	void Update()
    {
		//���Ӱ� �������� offset ��ü�� �����մϴ�.
		Vector2 newOffset = thisMaterial.mainTextureOffset;
		//Y �κп� ���� y ���� �ӵ��� ������ �����ؼ� �����ݴϴ�.
		newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime));
		//���������� offset�� ���� �������ݴϴ�.
		thisMaterial.mainTextureOffset = newOffset;
	}
}
