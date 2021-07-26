using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerswap : MonoBehaviour
{
    int nowStage;
    GameObject stageManager;

    private readonly string selectedchar = "SelectedCharacter";// tells game whatskin player wants

    public GameObject Playerform1;
    public GameObject Playerform2;

    private Vector3 CharacterPostition;
    private Vector3 OffScreen;//where skins go when not in use

    private int CharacterInt = 1;//determines placement in order
    private SpriteRenderer player1Renderer, player2Renderer;

    private void Awake()
    {
        CharacterPostition = Playerform1.transform.position;
        OffScreen = Playerform2.transform.position;
        player1Renderer = Playerform1.GetComponent<SpriteRenderer>();
        player2Renderer = Playerform2.GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        stageManager = GameObject.Find("StageNumObject");
        nowStage = stageManager.GetComponent<SceneChange>().stageNum;
    }

    public void NextCharachter()//i spelled this wrong not an issue
    {
        switch(CharacterInt)
        {
            case 1://we use switches to show then "hide" what we want to show the player
                PlayerPrefs.SetInt(selectedchar , 1);

                player1Renderer.enabled = false;
                Playerform1.transform.position = OffScreen;
                Playerform2.transform.position = CharacterPostition;
                player2Renderer.enabled = true;
                CharacterInt++;
                break;

            case 2:
                PlayerPrefs.SetInt(selectedchar , 2);

                player2Renderer.enabled = false;
                Playerform2.transform.position = OffScreen;
                Playerform1.transform.position = CharacterPostition;
                player1Renderer.enabled = true;
                CharacterInt++;
                ResetInt();
                break;
            default:
                
                break;
           

        }

    }
   


    private void ResetInt()// resets player skin selector
    {
        if (CharacterInt >= 2)
        {
            CharacterInt = 1;
        }

    }


    public void ChangeScene()
    {
       
        switch (nowStage)
        {
            case 1:
                // filler
                break;

            case 2:
                // filler
                break;

            case 3:
                // filler
                break;

            case 4:
                SceneManager.LoadScene(4);
                if (player1Renderer.enabled == true)
                {
                    DontDestroyOnLoad(Playerform1);
                }
                else
                {
                    DontDestroyOnLoad(Playerform2);
                }
                break;

            case 5:
                SceneManager.LoadScene(5);
                if (player1Renderer.enabled == true)
                {
                    DontDestroyOnLoad(Playerform1);
                }
                else
                {
                    DontDestroyOnLoad(Playerform2);
                }
                break;

            case 6:
                SceneManager.LoadScene(6);
                if (player1Renderer.enabled == true)
                {
                    DontDestroyOnLoad(Playerform1);
                }
                else
                {
                    DontDestroyOnLoad(Playerform2);
                }
                break;

            case 7:
                SceneManager.LoadScene(7);
                if (player1Renderer.enabled == true)
                {
                    DontDestroyOnLoad(Playerform1);
                }
                else
                {
                    DontDestroyOnLoad(Playerform2);
                }
                break;

            case 8:
                SceneManager.LoadScene(8);
                if (player1Renderer.enabled == true)
                {
                    DontDestroyOnLoad(Playerform1);
                }
                else
                {
                    DontDestroyOnLoad(Playerform2);
                }
                break;

            case 9:
                SceneManager.LoadScene(9);
                if (player1Renderer.enabled == true)
                {
                    DontDestroyOnLoad(Playerform1);
                }
                else
                {
                    DontDestroyOnLoad(Playerform2);
                }
                break;

            case 10:
                SceneManager.LoadScene(10);
                if (player1Renderer.enabled == true)
                {
                    DontDestroyOnLoad(Playerform1);
                }
                else
                {
                    DontDestroyOnLoad(Playerform2);
                }
                break;

            case 11:
                SceneManager.LoadScene(11);
                if (player1Renderer.enabled == true)
                {
                    DontDestroyOnLoad(Playerform1);
                }
                else
                {
                    DontDestroyOnLoad(Playerform2);
                }
                break;

            case 12:
                SceneManager.LoadScene(12);
                if (player1Renderer.enabled == true)
                {
                    DontDestroyOnLoad(Playerform1);
                }
                else
                {
                    DontDestroyOnLoad(Playerform2);
                }
                break;

            case 13:
                SceneManager.LoadScene(13);
                if (player1Renderer.enabled == true)
                {
                    DontDestroyOnLoad(Playerform1);
                }
                else
                {
                    DontDestroyOnLoad(Playerform2);
                }
                break;

            case 14:
                SceneManager.LoadScene(14);
                if (player1Renderer.enabled == true)
                {
                    DontDestroyOnLoad(Playerform1);
                }
                else
                {
                    DontDestroyOnLoad(Playerform2);
                }
                break;

            case 15:
                SceneManager.LoadScene(15);
                if (player1Renderer.enabled == true)
                {
                    DontDestroyOnLoad(Playerform1);
                }
                else
                {
                    DontDestroyOnLoad(Playerform2);
                }
                break;

            case 16:
                SceneManager.LoadScene(16);
                if (player1Renderer.enabled == true)
                {
                    DontDestroyOnLoad(Playerform1);
                }
                else
                {
                    DontDestroyOnLoad(Playerform2);
                }
                break;

            case 17:
                SceneManager.LoadScene(17);

                if (player1Renderer.enabled == true)
                {
                    DontDestroyOnLoad(Playerform1);
                }
                else
                {
                    DontDestroyOnLoad(Playerform2);
                }
                break;

            case 18:
                SceneManager.LoadScene(18);

                if (player1Renderer.enabled == true)
                {
                    DontDestroyOnLoad(Playerform1);
                }
                else
                {
                    DontDestroyOnLoad(Playerform2);
                }
                break;

            case 19:
                SceneManager.LoadScene(19);

                if (player1Renderer.enabled == true)
                {
                    DontDestroyOnLoad(Playerform1);
                }
                else
                {
                    DontDestroyOnLoad(Playerform2);
                }
                break;

            case 20:
                SceneManager.LoadScene(20);

                if (player1Renderer.enabled == true)
                {
                    DontDestroyOnLoad(Playerform1);
                }
                else
                {
                    DontDestroyOnLoad(Playerform2);
                }
                break;

            case 21:
                SceneManager.LoadScene(21);

                if (player1Renderer.enabled == true)
                {
                    DontDestroyOnLoad(Playerform1);
                }
                else
                {
                    DontDestroyOnLoad(Playerform2);
                }
                break;

            case 22:
                SceneManager.LoadScene(22);

                if (player1Renderer.enabled == true)
                {
                    DontDestroyOnLoad(Playerform1);
                }
                else
                {
                    DontDestroyOnLoad(Playerform2);
                }
                break;

            case 23:
                SceneManager.LoadScene(23);

                if (player1Renderer.enabled == true)
                {
                    DontDestroyOnLoad(Playerform1);
                }
                else
                {
                    DontDestroyOnLoad(Playerform2);
                }
                break;

            default:
                SceneManager.LoadScene(3);
                break;
        }
        
      
    }




    public void newgame()
    {
        SceneManager.LoadScene(4);

    }




    public void goback()
    {
        Destroy(stageManager);
        SceneManager.LoadScene(0);


    }

}
