using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text scoreText;  //점수를 표시하는 Text 객체 에디터에서 받아옴
	public Text startText;  //시작 텍스트

	int score = 0;          //점수 관리
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
		scoreText.text = "Score : " + score;	//텍스트에 반영
	}
}
