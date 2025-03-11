using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //�̱���
    public static SoundManager instance;
    AudioSource myAudio;        //����� �ҽ� ������Ʈ ���� ����
	public AudioClip soundBullet;    //�Ѿ� ���� ���� ����
	public AudioClip soundDie;		 //���� �״� ���� ���� ����

	private void Awake()
	{
		if(SoundManager.instance == null)    //�̱����� �Ҵ���� �ʾҴٸ�
		{
			SoundManager.instance = this;    //�ڱ� �ڽ��� �Ҵ�
		}
	}
	void Start()
    {
		myAudio = GetComponent<AudioSource>();    //����� �ҽ� ������Ʈ ��������
	}

	public void SoundDie()
	{
		myAudio.PlayOneShot(soundDie);		 //����� �ҽ� ������Ʈ�� ��� �Լ� ����
	}
	public void SoundBullet()
	{
		myAudio.PlayOneShot(soundBullet);    //����� �ҽ� ������Ʈ�� ��� �Լ� ����
	}

	void Update()
    {
        
    }
}
