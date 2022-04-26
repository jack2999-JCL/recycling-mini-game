using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBin1 : MonoBehaviour
{
    public UI_GamePlay ScoreNum;
    public HealthController Health;
    [SerializeField] private AudioSource PointsSoundEffect;
    public int Dame = 1;
    // private AudioSource playerAudio;
    // public AudioClip TrashSound;
    
    private void OnCollisionEnter(Collision other)
    {
        if (gameObject.tag == "GarbageCan")
        {
            if (other.gameObject.CompareTag("OrganicWaste"))
            {
                TrueObject();
                Destroy(other.gameObject);
            }
            else if ((other.gameObject.CompareTag("InorganicWaste")) || (other.gameObject.CompareTag("RecycledWaste"))||
            (other.gameObject.CompareTag("ToxicWaste")) || (other.gameObject.CompareTag("ConstructionWaste")))
            {
                FalseObject();
                Destroy(other.gameObject);
            }
        }

        else if (gameObject.tag == "GarbageCan2")
        {
            if (other.gameObject.CompareTag("InorganicWaste"))
            {
                TrueObject();
                Destroy(other.gameObject);
            }
            else if ((other.gameObject.CompareTag("RecycledWaste")) || (other.gameObject.CompareTag("OrganicWaste")) ||
            (other.gameObject.CompareTag("ToxicWaste")) || (other.gameObject.CompareTag("ConstructionWaste")))
            {
                FalseObject();
                Destroy(other.gameObject);
            }
           
        }


        else if (gameObject.tag == "GarbageCan3")
        {
            if (other.gameObject.CompareTag("RecycledWaste"))
            {
                TrueObject();
                Destroy(other.gameObject);
            }
            else if ((other.gameObject.CompareTag("OrganicWaste")) || (other.gameObject.CompareTag("InorganicWaste")) ||
            (other.gameObject.CompareTag("ToxicWaste")) || (other.gameObject.CompareTag("ConstructionWaste")))
            {
                FalseObject();
                Destroy(other.gameObject);
            }
            
        }

        else if (gameObject.tag == "GarbageCan4")
        {
            if (other.gameObject.CompareTag("ToxicWaste"))
            {
                TrueObject();
                Destroy(other.gameObject);
            }
            else if ((other.gameObject.CompareTag("ConstructionWaste")) || (other.gameObject.CompareTag("RecycledWaste")) ||
            (other.gameObject.CompareTag("InorganicWaste")) || (other.gameObject.CompareTag("OrganicWaste")) )
            {
                FalseObject();
                Destroy(other.gameObject);
            }
        }

        else if (gameObject.tag == "GarbageCan5")
        {
            if (other.gameObject.CompareTag("ConstructionWaste"))
            {
                TrueObject();
                Destroy(other.gameObject);
            }
            if ((other.gameObject.CompareTag("OrganicWaste")) || (other.gameObject.CompareTag("InorganicWaste")) ||
            (other.gameObject.CompareTag("RecycledWaste")) || (other.gameObject.CompareTag("ToxicWaste")))
            {
                FalseObject();
                Destroy(other.gameObject);
            }   
        }
        else if (gameObject.tag == "GarbageCanEnd")
        {
            FalseObject();
            Destroy(other.gameObject);
        }
    }
    public void TrueObject()
    {
        GameManager.Instance.SpawnTrash.SpawnOneByOne();
        ScoreNum.score += 1;
        Debug.Log("+1 score");
        PointsSoundEffect.Play();
        // playerAudio.PlayOneShot(TrashSound, 1.0f);
    }
    private void FalseObject()
    {
        GameManager.Instance.SpawnTrash.SpawnOneByOne();
        Health.TakeDamage(Dame);
        Debug.Log("-1 heart");
        // playerAudio.PlayOneShot(TrashSound, 1.0f);
    }
}


