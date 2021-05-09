using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位
    [Header("移動速度"), Range(0f, 2000f)]
    public float speed = 100f;//速度
    [Header("跳躍高度"), Range(0, 3000)]
    public int jump = 100;//跳躍
    [Range(0f, 200f)]
    public float hp = 100f;
    [Header("是否在地板上"), Tooltip("在地板上嗎?")]
    public bool floor = false;
    [Header("子彈"), Tooltip("子彈")]
    public GameObject bullet;//子彈
    [Header("子彈生成點"), Tooltip("子彈生成點")]
    public Transform bullet_spawnpoint;
    [Range(0, 5000)]
    public int bullet_speed = 800;//子彈速度
    [Header("開槍音效"), Tooltip("開槍音效")]
    public AudioClip bullet_sound;//開槍音效    
    private AudioSource audS;//音效來源
    private Rigidbody2D rig2D;//2D剛體
    private Animator anim;//動畫控制器
    private SpriteRenderer spr;
    #endregion
    #region 事件
    private void Start()
    {
        //利用程式取得元件
        //傳回元件 取得元件<元件名稱>()-<泛型>
        //取得跟此腳本同一層的元件
        rig2D=GetComponent<Rigidbody2D>();
        spr= GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        Move();
        Jump();
    }

    [Header("判斷地板碰撞的位移與半徑")]
    public Vector3 groundOffset;
    public float groundRadius = 0.2f;
    
    //繪製圖示-輔助編輯時的圖形線條
    private void OnDrawGizmos()
    {
        //1.指定顏色
        Gizmos.color=new Color(1, 0, 0, 0.5f);
        //2.繪製圖形
        Gizmos.DrawSphere(transform.position+ groundOffset, groundRadius);
    }
    #endregion
    #region 方法
    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        //1. 玩家按下左右鍵的資訊 Input
        float m=Input.GetAxis("Horizontal");
        //2. 使用左右鍵的資訊控制角色移動 
        //剛體.加速度=二維向量(水平*速度*一幀的時間)
        //一幀的時間 解決不同效能裝置的速度差
        rig2D.velocity=new Vector2(m*speed*Time.deltaTime,rig2D.velocity.y);
        //翻轉角色
        if (m < 0){spr.flipX = true;}
        else { spr.flipX = false; }
    }
    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {
        //如果 玩家 按下 空白鍵 就 向上跳躍
        //判斷式 C#
        if(Input.GetKeyDown(KeyCode.Space)){
            rig2D.AddForce(new Vector2(0, jump));
        }
    }
    /// <summary>
    /// 開槍
    /// </summary>
    private void Fire()
    {

    }
    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="hurt">造成的傷害</param>
    private void Hurt(float hurt)
    {
        
    }
    /// <summary>
    /// 死亡
    /// </summary>
    /// <param name="dead">是否死亡</param>
    /// <returns></returns>
    private bool Dead (bool dead)
    {
        return dead = false;
    }
    /// <summary>
    /// 吃道具
    /// </summary>
    /// <param name="item">道具的名稱</param>
    private void EatItem(string item)
    {
    
    }
    #endregion
}
