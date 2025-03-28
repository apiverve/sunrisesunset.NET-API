Sunrise Sunset API
============

Sunrise Sunset is a simple tool for getting the sunrise and sunset times. It returns the sunrise and sunset times for a given location and date.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [Sunrise Sunset API](https://apiverve.com/marketplace/api/sunrisesunset)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.SunriseSunset
```

Using the Package Manager:
```
nuget install APIVerve.API.SunriseSunset
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.SunriseSunset
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages..
4. Click on the Browse tab and search for "APIVerve.API.SunriseSunset".
5. Click on the APIVerve.API.SunriseSunset package, click Install.


---

## Configuration

Before using the sunrisesunset API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The Sunrise Sunset API documentation is found here: [https://docs.apiverve.com/api/sunrisesunset](https://docs.apiverve.com/api/sunrisesunset).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
Sunrise Sunset API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new SunriseSunsetAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new SunriseSunsetQueryOptions {
  lat = 36.7201600,
  lon = -4.4203400,
  date = "03-27-2025"
};
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "solarNoon": "2025-02-20T12:32:53.132Z",
    "sunrise": "2025-02-20T07:01:34.082Z",
    "sunset": "2025-02-20T18:04:12.182Z",
    "sunriseEnd": "2025-02-20T07:04:17.987Z",
    "sunsetStart": "2025-02-20T18:01:28.278Z",
    "dawn": "2025-02-20T06:35:17.568Z",
    "dusk": "2025-02-20T18:30:28.696Z",
    "nauticalDawn": "2025-02-20T06:05:07.51Z",
    "nauticalDusk": "2025-02-20T19:00:38.754Z",
    "nightEnd": "2025-02-20T05:35:08.859Z",
    "night": "2025-02-20T19:30:37.405Z",
    "goldenHourEnd": "2025-02-20T07:36:59.509Z",
    "goldenHour": "2025-02-20T17:28:46.756Z"
  },
  "code": 200
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2025 APIVerve, and EvlarSoft LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.