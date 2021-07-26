using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectorscript : MonoBehaviour
{
    public int stageNum;
    public GameObject stageNumObject;


    public SceneChange sc;

    // Start is called before the first frame update
    void Start()
    {
     
        

    }

    // Update is called once per frame
    void Update()
    {
        


    }

    public void goback()
    {
        SceneManager.LoadScene(0);
    }

    public void add1()
    {
        stageNum = 4;
        SceneManager.LoadScene(1);
        
        DontDestroyOnLoad(stageNumObject);
    }
    public void add2()
    {
        stageNum = 5;
        SceneManager.LoadScene(1);
       
        DontDestroyOnLoad(stageNumObject);
    }
    public void add3()
    {
        stageNum = 6;
        SceneManager.LoadScene(1);
        
        DontDestroyOnLoad(stageNumObject);
    }
    public void add4()
    {
        stageNum = 7;
        SceneManager.LoadScene(1);
        DontDestroyOnLoad(stageNumObject);
    }
    public void add5()
    {
        stageNum = 8;
        SceneManager.LoadScene(1);
        DontDestroyOnLoad(stageNumObject);
    }
   
    //////////////////////////////////////////////
    



    public void sub1()
    {
        stageNum = 9;
        SceneManager.LoadScene(1);
        
        DontDestroyOnLoad(stageNumObject);
    }
    public void sub2()
    {
        stageNum = 10;
        SceneManager.LoadScene(1);
        DontDestroyOnLoad(stageNumObject);
    }
    public void sub3()
    {
        stageNum = 11;
        SceneManager.LoadScene(1);
        DontDestroyOnLoad(stageNumObject);
    }
    public void sub4()
    {
        stageNum = 12;
        SceneManager.LoadScene(1);
        DontDestroyOnLoad(stageNumObject);
    }
    public void sub5()
    {
        stageNum = 13;
        SceneManager.LoadScene(1);
        DontDestroyOnLoad(stageNumObject);
    }


    //////////////////////////////////////////////



    public void multi1()
    {
        stageNum = 14;
        SceneManager.LoadScene(1);
        
        DontDestroyOnLoad(stageNumObject);
    }
    public void multi2()
    {
        stageNum = 15;
        SceneManager.LoadScene(1);
        DontDestroyOnLoad(stageNumObject);
    }
    public void multi3()
    {
        stageNum = 16;
        SceneManager.LoadScene(1);
        
        DontDestroyOnLoad(stageNumObject);
    }
    public void multi4()
    {
        stageNum = 17;
        SceneManager.LoadScene(1);
        
        DontDestroyOnLoad(stageNumObject);
    }
    public void multi5()
    {
        stageNum = 18;
        SceneManager.LoadScene(1);
        
        DontDestroyOnLoad(stageNumObject);
    }


    //////////////////////////////////////////////



    public void Div1()
    {
        stageNum = 19;
        SceneManager.LoadScene(1);
        
        DontDestroyOnLoad(stageNumObject);
    }
    public void Div2()
    {
        stageNum = 20;
        SceneManager.LoadScene(1);
        
        DontDestroyOnLoad(stageNumObject);
    }
    public void Div3()
    {
        stageNum = 21;
        SceneManager.LoadScene(1);
        
        DontDestroyOnLoad(stageNumObject);
    }
    public void Div4()
    {
        stageNum = 22;
        SceneManager.LoadScene(1);
        
        DontDestroyOnLoad(stageNumObject);
    }
    public void Div5()
    {
        stageNum = 23;
        SceneManager.LoadScene(1);
        
        DontDestroyOnLoad(stageNumObject);
    }

}
