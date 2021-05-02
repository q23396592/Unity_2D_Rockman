using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位
    [Header("移動速度"), Range(0f, 1000f)]
    public float speed = 10.5f;//速度
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
    #endregion
    #region 事件
    #endregion
    #region 方法
    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        
    }
    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {

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
