dotnet pack /property:PackageVersion="0.1.0-dev-$TRAVIS_BUILD_NUMBER" --configuration Release --no-build src/FbMessenger.Messaging/FbMessenger.Messaging.csproj && dotnet nuget push src/FbMessenger.Messaging/bin/Release/FbMessenger.Messaging.*.nupkg --api-key $NUGET_API_KEY --source $NUGET_SOURCE
# dotnet pack /property:PackageVersion="0.1.0-dev-$TRAVIS_BUILD_NUMBER" --configuration Release --no-build src/FbMessenger.WebhookEvents/FbMessenger.WebhookEvents.csproj && dotnet nuget push src/FbMessenger.WebhookEvents/bin/Release/FbMessenger.WebhookEvents.*.nupkg --api-key $NUGET_API_KEY --source $NUGET_SOURCE