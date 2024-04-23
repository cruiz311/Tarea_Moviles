using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class PlayerController : MonoBehaviour
//{
//    [SerializeField] private CurrentSelection SpaceShip;
//    [SerializeField] private ScoreSystem ScoreSystem;
//    [SerializeField] private LifeSystem LifeSystem;
//    [SerializeField] private SimpleObjectPooling BulletPooling;

//    private Rigidbody2D _rigidbody2D;

//    private float _timeDelta;
//    private float _timeShoot = 0.5f;
//    private float _input = 0f;
//    private float _vSpeed = 0f;

//    private void Start()
//    {
//        _rigidbody2D = GetComponent<Rigidbody2D>();
//        _vSpeed = SpaceShip.CurrentSpaceShip.SpaceHSpeed;

//        LifeSystem.SetLife(SpaceShip.CurrentSpaceShip);
//        ScoreSystem.SetScore();

//        BulletPooling.SetUp(this.transform);

//        _timeShoot = 0.5f;
//        _timeDelta = 0f;
//    }

//    private void Update()
//    {
//        if(Input.touchCount > 0)
//        {
//            Touch touch = Input.GetTouch(0);

//            Vector2 position = Camera.main.ScreenToWorldPoint(touch.position);

//            position = new Vector2(0, position.y);

//            _input = position.normalized.y;

//            if(touch.phase == TouchPhase.Stationary)
//            {
//                _timeDelta += Time.deltaTime;

//                if(_timeDelta >= _timeShoot)
//                {
//                    CreateBullet();
//                    _timeDelta = 0f;
//                }
//            }
//        }
//        else
//        {
//            _input = 0f;
//            _timeDelta = 0f;
//        }
//    }

//    private void FixedUpdate()
//    {
//        _rigidbody2D.velocity = new Vector2(0f, _input * _vSpeed);
//    }

//    private void CreateBullet()
//    {
//        Bullet bullet = BulletPooling.GetObject().GetComponent<Bullet>();

//        bullet.SetUp(Vector2.right, transform);
//    }
//}
