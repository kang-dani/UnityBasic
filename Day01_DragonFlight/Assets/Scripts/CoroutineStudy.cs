using System.Collections;
using UnityEngine;

public class CoroutineStudy : MonoBehaviour
{
	//C# �ڷ�ƾ ����
	//�ڷ�ƾ�� �Լ��� �Ͻ������ϰ� �ٽ� ������ �� �ִ� ����� �����ϴµ�, �̸� ���� ������ ������ �����ϰ� ������ �� �ִ�
	void Start()
	{
		StartCoroutine(ExampleCoroutine());
	}
	IEnumerator ExampleCoroutine()
	{
		while (true)
		{
			Debug.Log("1�ʸ��� ����");
			yield return new WaitForSeconds(1f);    //2�� ���
		}

	}
}
