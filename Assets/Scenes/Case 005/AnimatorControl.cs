using UnityEngine;

public class AnimatorControl : MonoBehaviour
{
    private static readonly int SpeedMultiplier = Animator.StringToHash("SpeedMultiplier");
    private static readonly int MotionTime = Animator.StringToHash("MotionTime");
    
    [Range(0.0f, 1.0f)]
    public float speedMultiplier = 1f;
    [Range(0.0f, 1.0f)]
    public float motionTime = 0f;

    private Animator _animator;
    
    // Start is called before the first frame update
    void Start()
    {
        // 读取 Animator 组件
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // 修改 animator 的 SpeedMultiplier 参数
        _animator.SetFloat(SpeedMultiplier, speedMultiplier);
        _animator.SetFloat(MotionTime, motionTime);
    }
}
