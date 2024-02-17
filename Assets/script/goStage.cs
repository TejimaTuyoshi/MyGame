using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goStage : MonoBehaviour
{
    float _waittime1 = 0;
    float _waittime2 = 0;
    float _waittime3 = 0;
    float _waittime4 = 0;
    bool _active1 = false;
    bool _active2 = false;
    bool _active3 = false;
    bool _active4 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_active1)
        {
            _waittime1 += Time.deltaTime;
        }
        if (_active2)
        {
            _waittime2 += Time.deltaTime;
        }
        if (_active3)
        {
            _waittime3 += Time.deltaTime;
        }
        if (_active4)
        {
            _waittime4 += Time.deltaTime;
        }
        if (_waittime1 > 0.8)
        {
            SceneManager.LoadScene("Stage1", LoadSceneMode.Single);
        }
        if (_waittime2 > 0.8)
        {
            SceneManager.LoadScene("Stage2", LoadSceneMode.Single);
        }
        if (_waittime3 > 0.8)
        {
            SceneManager.LoadScene("Stage3", LoadSceneMode.Single);
        }
        if (_waittime4 > 0.8)
        {
            SceneManager.LoadScene("Stage4", LoadSceneMode.Single);
        }
    }
    public void stage1()
    {
        _active1 = true;
    }
    public void stage2()
    {
        _active2 = true;
    }
    public void stage3()
    {
        _active3 = true;
    }
    public void stage4()
    {
        _active4 = true;
    }
}
