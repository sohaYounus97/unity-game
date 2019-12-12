using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public PlayHealth playHealth;


    Animator anim;


    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (playHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");
        }
    }
}
