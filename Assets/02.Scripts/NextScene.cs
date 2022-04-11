using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    private bool GameStart = false;

    public void Clickyoutube()
    {
        Application.OpenURL("https://namu.wiki/w/%EB%AF%B8%EC%95%88%ED%95%98%EB%8B%A4%20%EC%9D%B4%EA%B1%B0%20%EB%B3%B4%EC%97%AC%EC%A3%BC%EB%A0%A4%EA%B3%A0%20%EC%96%B4%EA%B7%B8%EB%A1%9C%EB%81%8C%EC%97%88%EB%8B%A4");
    }
    public void Clickhome()
    {
        Debug.Log("Gohome");
        SceneManager.LoadScene(0);
    }
    public void ClickStrat()
    {
        Debug.Log("로딩");
        GameStart = true;
        SceneManager.LoadScene(1);
    }
    public void ClickExit()
    {
        Debug.Log("종료");
        Application.Quit();
    }


}
