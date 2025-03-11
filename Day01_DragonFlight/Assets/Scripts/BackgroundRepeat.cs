using UnityEngine;

public class BackgroundRepeat : MonoBehaviour
{
    //스크롤할 속도를 상수로 지정해줍니다.
    public float scrollSpeed = 1.2f;
    //쿼드의 머터리얼 데이터를 받아올 객체를 선언합니다.
    private Material thisMaterial;
	void Start()
    {
		//현재 객체의 Component인 Renderer에서 Material 데이터를 받아옵니다.
        thisMaterial = GetComponent<Renderer>().material;
	}

	// Update is called once per frame
	void Update()
    {
		//새롭게 지정해줄 offset 객체를 선언합니다.
		Vector2 newOffset = thisMaterial.mainTextureOffset;
		//Y 부분에 현재 y 값에 속도에 프레임 보정해서 더해줍니다.
		newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime));
		//최종적으로 offset을 새로 지정해줍니다.
		thisMaterial.mainTextureOffset = newOffset;
	}
}
