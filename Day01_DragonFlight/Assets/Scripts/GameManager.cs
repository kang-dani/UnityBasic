using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text scoreText;  //������ ǥ���ϴ� Text ��ü �����Ϳ��� �޾ƿ�
	public Text startText;  //���� �ؽ�Ʈ

	int score = 0;          //���� ����
	void Start()
    {
        if(instance == null)
		{
			instance = this;
		}
		else
		{
			Destroy(gameObject);
		}
		StartCoroutine(StartText());
	}

	IEnumerator StartText()
	{
		int i = 3;

		while(i > 0)
		{
			startText.text = i.ToString();
			yield return new WaitForSeconds(1f);
			i--;

			if(i == 0)
			{
				startText.text = "Start!";
				startText.gameObject.SetActive(false);
			}
		}
	}

	public void Add(int num)
	{
		score += num;
		scoreText.text = "Score : " + score;	//�ؽ�Ʈ�� �ݿ�
	}
}
