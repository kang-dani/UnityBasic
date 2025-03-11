using System.Collections;
using UnityEngine;

public class CoroutineStudy : MonoBehaviour
{
	//C# 코루틴 정리
	//코루틴은 함수를 일시정지하고 다시 시작할 수 있는 기능을 제공하는데, 이를 통해 복잡한 로직을 간단하게 구현할 수 있다
	void Start()
	{
		StartCoroutine(ExampleCoroutine());
	}
	IEnumerator ExampleCoroutine()
	{
		while (true)
		{
			Debug.Log("1초마다 샐행");
			yield return new WaitForSeconds(1f);    //2초 대기
		}

	}
}
