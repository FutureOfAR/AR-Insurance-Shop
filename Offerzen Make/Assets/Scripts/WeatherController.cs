using System;
using System.Collections;
using System.Collections.Generic;
using Application;
using UnityEngine;
using UnityEngine.Networking;

public class WeatherController : MonoBehaviour {
    private const string API_KEY = "88169749096b61e3b85398905927f53c";

    public string CityId;

    // Use this for initialization
    void Start () {
        var result = GetWeather(CheckSnowStatus);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CheckSnowStatus(WeatherInfo weatherObj)
    {
        bool snowing = weatherObj.weather[0].main.Equals("Snow");
    }
    IEnumerator GetWeather(Action<WeatherInfo> onSuccess)
    {
        using (UnityWebRequest req = UnityWebRequest.Get(String.Format("http://api.openweathermap.org/data/2.5/weather?id={0}&APPID={1}", CityId, API_KEY)))
        {
            yield return req.SendWebRequest();
            while (!req.isDone)
                yield return null;
            byte[] result = req.downloadHandler.data;
            string weatherJSON = System.Text.Encoding.Default.GetString(result);
            WeatherInfo info = JsonUtility.FromJson<WeatherInfo>(weatherJSON);
            onSuccess(info);
        }
    }
}
