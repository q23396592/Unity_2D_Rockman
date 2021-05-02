using UnityEngine;

public class Car : MonoBehaviour
{
    #region 摺疊
    //#region 摺疊程式開始處
    //#endregion 結束
    #endregion
    #region 欄位
    //物件資料-欄位Field:儲存物件資料
    //欄位語法
    //修飾詞 類型 名稱 指定 預設值 結尾

    //屬性欄位語法
    //[屬性名稱(屬性內容)]
    //標題 Header("字串")
    //提示 ToolTip("字串")
    //範圍 Range(最小值,最大值)-限定數值類型

    //修飾詞
    //私人 不顯示 private
    //公開 顯示 public

    //四大類型
    //整數int 
    //浮點數 float 結尾要加f
    //字串 string 要加雙引號""
    //布林值 bool true/false
    //關鍵字 顏色:藍色


    [Header("汽車CC數"), Tooltip("汽車CC數"), Range(1000, 5000)]
    public int cc = 2000;//公升數
    [Header("汽車重量"), Tooltip("汽車重量"), Range(0.5f, 10f)]
    public float weight = 1.5f;//重量
    [Header("汽車品牌")]
    public string brand = "BMW";//品牌
    [Header("汽車有無天窗")]
    public bool hasWindow = true;//天窗

    //Unity 常見類型
    //顏色 Color.顏色  
    public Color color = Color.red;
    //新顏色 new Color(r,g,b,a)範圍0到1
    public Color color1 = new Color(0.5f, 0.5f, 0.5f, 1f);
    //座標二維-四維 Vector2,3,4
    public Vector2 v2 = Vector2.one;
    //自訂座標 new Vector2,3,4 (x,y,z,w)
    public Vector2 v2my = new Vector2(4, 4);
    //按鍵 KeyCode
    public KeyCode key1;//none不指定
    //KeyCode.A
    //KeyCode.Mouse0 滑鼠左0右1滾輪2

    //遊戲物件跟元件
    //遊戲物件GameObject
    public GameObject obj1;
    public GameObject obj2;
    //元件 Compontent-屬性面板可摺疊的
    //名稱去掉空格
    public Transform tra;   //可儲存任何包含Transform元件的產物
    #endregion; 
    #region 事件
    public int number = 1;
    public bool test = false;
    public string prop = "紅色藥水";

    //事件:在特定時間點會被執行的方法
    //Unity提供的事件:開始Start 更新Update

    //開始事件執行時間點與次數:播放遊戲後執行一次
    //應用:數值初始化，例如:遊戲一開始多少金幣或生命值等等...
    private void Start()
    {
        //print(任何資料)-輸出資料到Console儀表板上
        print("我是開始事件喔");

        //欄位存取
        //取得
        //語法:欄位名稱
        //字串串接:字串+其他欄位
        print("number取得欄位" + number);

        //存放
        //語法:欄位名稱 指定 值
        //值必須與此欄位類型相同
        print("存放欄位後的的結果" + test);
        test = true;
        print("存放欄位後的的結果" + test);

        print("存放後的道具名稱:" + prop);
        prop = "藍色藥水";
        print("存放後的道具名稱:" + prop);

        //呼叫方法
        //方法名稱()
        Test();
        //傳回方法
        //傳回類型 名稱 = 傳回方法()
        int t = Ten();
        print("傳回方法的結果" + t);

        Drive50();
        Drive100();
        Drive300();
        //呼叫方法要有相同數量的參數
        //有預設值的參數為[選填式參數]
        Drive(200, "咻咻咻");
        Drive(999, "轟轟轟", "爆炸特效");
        Drive(777, "閃電特效");         //錯誤-特效在音效上
        Drive(777, effect: "閃電特效"); //正確-指定特效參數

        float bmi=BMI(1.68f, 60);
        print("計算後的BMI" + bmi);
    }

    //更新事件執行時間點與次數:開始事件後以每秒約60次執行 60fps
    //應用:監聽玩家輸入與物件持續行為，例如:玩家有沒有按按鈕或讓物體持續移動
    private void Update()
    {
        print("我是更新事件喔");

    }
    #endregion
    #region 方法
    //方法:保存較複雜或演算法的程式區塊
    //語法:
    //修飾詞 傳回類型 名稱(參數1,參數2  ){較複雜或演算法的程式區塊}
    //void 無傳回:使用這個方法不會有傳回
    //方法需要被[呼叫]才會執行
    /// <summary>
    /// 摘要
    /// 我是一個測試方法
    /// </summary>
    private void Test()
    {
        print("我是測試方法");
    }

    //如果不是無傳回 void
    //在大括號內必須使用 傳回 return 值(必須與傳回類型相同)
    /// <summary>
    /// 傳回整數十的方法
    /// </summary>
    /// <returns>整數十</returns>
    /// 
    private int Ten()
    {
        return 10;
    }

    //舉例:
    //三個方法 1. 以時速 50 開車 2. 時速 100 3. 時速300
    //加新功能 要有音效
    //加特效
    private void Drive50()
    {
        print("開車時數:" + 50);
        print("開車音效");
    }
    private void Drive100()
    {
        print("開車時數:" + 100);
        print("開車音效");
    }
    private void Drive300()
    {
        print("開車時數:" + 300);
        print("開車音效");
    }

    //用參數解決 Paramater
    //參數與法:類型 參數名稱
    //有預設值的參數只能寫在最右邊
    /// <summary>
    /// 開車
    /// </summary>
    /// <param name="speed">開車的時數</param>
    /// <param name="sound">開車的音效</param>
    /// <param name="effect">特效</param>
    private void Drive(int speed, string sound = "咻", string effect = "灰塵特效")
    {
        print("開車時數:" + speed);
        print("開車音效" + sound);
        print("特效:" + effect);
    }
    /// <summary>
    /// 計算BMI公式
    /// </summary>
    /// <param name="height">身高</param>
    /// <param name="weight">體重</param>
    /// <returns>公式</returns>
    private float BMI(float height,float weight)
    {
        return weight / (height * height);
    }
    #endregion

}
