using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class RandomWalk : MonoBehaviour
{
    public float mRange = 25.0f;
    Vector2 lastPos;
    NavMeshAgent mAgent;
    Vector2 randomPos;
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "dragonHouse")
        {
            mAgent = GetComponent<NavMeshAgent>();
        }
    }

    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "dragonHouse")
        {
            if (mAgent.pathPending || mAgent.remainingDistance > 0.1f)
                return;
            randomPos = Random.insideUnitCircle * mRange;
            if (randomPos == lastPos)
                randomPos = Random.insideUnitCircle * mRange;
            mAgent.destination = new Vector3(randomPos.x, 0, randomPos.y);
        }
    }
}