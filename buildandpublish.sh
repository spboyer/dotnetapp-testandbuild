#run docker container to build, test application
docker-compose up

#build final production container image
docker build -t spboyer/dotnetbot:production .