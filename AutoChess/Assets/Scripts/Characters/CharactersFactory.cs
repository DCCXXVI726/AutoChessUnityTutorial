using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersFactory {
    public static Character CreateCaravan() {
        Character newCharacter = new Character();
        List<Ability> abilities = new List<Ability>() {new MoveAbility(), new HealthAbility()};
        newCharacter.AddAbility(abilities);
        return newCharacter;
    }

    public static Character CreateSpawner() {
        Character newCharacter = new Character();
        List<Ability> abilities = new List<Ability>() {new SpawnAbility()};
        newCharacter.AddAbility(abilities);
        return newCharacter;
    }
}