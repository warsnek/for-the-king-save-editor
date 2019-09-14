using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace ForTheKingSaveEdit
{
  public class CharacterInfo
  {
    private JObject _rawPlayerData;

    private JObject _stateCSData;

    public string Name { get; }

    public CharacterInfo(JObject rawPlayerData)
    {
      _rawPlayerData = rawPlayerData;
      _stateCSData = JObject.Parse(rawPlayerData.Value<string>("m_StateCSData"));

      Gold = GetStateValue<int>("m_Gold");
      AugmentedDamagePhysical = GetStateValue<int>("m_AugmentedDamagePhysical");
      AugmentedDamageMagic = GetStateValue<int>("m_AugmentedDamageMagic");
      AugmentedDefensePhysical = GetStateValue<int>("m_AugmentedDefensePhysical");
      AugmentedDefenseMagic = GetStateValue<int>("m_AugmentedDefenseMagic");
      AugmentedEvadeRating = Convert.ToInt32(GetStateValue<float>("m_AugmentedEvadeRating") * 100);
      AugmentedToughness = Convert.ToInt32(GetStateValue<float>("m_AugmentedToughness") * 100);
      AugmentedAwareness = Convert.ToInt32(GetStateValue<float>("m_AugmentedAwareness") * 100);
      AugmentedFortitude = Convert.ToInt32(GetStateValue<float>("m_AugmentedFortitude") * 100);
      AugmentedQuickness = Convert.ToInt32(GetStateValue<float>("m_AugmentedQuickness") * 100);
      AugmentedVitality = Convert.ToInt32(GetStateValue<float>("m_AugmentedVitality") * 100);
      AugmentedTalent = Convert.ToInt32(GetStateValue<float>("m_AugmentedTalent") * 100);
      AugmentedLuck = Convert.ToInt32(GetStateValue<float>("m_AugmentedLuck") * 100);
      AugmentedMaxFocus = GetStateValue<int>("m_AugmentedMaxFocus");
      AugmentedMaxHealth = GetStateValue<int>("m_AugmentedMaxHealth");
    }

    public int Gold { get; set; }
    public int AugmentedDamagePhysical { get; set; }
    public int AugmentedDamageMagic { get; set; }
    public int AugmentedDefensePhysical { get; set; }
    public int AugmentedDefenseMagic { get; set; }
    public int AugmentedEvadeRating { get; set; }
    public int AugmentedToughness { get; set; }
    public int AugmentedAwareness { get; set; }
    public int AugmentedFortitude { get; set; }
    public int AugmentedQuickness { get; set; }
    public int AugmentedVitality { get; set; }
    public int AugmentedTalent { get; set; }
    public int AugmentedLuck { get; set; }
    public int AugmentedMaxFocus { get; set; }
    public int AugmentedMaxHealth { get; set; }


    private T GetStateValue<T>(string stateName)
    {
      return ((JObject)_stateCSData[stateName]).Value<T>("$content");
    }

    private void SetStateValue(string stateName, int value)
    {
      ((JObject)_stateCSData[stateName])["$content"] = value;
    }

    private void SetStateValue(string stateName, float value)
    {
      ((JObject)_stateCSData[stateName])["$content"] = value;
    }

    public void ApplyChanges()
    {
      SetStateValue("m_Gold", Gold);
      SetStateValue("m_AugmentedDefensePhysical", AugmentedDefensePhysical);
      SetStateValue("m_AugmentedDefenseMagic", AugmentedDefenseMagic);
      SetStateValue("m_AugmentedDamagePhysical", AugmentedDamagePhysical);
      SetStateValue("m_AugmentedDamageMagic", AugmentedDamageMagic);
      SetStateValue("m_AugmentedEvadeRating", AugmentedEvadeRating / 100F);
      SetStateValue("m_AugmentedToughness", AugmentedToughness / 100F);
      SetStateValue("m_AugmentedAwareness", AugmentedAwareness / 100F);
      SetStateValue("m_AugmentedFortitude", AugmentedFortitude / 100F);
      SetStateValue("m_AugmentedQuickness", AugmentedQuickness / 100F);
      SetStateValue("m_AugmentedVitality", AugmentedVitality / 100F);
      SetStateValue("m_AugmentedTalent", AugmentedTalent / 100F);
      SetStateValue("m_AugmentedLuck", AugmentedLuck / 100F);
      SetStateValue("m_AugmentedMaxFocus", AugmentedMaxFocus);
      SetStateValue("m_AugmentedMaxHealth", AugmentedMaxHealth);

      _rawPlayerData["m_StateCSData"] = _stateCSData.ToString(Formatting.None);
    }
  }
}
