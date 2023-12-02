using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed_Script : MonoBehaviour
{
    public enum PowerUp { Speed }
    public PowerUp powerups;

    public float AmountToGive;

    private RubyController player;

    private void Awake()
    {
        player = findObjectOfType<RubyController>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            switch (powerups)
            {
                case PowerUp.Speed:
                    player.Speed += AmountToGive;
                    break;
                default:
                    break;
            }

            Destroy(gameObject);
        }
    }
}
