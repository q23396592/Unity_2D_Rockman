using UnityEngine;

public class Car : MonoBehaviour
{
    //物件資料-欄位Field:儲存物件資料
    //欄位語法
    //修飾詞 類型 名稱 指定 預設值 結尾
    
    //修飾詞
    //私人 不顯示 private
    //公開 顯示 public
    
    //四大類型
    //整數int 
    //浮點數 float 結尾要加f
    //字串 string 要加雙引號""
    //布林值 bool true/false
    //關鍵字 顏色:藍色
    
    //屬性欄位語法
    //[屬性名稱(屬性內容)]
    //標題 Header("字串")
    //提示 ToolTip("字串")
    //範圍 Range(最小值,最大值)-限定數值類型
    [Header("汽車CC數"),Tooltip("汽車CC數"),Range(1000,5000)]
    public int cc=2000;//公升數
    [Header("汽車重量"), Tooltip("汽車重量"), Range(0.5f, 10f)]
    public float weight =1.5f;//重量
    [Header("汽車品牌")]
    public string brand ="BMW";//品牌
    [Header("汽車有無天窗")]
    public bool hasWindow =true;//天窗

    //Unity 常見類型
    //顏色 Color.顏色  
    public Color color=Color.red;
    //新顏色 new Color(r,g,b,a)範圍0到1
    public Color color1= new Color(0.5f, 0.5f, 0.5f, 1f);
    //座標二維-四維 Vector2,3,4
    public Vector2 v2=Vector2.one;
    //自訂座標 new Vector2,3,4 (x,y,z,w)
    public Vector2 v2my=new Vector2(4,4);
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
}
