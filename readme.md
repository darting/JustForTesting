- run

docker run -e "ASPNETCORE_ENVIRONMENT=Development" -it --rm -p 8100:80 --name justfortesting justfortesting

- build

docker build -t justfortesting .

- push to private registry

docker tag justfortesting:latest 127.0.0.1:5000/justfortesting:latest
docker push 127.0.0.1:5000/justfortesting:latest

- push to docker hub

docker tag justfortesting:latest valorzhong/justfortesting:latest
docker push valorzhong/justfortesting:latest

- pull from docker hub

docker pull valorzhong/justfortesting
