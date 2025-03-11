using UnityEngine;

public class Enemy : MonoBehaviour
{
	//움직이는 속도를 정의
	public float moveSpeed = 2f;

	void Start()
    {
        
	}

    // Update is called once per frame
    void Update()
    {
        //움직일 거리를 계산
        float distanceY = moveSpeed * Time.deltaTime;

        //움직임을 반영
        transform.Translate(0, -distanceY, 0);
	}

	//화면 밖으로 나가 카메라에서 보이지 않으면 호출되는 함수
	private void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
}
