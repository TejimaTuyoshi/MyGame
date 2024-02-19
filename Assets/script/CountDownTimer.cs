using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    [SerializeField] static float CountDownTime;    // �J�E���g�_�E���^�C��
    public Text TextCountDown;              // �\���p�e�L�X�gUI
    public static float cleartime = 99.0f;
    [SerializeField] GameObject _overPanel;
    [SerializeField] Player _player;

    // Use this for initialization
    void Start()
    {
        CountDownTime = 60.0F;    // �X�e�[�W�P�p�̃^�C�}�[
    }

    // Update is called once per frame
    void Update()
    {
        TextCountDown.text = String.Format("Time: {0:00.00}", CountDownTime);// �J�E���g�_�E���^�C���𐮌`���ĕ\��


        CountDownTime -= Time.deltaTime;// �o�ߎ����������Ă��� 

        if (CountDownTime <= 0.0F) // 0.0�b�ȉ��ɂȂ�����J�E���g�_�E���^�C����0.0�ŌŒ�i�~�܂����悤�Ɍ�����j
        {
            CountDownTime = 0.0F;
        }
        if (CountDownTime == 0.0F)//�^�C���I�[�o�[���AGameover��ʂɔ�΂��B
        {
            _overPanel.SetActive(true);
            _player.notmove = true;
        }
    }
}