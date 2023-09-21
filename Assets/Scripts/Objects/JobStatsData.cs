using UnityEngine;

[CreateAssetMenu(fileName = "JobStatsData", menuName = "ScriptableObjects/JobStatsData", order = 1)]
public class JobStatsData : ScriptableObject
{
    public string description;
    public int atk;
    public int def;
    public int hp;
    public int critical;
}