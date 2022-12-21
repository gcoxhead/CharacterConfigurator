using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CharacterCustomiser : MonoBehaviour
{
    public CharacterSO Character;

    public SkinnedMeshRenderer RightArm;
    public SkinnedMeshRenderer LeftArm;
    public SkinnedMeshRenderer RightCalf;
    public SkinnedMeshRenderer LeftCalf;
    public SkinnedMeshRenderer RightFoot;
    public SkinnedMeshRenderer LeftFoot;
    public SkinnedMeshRenderer RightForearm;
    public SkinnedMeshRenderer LeftForearm;
    public SkinnedMeshRenderer Hair;
    public int _hairIndex = 0;

    public SkinnedMeshRenderer RightHand;
    public SkinnedMeshRenderer LeftHand;
    public SkinnedMeshRenderer Legs;
    public SkinnedMeshRenderer Torso;
    public SkinnedMeshRenderer Belt;
    public int _beltIndex = 0; 

    public SkinnedMeshRenderer Cape;
    public SkinnedMeshRenderer RightElbow;
    public SkinnedMeshRenderer LeftElbow;
    public SkinnedMeshRenderer Eyebrows;
    public SkinnedMeshRenderer RightKnee;
    public SkinnedMeshRenderer LeftKnee;
    public SkinnedMeshRenderer RightPauldron;
    public SkinnedMeshRenderer LeftPauldron;

    public void Randomise()
    {
        RightArm.sharedMesh = Character.RightArm[Random.Range(0, Character.RightArm.Length)];
        LeftArm.sharedMesh = Character.LeftArm[Random.Range(0, Character.LeftArm.Length)];
        RightCalf.sharedMesh = Character.RightCalf[Random.Range(0, Character.RightCalf.Length)];
        LeftCalf.sharedMesh = Character.LeftCalf[Random.Range(0, Character.LeftCalf.Length)];
        RightFoot.sharedMesh = Character.RightFoot[Random.Range(0, Character.RightFoot.Length)];
        LeftFoot.sharedMesh = Character.LeftFoot[Random.Range(0, Character.LeftFoot.Length)];
        RightForearm.sharedMesh = Character.RightForearm[Random.Range(0, Character.RightForearm.Length)];
        LeftForearm.sharedMesh = Character.LeftForearm[Random.Range(0, Character.LeftForearm.Length)];
        Hair.sharedMesh = Character.Hair[Random.Range(0, Character.Hair.Length)];
        RightHand.sharedMesh = Character.RightHand[Random.Range(0, Character.RightHand.Length)];
        LeftHand.sharedMesh = Character.LeftHand[Random.Range(0, Character.LeftHand.Length)];
        Legs.sharedMesh = Character.Legs[Random.Range(0, Character.Legs.Length)];
        Torso.sharedMesh = Character.Torso[Random.Range(0, Character.Torso.Length)];
        Belt.sharedMesh = Character.Belt[Random.Range(0, Character.Belt.Length)];
        Cape.sharedMesh = Character.Cape[Random.Range(0, Character.Cape.Length)];
        RightElbow.sharedMesh = Character.RightElbow[Random.Range(0, Character.RightElbow.Length)];
        LeftElbow.sharedMesh = Character.LeftElbow[Random.Range(0, Character.LeftElbow.Length)];
        Eyebrows.sharedMesh = Character.Eyebrows[Random.Range(0, Character.Eyebrows.Length)];
        RightKnee.sharedMesh = Character.RightKnee[Random.Range(0, Character.RightKnee.Length)];
        LeftKnee.sharedMesh = Character.LeftKnee[Random.Range(0, Character.LeftKnee.Length)];
        RightPauldron.sharedMesh = Character.RightPauldron[Random.Range(0, Character.RightPauldron.Length)];
        LeftPauldron.sharedMesh = Character.LeftPauldron[Random.Range(0, Character.LeftPauldron.Length)];
    }
    public void NextHair()
    {
        _hairIndex ++;

        if (_hairIndex >= Character.Hair.Length)
        {
            _hairIndex = 0;
            Debug.Log("hair element" + _hairIndex + " selected");
            Hair.sharedMesh = Character.Hair[_hairIndex];
        }
            
        else
        {
            Hair.sharedMesh = Character.Hair[_hairIndex];
            Debug.Log("hair element" + _hairIndex + " selected");
        }

    }

    public void PreviousHair()
    {
        

        if (_hairIndex == 0)
        {
            _hairIndex = (Character.Hair.Length -1);
            Debug.Log("hair element" + _hairIndex + " selected");
            Hair.sharedMesh = Character.Hair[_hairIndex];
        }

        else
        {
            _hairIndex--;
            Hair.sharedMesh = Character.Hair[_hairIndex];
            Debug.Log("hair element" + _hairIndex + " selected");
        }
    }
}
[CustomEditor(typeof(CharacterCustomiser))]
public class CustomiserEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        var characterCustomiser = (CharacterCustomiser)target;

        if (GUILayout.Button("Randomise"))
        {
            characterCustomiser.Randomise();
        }
    }
}
