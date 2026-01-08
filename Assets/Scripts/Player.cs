using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds; 
        _numSeedsPlanted = 0;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);


    }

    private void Update()
    {
        MovePlayer();
        CheckPlantInput();

    }

    private void MovePlayer()
    {
        float horizontal = Input.GetAxis("Horizontal"); 
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, vertical, 0);
        _playerTransform.Translate(direction * _speed * Time.deltaTime);
    }

    private void CheckPlantInput()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        { 
            PlantSeed(); 
        }
    }
    public void PlantSeed ()
    {
        if (_numSeedsLeft <= 0) return;
        Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);
        _numSeedsLeft-=1;
        _numSeedsPlanted+=1;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }
}
