using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
      AugmentedEvadeRating = GetStateValue<float>("m_AugmentedEvadeRating");
      AugmentedToughness = GetStateValue<float>("m_AugmentedToughness");
      AugmentedAwareness = GetStateValue<float>("m_AugmentedAwareness");
      AugmentedFortitude = GetStateValue<float>("m_AugmentedFortitude");
      AugmentedQuickness = GetStateValue<float>("m_AugmentedQuickness");
      AugmentedVitality = GetStateValue<float>("m_AugmentedVitality");
      AugmentedTalent = GetStateValue<float>("m_AugmentedTalent");
      AugmentedLuck = GetStateValue<float>("m_AugmentedLuck");
      AugmentedMaxFocus = GetStateValue<float>("m_AugmentedMaxFocus");
      AugmentedMaxHealth = GetStateValue<float>("m_AugmentedMaxHealth");
    }

    public int Gold { get; set; }
    public int AugmentedDamagePhysical { get; set; }
    public int AugmentedDamageMagic { get; set; }
    public int AugmentedDefensePhysical { get; set; }
    public int AugmentedDefenseMagic { get; set; }
    public float AugmentedEvadeRating { get; set; }
    public float AugmentedToughness { get; set; }
    public float AugmentedAwareness { get; set; }
    public float AugmentedFortitude { get; set; }
    public float AugmentedQuickness { get; set; }
    public float AugmentedVitality { get; set; }
    public float AugmentedTalent { get; set; }
    public float AugmentedLuck { get; set; }
    public float AugmentedMaxFocus { get; set; }
    public float AugmentedMaxHealth { get; set; }


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
      SetStateValue("m_AugmentedEvadeRating", AugmentedEvadeRating);
      SetStateValue("m_AugmentedToughness", AugmentedToughness);
      SetStateValue("m_AugmentedAwareness", AugmentedAwareness);
      SetStateValue("m_AugmentedFortitude", AugmentedFortitude);
      SetStateValue("m_AugmentedQuickness", AugmentedQuickness);
      SetStateValue("m_AugmentedVitality", AugmentedVitality);
      SetStateValue("m_AugmentedTalent", AugmentedTalent);
      SetStateValue("m_AugmentedLuck", AugmentedLuck);
      SetStateValue("m_AugmentedMaxFocus", AugmentedMaxFocus);
      SetStateValue("m_AugmentedMaxHealth", AugmentedMaxHealth);
           

      _rawPlayerData["m_StateCSData"] = _stateCSData.ToString(Formatting.None);
    }
  }
}
