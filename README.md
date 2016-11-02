dotnetapp-testandbuild Sample
=============================

### OSX / Linux

* Run `sh buildandpublish.sh`
    - runs `docker-compose up` to build and test the console application within the container.
    - runs `docker build -t spboyer/dotnetbot:production .` to create the final production image

### Windows (TODO)


* Notes

Need a non SDK base image for the production image.

