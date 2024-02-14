using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goStage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void stage1()
    {
        SceneManager.LoadScene("Stage1", LoadSceneMode.Single);
    }
    public void stage2()
    {
        SceneManager.LoadScene("Stage2", LoadSceneMode.Single);
    }
    public void stage3()
    {
        SceneManager.LoadScene("Stage3", LoadSceneMode.Single);
    }
    public void stage4()
    {
        SceneManager.LoadScene("Stage4", LoadSceneMode.Single);
    }
}
