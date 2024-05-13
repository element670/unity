using System.Collections.Generic;
using TMPro;

using UnityEngine;

public class ComparingParts : MonoBehaviour
{
    private TextMeshPro txt;
    public GameObject characterContainer;

    public Dictionary<CharacterMap, CharacterMap> chars;
    public CharacterAppearance[] appearances;
    public Character CharacterPrefab;
    private void Start()
    {

        Vector3 pos = Vector3.zero;
        chars = new Dictionary<CharacterMap, CharacterMap>();
        for (int i = 0; i < appearances.Length; i++)
        {

            var character = Instantiate(CharacterPrefab, characterContainer.transform);
            character.SetAppearance(appearances[i]);
           
            var c = character.ToCharacterMap();
            
            Debug.Log(c.GetHashCode());
            chars.Add(c, c);

            character.transform.localPosition = pos;
            pos.x += 5;
        }

        txt = GetComponent<TextMeshPro>();
        Debug.Log(chars.Keys);
        Debug.Log(chars.Values);

        Compare();

    }
    void Compare()
    {
        var player = Player.instance.gameObject.GetComponent<Character>().ToCharacterMap();

        Debug.Log(player.GetHashCode());
        if (chars.ContainsKey(player))
        {
            chars.TryGetValue(player, out CharacterMap character);
            if (character != null)
            {
                Debug.Log(character.Charactername);
            }
            else
            {
                Debug.Log("Not found");
            }
        }
        else
        {
            Debug.Log("Not contains");
        }
    }
}
