# Facebook Messenger Platform SDK for chatbot development ([Send API](https://developers.facebook.com/docs/messenger-platform/reference/send-api/)) in .NET

 * master [![Build Status](https://travis-ci.org/grajdeanserghei/fb-messenger-sdk.svg?branch=master)](https://travis-ci.org/grajdeanserghei/fb-messenger-sdk)
 * dev [![Build Status](https://travis-ci.org/grajdeanserghei/fb-messenger-sdk.svg?branch=dev)](https://travis-ci.org/grajdeanserghei/fb-messenger-sdk)

## This is not an oficial Facebook repository. 

A client to call Facebook messenger [Send API](https://developers.facebook.com/docs/messenger-platform/reference/send-api/).

## NuGet package

The SDK is available as NuGet pacakges. Stable version and dev version can be downloaded from NuGet repository.



|Package name               | Stable (master branch)      | Nightly (dev branch)    |
|---------------------------|:---------------------------:|:-----------------------:|
|FbMessenger.Messaging      | ![NuGet](https://img.shields.io/nuget/v/FbMessenger.Messaging.svg?style=flat-square&label=nuget)  | [![NuGet](https://img.shields.io/nuget/vpre/FbMessenger.Messaging.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/FbMessenger.Messaging/)         |
|FbMessenger.WebhookEvents  | ![NuGet](https://img.shields.io/nuget/v/FbMessenger.WebhookEvents.svg?style=flat-square&label=nuget) | [![NuGet](https://img.shields.io/nuget/vpre/FbMessenger.WebhookEvents.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/FbMessenger.WebhookEvents/) |

## Suppported API

1. Text Messages
2. [Quick Replies](https://developers.facebook.com/docs/messenger-platform/send-messages/quick-replies)
3. [Message Templates](https://developers.facebook.com/docs/messenger-platform/send-messages/templates) - partially
   - [x] [Generic Template](https://developers.facebook.com/docs/messenger-platform/send-messages/template/generic)
   
    - [x] [List Template](https://developers.facebook.com/docs/messenger-platform/send-messages/template/list) 
    - [x] [Button template](https://developers.facebook.com/docs/messenger-platform/send-messages/template/button)
    - [x] [Open Graph Template](https://developers.facebook.com/docs/messenger-platform/send-messages/template/open-graph) 
    - [x] [Media Template](https://developers.facebook.com/docs/messenger-platform/send-messages/template/media)
    - [x] [Receipt Template](https://developers.facebook.com/docs/messenger-platform/send-messages/template/receipt)
    - [ ] [Airline Templates](https://developers.facebook.com/docs/messenger-platform/send-messages/template/airline)
  1. [Buttons](https://developers.facebook.com/docs/messenger-platform/send-messages/buttons)
     - [x] [URL Button](https://developers.facebook.com/docs/messenger-platform/send-messages/buttons#url)
     - [x] [Postback Button](https://developers.facebook.com/docs/messenger-platform/send-messages/buttons#postback)
     - [ ] [Share Button](https://developers.facebook.com/docs/messenger-platform/send-messages/buttons#share)
     - [ ] [Buy Button](https://developers.facebook.com/docs/messenger-platform/send-messages/buttons#buy)
     - [ ] [Call Button](https://developers.facebook.com/docs/messenger-platform/send-messages/buttons#call)
     - [ ] [Log In Button](https://developers.facebook.com/docs/messenger-platform/send-messages/buttons#login)
     - [ ] [Log Out Button](https://developers.facebook.com/docs/messenger-platform/send-messages/buttons#logout)
     - [ ] [Game Play Button](https://developers.facebook.com/docs/messenger-platform/send-messages/buttons#game_play)
     
