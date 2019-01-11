# Infinite Campus SDK for .NET

Infinite Campus SDK for .NET will allow the developer to use Entity Framework to query, insert, update, and delete data on an Infinite Campus database.

## Download

Add Infinite Campus SDK for .NET to your .NET project using the [Nuget package](https://www.nuget.org/packages/InfiniteCampusSdk).

## CampusContext

CampusContext is expecting a connection string with the name of "Campus" in you App.config or Web.config file.

```xml
  <connectionStrings>
    <add name="Campus" connectionString="data source={data_source};initial catalog={initial_catalog};persist security info=True;user id={userid};password={password};MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient" />
  </connectionStrings>
```