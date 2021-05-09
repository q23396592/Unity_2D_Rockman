
using UnityEngine;
using UnityEngine.SceneManagement;//引用 場景管理器 API

public class MenuMamager : MonoBehaviour
{
    //使用靜態方法處理 1.開始遊戲 2.結束遊戲
    //如何使用按鈕跟程式溝通
    //需要一個公開的方法
    
    public void StartGame()
    {
        //延遲時間("方法名稱",延遲時間)
        Invoke("DelayStartGame",1.1f);
    }
    /// <summary>
    /// 開始遊戲
    /// </summary>
    public void DelayStartGame()
    {

        //場景管理.載入場景("場景名稱")
        SceneManager.LoadScene("遊戲畫面");
        //SceneManager.LoadScene(1);
        //都可以用
    }
    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void QuitGame()
    {
        Invoke("DelayQuitGame", 1.1f);
    }
    
    public void DelayQuitGame()
    {
        //應用程式離開
        Application.Quit();
        
    }
}
