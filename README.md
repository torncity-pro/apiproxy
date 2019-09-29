[![Build Status](https://travis-ci.org/torncity-pro/apiproxy.svg?branch=master)](https://travis-ci.org/torncity-pro/apiproxy)
# Introduction 
This project aims to create a C# interface to the Torn.com API.

# Usage
Import the nupkg into your C# project and use the TornHttpProxy to query the endpoints desired. The first argument will be the Id of what is being queried (string.empty accepted for self-queries). The second argument is a params list of a given field type for the endpoint being called. For instance GetUserProperties(string.Empty, UserField.Honors) will retrieve the honors the api key owner has earned.

# Contibute
If any errors are encountered while using please file a bug. Additionally if desired please open a pull request with the proposed fix.