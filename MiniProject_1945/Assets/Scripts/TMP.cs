using System.Collections;
using TMPro;
using UnityEngine;

public class TMP : MonoBehaviour
{
    //���� ��ȯ�� �ɸ��� �ð�
    [SerializeField]
    float lerpTime = 0.1f;

    //�ؽ�Ʈ ������Ʈ
    TextMeshProUGUI textBossWarning;

	private void Awake()
	{
		textBossWarning = GetComponent<TextMeshProUGUI>();
	}

    //OnEnable : ������Ʈ�� Ȱ��ȭ �� �� ȣ��
	private void OnEnable()
	{
		StartCoroutine(ColorLerpLoop());
	}
	
	//���� ��ȯ ���� �ڷ�ƾ
	IEnumerator ColorLerpLoop()
	{
		while(true)
		{
			yield return StartCoroutine(ColorLerp(Color.white, Color.red));
			yield return StartCoroutine(ColorLerp(Color.red, Color.white));
		}
	}

	IEnumerator ColorLerp(Color color, Color color2)
	{
		float currentTime = 0.0f;
		float percent = 0.0f;

		while (percent < 1.0f)
		{
			currentTime += Time.deltaTime;
			percent = currentTime / lerpTime;

			textBossWarning.color = Color.Lerp(color, color2, percent);
			yield return null;
		}
	}
}
