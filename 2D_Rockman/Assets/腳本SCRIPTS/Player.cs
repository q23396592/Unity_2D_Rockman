using UnityEngine;

public class Player : MonoBehaviour
{
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
}
