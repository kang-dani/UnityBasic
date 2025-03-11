using UnityEngine;
public class Player
{
    public string name;
    public int score;

    public Player(string _name, int playerScore)
	{
		name = _name;
		score = playerScore;
	}
    public void ShowInfo()
    {
		Debug.Log("Player Name : " + name + ", Score : " + score);
	}
}

public class ClassExample : MonoBehaviour
{
    void Start()
    {
        Player player = new Player("John", 100);
        player.ShowInfo();
	}

    void Update()
    {
        
    }
}
