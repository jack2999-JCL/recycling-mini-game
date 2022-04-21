using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    // public UI_GamePlay ScoreNum;
    // public HealthController Health;
    // public int Dame = 1;
    // private void OnCollisionEnter(Collision other)
    // {
    //     /*
    //     Rác thải hữu cơ - OrganicWaste
    //     Rác thải vô cơ - InorganicWaste
    //     Rác thải tái chế - RecycledWaste
    //     Rác thải công nghiệp - IndustrialWaste - toxicwaste
    //     Rác thải xây dựng - ConstructionWaste   
    //     */
       
    //      if (gameObject.tag == "OrganicWaste")
    //     {
    //         if (other.gameObject.CompareTag("GarbageCanEnd"))
    //         {
    //             FalseObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan"))
    //         {
    //             TrueObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan2"))
    //         {
    //            FalseObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan3"))
    //         {
    //            FalseObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan4"))
    //         {
    //            FalseObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan5"))
    //         {
    //             FalseObject();
    //         }
    //     }

    //     else if (gameObject.tag == "InorganicWaste")
    //     {
    //         if (other.gameObject.CompareTag("GarbageCanEnd"))
    //         {
    //             FalseObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan"))
    //         {
    //             FalseObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan2"))
    //         {
    //             TrueObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan3"))
    //         {
    //             FalseObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan4"))
    //         {
    //             FalseObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan5"))
    //         {
    //             FalseObject();
    //         }
    //     }


    //     else if (gameObject.tag == "RecycledWaste")
    //     {
    //         if (other.gameObject.CompareTag("GarbageCanEnd"))
    //         {
    //             FalseObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan"))
    //         {
    //             FalseObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan2"))
    //         {
    //             FalseObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan3"))
    //         {
    //             TrueObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan4"))
    //         {
    //             FalseObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan5"))
    //         {
    //             FalseObject();
    //         }
    //     }

    //     else if (gameObject.tag == "ToxicWaste")
    //     {
    //         if (other.gameObject.CompareTag("GarbageCanEnd"))
    //         {
    //             FalseObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan"))
    //         {
    //             FalseObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan2"))
    //         {
    //             FalseObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan3"))
    //         {
    //             FalseObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan4"))
    //         {
    //             TrueObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan5"))
    //         {
    //            FalseObject();
    //         }
    //     }

    //     else if (gameObject.tag == "ConstructionWaste")
    //     {
    //         if (other.gameObject.CompareTag("GarbageCanEnd"))
    //         {
    //             FalseObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan"))
    //         {
    //             FalseObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan2"))
    //         {
    //             FalseObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan3"))
    //         {
    //             FalseObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan4"))
    //         {
    //             FalseObject();
    //         }
    //         else if (other.gameObject.CompareTag("GarbageCan5"))
    //         {
    //             TrueObject();
    //         }
    //     }
    // }
    // public void TrueObject()
    // {
    //     Destroy(gameObject);
    //     GameManager.Instance.SpawnTrash.SpawnOneByOne();
    //     // ScoreNum.score += 1;
    //     Debug.Log("+1 score");
    // }
    // private void FalseObject()
    // {
    //     Destroy(gameObject);
    //     GameManager.Instance.SpawnTrash.SpawnOneByOne();
    //     // Health.TakeDamage(Dame);
    //     Debug.Log("-1 heart");
    // }
}
