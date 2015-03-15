FDD.OrleansGPSTracker
=====================

Sample GPS tracker application running on Orleans platform.

Description
===========

This project is a small demonstration how Orleans platform can be used to implement a backend for a social game.
Idea behind the game is simple - each player sees on her smartphone other players in proximity and scores a point
if she gets close to some other player. Orleans can be used to make this backend scalable and resilient.

To see this code in action you need to open a few browser windows with device emulator, press Start on each
emulator page and drag map to simulate device movement.

Running sample
==============

To run this code you will need to install a few things:
- Visual Studio 2013
- [Orleans SDK 1.0.1 (January 2015)](https://github.com/dotnet/orleans/releases/tag/v1.0.1)
- Azure SDK 2.5

To run web device emulator you will need Bing Maps Application Key which can be generated for free on
https://www.bingmapsportal.com/.

For more information, samples and documentation visit https://orleans.codeplex.com/.

Disclaimer
==========

Code in this project is oversimplified on purpose. A few major things to notice:
- Whole communication is organised using polling - in real scenario changes should be pushed from grain to grain
  and possibly from grain to clients.
- There is no authentication or any other form of security.
- Earth is assumed to be flat ;)
- There is no persistency.
