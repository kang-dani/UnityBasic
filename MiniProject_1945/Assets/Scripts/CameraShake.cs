using Unity.Cinemachine;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
	public static CameraShake instance;
	//������ Impulse �ҽ� ������Ʈ ��������
	private CinemachineImpulseSource impulseSource;
	void Awake()
	{
		instance = this;
		//���� ������Ʈ�� ������ Impulse Source ������Ʈ ��������
		impulseSource = GetComponent<CinemachineImpulseSource>();

	}

	//ī�޶� ����ũ ����
	public void CameraShakeShow()
	{
		if (impulseSource != null)
		{
			//�⺻ �������� ���޽� ����
			impulseSource.GenerateImpulse();
		}
	}
	void Update()
	{

	}
}
