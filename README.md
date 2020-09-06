# NuGet Testbed

This repository provides a testbed (or sandbox) for experimenting with the creation of NuGet packages - without the need to publish them to a package registry. Instead the packages are "published" into a local folder.

The solution `NuGet-Testbed.sln` contains two projects:

* `PackageProvider`: this project is packaged as NuGet package on build
* `PackageConsumer`: this project references the NuGet package built by the other project

The built NuGet package will be stored in the `_LocalPackages` folder.
