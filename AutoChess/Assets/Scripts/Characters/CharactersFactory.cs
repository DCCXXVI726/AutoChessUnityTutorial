using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersFactory {
    public static Character createCaravan() {
        Character newCharacter = new Character();
        List<Ability> abilities = new List<Ability>() {new MovementAbility(), new HealthAbility()};
        newCharacter.AddAbility(abilities);
        return newCharacter;
    }
}
