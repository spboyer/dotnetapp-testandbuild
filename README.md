dotnetapp-testandbuild Sample
=============================
Uses the [dotnet/dotnet-docker-samples](https://github.com/dotnet/dotnet-docker-samples/tree/master/dotnetapp-preview) repo code example with the dotnet-bot console application. [Restructured for testing](https://docs.microsoft.com/dotnet/articles/core/testing/unit-testing-with-dotnet-test?WT.mc_id=dotnet-0000-shboyer). Based on [Building optimized Docker images with ASP.NET Core](https://blogs.msdn.microsoft.com/stevelasker/2016/09/29/building-optimized-docker-images-with-asp-net-core/?WT.mc_id=dotnet-0000-shboyer).


### OSX / Linux

* Run `sh buildandpublish.sh`
    - runs `docker-compose up` to build and test the console application within the container.
    - runs `docker build -t spboyer/dotnetbot:production .` to create the final production image
* Run application `docker run spboyer/dotnetbot:production`

### Windows (TODO)


* Notes

