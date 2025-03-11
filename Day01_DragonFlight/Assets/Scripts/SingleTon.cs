using UnityEngine;

public class SingleTon : MonoBehaviour
{
    //유니티에서 싱글톤을 사용하면 하나의 인스턴스만 유지하면서 어디서든 접근 가능하게 만들 수 있습니다.
    public static SingleTon Instance { get; private set; }
    private void Awake()            //한 번 실행되며, start보다 먼저 실행됩니다.
	{
		if (Instance == null)
		{
			Instance = this;
			DontDestroyOnLoad(gameObject);  //씬이 바뀌어도 게임오브젝트가 파괴되지 않게 합니다.
		}
		else
		{
			Destroy(gameObject);
		}
	}

	public void PrintMessage()
	{
		Debug.Log("싱글톤 메시지 출력");
	}
}
