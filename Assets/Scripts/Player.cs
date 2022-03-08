using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float movementSpeed = 10f;
    private float _directionMove;
    private Rigidbody2D _playerRb;
    private Animator _playerAnimator;
    private int _state = 0;
    public static bool isJumped;
    
    public static int coins;
    public Text coinsText;

    public GameObject gameOverPanel;
    public Text gameScore;

    public GameObject mainCamera;
    private float deadZone = 10f;

    void Start()
    {
        _playerRb = GetComponent<Rigidbody2D>();
        _playerAnimator = GetComponent<Animator>();

        coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _playerAnimator.SetInteger("state", _state);
#if UNITY_EDITOR || UNITY_STANDALONE
        _directionMove = Input.GetAxis("Horizontal") * movementSpeed;
#else
        _directionMove = Input.acceleration.x * movementSpeed;
#endif
        coinsText.text = "Coins: " + coins.ToString();
    }

    private void FixedUpdate()
    {
        Vector2 velocity = _playerRb.velocity;
        velocity.x = _directionMove;
        _playerRb.velocity = velocity;

        if (transform.position.y < (mainCamera.transform.position.y - deadZone))
        {
            gameOverPanel.SetActive(true);
            gameScore.text = coins.ToString();
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<Platform>() != null)
        {
            if (other.relativeVelocity.y >= 0)
            {
                _state = 0;
            }
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<Platform>() != null) _state = 1;
    }
}
