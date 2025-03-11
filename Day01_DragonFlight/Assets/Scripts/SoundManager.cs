using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //싱글톤
    public static SoundManager instance;
    AudioSource myAudio;        //오디오 소스 컴포넌트 변수 선언
	public AudioClip soundBullet;    //총알 사운드 변수 선언
	public AudioClip soundDie;		 //몬스터 죽는 사운드 변수 선언

	private void Awake()
	{
		if(SoundManager.instance == null)    //싱글톤이 할당되지 않았다면
		{
			SoundManager.instance = this;    //자기 자신을 할당
		}
	}
	void Start()
    {
		myAudio = GetComponent<AudioSource>();    //오디오 소스 컴포넌트 가져오기
	}

	public void SoundDie()
	{
		myAudio.PlayOneShot(soundDie);		 //오디오 소스 컴포넌트의 재생 함수 실행
	}
	public void SoundBullet()
	{
		myAudio.PlayOneShot(soundBullet);    //오디오 소스 컴포넌트의 재생 함수 실행
	}

	void Update()
    {
        
    }
}
