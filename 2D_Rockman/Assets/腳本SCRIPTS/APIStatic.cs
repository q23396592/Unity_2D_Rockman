
using UnityEngine;

public class APIStatic : MonoBehaviour
{
    #region API
    //認識靜態API
    //包含關鍵字 static 就是靜態

    private void Start()
    {
        //屬性 欄位 要知道如何存取
        //練習取得靜態屬性 Static Properties
        //語法
        //類別名稱.靜態屬性名稱
        float r = Random.value;         //隨機值
        print("隨機值:"+r);

        //練習存放靜態屬性 Static Properties
        //顯示Read Only屬性不能存放
        //語法
        //類別名稱.靜態屬性名稱 指定 值
        Cursor.visible = false;         //指標.可見度

        //練習使用靜態方法 Static Methods
        //語法
        //類別名稱.靜態方法(對應的參數)
        int attack = Random.Range(100, 300);
        print("隨機攻擊力:" + attack);

        float n = Mathf.Abs(-99.9f);
        #endregion
      #region 練習
        print("所有攝影機"+Camera.allCamerasCount);
        print("重力"+Physics2D.gravity);
        Physics2D.gravity=new Vector2 (0,-20f);
        print("重力" + Physics2D.gravity);
    }
    private void Update()
    {
        print("玩家是否按下任意鍵" +  Input.anyKeyDown);
        print("遊戲時間" + Time.time);
    }
    #endregion

}
