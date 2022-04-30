using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Parks.Models
{
  public class StateAndNatPark
  {
    public int StateAndNatParkId { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string LocationByState { get; set; }

    public static List<StateAndNatPark> GetStateAndNatParks()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<StateAndNatPark> stateAndNatParkList = JsonConvert.DeserializeObject<List<StateAndNatPark>>(jsonResponse.ToString());

      return stateAndNatParkList;
    }
  }
}