using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletController : MonoBehaviour
{
    float bulletTtl = 5;
    [SerializeField]
    GameObject Particle;
    GameObject TurnManagerRef;
    TurnManager turnManager;




    // Update is called once per frame
    void Start()
    {
        TurnManagerRef = GameObject.Find("TurnManager");
        turnManager = TurnManagerRef.GetComponent<TurnManager>();
    }
    void Update()
    {
        bulletTtl = bulletTtl - Time.deltaTime;
        if (bulletTtl <= 0)
        {
           // GameObject b = Instantiate(Particle, transform.position, transform.rotation);
            turnManager.WisselBeurt();
            Destroy(gameObject);

        }
    }

    private void OnCollisionEnter2D(Collision2D colision)
    {
       // GameObject b = Instantiate(Particle, transform.position, transform.rotation);
        turnManager.WisselBeurt();
        Destroy(gameObject);

        if (colision.gameObject.name == "Tank 1")
        {
            Debug.Log("Raakt player2");
            GameObject.Find("Main Camera").GetComponent<ScoreManager>().AddP2Score();
        }
        if (colision.gameObject.name == "Tank 2")
        {
            Debug.Log("Raakt Player1");
            GameObject.Find("Main Camera").GetComponent<ScoreManager>().AddP1Score();
        }
    }

}