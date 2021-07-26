using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LevelButton : MonoBehaviour
{
    public SceneChange sc;

    public void OnClickBox()
    {
        string nowbutton = EventSystem.current.currentSelectedGameObject.name;

        if (nowbutton == "add1") sc.stageNum = 4;
        else if (nowbutton == "add2") sc.stageNum = 5;
        else if (nowbutton == "add3") sc.stageNum = 6;
        else if (nowbutton == "add4") sc.stageNum = 7;
        else if (nowbutton == "add5") sc.stageNum = 8;

        else if (nowbutton == "Sub1") sc.stageNum = 9;
        else if (nowbutton == "Sub2") sc.stageNum = 10;
        else if (nowbutton == "Sub3") sc.stageNum = 11;
        else if (nowbutton == "Sub4") sc.stageNum = 12;
        else if (nowbutton == "Sub5") sc.stageNum = 13;

        else if (nowbutton == "multi1") sc.stageNum = 14;
        else if (nowbutton == "multi2") sc.stageNum = 15;
        else if (nowbutton == "multi3") sc.stageNum = 16;
        else if (nowbutton == "multi4") sc.stageNum = 17;
        else if (nowbutton == "multi5") sc.stageNum = 18;

        else if (nowbutton == "div1") sc.stageNum = 19;
        else if (nowbutton == "div2") sc.stageNum = 20;
        else if (nowbutton == "div3") sc.stageNum = 21;
        else if (nowbutton == "div4") sc.stageNum = 22;
        else if (nowbutton == "div5") sc.stageNum = 23;

        else if (nowbutton == "Back")
        {
            SceneManager.LoadScene(0);
            Destroy(sc);
        }
        if (sc.stageNum != 0) sc.call();
    }

}
