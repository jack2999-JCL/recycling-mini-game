using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrash : MonoBehaviour
{
    [SerializeField] private Transform _spawnPos;
    [SerializeField] private float _count;
    
    
    private void Start()
    {
        StartCoroutine(IeSpawn());
    }
    IEnumerator IeSpawn()
    {
        yield return new WaitUntil(CheckToSpawn);
        SpawnOneByOne();
    }
    private bool CheckToSpawn()
    {
        return true;
    }
    public void SpawnOneByOne()
    {
         int trash = Random.Range(0,GameManager.Instance.ListTrash.Count);
        Vector3 pos = _spawnPos.transform.position;
        if (_count > 0)
        {
            // GameObject go = Instantiate( GameManager.Instance.ListTrash[trash].gameObject, pos, GameManager.Instance.ListTrash[trash].gameObject.transform.rotation);
            GameObject go = Instantiate(GameManager.Instance.ListTrash[trash].gameObject);
            go.transform.position = pos;
            _count -= 1;
        }
    }
}
