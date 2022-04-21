using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private SpawnTrash _spawnTrash;
    public SpawnTrash SpawnTrash => _spawnTrash;
    [SerializeField] private List<Trash> _listTrash = new List<Trash>();
    public List<Trash> ListTrash => _listTrash;
    
    // private AudioSource playerAudio;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // void Start()
    // {
    //     playerAudio =GetComponent<AudioSource>();
    // }
}
