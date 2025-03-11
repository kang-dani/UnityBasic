using UnityEngine;

public class SingleTon : MonoBehaviour
{
    //����Ƽ���� �̱����� ����ϸ� �ϳ��� �ν��Ͻ��� �����ϸ鼭 ��𼭵� ���� �����ϰ� ���� �� �ֽ��ϴ�.
    public static SingleTon Instance { get; private set; }
    private void Awake()            //�� �� ����Ǹ�, start���� ���� ����˴ϴ�.
	{
		if (Instance == null)
		{
			Instance = this;
			DontDestroyOnLoad(gameObject);  //���� �ٲ� ���ӿ�����Ʈ�� �ı����� �ʰ� �մϴ�.
		}
		else
		{
			Destroy(gameObject);
		}
	}

	public void PrintMessage()
	{
		Debug.Log("�̱��� �޽��� ���");
	}
}
