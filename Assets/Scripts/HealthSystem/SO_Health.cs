using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Health", menuName = "Systems/Health")]
public class SO_Health : ScriptableObject
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private string _name = "Player";
    [SerializeField] private UIHandler _uihandler;
    [SerializeField] private SO_SpriteHolder _spriteHolder;

    private int _health;
    private Image _image;

    private void OnDisable()
    {
        _health = _maxHealth;
    }
    public void HealthBarInýt(Image image)
    {
        _image = image;
        SetSprite();
    }
    public void TakeDamage(int damage)
    {
        _health -= damage;

        SetSprite();

        if (_health <= 0)
        {
            WinLoseCondition();
        }
    }
    public void WinLoseCondition()
    {
        if (_name == "Player")
        {
            //lose
            _uihandler.ChangeActivePanel(3);
        }
        else
        {
            //win
            _uihandler.ChangeActivePanel(2);
        }
    }

    private void SetSprite()
    {
        if (_health <= _maxHealth && _health > _maxHealth * 0.8f)
        {
            _image.sprite = _spriteHolder.Sprites[0];
        }
        else if (_health < _maxHealth * 0.8f && _health > _maxHealth * 0.6f)
        {
            _image.sprite = _spriteHolder.Sprites[1];
        }
        else if (_health < _maxHealth * 0.6f && _health > _maxHealth * 0.4f)
        {
            _image.sprite = _spriteHolder.Sprites[2];
        }
        else if (_health < _maxHealth * 0.4f && _health > _maxHealth * 0.2f)
        {
            _image.sprite = _spriteHolder.Sprites[3];
        }
        else if (_health < _maxHealth * 0.2f)
        {
            _image.sprite = _spriteHolder.Sprites[4];
        }
        else if (_health <= 0)
        {
            _image.sprite = _spriteHolder.Sprites[5];
        }
    }
}